<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Bank/MasterPage/Admin.master" AutoEventWireup="true" CodeFile="AddLoanDetails.aspx.cs" Inherits="Users_Bank_AddLoan_AddLoanDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
    <table style="height: 215px; width: 633px;">
        <tr>
            <td colspan="2"><center><h3>Add Loan Details </h3>&nbsp;</center></td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Red" Text="Bank Name :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_BankName" runat="server" Font-Bold="True" Font-Size="Medium" Text="Label" ForeColor="Red"></asp:Label>
                &nbsp;<br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="BankName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_BankName" runat="server" Width="174px" Enabled="False"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Loan Started Date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_LoanStartedDate" runat="server" Width="174px" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Name" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Adhar Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_AdharId" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Pan Card No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_PanCardNo" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Ration Card No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_RationCardNo" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Income"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Income" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Address"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Address" runat="server" Width="174px" Height="75px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Loan Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_LoanName" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Loan Duration"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drp_LoanDuration" runat="server">
                    <asp:ListItem>----Select---</asp:ListItem>
                    <asp:ListItem>1Month</asp:ListItem>
                    <asp:ListItem>3Months</asp:ListItem>
                    <asp:ListItem>6Months</asp:ListItem>
                    <asp:ListItem>1Year</asp:ListItem>
                    <asp:ListItem>3Years</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Amount"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Amount" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Status"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="drp_Status" runat="server">
                    <asp:ListItem>---Select Status---</asp:ListItem>
                    <asp:ListItem>Not Paid</asp:ListItem>
                    <asp:ListItem>paid</asp:ListItem>
                    <asp:ListItem>Pending</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btn_AddLoan" runat="server" Text="Add" OnClick="btn_AddLoan_Click"/>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>
</asp:Content>

