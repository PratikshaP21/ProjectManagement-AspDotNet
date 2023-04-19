<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Assign Project.aspx.cs" Inherits="ProjectManagement_AspDotNet.Assign_Project" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 66%;
            height: 256px;
            border: 4px solid blue;
             background-color: lightskyblue;
        }
        .auto-style7 {
            text-align: center;
        }
        .auto-style8 {
            text-align: center;
            width: 368px;
        }
        .auto-style9 {
            text-align: center;
            height: 38px;
        }
        .auto-style10 {
            text-align: center;
            width: 368px;
            height: 38px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style6">
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lblProject" runat="server" Text="Project :"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:DropDownList ID="drpProject" runat="server" OnSelectedIndexChanged="drpProject_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lblProjectManager" runat="server" Text="Project Manager :"></asp:Label>
            </td>
            <td class="auto-style8">
                <asp:DropDownList ID="drpProjectManager" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Button ID="btnAssign" runat="server" OnClick="btnAssign_Click" Text="Assign" />
            </td>
            <td class="auto-style10">
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </td>
        </tr>
    </table>
<p>
    <br />
</p>
</asp:Content>
