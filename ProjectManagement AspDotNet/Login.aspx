<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectManagement.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectManagement_AspDotNet.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style7 {
        width: 49%;
        height: 238px;
        border: 4px solid Blue;
          background-color: lightskyblue;
    }
    .auto-style8 {
        height: 33px;
        width: 526px;
        text-align: center;
    }
    .auto-style9 {
        height: 35px;
        width: 526px;
        text-align: center;
    }
    .auto-style10 {
        height: 42px;
        width: 526px;
        text-align: center;
    }
    .auto-style11 {
        height: 42px;
        width: 510px;
        text-align: center;
    }
    .auto-style12 {
        height: 35px;
        width: 510px;
        text-align: center;
    }
    .auto-style13 {
        height: 33px;
        width: 510px;
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <table class="auto-style7" align="center">
        <tr>
            <td class="auto-style10">
                <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="auto-style12">
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </td>
            <td class="auto-style13">
                <asp:Button ID="btnClear" runat="server" Text="Clear" />
            </td>
        </tr>
    </table>
</p>
<p>
</p>
</asp:Content>
