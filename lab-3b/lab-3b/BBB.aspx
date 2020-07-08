<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BBB.aspx.cs" Inherits="lab_3b.BBB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Surname</td>
                    <td><asp:TextBox ID="Surname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td><asp:TextBox ID="Name" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Patronymic</td>
                    <td><asp:TextBox ID="Patronymic" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Birthday</td>
                    <td><asp:TextBox ID="Birthday" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td><asp:TextBox ID="Email" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Sum</td>
                    <td><asp:TextBox ID="Sum" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td><asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Button" runat="server" Text="Submit"/></td>
                </tr>
            </table>
            <br /><br />
            <asp:ValidationSummary ID="ValidationSummary" runat="server" ShowMessageBox="false" ShowSummary="true" DisplayMode="BulletList" />
            <asp:RequiredFieldValidator ID="SurnameValidator" runat="server" ErrorMessage="Empty value of Surname" ControlToValidate="Surname" Display="None"></asp:RequiredFieldValidator><br />
            <asp:RequiredFieldValidator ID="NameValidator" runat="server" ErrorMessage="Empty value of Name" ControlToValidate="Name" Display="None"></asp:RequiredFieldValidator><br />
            <asp:RequiredFieldValidator ID="PatronymicValidator" runat="server" ErrorMessage="Empty value of Patronymic" ControlToValidate="Patronymic" Display="None"></asp:RequiredFieldValidator><br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Incorrect value of Surname"
                ControlToValidate="Surname" ValidationExpression="([А-Яа-я])+" Display="None"></asp:RegularExpressionValidator><br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Incorrect value of Name"
                ControlToValidate="Name" ValidationExpression="([А-Яа-я])+" Display="None"></asp:RegularExpressionValidator><br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Incorrect value of Patronymic"
                ControlToValidate="Patronymic" ValidationExpression="([А-Яа-я])+" Display="None"></asp:RegularExpressionValidator><br />
            <asp:RangeValidator ID="SumValidator" runat="server" ErrorMessage="Range error in Sum" Type="Integer"
                 MinimumValue="1000" MaximumValue="2000" ControlToValidate="Sum" Display="None"></asp:RangeValidator><br />
            <asp:CompareValidator ID="CompareValidator" runat="server" ErrorMessage="Error in Birthday" Type="Date" Operator="LessThan" 
                ControlToValidate="Birthday" ValueToCompare="26.03.2020" Display="None"></asp:CompareValidator><br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server" ErrorMessage="Incorrect value of Email"
                ControlToValidate="Email" ValidationExpression="^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$" Display="None"></asp:RegularExpressionValidator><br />
            <asp:CustomValidator ID="CustomValidator" runat="server" ErrorMessage="Password must contain more than 7 characters and non-repeatable symbols"
                ControlToValidate="Password" ServerValidate="MyHandler" ClientValidationFunction="MyHandler" EnableClientScript="true" Display="None"></asp:CustomValidator>
            <script>
                function MyHandler(c, n) {
                    n.IsValid = (new Set(n.Value).size == n.Value.length) && (n.Value.length >= 7);
                }
            </script>
        </div>
    </form>
</body>
</html>
