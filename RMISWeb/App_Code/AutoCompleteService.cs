using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.ComponentModel;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;
using RMIS.Domain.RiceMill;

/// <summary>
/// Summary description for AutoCompleteService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
[System.Web.Script.Services.ScriptService]
public class AutoCompleteService : System.Web.Services.WebService
{

    [WebMethod]     
    public string[] GetSellerNames(string prefixText, int count,string contextKey)
    {
        List<string> names = new List<string>();
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        List<SellerInfoEntity> listSellerInfoEntity = imp.GetPaddySellerInfo(count, prefixText, contextKey);
          if(listSellerInfoEntity!=null && listSellerInfoEntity.Count>0)
              foreach(SellerInfoEntity objSellerInfoEntity in listSellerInfoEntity)
                {
                    string item = AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem
                        (objSellerInfoEntity.Name ,
                        objSellerInfoEntity.SellerID);
                    names.Add(item);
                }
                
        
        return names.ToArray();
    }
} 
