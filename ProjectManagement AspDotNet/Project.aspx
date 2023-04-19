<%@ Page Title="" Language="C#" MasterPageFile="~/ProjectManagement.Master" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="ProjectManagement_AspDotNet.Project" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            width: 45%;
            height: 299px;
             border:4px solid blue;
              background-color: lightskyblue;
        }
        .auto-style8 {
            height: 49px;
            text-align: center;
        }
        .auto-style9 {
            text-align: center;
        }
        .auto-style11 {
            margin-bottom: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table align="center" class="auto-style7">
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="lblType" runat="server" Text="Type"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:DropDownList ID="drpType" runat="server">
                        <asp:ListItem>Java</asp:ListItem>
                        <asp:ListItem>Python</asp:ListItem>
                        <asp:ListItem>MVC</asp:ListItem>
                        <asp:ListItem>.Net</asp:ListItem>
                        <asp:ListItem>PHP</asp:ListItem>
                        <asp:ListItem>C#</asp:ListItem>
                        <asp:ListItem>C++</asp:ListItem>
                        <asp:ListItem>HTML</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="lblPrpjectName" runat="server" Text="Project Name"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtProjectName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="lblStartDate" runat="server" Text="Start Date"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtCalStartDate" runat="server" CssClass="auto-style11" OnTextChanged="txtCalStartDate_TextChanged"></asp:TextBox>
                    <asp:ImageButton ID="btnCalStartDate" runat="server" Height="20px" ImageUrl="~/Content/Images/calendar ASP.png" OnClick="btnCalStartDate_Click" Width="33px" />
                    <asp:Calendar ID="CalStartDate" runat="server" OnSelectionChanged="CalStartDate_SelectionChanged" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="lblEndDate" runat="server" Text="EndDate"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtCalEndDate" runat="server"></asp:TextBox>
                    <asp:ImageButton ID="btnEndDate" runat="server" Height="16px" ImageUrl="~/Content/Images/calendar ASP.png" OnClick="btnEndDate_Click" Width="33px" />
                    <asp:Calendar ID="CalEndDate" runat="server" OnSelectionChanged="CalEndDate_SelectionChanged" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                </td>
            </tr>
        </table>
        <br />
    </p>
    </asp:Content>
