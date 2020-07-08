using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_1b
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                EventTrace.Text += "---Page_Load_NoPostBack---";
            }
            else
            {
                EventTrace.Text += "---Page_Load_PostBack---";
            }

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            EventTrace.Text += "---Page_Init---";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            EventTrace.Text += "---Page_PreRender---";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            EventTrace.Text += "---Page_Unload---";
        }

        protected void Page_Dispose(object sender, EventArgs e)
        {
            EventTrace.Text += "---Page_Dispose---";
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            EventTrace.Text += "---Button_Click---";
            Label.Text = "";
            string[] s = Request.Form.AllKeys.Where(x => Regex.IsMatch(x, @"__VIEWSTATE(\d)*$")).ToArray();
            foreach (var x in s)
            {
                Label.Text += $"{x} length: [{Request[x].Length}],<br/>";
            }
            Label.Text += $"Text length: [{TextBox.Text.Length}]";
        }

        protected void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EventTrace.Text += "---Check---";
        }
    }
}