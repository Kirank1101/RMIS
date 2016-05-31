using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Web.Script.Serialization;

[assembly: System.Web.UI.WebResource("RMIS.CustomControls.GridViewKeyBoardPagerBehavior.js", "application/x-javascript")]
namespace RMIS.CustomControls
{
    [TargetControlType(typeof(System.Web.UI.WebControls.GridView))]
    public class GridViewKeyBoardPagerExtender : System.Web.UI.ExtenderControl
    {
        #region Properties
        #region Editing

        private Keys _editBeginKey = Keys.M;

        [Browsable(false)]
        protected string EditBeginKeyCode
        {
            get { return Convert.ToInt32(_editBeginKey).ToString(); }
        }

        [Browsable(true), DefaultValue(Keys.M)]
        public Keys EditBeginKey
        {
            get { return _editBeginKey; }
            set { _editBeginKey = value; }
        }

        private Keys _editCancelKey = Keys.Q;

        [Browsable(false)]
        protected string EditCancelKeyCode
        {
            get { return Convert.ToInt32(_editCancelKey).ToString(); }
        }

        [Browsable(true), DefaultValue(Keys.Q)]
        public Keys EditCancelKey
        {
            get { return _editCancelKey; }
            set { _editCancelKey = value; }
        }

        private Keys _editUpdateKey = Keys.U;

        [Browsable(false)]
        protected string EditUpdateKeyCode
        {
            get { return Convert.ToInt32(_editUpdateKey).ToString(); }
        }

        [Browsable(true), DefaultValue(Keys.U)]
        public Keys EditUpdateKey
        {
            get { return _editUpdateKey; }
            set { _editUpdateKey = value; }
        }

        private string _editBeginCmdArgument = string.Empty;
        /// <summary>
        /// The postback CommandArgument value of the row to edit.
        /// </summary>
        [Browsable(false)]
        protected string EditBeginCmdArgument
        {
            get { return _editBeginCmdArgument; }
            set { _editBeginCmdArgument = value; }
        }

        private string _editCancelCmdArgument = string.Empty;
        /// <summary>
        /// The CommandArgument value to cancel the editing of the row currently in edit mode.
        /// </summary>
        [Browsable(false)]
        protected string EditCancelCmdArgument
        {
            get { return _editCancelCmdArgument; }
            set { _editCancelCmdArgument = value; }
        }

        private string _editUpdateCmdArgument = string.Empty;
        /// <summary>
        /// The CommandArgument value to update and save the currently edited row.
        /// </summary>
        [Browsable(false)]
        protected string EditUpdateCmdArgument
        {
            get { return _editUpdateCmdArgument; }
            set { _editUpdateCmdArgument = value; }
        }

        #endregion

        #region Selecting

        private Keys _prevSelectKey = Keys.Up;

        [Browsable(false)]
        protected string PrevSelectKeyCode
        {
            get { return Convert.ToInt32(_prevSelectKey).ToString(); }
        }

        [Browsable(true), DefaultValue(Keys.Up)]
        public Keys PrevSelectKey
        {
            get { return _prevSelectKey; }
            set { _prevSelectKey = value; }
        }

        private Keys _nextSelectKey = Keys.Down;

        [Browsable(false)]
        protected string NextSelectKeyCode
        {
            get { return Convert.ToInt32(_nextSelectKey).ToString(); }
        }

        [Browsable(true), DefaultValue(Keys.Down)]
        public Keys NextSelectKey
        {
            get { return _nextSelectKey; }
            set { _nextSelectKey = value; }
        }

        private string _prevSelectCmdArgument = string.Empty;
        /// <summary>
        /// The CommandArgument value to select the previous row in the grid
        /// </summary>
        [Browsable(false)]
        protected string PrevSelectCmdArgument
        {
            get { return _prevSelectCmdArgument; }
            set { _prevSelectCmdArgument = value; }
        }

        private string _nextSelectCmdArgument = string.Empty;
        /// <summary>
        /// The CommandArgument value to select the next row in the grid.
        /// </summary>
        [Browsable(false)]
        protected string NextSelectCmdArgument
        {
            get { return _nextSelectCmdArgument; }
            set { _nextSelectCmdArgument = value; }
        }

        #endregion

        #region Paging
        private Keys _firstPageKey = Keys.Home;

