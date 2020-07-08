using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_3d
{
    public partial class WebFormA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalculateButton_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(TextBox4.Text, out x) && int.TryParse(TextBox5.Text, out y))
            {
                Thread.Sleep(TimeSpan.FromSeconds(5));
                TextBox6.Text = (x * y).ToString();
            }
        }
    }
}