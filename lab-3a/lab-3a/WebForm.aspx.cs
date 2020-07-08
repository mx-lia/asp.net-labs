using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace lab_3a
{
    public partial class WebForm : System.Web.UI.Page
    {
        private HtmlTable htmlTable = new HtmlTable
        {
            ID = "HtmlTable",
            Border = 1,
            CellPadding = 3,
            CellSpacing = 3,
            Align = "center",
            BorderColor = "red"
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                InputSelect.Items.Add("1");
                InputSelect.Items.Add("2");
                InputSelect.Items.Add("3");
            }
            HtmlTableRow tableRow = new HtmlTableRow();
            HtmlTableCell tableCell = new HtmlTableCell
            {
                InnerHtml = "Html Control"
            };
            tableRow.Cells.Add(tableCell);
            tableCell = new HtmlTableCell
            {
                InnerHtml = "onserverclick"
            };
            tableRow.Cells.Add(tableCell);
            tableCell = new HtmlTableCell
            {
                InnerHtml = "onserverchange"
            };
            tableRow.Cells.Add(tableCell);
            htmlTable.Rows.Add(tableRow);
            Controls.Add(htmlTable);
        }

        protected void OnServerClick(object sender, EventArgs e)
        {
            HtmlTableRow tableRow = new HtmlTableRow();
            HtmlTableCell tableCell = new HtmlTableCell
            {
                InnerHtml = ((Control)sender).ID
            };
            tableRow.Cells.Add(tableCell);
            tableCell = new HtmlTableCell
            {
                InnerHtml = "YES"
            };
            tableRow.Cells.Add(tableCell);
            tableCell = new HtmlTableCell
            {
                InnerHtml = "NO"
            };
            tableRow.Cells.Add(tableCell);
            ((HtmlTable)Controls[Controls.IndexOf(htmlTable)]).Rows.Add(tableRow);
        }

        protected void OnServerChange(object sender, EventArgs e)
        {
            HtmlTableRow tableRow = new HtmlTableRow();
            HtmlTableCell tableCell = new HtmlTableCell
            {
                InnerHtml = ((Control)sender).ID
            };
            tableRow.Cells.Add(tableCell);
            tableCell = new HtmlTableCell
            {
                InnerHtml = "NO"
            };
            tableRow.Cells.Add(tableCell);
            tableCell = new HtmlTableCell
            {
                InnerHtml = "YES"
            };
            tableRow.Cells.Add(tableCell);
            ((HtmlTable)Controls[Controls.IndexOf(htmlTable)]).Rows.Add(tableRow);
        }
    }
}