using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RMIS.Mediator.BackEnd;
using RMIS.Domain.RiceMill;
using AllInOne.BootStrapper.BackEnd;
using RMIS.Domain;
using RMIS.Binder.BackEnd;
using RMIS.Domain.Mediator;

namespace RMIS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IRMISMediator imp = BinderSingleton.Instance.GetInstance<IRMISMediator>();
            imp.BeginTransaction();
            SellerTypeEntity objEntity = new SellerTypeEntity();
            objEntity.SellerTypeID = AllInOne.Common.Library.Util.CommonUtil.CreateUniqueID("BE");
            objEntity.CustID = "w32423";
            objEntity.SellerType = "test";
            objEntity.ObsInd = YesNo.N;
            objEntity.LastModifiedDate = DateTime.Now;
            objEntity.LastModifiedBy = "test";
            imp.SaveOrUpdateSellerTypeEntity(objEntity, true);
            imp.CommitAndCloseSession();


            objEntity = imp.GetSellerTypeEntity(objEntity.SellerTypeID);
        }
    }
}