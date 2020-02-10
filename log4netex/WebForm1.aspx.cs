using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;

namespace log4netex
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ILog logger = log4net.LogManager.GetLogger("ErrorLog");
                try
                {
                    throw new Exception("Divide By zero exception", new DivideByZeroException());

                }
                catch (Exception ee)
                {
                    logger.Error(ee.Message);
                }
            }

        }
    }
}