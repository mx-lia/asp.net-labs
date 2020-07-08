using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_3d
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(TextBox1.Text, out x) && int.TryParse(TextBox2.Text, out y))
            {
                TextBox3.Text = (x + y).ToString();
            }
            else
                throw new ApplicationException("My error");
        }

        protected void ScriptManager_AsyncPostBackError(object sender, AsyncPostBackErrorEventArgs e)
        {
            ScriptManager.AsyncPostBackErrorMessage = "My error text";
        }

        protected void Timer_Tick(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(TextBox1.Text, out x) && int.TryParse(TextBox2.Text, out y))
                TextBox3.Text = (x + y).ToString();
        }
    }
}