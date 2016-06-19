using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using System.Web.UI;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;

namespace RMIS.CustomControls
{
    public class TextBoxDatenTimeExtender : CompositeControl
    {      

        protected TextBox txtBoxDate;
        protected TextBox txtBoxTime;
        protected CalendarExtender calenderExtender;
        protected Image img;
        protected MaskedEditExtender mskDate;
        protected MaskedEditExtender mskTime;

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            txtBoxDate = new TextBox();
            txtBoxDate.ID = "txtBoxDate" + this.ID;
            this.Controls.Add(txtBoxDate);

            txtBoxDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //img = new Image();
            //img.ID = "img" + this.ID;
            //img.Height = Unit.Pixel(19);
            //img.Width = Unit.Pixel(19);
            //img.ImageUrl = "~/images/Calendar.png";
            //this.Controls.Add(img);

            txtBoxTime = new TextBox();
            txtBoxTime.ID = "txtBoxTime" + this.ID;
            //img.Height = Unit.Pixel(19);
            txtBoxTime.Width = Unit.Pixel(80);
            this.Controls.Add(txtBoxTime);
            txtBoxTime.Text = DateTime.Now.TimeOfDay.ToString();


           
            mskDate = new MaskedEditExtender();
            mskDate.ID = "mskDate" + this.ID;
            mskDate.Mask = "99/99/9999";
            //mskDate.ClearMaskOnLostFocus = false;
            //mskDate.MessageValidatorTip = true;
            //mskDate.OnFocusCssClass = "MaskedEditFocus";
            //mskDate.OnInvalidCssClass = "MaskedEditError";
            // mskDate.MaskType = MaskedEditType.Date;
            //mskDate.ErrorTooltipEnabled = true;
            mskDate.InputDirection = MaskedEditInputDirection.RightToLeft;
            //mskDate.AcceptNegative = MaskedEditShowSymbol.None;
            mskDate.TargetControlID = txtBoxDate.ID;
            this.Controls.Add(mskDate);

            mskTime = new MaskedEditExtender();
            mskTime.ID = "mskTime" + this.ID;
            mskTime.Mask = "99:99:99";
            //mskTime.MessageValidatorTip = true;
            //mskTime.OnFocusCssClass = "MaskedEditFocus";
            //mskTime.OnInvalidCssClass = "MaskedEditError";
            // mskTime.MaskType = MaskedEditType.Time;
            mskTime.InputDirection = MaskedEditInputDirection.RightToLeft;
            mskTime.AcceptNegative = MaskedEditShowSymbol.None;
            mskTime.TargetControlID = txtBoxTime.ID;
            //mskTime.ErrorTooltipEnabled = true;
            mskTime.AcceptAMPM = true;

            mskTime.ClearMaskOnLostFocus = false;
            this.Controls.Add(mskTime);


           
            //       <ajaxToolkit:MaskedEditExtender
            //TargetControlID="TextBox2" 
            //Mask="9,999,999.99"
            //MessageValidatorTip="true" 
            //OnFocusCssClass="MaskedEditFocus" 
            //OnInvalidCssClass="MaskedEditError"
            //MaskType="Number" 
            //InputDirection="RightToLeft" 
            //AcceptNegative="Left" 
            //DisplayMoney="Left"
            //ErrorTooltipEnabled="True"/>
        }

        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            calenderExtender = new CalendarExtender();
            calenderExtender.CssClass = "ajax__calendar";
            calenderExtender.ID = "calenderExtender1" + this.ID;
            // calenderExtender.PopupButtonID = img.ID;
            calenderExtender.Enabled = true;
            calenderExtender.Format = "dd/MM/yyyy";
            calenderExtender.TargetControlID = txtBoxDate.ID;
            this.Controls.Add(calenderExtender);

           




        }


    }
}
