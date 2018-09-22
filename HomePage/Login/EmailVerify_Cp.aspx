<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MasterPage/General.master" AutoEventWireup="true" CodeFile="EmailVerify_Cp.aspx.cs" Inherits="HomePage_Login_ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
    <table style="height: 215px; width: 633px;">
        <tr>
            <td colspan="2"><center><h3>Verify Password </h3>&nbsp;</center></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Email Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Email" runat="server" Width="174px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btn_CheckEmail" runat="server" Text="Check Email" OnClick="btn_CheckEmail_Click" />
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

