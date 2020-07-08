<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab_1a._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="col-md-4">
            <h2>Lab 1</h2>
            <p>
                <asp:DropDownList ID="MyDropDownList" runat="server">
                    <asp:ListItem Selected="true">Option 1</asp:ListItem>
                    <asp:ListItem>Option 2</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:CheckBox ID="MyCheckBox" runat="server" Text="CheckBox"></asp:CheckBox>
            </p>
            <p>
                <asp:Label ID="MyLabel" runat="server">Label</asp:Label>
            </p>
            <p>
                <asp:TextBox ID="MyTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="MyButton" runat="server" onClick="MyButton_Click" cssClass="btn btn-default" Text="Click me!"></asp:Button>
            </p>
        </div>
</asp:Content>
