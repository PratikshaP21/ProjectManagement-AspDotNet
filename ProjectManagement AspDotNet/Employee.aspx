<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectManagement.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="ProjectManagement_AspDotNet.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            width: 46%;
            height: 290px;
            border:4px solid blue;
            background-color:lightskyblue;
        }
        .auto-style9 {
            text-align: center;
            height: 13px;
        }
        .auto-style10 {
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
                    <asp:Label ID="lblType" runat="server" Text="Type:"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:DropDownList ID="drpType" runat="server">
                        <asp:ListItem>--selecte---</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblEmail" runat="server" Text="E-mail:"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblPhone" runat="server" Text="Phone:"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:RadioButton ID="rdbMale" runat="server" OnCheckedChanged="rdbMale_CheckedChanged" Text="Male" />
                    <asp:RadioButton ID="rdbFemale" runat="server" OnCheckedChanged="rdbFamale_CheckedChanged" Text="Female" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblCountry" runat="server" Text="Country:"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:DropDownList ID="drpCountry" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpCountry_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblState" runat="server" Text="State:"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:DropDownList ID="drpState" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpState_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblCity" runat="server" Text="City:"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:DropDownList ID="drpCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpCity_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
                    </em>
                </td>
            </tr>
        </table>
    </p>
    <p>
    </p>
</asp:Content>
