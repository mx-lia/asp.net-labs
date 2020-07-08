<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormA.aspx.cs" Inherits="lab_3d.WebFormA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
            <script>
                    var pm = Sys.WebForms.PageRequestManager.getInstance();
                    pm.add_initializeRequest(InitializeRequest);

                    function InitializeRequest(sender, args) {
                        if (pm.get_isInAsyncPostBack()) {
                            args.set_cancel(true);
                        }
                    }
                    function AbortPostBack() {
                        if (pm.get_isInAsyncPostBack()) {
                            pm.abortPostBack();
                        }
                    }
            </script>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox> * <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox> <asp:Button ID="CalculateButton" runat="server" Text=" = " OnClick="CalculateButton_Click" /> <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br /><br />
                    <asp:UpdateProgress ID="UpdateProgress" AssociatedUpdatePanelID="UpdatePanel1" runat="server">
                        <ProgressTemplate>
                            <img width="16" height="16" src="Content/load.gif" />
                            <input type="button" id="CancelButton" onclick="AbortPostBack()" value="cancel" />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
