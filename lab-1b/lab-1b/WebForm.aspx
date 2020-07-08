<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="lab_1b.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="CheckBox" runat="server" Text="CheckBox_PostBack" AutoPostBack="true" OnCheckedChanged="CheckBox_CheckedChanged"/>
        </div>
        <br />
        <div>
            <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>
            <asp:Button ID="Button" runat="server" OnClick="Button_Click" Text="Click me"/>
        </div>
        <div>
            <asp:Label ID="Label" runat="server"></asp:Label>
        </div>
        <br />
        <div>
            <asp:Label ID="EventTrace" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
