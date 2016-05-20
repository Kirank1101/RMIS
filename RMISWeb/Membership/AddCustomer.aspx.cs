using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;
using System.Configuration;
using System.Data.SqlClient;
using AllInOne.Common.Library.Util;

public partial class Membership_AddCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            bindCustomers();
    }

    void bindCustomers()
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        ddlCustomeList.DataSource = imp.GetAllCustomerInfoEntities();
        ddlCustomeList.DataBind();
    }

    protected void btnCreateCustomer_Click(object sender, EventArgs e)
    {
        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
        imp.SaveCustomerInformation(txtUsername.Text.Trim(), txtOrganization.Text);

        string connectionString = ConfigurationManager.ConnectionStrings["SecurityTutorialsConnectionString"].ConnectionString;
        string insertSql = "INSERT INTO [aspnet_Applications]([ApplicationName], [LoweredApplicationName], [ApplicationId]) VALUES(@ApplicationName, @LoweredApplicationName, @ApplicationId)";
        using (SqlConnection myConnection = new SqlConnection(connectionString))
        {
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(insertSql, myConnection);
            myCommand.Parameters.AddWithValue("@ApplicationName", txtUsername.Text.Trim());
            myCommand.Parameters.AddWithValue("@LoweredApplicationName", txtUsername.Text.Trim());
            myCommand.Parameters.AddWithValue("@ApplicationId", Guid.NewGuid());
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        ddlCustomeList.Items.Clear();
        bindCustomers();
    }

    string sessionApplicationName = "ApplicationName";
    protected void btnSetCustomer_Click(object sender, EventArgs e)
    {
        if (ddlCustomeList.SelectedIndex > 0)
        {
            HttpContext.Current.Session[sessionApplicationName] = ddlCustomeList.SelectedItem.Text;
        }
    }
}