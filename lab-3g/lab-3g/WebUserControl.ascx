<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl.ascx.cs" Inherits="lab_3g.WebUserControl" %>

 <div>
    <table>
        <tr>
            <td>Surname</td>
            <td><asp:TextBox ID="SurnameTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Name</td>
            <td><asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Patronymic</td>
            <td><asp:TextBox ID="PatronymicTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Birthday</td>
            <td><asp:TextBox ID="BirthdayTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:RadioButtonList ID="GenderList" runat="server">
                    <asp:ListItem Text="woman" Value="woman"></asp:ListItem>
                    <asp:ListItem Text="man" Value="man"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Faculty</td>
            <td>
                <asp:DropDownList ID="FacultiesList" runat="server">
                    <asp:ListItem Text="IT" Value="IT"></asp:ListItem>
                    <asp:ListItem Text="TOV" Value="TOV"></asp:ListItem>
                    <asp:ListItem Text="PIM" Value="PIM"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Group</td>
            <td><asp:TextBox ID="GroupTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Year of entry</td>
            <td><asp:TextBox ID="YearTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button ID="SubmitButton" runat="server" Text="submit"/></td>
            <td><asp:Button ID="CancelButton" runat="server" Text="cancel"/></td>
        </tr>
    </table>
    <br /><br />
    <asp:ValidationSummary ID="ValidationSummary" runat="server" ShowMessageBox="false" ShowSummary="true" DisplayMode="BulletList" />
    <asp:RequiredFieldValidator ID="SurnameValidator" runat="server" ErrorMessage="Empty value of Surname" ControlToValidate="SurnameTextBox" Display="None"></asp:RequiredFieldValidator><br />
    <asp:RangeValidator ID="GroupRangeValidator" runat="server" ErrorMessage="Group must be in [1, 100]" Type="Integer" MinimumValue="1" MaximumValue="100" ControlToValidate="GroupTextBox" Display="None"></asp:RangeValidator><br />
</div>