<%@ Page Title="" Language="C#" MasterPageFile="~/Team Leader.Master" AutoEventWireup="true" CodeBehind="Team Leader.aspx.cs" Inherits="ProjectManagement_AspDotNet.Team_Leader3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        width: 100%;
        height: 326px;
        border: 2px solid #000080;
        background-color: #00FFFF;
    }
    .auto-style5 {
        text-align: right;
    }
    .auto-style6 {
        text-align: center;
    }
    .auto-style7 {
        height: 326px;
    }
        .auto-style8 {
            width: 65%;
            height: 311px;
            border: 2px solid #000080;
            background-color: #00FFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style7">
    <table class="auto-style8">
        <tr>
            <td class="auto-style5" colspan="3">
                <asp:Label ID="lblTlName" runat="server" Text="TL Name"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="3">
                <asp:Label ID="lblProjectName" runat="server" Text="Project Name"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label3" runat="server" Text="Project Name"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:Label ID="lblItration1" runat="server" Text="Itration1"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:Button ID="btnComplete1" runat="server" Text="Complete" OnClick="btnComplete1_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label4" runat="server" Text="Project Name"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:Label ID="lblItration2" runat="server" Text="Itration2"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:Button ID="btnComplete2" runat="server" Text="Complete" OnClick="btnComplete2_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label5" runat="server" Text="Project Name"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:Label ID="lblItration3" runat="server" Text="Itration3"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:Button ID="btnComplete3" runat="server" Text="Complete" OnClick="btnComplete3_Click" />
            </td>
        </tr>
    </table>
    <br />
</p>
</asp:Content>
