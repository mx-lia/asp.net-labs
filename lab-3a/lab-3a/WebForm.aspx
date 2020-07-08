<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="lab_3a.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="Form" runat="server">
        <div>
            Элемент InputReset <input id="InputReset" type="reset" value="reset" runat="server" onserverclick="OnServerClick" onserverchange="OnServerChange" /><br />
            Элемент InputFile <input id="InputFile" type="file" runat="server" onserverclick="OnServerClick" onserverchange="OnServerChange" /><br />
            Элемент InputText <input id="InputText" type="text" runat="server" onserverclick="OnServerClick" onserverchange="OnServerChange" /><br />
            Элемент InputPassword <input id="InputPassword" type="password" runat="server" onserverclick="OnServerClick" onserverchange="OnServerChange" /><br />
            Элемент InputCheckbox <input id="InputCheckbox" type="checkbox" value="InputCheckbox" runat="server" onserverclick="OnServerClick" onserverchange="OnServerChange" /><br />
            Элемент InputRadioButton <input id="InputRadioButton" name="radio" type="radio" runat="server" value="1" onserverchange="OnServerChange" /><br />
            Элемент InputTextArea <textarea id="InputTextArea" runat="server" onserverclick="OnServerClick" onserverchange="OnServerChange" /><br />
            Элемент InputSelect <select id="InputSelect" value="InputSelect" runat="server" onserverclick="OnServerClick" onserverchange="OnServerChange" /><br />
            Элемент InputButton <input id="InputButton" type="button" value="button" runat="server" onserverclick="OnServerClick" onserverchange="OnServerChange" /><br />
            Элемент InputSubmit <input id="InputSubmit" type="submit" value="submit" runat="server" onserverclick="OnServerClick" onserverchange="OnServerChange" /><br />
        </div>
    </form>
</body>
</html>
