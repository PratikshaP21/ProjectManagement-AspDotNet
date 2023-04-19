<%@ Page Title="" Language="C#" MasterPageFile="~/Project Manager.Master" AutoEventWireup="true" CodeBehind="Project Manager.aspx.cs" Inherits="ProjectManagement_AspDotNet.Team_Leader1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style6 {
            width: 40%;
            height: 263px;
            border: 4px solid blue;
             background-color: lightskyblue;
        }
        .auto-style7 {
            text-align: center;
            height: 135px;
            width: 355px;
        }
        .auto-style8 {
            text-align: center;
            width: 368px;
            height: 135px;
        }
        .auto-style15 {
            text-align: center;
            height: 108px;
            width: 355px;
        }
        .auto-style16 {
            text-align: center;
            width: 368px;
            height: 108px;
           
        }
        .auto-style17 {
            text-align: center;
            height: 105px;
            width: 355px;
        }
        .auto-style18 {
            text-align: center;
            width: 368px;
            height: 105px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <table align="center" class="auto-style6">
        <tr>
            <td class="auto-style15">
                <asp:Label ID="lblProject" runat="server" Text="Project :"></asp:Label>
            </td>
            <td class="auto-style16">
                <asp:DropDownList ID="drpProject" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">
                <asp:Label ID="lblProjectManager" runat="server" Text="Team Leader :"></asp:Label>
            </td>
            <td class="auto-style18">
                <asp:DropDownList ID="drpTeamLeader" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Button ID="btnAssign" runat="server" OnClick="btnAssign_Click" Text="Assign" />
            </td>
            <td class="auto-style8">
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </td>
        </tr>
    </table>
</p>
<p>
    &nbsp;</p>
</asp:Content>
