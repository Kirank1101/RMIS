using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using RMIS.Mediator.BackEnd;
using RMIS.Domain.RiceMill;
using RMIS.Domain;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Mediator;
using RMIS.Domain.Business;
using RMIS.Domain.DataTranserClass;
using RMIS.Domain.Constant;
using AllInOne.Common.Library.Util;

public partial class BankTransaction : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            Header = "Bank Balance";
            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

            lblBankBalance.Text = Convert.ToString(imp.GetBankBalance());
            string AmountInWords = imp.NumberToWord(Convert.ToInt32(lblBankBalance.Text.Trim()));
            lblBankBalance.Text += " ( " + AmountInWords + " only.)";
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ResultDTO resultDto = new ResultDTO();
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();

        resultDto = BinderSingleton.Instance.GetInstance<IValidateTransactionBusiness>().ValidateBankBalance(txtmoney.Text.ConvertToDouble());
        if (resultDto.IsSuccess)
            resultDto = imp.SaveBankTransaction("Added Bank Balance", 0, txtmoney.Text.ConvertToDouble(), DateTime.Now);
        SetMessage(resultDto);
    }

}