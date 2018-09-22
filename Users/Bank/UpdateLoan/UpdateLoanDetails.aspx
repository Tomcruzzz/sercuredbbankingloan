<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Bank/MasterPage/Admin.master" AutoEventWireup="true" CodeFile="UpdateLoanDetails.aspx.cs" Inherits="Users_Bank_AddLoan_AddLoanDetails" %>

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
            <td colspan="2"><center><h3>Update Loan Details </h3>&nbsp;</center></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
       <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="BankName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_BankName" runat="server" Width="174px" Enabled="False"></asp:TextBox>
                <br />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Loan Started Date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_LoanStartedDate" runat="server" Width="174px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Name" runat="server" Width="174px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Loan Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_LoanName" runat="server" Width="174px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
       
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Issued Amount"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Amount" runat="server" Width="174px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Balance"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Balance" runat="server" Width="174px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Paid For"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drp_Status" runat="server" OnSelectedIndexChanged="drp_Status_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>---Select Status---</asp:ListItem>
                    <asp:ListItem>First Payment</asp:ListItem>
                    <asp:ListItem>Second Payment</asp:ListItem>
                    <asp:ListItem>Third Payment</asp:ListItem>
                    <asp:ListItem>Pending</asp:ListItem>
                </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            <td>
                <asp:Label ID="lbl_Pay" runat="server" Text="Payment Amount"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_PaymentAmount" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
         <tr>
            <td colspan="2">
                <asp:Button ID="btn_UpdateLoan" runat="server" Text="Update" OnClick="btn_AddLoan_Click"/>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="4">
                 <asp:GridView ID="grd_EditLoan" runat="server" AutoGenerateColumns="False" DataKeyNames="Bank_Id" Width="16px">
                    <Columns>
                        <asp:TemplateField HeaderText="Loan_Id" Visible="False">
                            <ItemTemplate>
                                <asp:Label ID="Label11" runat="server" Text='<%# bind("Loan_Id") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="AdharId" Visible="False">
                        <ItemTemplate>
                                <asp:Label ID="Label12" runat="server" Text='<%# bind("AdharId") %>'></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                        <asp:TemplateField HeaderText="Name">
                            <ItemTemplate>
                                <asp:Label ID="Label13" runat="server" Text='<%# bind("Name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="LoanName">
                            <ItemTemplate>
                                <asp:Label ID="Label14" runat="server" Text='<%# bind("LoanName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Duration">
                            <ItemTemplate>
                                <asp:Label ID="Label15" runat="server" Text='<%# bind("LoanDuration") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Issued Date">
                            <ItemTemplate>
                                <asp:Label ID="Label16" runat="server" Text='<%# bind("Loan_StartedDate") %>'></asp:Label>
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
                                <asp:Label ID="Label17" runat="server" Text='<%# bind("Loan_ThirdDate") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Balance">
                            <ItemTemplate>
                                <asp:Label ID="Label9" runat="server" Text='<%# bind("Balance") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Status">
                            <ItemTemplate>
                                <asp:Label ID="Label10" runat="server" Text='<%# bind("Status") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
           
            <td class="auto-style1">
                 &nbsp;</td>
           
            <td class="auto-style1">
                 &nbsp;</td>
           
        </tr>
        
    </table>
        </div>
</asp:Content>

