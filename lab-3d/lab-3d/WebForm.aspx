<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="lab_3d.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>
        function pageLoad() {
            let pm = Sys.WebForms.PageRequestManager.getInstance();
            pm.add_endRequest(endRequest);
        }
        function endRequest(sender, args) {
            if (args.get_error() != undefined)
                alert(args.get_error().message);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager" runat="server" OnAsyncPostBackError="ScriptManager_AsyncPostBackError"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> + <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> = <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br />
                    <asp:CheckBox ID="CheckBox" runat="server" Text="checkbox" /><br /><br />
                    <asp:RadioButton ID="RadioButton" runat="server" Text="radiobutton" /><br /><br />
                    <asp:Button ID="SubmitButton" runat="server" Text="submit" OnClick="SubmitButton_Click" />
                    <asp:Timer ID="Timer1" runat="server" Interval="5000" OnTick="Timer_Tick"></asp:Timer>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="TriggerButton" EventName="Click"  />
                </Triggers>
            </asp:UpdatePanel>
            <br />
            <asp:Button ID="TriggerButton" runat="server" Text="trigger" OnClick="SubmitButton_Click" />
            <br /><br />
        </div>
    </form>
</body>
</html>
