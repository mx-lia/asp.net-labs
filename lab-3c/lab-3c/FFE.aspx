<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FFE.aspx.cs" Inherits="lab_3c.FFE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Mode" runat="server"></asp:Label>
            <asp:AdRotator ID="AdRotator" runat="server" AdvertisementFile="~/App_Data/AdRotator.xml" />
            <br /><br />
            <asp:MultiView ID="MultiView" runat="server" ActiveViewIndex="0">

                <asp:View ID="View1" runat="server">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Button1" OnClick="Button1_Click" />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <br /><br />
                    <asp:Wizard ID="Wizard" runat="server" BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" DisplayCancelButton="True"
                        CancelButtonText="Stop" FinishCompleteButtonText="Done" FinishPreviousButtonText="Previous" Font-Bold="False" StartNextButtonText="Next" StepNextButtonText="Next" StepPreviousButtonText="Previous" ActiveStepIndex="0" OnCancelButtonClick="Wizard_CancelButtonClick" OnActiveStepChanged="Wizard_ActiveStepChanged" OnFinishButtonClick="Wizard_FinishButtonClick">
                        <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Left" />
                        <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                        <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
                        <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
                        <StepStyle BorderWidth="0px" ForeColor="#5D7B9D" />
                        <WizardSteps>
                            <asp:WizardStep runat="server" Title="Personal data">
                                <table>
                                    <tr>
                                        <td>Surname</td>
                                        <td><asp:TextBox ID="Surname" runat="server"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>Name</td>
                                        <td><asp:TextBox ID="Name" runat="server"></asp:TextBox></td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="CheckBoxList">
                                <asp:CheckBoxList ID="CheckBoxList" runat="server">
                                    <asp:ListItem>CheckBox1</asp:ListItem>
                                    <asp:ListItem>CheckBox2</asp:ListItem>
                                    <asp:ListItem>CheckBox3</asp:ListItem>
                                </asp:CheckBoxList>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="RadioButtonList">
                                <asp:RadioButtonList ID="RadioButtonList" runat="server">
                                    <asp:ListItem>Radio1</asp:ListItem>
                                    <asp:ListItem>Radio2</asp:ListItem>
                                    <asp:ListItem>Radio3</asp:ListItem>
                                </asp:RadioButtonList>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="ListBox">
                                <asp:ListBox ID="ListBox" runat="server">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                </asp:ListBox>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="Calendar">
                                <asp:Label ID="CalendarMode" runat="server" Text="DayWeek"></asp:Label>
                                <asp:Button ID="ChangeMode" runat="server" Text="ChangeMode" OnClick="ChangeMode_Click" />
                                <asp:Calendar ID="Calendar" runat="server" SelectionMode="DayWeek"></asp:Calendar>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="All info">
                                <asp:Label ID="AllInfo" runat="server"></asp:Label>
                            </asp:WizardStep>
                        </WizardSteps>
                    </asp:Wizard>
                </asp:View>

                <asp:View ID="View2" runat="server">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Text="Button2" OnClick="Button2_Click" />
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                    <br /><br />
                    <asp:TreeView ID="TreeView" runat="server" OnTreeNodeCheckChanged="TreeView_TreeNodeCheckChanged">
                        <Nodes>
                            <asp:TreeNode ImageUrl="~/Images/heart.png" Text="1" Value="1">
                                <asp:TreeNode Text="1-1" Value="1-1">
                                    <asp:TreeNode ShowCheckBox="True" Text="1-1-1" Value="1-1-1"></asp:TreeNode>
                                    <asp:TreeNode ShowCheckBox="True" Text="1-1-2" Value="1-1-2"></asp:TreeNode>
                                </asp:TreeNode>
                                <asp:TreeNode Text="1-2" Value="1-2"></asp:TreeNode>
                                <asp:TreeNode Text="1-3" Value="1-3"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="2" ToolTip="ToolTip for 2" Value="2">
                                <asp:TreeNode Text="2-1" Value="2-1"></asp:TreeNode>
                            </asp:TreeNode>
                        </Nodes>
                    </asp:TreeView>
                    <br />
                    <asp:Button runat="server" Text="submit"/>
                </asp:View>

                <asp:View ID="View3" runat="server">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button3" runat="server" Text="Button3" OnClick="Button3_Click" />
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                    <br /><br />
                    <asp:Menu ID="Menu" runat="server" OnMenuItemClick="Menu_MenuItemClick" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" StaticSubMenuIndent="10px">
                        <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <DynamicMenuStyle BackColor="#F7F6F3" />
                        <DynamicSelectedStyle BackColor="#5D7B9D" />
                        <Items>
                            <asp:MenuItem Text="1" Value="1">
                                <asp:MenuItem Text="1-1" Value="1-1">
                                    <asp:MenuItem Text="1-1-1" Value="1-1-1"></asp:MenuItem>
                                    <asp:MenuItem Text="1-1-2" Value="1-1-2"></asp:MenuItem>
                                </asp:MenuItem>
                                <asp:MenuItem Text="1-2" ToolTip="ToolTip for 1-2" Value="1-2"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="2" Value="2">
                                <asp:MenuItem Text="2-1" Value="2-1"></asp:MenuItem>
                            </asp:MenuItem>
                        </Items>
                        <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <StaticSelectedStyle BackColor="#5D7B9D" />
                    </asp:Menu>
                </asp:View>

            </asp:MultiView>
            <br /><br />
            <asp:Button ID="Button" runat="server" Text="Change view" OnClick="Button_Click" />
            <br /><br />
            <asp:Button ID="ChangeAdMode" runat="server" Text="ChangeAdMode" OnClick="ChangeAdMode_Click" />
        </div>
    </form>
</body>
</html>