        [Browsable(false)]
        protected string FirstPageKeyCode
        {
            get { return Convert.ToInt32(_firstPageKey).ToString(); }
        }

        [Browsable(true), DefaultValue(Keys.Home)]
        public Keys FirstKey
        {
            get { return _firstPageKey; }
            set { _firstPageKey = value; }
        }

        private Keys _lastPageKey = Keys.End;

        [Browsable(false)]
        protected string LastPageKeyCode
        {
            get { return Convert.ToInt32(_lastPageKey).ToString(); }
        }

        [Browsable(true), DefaultValue(Keys.End)]
        public Keys LastKey
        {
            get { return _lastPageKey; }
            set { _lastPageKey = value; }
        }

        private Keys _nextPageKey = Keys.Right;

        [Browsable(false)]
        protected string PrevPageKeyCode
        {
            get { return Convert.ToInt32(_prevPageKey).ToString(); }
        }

        [Browsable(true), DefaultValue(Keys.Right)]
        public Keys NextKey
        {
            get { return _nextPageKey; }
            set { _nextPageKey = value; }
        }

        private Keys _prevPageKey = Keys.Left;

        [Browsable(false)]
        protected string NextPageKeyCode
        {
            get { return Convert.ToInt32(_nextPageKey).ToString(); }
        }

        [Browsable(true), DefaultValue(Keys.Left)]
        public Keys PreviousKey
        {
            get { return _prevPageKey; }
            set { _prevPageKey = value; }
        }

        private string _firstPageCmdArgument = string.Empty;
        /// <summary>
        /// The CommandArgument value to navigate to the first page.
        /// </summary>
        [Browsable(false)]
        protected string FirstPageCmdArgument
        {
            get { return _firstPageCmdArgument; }
            set { _firstPageCmdArgument = value; }
        }

        private string _lastPageCmdArgument = string.Empty;
        /// <summary>
        /// The CommandArgument value to navigate to the last page.
        /// </summary>
        [Browsable(false)]
        protected string LastPageCmdArgument
        {
            get { return _lastPageCmdArgument; }
            set { _lastPageCmdArgument = value; }
        }

        private string _prevPageCmdArgument = string.Empty;
        /// <summary>
        /// The CommandArgument value to page to previous page.
        /// </summary>
        [Browsable(false)]
        protected string PreviousPageCmdArgument
        {
            get { return _prevPageCmdArgument; }
            set { _prevPageCmdArgument = value; }
        }

        private string _nextPageCmdArgument = string.Empty;
        /// <summary>
        /// The CommandArgument value to page to next page.
        /// </summary>
        [Browsable(false)]
        protected string NextPageCmdArgument
        {
            get { return _nextPageCmdArgument; }
            set { _nextPageCmdArgument = value; }
        }

        #endregion

        #region Deleting

        private string _delCmdArgument = string.Empty;
        /// <summary>
        /// The CommandArgument value to delete the currently selected row.
        /// </summary>
        [Browsable(false)]
        protected string DeleteCmdArgument
        {
            get { return _delCmdArgument; }
            set { _delCmdArgument = value; }
        }

        private Keys _delKey = Keys.Delete;

        [Browsable(false)]
        protected string DeleteKeyCode
        {
            get { return Convert.ToInt32(_delKey).ToString(); }
        }

        [Browsable(true), DefaultValue(Keys.Delete)]
        public Keys DeleteKey
        {
            get { return _delKey; }
            set { _delKey = value; }
        }

        #endregion

        #region Sorting

        private bool _allowSorting = true;

        [Browsable(true), DefaultValue(true)]
        public bool AllowSorting
        {
            get { return _allowSorting; }
            set { _allowSorting = value; }
        }

        [Browsable(false)]
        protected string SortColumnNames { get; set; }

        [Browsable(false)]
        protected List<string> SortColumns { get; set; }

        #endregion

        private GridView _grid;
        [Browsable(false)]
        protected GridView Grid
        {
            get
            {
                if (_grid == null)
                {
                    _grid = Parent.FindControl(TargetControlID) as System.Web.UI.WebControls.GridView;
                    if (_grid == null)
                    {
                        throw new NullReferenceException(string.Format("{0} is not of type GridView or the GridView is no initialized.", TargetControlID));
                    }
                }

                return _grid;
            }
        }

        [Browsable(false)]
        protected string PostBackCtrlID
        {
            get { return Grid.UniqueID; }
        }

