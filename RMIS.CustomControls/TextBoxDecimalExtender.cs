﻿using System;
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
    public class TextBoxDecimalExtender : CompositeControl
    {

       
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

        protected TextBox txtBox;
        protected MaskedEditExtender fltTextBox;

        public string Text
        {
            get
            {
                return txtBox.Text.ConvertToDouble().ToString();                
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    string s = value.ConvertToDouble().ToString("0.00");
                    if (s.EndsWith("00"))
                    {
                        s = value.ConvertToDouble().ToString("0");
                    }
                    txtBox.Text = value;
                }
                else
                    txtBox.Text = value;                
            }
        }

        const string viewStateServerMask = "viewStateMask";
        public string Mask
        {
            get
            {
                if (ViewState[viewStateServerMask] == null)
                {
                    ViewState[viewStateServerMask] = "99,99,999.99";
                }

                return (string)ViewState[viewStateServerMask];
            }
            set
            {
                ViewState[viewStateServerMask] = value;
            }
        }

        public bool ReadOnly
        {
            get
            {
                EnsureChildControls();
                return txtBox.ReadOnly;
            }
            set
            {
                EnsureChildControls();
                txtBox.ReadOnly = value;
            }
        }

        public   System.Drawing.Color ForeColor
        {
            get
            {
                EnsureChildControls();
                return txtBox.ForeColor;
            }
            set
            {
                EnsureChildControls();
                txtBox.ForeColor = value;
            }
        }




        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            txtBox = new TextBox();
            txtBox.ID = "txtBox" + this.ID;            
            this.Controls.Add(txtBox);
            txtBox.Text = "0.00";
            fltTextBox = new MaskedEditExtender();
            fltTextBox.ID = "fltTextBox" + this.ID;
            fltTextBox.MaskType = MaskedEditType.Number;
            fltTextBox.Mask = Mask;
            fltTextBox.Enabled = true;
            fltTextBox.TargetControlID = txtBox.ID;
            this.Controls.Add(fltTextBox);

        }
    }
}
