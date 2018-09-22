<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Bank/MasterPage/Admin.master" AutoEventWireup="true" CodeFile="Deposit_Debit.aspx.cs" Inherits="Users_Bank_DebitDeposit_Deposit_Debit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
    <table style="height: 100px; width: 633px;">
        <tr>
            <td colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Red" Text="Bank Name :"></asp:Label>

                &nbsp;

                <asp:Label ID="lbl_BankName" runat="server" Font-Bold="True" Font-Size="Medium" Text="Label" ForeColor="Red"></asp:Label>
                &nbsp;<br />
            </td>
        </tr>
        <tr>
            <td colspan="2"><center><h3>Debit Card Details </h3>&nbsp;</center></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Account_No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_AccountNo" runat="server" Width="174px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Name" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Adhar No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_AdharNo" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Amount"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Amount" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Mobile No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_MobileNo" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Email Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_EmailId" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Date" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btn_Submit" runat="server" Text="Submit" OnClick="btn_Submit_Click"/>
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

