<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Completed Project.aspx.cs" Inherits="ProjectManagement_AspDotNet.Completed_Project" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style6 {
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <div class="auto-style6">
        <asp:GridView ID="grdCompletedProject" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="207px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="760px" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="ProjectName" HeaderText="ProjectName" />
                <asp:BoundField DataField="Team Leader" HeaderText="Team Leader" />
                <asp:BoundField DataField="Project Manager" HeaderText="Project Manager" />
                <asp:BoundField DataField="Eemail" HeaderText="Eemail" />
                <asp:BoundField DataField="EPhoneNo" HeaderText="EPhoneNo" />
                <asp:BoundField DataField="AssignDate" HeaderText="AssignDate" />
                <asp:BoundField DataField="TLId" HeaderText="TLId" />
                <asp:BoundField DataField="ProjectID" HeaderText="ProjectID" />
                <asp:CommandField ButtonType="Button" HeaderText="Manage" SelectText="Pay" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </div>
    <br />
</p>
</asp:Content>
