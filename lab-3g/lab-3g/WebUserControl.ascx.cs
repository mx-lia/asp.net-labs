using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_3g
{
    public partial class WebUserControl : System.Web.UI.UserControl
    {
        public string Surname { get { return SurnameTextBox.Text; } set { SurnameTextBox.Text = value; } }
        public string Name { get { return NameTextBox.Text; } set { NameTextBox.Text = value; } }
        public string Patronymic { get { return PatronymicTextBox.Text; } set { PatronymicTextBox.Text = value; } }
        public DateTime Birthday { get { return DateTime.Parse(BirthdayTextBox.Text); } set { BirthdayTextBox.Text = value.ToShortDateString(); } }
        public string Gender { get { return GenderList.SelectedValue; } set { GenderList.SelectedValue = value; } }
        public string Faculty { get { return FacultiesList.SelectedValue; } set { FacultiesList.SelectedValue = value; } }
        public int Group { get { return int.Parse(GroupTextBox.Text); } set { GroupTextBox.Text = value.ToString(); } }
        public int YearOfEntry { get { return int.Parse(YearTextBox.Text); } set { YearTextBox.Text = value.ToString(); } }
        public string SubmitButtonText { get { return SubmitButton.Text; } set { SubmitButton.Text = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}