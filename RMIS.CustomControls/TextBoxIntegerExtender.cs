using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using System.Web.UI;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;
using AllInOne.Common.Library.Util;

namespace RMIS.CustomControls
{
    public class TextBoxIntegerExtender : CompositeControl
    {

        protected TextBox txtBox;
        protected FilteredTextBoxExtender fltTextBox;


        public string Text
        {
            get
            {
                EnsureChildControls();
                return txtBox.Text.ConvertToInt().ToString();
            }
            set
            {
                EnsureChildControls();
                txtBox.Text = value;
            }
        }

        const string viewStateServerLength = "viewStateLength";
        public int MaxLength
        {
            get
            {
                if (ViewState[viewStateServerLength] == null)
                {
                    ViewState[viewStateServerLength] = 10;
                }

                return (int)ViewState[viewStateServerLength];
            }
            set
            {
                ViewState[viewStateServerLength] = value;
            }
        }



        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            txtBox = new TextBox();
            txtBox.ID = "txtBox" + this.ID;
            txtBox.MaxLength = MaxLength;
            txtBox.Height = Unit.Pixel(22);
            txtBox.Width = Unit.Pixel(100);
            this.Controls.Add(txtBox);
            txtBox.Text = "0";
            fltTextBox = new FilteredTextBoxExtender();
            fltTextBox.ID = "fltTextBox" + this.ID;
            fltTextBox.FilterType = FilterTypes.Numbers;
            fltTextBox.Enabled = true;
            fltTextBox.TargetControlID = txtBox.ID;
            this.Controls.Add(fltTextBox);

        }
    }
}