        #endregion

        protected override void OnPreRender(EventArgs e)
        {
            // Grid is in edit mode, so we set corresponding command arguments.
            // canceling or updating editing are the only allowed actions in this state.
            if (Grid.EditIndex > -1)
            {
                _editCancelCmdArgument = "Cancel$" + Grid.EditIndex.ToString();
                _editUpdateCmdArgument = "Update$" + Grid.EditIndex.ToString();
            }
            else
            {
                // Is a row selected
                if (Grid.SelectedIndex > -1)
                {
                    // Deleting	of that row is possible
                    _delCmdArgument = "Delete$" + Grid.SelectedIndex.ToString();
                    // switch row to Editing mode is possible
                    _editBeginCmdArgument = "Edit$" + Grid.SelectedIndex.ToString();

                    // Selecting is possible if selecting is enabled
                    if (Grid.SelectedIndex == 0)
                    {
                        _prevSelectCmdArgument = String.Empty;
                    }
                    else
                    {
                        _prevSelectCmdArgument = "Select$" + Convert.ToString(Grid.SelectedIndex - 1);
                    }

                    if ((Grid.SelectedIndex == Grid.PageSize - 1) || (Grid.SelectedIndex == Grid.Rows.Count - 1))
                    {
                        _nextSelectCmdArgument = String.Empty;
                    }
                    else
                    {
                        _nextSelectCmdArgument = "Select$" + Convert.ToString(Grid.SelectedIndex + 1);
                    }
                }

                #region Paging
                // dependent of the PagerSettings.Mode value the CommandArgument value of the Pager LinkButtons differ.
                switch (Grid.PagerSettings.Mode)
                {
                    case PagerButtons.Numeric:
                    case PagerButtons.NumericFirstLast:
                        #region Prev/Next Paging Arguments

                        // claculate Next/Previous Pager Arguments
                        if (Grid.PageIndex == 0) // there is no previous page, the grid shows the first page
                        {
                            _prevPageCmdArgument = string.Empty;
                        }
                        else
                        {
                            _prevPageCmdArgument = "Page$" + Convert.ToString(Grid.PageIndex);
                        }

                        if (Grid.PageIndex + 2 > Grid.PageCount) // there is no next page. The grid shows the last page
                        {
                            _nextPageCmdArgument = string.Empty;
                        }
                        else
                        {
                            _nextPageCmdArgument = "Page$" + Convert.ToString(Grid.PageIndex + 2);
                        }
                        #endregion

                        break;
                    case PagerButtons.NextPrevious:
                    case PagerButtons.NextPreviousFirstLast:
                        #region Prev/Next Paging
                        if (Grid.PageIndex == 0) // there is no previous page, the grid shows the first page
                        {
                            _prevPageCmdArgument = String.Empty;
                        }
                        else
                        {
                            _prevPageCmdArgument = "Page$Prev";
                        }

                        if (Grid.PageIndex == Grid.PageCount - 1) // there is no next page. The grid shows the last page
                        {
                            _nextPageCmdArgument = String.Empty;
                        }
                        else
                        {
                            _nextPageCmdArgument = "Page$Next";
                        }
                        #endregion
                        break;
                }

                #region First/Last Paging Settings

                if (Grid.PageIndex == 0)
                {
                    _firstPageCmdArgument = String.Empty;
                }
                else
                {
                    _firstPageCmdArgument = "Page$First";
                }

                if (Grid.PageIndex == Grid.PageCount - 1)
                {
                    _lastPageCmdArgument = String.Empty;
                }
                else
                {
                    _lastPageCmdArgument = "Page$Last";
                }

                #endregion
                #endregion

                #region Sorting

                if (_allowSorting
                    && Grid.AllowSorting
                    && (Grid.Columns != null)
                    && (Grid.Columns.Count > 1))
                {
                    int sortColumnCount = 0;
                    SortColumns = new List<string>();

                    for (int i = 0; i < Grid.Columns.Count; i++)
                    {
                        BoundField field = Grid.Columns[i] as BoundField;

                        if (field == null)
                        {
                            continue;
                        }
                        // only columns derived from DataField with a SortExpression set are sortable
                        if ((String.IsNullOrEmpty(field.SortExpression)) || (String.IsNullOrEmpty(field.DataField)))
                        {
                            continue;
                        }

                        if (sortColumnCount == 9)
                        {
                            {
                                SortColumns.Add(field.DataField);
                                break;
                            }
                        }
                        else
                        {
                            SortColumns.Add(field.DataField);
                            sortColumnCount++;
                        }
                    }
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    SortColumnNames = serializer.Serialize(SortColumns);
                    //SortColumnNames = String.Join(",", SortColumns.ToArray());
                }

                #endregion
            }

            base.OnPreRender(e);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            ClientScriptManager csm = Page.ClientScript;

            for (int i = 0; i < Grid.PageSize; i++)
            {
                csm.RegisterForEventValidation(Grid.UniqueID, "Select$" + i.ToString());
                csm.RegisterForEventValidation(Grid.UniqueID, "Edit$" + i.ToString());
                csm.RegisterForEventValidation(Grid.UniqueID, "Cancel$" + i.ToString());
                csm.RegisterForEventValidation(Grid.UniqueID, "Delete$" + i.ToString());
                csm.RegisterForEventValidation(Grid.UniqueID, "Update$" + i.ToString());
            }

            for (int i = 1; i <= Grid.PageCount; i++)
            {
                csm.RegisterForEventValidation(Grid.UniqueID, "Page$" + i.ToString());
            }

            csm.RegisterForEventValidation(Grid.UniqueID, "Page$First");
            csm.RegisterForEventValidation(Grid.UniqueID, "Page$Last");

            if (SortColumns != null)
            {
                foreach (string field in SortColumns)
                {
                    csm.RegisterForEventValidation(Grid.UniqueID, "Sort$" + field);
                }
            }

            base.Render(writer);
        }

