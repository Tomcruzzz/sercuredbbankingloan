<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MasterPage/General.master" AutoEventWireup="true" CodeFile="After_CheckEmail_Fp.aspx.cs" Inherits="HomePage_Login_After_CheckEMail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
             width: 169px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div align="center">
    <table style="height: 215px; width: 633px;">
        <tr>
            <td colspan="2"><center><h3>Forgot Password </h3>&nbsp;</center></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Change Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_ChangePassword" runat="server" Width="174px" TextMode="Password"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Verification Code"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Verificationcode" runat="server" Width="174px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btn_Confirm" runat="server" Text="Confirm" OnClick="btn_Confirm_Click"/>
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

