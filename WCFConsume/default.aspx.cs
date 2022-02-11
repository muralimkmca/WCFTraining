using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFConsume
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            samplewcfservice.ServiceClient wcfsvc = new samplewcfservice.ServiceClient("WSHttpBinding_IService");
            Label1.Text = wcfsvc.GetData(5, 5);
        }
    }
}