        protected override IEnumerable<ScriptDescriptor> GetScriptDescriptors(Control targetControl)
        {
            ScriptBehaviorDescriptor descriptor = new ScriptBehaviorDescriptor("RMIS.CustomControls.GridViewKeyBoardPagerBehavior", targetControl.ClientID);
            descriptor.AddProperty("_firstCmdArgument", this.FirstPageCmdArgument);
            descriptor.AddProperty("_lastCmdArgument", this.LastPageCmdArgument);
            descriptor.AddProperty("_prevKeyCode", this.PrevPageKeyCode);
            descriptor.AddProperty("_nextKeyCode", this.NextPageKeyCode);
            descriptor.AddProperty("_firstKeyCode", this.FirstPageKeyCode);
            descriptor.AddProperty("_lastKeyCode", this.LastPageKeyCode);
            descriptor.AddProperty("_prevCmdArgument", this.PreviousPageCmdArgument);
            descriptor.AddProperty("_nextCmdArgument", this.NextPageCmdArgument);

            descriptor.AddProperty("_nextSelectKeyCode", this.NextSelectKeyCode);
            descriptor.AddProperty("_prevSelectKeyCode", this.PrevSelectKeyCode);
            descriptor.AddProperty("_nextSelectCmdArgument", this.NextSelectCmdArgument);
            descriptor.AddProperty("_prevSelectCmdArgument", this.PrevSelectCmdArgument);

            descriptor.AddProperty("_editBeginKeyCode", this.EditBeginKeyCode);
            descriptor.AddProperty("_editCancelKeyCode", this.EditCancelKeyCode);
            descriptor.AddProperty("_editUpdateKeyCode", this.EditUpdateKeyCode);
            descriptor.AddProperty("_editBeginCmdArgument", this.EditBeginCmdArgument);
            descriptor.AddProperty("_editCancelCmdArgument", this.EditCancelCmdArgument);
            descriptor.AddProperty("_editUpdateCmdArgument", this.EditUpdateCmdArgument);

            descriptor.AddProperty("_delKeyCode", this.DeleteKeyCode);
            descriptor.AddProperty("_delCmdArgument", this.DeleteCmdArgument);

            descriptor.AddProperty("_sortColumns", this.SortColumnNames);

            descriptor.AddProperty("_postBackCtrlID", this.PostBackCtrlID);

            return new ScriptDescriptor[] { descriptor };

        }

        protected override IEnumerable<ScriptReference> GetScriptReferences()
        {
            ScriptReference reference = new ScriptReference();
            reference.Name = "RMIS.CustomControls.GridViewKeyBoardPagerBehavior.js";
            reference.Assembly = "RMIS.CustomControls";

            return new ScriptReference[] { reference };
        }

    }
}
