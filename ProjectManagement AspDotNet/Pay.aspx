<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Pay.aspx.cs" Inherits="ProjectManagement_AspDotNet.Pay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 62%;
        }
        .auto-style7 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style6">
        <tr>
            <td class="auto-style7">
        <asp:Button ID="btnPayment" runat="server" Text="Payment" OnClick="btnPayment_Click" />
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
</asp:Content>
