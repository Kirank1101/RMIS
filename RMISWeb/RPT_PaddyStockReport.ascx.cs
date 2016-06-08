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
using Microsoft.Reporting.WebForms;
using RMIS.Domain.Constant;

using System.Collections.Generic;
using AllInOne.Common.Library.Util;

public partial class RPT_PaddyStockReport : BaseUserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsControlPostBack)
        {
            ReportViewer1.ProcessingMode = ProcessingMode.Local;

            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            int count;
            List<PaddyStockDTO> listPaddyStockDTO = imp.GetPaddyStockDTO(0, 1000, out count, SortExpression.Desc);

            if (listPaddyStockDTO != null && listPaddyStockDTO.Count > 0)
            {
                ReportDataSource datasource = new ReportDataSource("PaddyStock", CollectionHelper.ConvertTo<PaddyStockDTO>(listPaddyStockDTO));

                ReportViewer1.AsyncRendering = false;

                ReportViewer1.LocalReport.DataSources.Clear();

                ReportViewer1.LocalReport.DataSources.Add(datasource);

                ReportViewer1.LocalReport.Refresh();
               

            }
        }
    }

}