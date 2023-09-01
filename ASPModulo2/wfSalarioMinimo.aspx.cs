using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPModulo2
{
    public partial class wfSalarioMinimo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbPd.Visible = false;

            if (rblPd.SelectedIndex == 3)
            {
                txbPd.Visible = true;
            }
        }
    }
}