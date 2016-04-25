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

public partial class PaddyStockDisplay : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        IPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IPaddyBusiness>();        
        SellerTypeEntity objEntity = new SellerTypeEntity();
        objEntity.SellerTypeID = AllInOne.Common.Library.Util.CommonUtil.CreateUniqueID("BE");
        objEntity.CustID = "w32423";
        objEntity.SellerType = "test";
        objEntity.ObsInd = YesNo.N;
        objEntity.LastModifiedDate = DateTime.Now;
        objEntity.LastModifiedBy = "test";
        imp.SaveSellerType(objEntity);


        //objEntity = imp.GetMasterSellerTypeEntities(objEntity.SellerTypeID);
    }
}
