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

    [WebMethod]
    public string[] GetBuyerNames(string prefixText, int count, string contextKey)
    {
        List<string> names = new List<string>();
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        List<BuyerInfoEntity> listBuyerInfoEntity = imp.GetBuyerInfo(count, prefixText, contextKey);
        if (listBuyerInfoEntity != null && listBuyerInfoEntity.Count > 0)
            foreach (BuyerInfoEntity objBuyerInfoEntity in listBuyerInfoEntity)
            {
                string item = AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem
                    (objBuyerInfoEntity.Name,
                    objBuyerInfoEntity.BuyerID);
                names.Add(item);
            }


        return names.ToArray();
    }

    [WebMethod]
    public string[] GetEmployeeNames(string prefixText, int count, string contextKey)
    {
        List<string> names = new List<string>();
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        List<EmployeeDetailsEntity> listEmployeeDetailsEntity = imp.GetEmployeeDetails(contextKey,count, prefixText);
        if (listEmployeeDetailsEntity != null && listEmployeeDetailsEntity.Count > 0)
            foreach (EmployeeDetailsEntity objEmployeeDetailsEntity in listEmployeeDetailsEntity)
            {
                string item = AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem
                    (objEmployeeDetailsEntity.Name,
                    objEmployeeDetailsEntity.EmployeeID);
                names.Add(item);
            }


        return names.ToArray();
    }
} 
