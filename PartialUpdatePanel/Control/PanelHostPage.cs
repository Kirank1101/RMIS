// Copyright (c) iucon GmbH. All rights reserved.
// For more information about our work, visit http://www.iucon.com

using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace iucon.web.Controls
{
    /// <summary>
    /// Hosts the UserControl and renderes the output
    /// </summary>
    internal class PanelHostPage : Page
    {
        private HtmlForm _mainForm = null;
        private ScriptManager _scriptManager = null;
        private Page _parentPage;
        private PageStatePersister _persister = null;

        private string _controlPath = null;
        private string _pageViewState = null;
        private string _renderedContent = null;
        private string _controlClientID = null;

        internal ScriptManager ScriptManager
        {
            get { return _scriptManager; }
        }

        public PanelHostPage(string ControlPath, string ControlClientID)
        {
            EnableEventValidation = false;
            _controlPath = ControlPath;
            _controlClientID = ControlClientID;

            HtmlHead head = new HtmlHead();
            head.ID = "aspnetHead";
            Controls.Add(head);

            _mainForm = new HtmlForm();
            _mainForm.ID = "aspnetForm";
            Controls.Add(_mainForm);
        }

        public PanelHostPage(string ControlPath, string ControlClientID, Page parentPage)
            : this(ControlPath, ControlClientID)
        {
            _parentPage = parentPage;
            _scriptManager = CreateScriptManager(_parentPage);
            _mainForm.Controls.Add(_scriptManager);
        }

        public PanelHostPage(string ControlPath, string ControlClientID, IDictionary scriptInfo)
            : this(ControlPath, ControlClientID)
        {
            _scriptManager = CreateScriptManager(scriptInfo);
            _mainForm.Controls.Add(_scriptManager);
        }


        /// <summary>
        /// This content is written to the client by PartialUpdatePanelHandler
        /// </summary>        
        public string GetHtmlContent()
        {
            StringBuilder sb = new StringBuilder();

            // insert new viewstate
            sb.AppendFormat("<input type=\"hidden\" name=\"{0}_ViewState\" id=\"{0}_ViewState\" value=\"{1}\" />", _controlClientID, _pageViewState);

            // process PostBackLinks
            string content = PostProcessPostBackLinks(_renderedContent);

            // append content            
            sb.Append(content);

            return sb.ToString();
        }

        protected override void CreateChildControls()
        {
            // Load Control
            if (_controlPath != null)
            {
                Control control = LoadControl(ResolveUrl(_controlPath));
                DummyContainer currentContainer = null;

                // recreate the exact control hierarchie 
                // by using dummy controls that implement INamingContainer
                string[] IDs = _controlClientID.Split('_');
                control.ID = IDs[IDs.Length - 1];

                for (int i = 0; i < IDs.Length - 1; i++)
                {
                    DummyContainer container = new DummyContainer();
                    container.ID = IDs[i];

                    if (currentContainer != null)
                        currentContainer.Controls.Add(container);
                    else
                        Form.Controls.Add(container);

                    currentContainer = container;
                }

                if (currentContainer != null)
                    currentContainer.Controls.Add(control);
                else
                    Form.Controls.Add(control);                
            }

            base.CreateChildControls();
        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            base.OnPreRenderComplete(e);
  
            foreach (Control c in Controls)
                ProcessPostBackControls(c);

            SetRenderMethodDelegate(new RenderMethod(RenderPage));
            _mainForm.SetRenderMethodDelegate(new RenderMethod(RenderForm));
        }

        /// <summary>
        /// This custom delegate is necessary, because otherwise the page
        /// would send it's form-tag, script-tags etc. directly to the the response
        /// when a control is rendered in the Serverside initial startup mode.
        /// Here we simply discard the default output, because we only want to have the
        /// contents of our _mainForm
        /// </summary>
        private void RenderPage(HtmlTextWriter writer, Control control)
        {
            StringWriter controlWriter = new StringWriter();
            HtmlTextWriter htmlWriter = new HtmlTextWriter(controlWriter);

            foreach (Control child in control.Controls)
                child.RenderControl(htmlWriter);
        }

        private void RenderForm(HtmlTextWriter writer, Control control)
        {
            StringBuilder controlBuilder = new StringBuilder();
            StringWriter controlWriter = new StringWriter(controlBuilder);
            HtmlTextWriter htmlWriter = new HtmlTextWriter(controlWriter);

            foreach (Control child in control.Controls)
            {
                if (!(child is ScriptManager))
                {
                    child.RenderControl(htmlWriter);
                }
            }

            _renderedContent = controlBuilder.ToString();

            if (_parentPage == null)
            {
                // append JScript elements
                ScriptRenderer script = new ScriptRenderer(_scriptManager, _controlClientID);
                _renderedContent += script.GetScriptBlock();
            }
            else
            {
                ClientScriptRegister cs = new ClientScriptRegister();
                cs.RegisterScripts(_scriptManager, _parentPage);
            }

            _renderedContent += GetParametersBlock();
        }

        /// <summary>
        /// Replaces javascript PostBack-commands "__doPostBack" with the internal 
        /// PartialUpdatePanel-PostBack
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private string PostProcessPostBackLinks(string content)
        {
            if (content != null)
            {
                content = content.Replace("&#39;", "'");

                Regex regex = new Regex(@"__doPostBack\('(?<control>[^']*)','(?<argument>[^']*)'\)");
                foreach (Match match in regex.Matches(content))
                    content = content.Replace(match.Value, GetPostBackReference(match.Groups["control"].Value, match.Groups["argument"].Value, false));

                regex = new Regex(@"javascript:setTimeout\('__doPostBack\(\\'(?<control>[^']*)\\',\\'(?<argument>[^']*)\\'\)', 0\)");
                foreach (Match match in regex.Matches(content))
                    content = content.Replace(match.Value, GetPostBackReference(match.Groups["control"].Value, match.Groups["argument"].Value, true));
            }

            return content;
        }

        /// <summary>
        /// Adds OnClientClick to buttons.
        /// The result is that by clicking on these controls
        /// only a partial PostBack is made. It prevents the whole page from doing a PostBack
        /// </summary>        
        private void ProcessPostBackControls(Control control)
        {
            if (control is Button)
            {
                ((Button)control).OnClientClick = GetPostBackReference(control.ClientID.Replace('_', '$'), "null", true);
                ((Button)control).OnClientClick += "return false;";
            }
            else if (control is ImageButton)
            {
                ((ImageButton)control).OnClientClick = GetPostBackReference(control.ClientID.Replace('_', '$'), "null", true);
                ((ImageButton)control).OnClientClick += "return false;";
            }

            foreach (Control child in control.Controls)
                ProcessPostBackControls(child);
        }

        /// <summary>
        /// Gets the internal PostBack command for the hosted control
        /// </summary>        
        private string GetPostBackReference(string eventTarget, string eventArgument, bool enclosed)
        {
            string reference = "";

            if (enclosed)
                reference = string.Format("setTimeout('$find(\\'{0}\\').pb(\\'{1}\\',\\'{2}\\')',0);",
                                              _controlClientID,
                                              eventTarget,
                                              eventArgument);
            else
                reference = string.Format("$find('{0}').doPostBack('{1}','{2}');",
                                              _controlClientID,
                                              eventTarget,
                                              eventArgument);

            return reference;
        }

        private string GetParametersBlock()
        {
            string block = string.Empty;
            if (ParameterCollection.IsDirty)
            {
                ParameterCollection parameters = ParameterCollection.Instance;
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("<div style=\"display: none;\" id=\"{0}__PARAMETERS\">", _controlClientID);
                sb.Append(serializer.Serialize(parameters));
                sb.Append("</div>");

                block = sb.ToString();
            }

            return block;
        }

        private ScriptManager CreateScriptManager(IDictionary scriptInfo)
        {
            ScriptManager sm = null;
            if (scriptInfo != null && scriptInfo.Count > 0)
            {
                string scriptManagerID = (string)scriptInfo["ScriptManagerID"];
                string scriptManagerType = (string)scriptInfo["ScriptManagerType"];

                if (!string.IsNullOrEmpty(scriptManagerID) && !string.IsNullOrEmpty(scriptManagerType))
                {
                    // create ScriptManager from type
                    scriptManagerType = Encryptor.DecryptFromString(scriptManagerType);
                    Type type = Type.GetType(scriptManagerType, true);

                    sm = Activator.CreateInstance(type) as ScriptManager;
                    sm.ID = scriptManagerID;

                    // init properties
                    IDictionaryEnumerator enumerator = scriptInfo.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        string propertyName = (string)enumerator.Key;
                        PropertyInfo property = type.GetProperty(propertyName);
                        if (property != null)
                        {
                            object propertyValue = enumerator.Value;

                            if (property.PropertyType == typeof(Uri))
                                property.SetValue(sm, new Uri((string)propertyValue, UriKind.RelativeOrAbsolute), null);
                            else
                                property.SetValue(sm, Convert.ChangeType(propertyValue, property.PropertyType), null);
                        }
                    }
                }
            }
            else
                sm = new ScriptManager();

            return sm;
        }

        private ScriptManager CreateScriptManager(Page parentPage)
        {
            ScriptManager sm = null;

            if (parentPage != null)
            {
                ScriptManager psm = ScriptManager.GetCurrent(parentPage);

                // create ScriptManager with same type
                sm = (ScriptManager)Activator.CreateInstance(psm.GetType());
                sm.ID = psm.ClientID;

                // copy properties
                foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(psm))
                {
                    if (property.IsBrowsable && !property.IsReadOnly &&
                        property.ShouldSerializeValue(psm))
                    {
                        property.SetValue(sm, property.GetValue(psm));
                    }
                }
            }
            else
                sm = new ScriptManager();

            return sm;
        }

        #region ViewState Management

        protected override PageStatePersister PageStatePersister
        {
            get
            {
                if (_persister == null)
                    _persister = new PartialPageStatePersister(this);

                return _persister;
            }
        }

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);

            if (Request.Form["__CULTURE"] != null)
            {
                string[] culture = Request.Form["__CULTURE"].Split(';');
                if (culture.Length == 2)
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture[0]);
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture[1]);
                }
            }
            
            // load fake viewstate as it is provided by the "Serverside" initial rendering
            if (Request.Form[_controlClientID + "_VIEWSTATE"] != null)
                _pageViewState = HttpUtility.UrlDecode(Request.Form[_controlClientID + "_VIEWSTATE"]);

            // load viewstate requested by async load
            else if (Request.Form["__VIEWSTATE"] != null)
                _pageViewState = Request.Form["__VIEWSTATE"];
        }

        protected override object LoadPageStateFromPersistenceMedium()
        {
            PartialPageStatePersister persister = PageStatePersister as PartialPageStatePersister;
            persister.PageState = _pageViewState;
            persister.Load();

            return new Pair(persister.ControlState, persister.ViewState);
        }

        protected override void SavePageStateToPersistenceMedium(object state)
        {
            PartialPageStatePersister pageStatePersister = this.PageStatePersister as PartialPageStatePersister;
            if (state is Pair)
            {
                Pair pair = (Pair)state;
                pageStatePersister.ControlState = pair.First;
                pageStatePersister.ViewState = pair.Second;
            }
            else
            {
                pageStatePersister.ViewState = state;
            }
            pageStatePersister.Save();

            _pageViewState = HttpUtility.UrlEncode(pageStatePersister.PageState);
        }

        #endregion
    }
}
