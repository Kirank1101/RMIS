using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;

public partial class BackgroundLogger : System.Web.UI.Page
{
    private static readonly ILog Logger = LogManager.GetLogger(typeof(BackgroundLogger));
    protected void Page_Load(object sender, EventArgs e)
    {
        Logger.Debug("Back ground logger called by Scheduler Job");
    }
}