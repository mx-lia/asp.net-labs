using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_3b
{
    public partial class AAA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void MyHandler(object sender, ServerValidateEventArgs args)
        {
            try
            {
                int.TryParse(args.Value, out int n);
                if (n > 1)
                {
                    for (var i = 2u; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            args.IsValid = false;
                            break;
                        }
                    }
                }
                else
                {
                    args.IsValid = false;
                }
            }
            catch
            {
                args.IsValid = false;
            }
        }
    }
}