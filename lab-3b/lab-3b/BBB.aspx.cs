using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_3b
{
    public partial class BBB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MyHandler(object sender, ServerValidateEventArgs args)
        {
            args.IsValid = (args.Value.Distinct().ToString().Length == args.Value.Length) && (args.Value.Length >= 7);
        }
    }
}