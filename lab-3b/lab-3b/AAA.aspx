<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AAA.aspx.cs" Inherits="lab_3b.AAA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox" runat="server" ValidationGroup="group1"></asp:TextBox>
            <asp:DropDownList ID="DropDownList" runat="server" ValidationGroup="group1"></asp:DropDownList>
            <br /><br />
            <asp:Button ID="ButtonGroup1" runat="server" Text="Group1"  ValidationGroup="group1"/>
            <br /><br />

            <asp:TextBox ID="NumberTextBox" runat="server" ValidationGroup="group2"></asp:TextBox>
            <asp:TextBox ID="DateTextBox" runat="server" ValidationGroup="group2"></asp:TextBox>
            <br /><br />
            <asp:Button ID="ButtonGroup2" runat="server" Text="Group2"  ValidationGroup="group2"/>
            <br /><br />

            <asp:TextBox ID="DateTextBox1" runat="server" ValidationGroup="group3"></asp:TextBox>
            <asp:TextBox ID="DateTextBox2" runat="server" ValidationGroup="group3"></asp:TextBox>
            <br /><br />
            <asp:Button ID="ButtonGroup3" runat="server" Text="Group3"  ValidationGroup="group3"/>
            <br /><br />

            <asp:TextBox ID="EmailTextBox" runat="server" ValidationGroup="group4"></asp:TextBox>
            <br /><br />
            <asp:Button ID="ButtonGroup4" runat="server" Text="Group4"  ValidationGroup="group4"/>
            <br /><br />

            <asp:TextBox ID="SimpleNumberTextBox" runat="server" ValidationGroup="group5"></asp:TextBox>
            <br /><br />
            <asp:Button ID="ButtonGroup5" runat="server" Text="Group5"  ValidationGroup="group5"/>
            <br /><br />

            <asp:RequiredFieldValidator ID="TextBoxValidator" runat="server" ErrorMessage="Не введено значение TextBox" ControlToValidate="TextBox" ValidationGroup="group1"></asp:RequiredFieldValidator>
            <br />
            <asp:RequiredFieldValidator ID="DropDownListValidator" runat="server" ErrorMessage="Не введено значение DropDownList" ControlToValidate="DropDownList" ValidationGroup="group1"></asp:RequiredFieldValidator>
            <br />

            <asp:RangeValidator ID="NumberTextBoxValidator" runat="server" ErrorMessage="Ошибка диапазона NumberTextBox" Type="Integer"
                 MinimumValue="100" MaximumValue="200" ControlToValidate="NumberTextBox" ValidationGroup="group2"></asp:RangeValidator>
            <br />
            <asp:RangeValidator ID="DateTextBoxValidator" runat="server" ErrorMessage="Ошибка диапазона DateTextBox" Type="Date"
                 MinimumValue="01.01.2011" MaximumValue="31.12.2011" ControlToValidate="DateTextBox" ValidationGroup="group2"></asp:RangeValidator>
            <br />

            <asp:CompareValidator ID="CompareValidator" runat="server" ErrorMessage="Ошибка сравнения DateTextBox1 и DateTextBox2" Type="Date" Operator="LessThan" 
                ControlToValidate="DateTextBox1" ControlToCompare="DateTextBox2" ValidationGroup="group3"></asp:CompareValidator>
            <br />

            <asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server" ErrorMessage="Ошибка регулярного выражения в EmailTextBox"
                ControlToValidate="EmailTextBox" ValidationExpression="^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$" ValidationGroup="group4"></asp:RegularExpressionValidator>
            <br />

            <asp:CustomValidator ID="CustomValidator" runat="server" ErrorMessage="Пользовательская ошибка в SimpleNumberTextBox" ValidationGroup="group5"
                ControlToValidate="SimpleNumberTextBox" ServerValidate="MyHandler" ClientValidationFunction="MyHandler" EnableClientScript="true"></asp:CustomValidator>
            <script type="text/javascript">
                function MyHandler(c, n) {
                    if (n.Value > 1) {
                        for (var i = 2; i < n.Value; i++) {
                            if (n.Value % i == 0) {
                                n.IsValid = false;
                                break;
                            }
                        }
                    }
                    else {
                        n.IsValid = false;
                    }
                }
            </script>
            <br />

        </div>
    </form>
</body>
</html>
