using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;

public partial class LogOnNew : RegisterBasePage
{
    protected void lgAbalone_Authenticate(object sender, AuthenticateEventArgs e)
    {
        
        if (Membership.ValidateUser(lgAbalone.UserName, lgAbalone.Password))
        {
            ISessionProvider imp = BinderSingleton.Instance.GetInstance<ISessionProvider>();
            imp.SetCurrentCustomerId(lgAbalone.UserName.Split('/')[1]);
            imp.SetLoggedInUserId(lgAbalone.UserName);
            // Username/password are valid, check email
            MembershipUser usrInfo = Membership.GetUser(lgAbalone.UserName);
            if (usrInfo != null)
            {
                // Email matches, the credentials are valid
                e.Authenticated = true;
                FormsAuthentication.SetAuthCookie(lgAbalone.UserName, false);
                Response.Redirect("Default.aspx");
            }
            else
            {
                // Email address is invalid...
                e.Authenticated = false;
            }
        }
        else
        {
            // Username/password are not valid...
            e.Authenticated = false;
        }

    }


    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
           // bindCustomers();
    }


    //void bindCustomers()
    //{
    //    ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
    //    ddlCustomeList.DataSource = imp.GetAllCustomerInfoEntities();
    //    ddlCustomeList.DataBind();
    //}

    protected void lnkContactUs_Click(object sender, EventArgs e)
    {
        Response.Redirect("ContactUs.aspx", true);
    }

    //private void  SetupFormsAuthTicket(string userName, bool persistanceFlag)
    //{
    //    EmployeeBusiness business = new EmployeeBusiness();
    //    EmployeeInfo user = business.GetUserObjByUserName(userName);

    //    var userId = user.EmployeeId;
    //    var userData = userId.ToString(CultureInfo.InvariantCulture);
    //    var authTicket = new FormsAuthenticationTicket(1, //version
    //                        userName, // user name
    //                        DateTime.Now,             //creation
    //                        DateTime.Now.AddMinutes(30), //Expiration
    //                        persistanceFlag, //Persistent
    //                        userData);

    //    var encTicket = FormsAuthentication.Encrypt(authTicket);
    //    Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
    //    return ;
    //} 
    string sessionApplicationName = "ApplicationName";
    string sessionCustomerId = "sessionCustomerId";

}