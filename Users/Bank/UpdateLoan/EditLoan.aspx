<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Bank/MasterPage/Admin.master" AutoEventWireup="true" CodeFile="EditLoan.aspx.cs" Inherits="Users_Bank_UpdateLoan_EditLoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
             width: 169px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
    <table style="height: 100px; width: 656px;">
        <tr>
            <td colspan="2"><center><h3>Edit Loan Details </h3>&nbsp;</center></td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="2">
                <asp:GridView ID="grd_EditLoan" runat="server" AutoGenerateColumns="False" OnRowCommand="grd_EditLoan_RowCommand" DataKeyNames="Loan_Id" Width="187px">
                    <Columns>
                        <asp:TemplateField HeaderText="Bank Id" Visible="False">
                             <ItemTemplate>
                                <asp:Label ID="Label11" runat="server" Text='<%# bind("Bank_Id") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Loan_Id" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# bind("Loan_Id") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="AdharId" Visible="false">
                        <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# bind("AdharId") %>'></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                        <asp:TemplateField HeaderText="Name">
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# bind("Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="LoanName">
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# bind("LoanName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Duration">
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# bind("LoanDuration") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Issued Date" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" Text='<%# bind("Loan_StartedDate") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="First Payment Date">
                            <ItemTemplate>
                                <asp:Label ID="Label7" runat="server" Text='<%# bind("Loan_FirstDate") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Second Payment Date">
                            <ItemTemplate>
                                <asp:Label ID="Label8" runat="server" Text='<%# bind("Loan_SecondDate") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Third Payment Date">
                             <ItemTemplate>
                                <asp:Label ID="Label8" runat="server" Text='<%# bind("Loan_ThirdDate") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Issued Amount">
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" Text='<%# bind("LoanAmount") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Status">
                            <ItemTemplate>
                                <asp:Label ID="Label10" runat="server" Text='<%# bind("Status") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowEditButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
           
        </tr>
        
    </table>
        </div>

</asp:Content>

