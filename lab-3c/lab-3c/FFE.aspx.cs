using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_3c
{
    public partial class FFE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Mode.Text = AdRotator.KeywordFilter;
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            MultiView.ActiveViewIndex = (MultiView.ActiveViewIndex + 1) % 3;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = TextBox2.Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label3.Text = TextBox3.Text;
        }

        protected void ChangeAdMode_Click(object sender, EventArgs e)
        {
            switch (AdRotator.KeywordFilter)
            {
                case "": AdRotator.KeywordFilter = "group1"; break;
                case "group1": AdRotator.KeywordFilter = "group2"; break;
                case "group2": AdRotator.KeywordFilter = ""; break;
            }
            Mode.Text = AdRotator.KeywordFilter;
        }

        protected void Menu_MenuItemClick(object sender, MenuEventArgs e)
        {
            Label3.Text = ((Menu)sender).SelectedValue;
        }

        protected void TreeView_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {
            Label2.Text = "";
            TreeNodeCollection checkedNodes = TreeView.CheckedNodes;
            foreach(TreeNode checkedNode in checkedNodes)
            {
                Label2.Text += $"{checkedNode.Value}: true ";
            }
        }

        protected void Wizard_CancelButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("/FFE.aspx");
        }

        protected void Wizard_ActiveStepChanged(object sender, EventArgs e)
        {
            if(Wizard.ActiveStepIndex == 5)
            {
                AllInfo.Text = $"{Surname.Text} {Name.Text}<br/>";
                foreach(ListItem item in CheckBoxList.Items)
                {
                    if (item.Selected)
                        AllInfo.Text += $"{item} ";
                }
                AllInfo.Text += $"<br/>{RadioButtonList.SelectedValue}<br/>{ ListBox.SelectedValue}<br/>";
                if (Calendar.SelectionMode == CalendarSelectionMode.DayWeek)
                    AllInfo.Text += $"{Calendar.SelectedDate.ToShortDateString()}";
                else
                {
                    foreach (DateTime date in Calendar.SelectedDates)
                        AllInfo.Text += $"{date.ToShortDateString()}<br/>";
                }
            }
        }

        protected void Wizard_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Redirect("/FFE.aspx");
        }

        protected void ChangeMode_Click(object sender, EventArgs e)
        {
            if (Calendar.SelectionMode == CalendarSelectionMode.DayWeek)
                Calendar.SelectionMode = CalendarSelectionMode.DayWeekMonth;
            else
                Calendar.SelectionMode = CalendarSelectionMode.DayWeek;
            CalendarMode.Text = Calendar.SelectionMode.ToString();
        }
    }
}