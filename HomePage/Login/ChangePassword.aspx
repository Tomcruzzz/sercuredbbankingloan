<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MasterPage/General.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="HomePage_Login_ChangePassword" %>

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
            <td colspan="2"><center><h3>Change Password </h3>&nbsp;</center></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Current Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_CurrentPassword" runat="server" Width="174px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="New Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_NewPassword" runat="server" Width="174px" TextMode="Password"></asp:TextBox>
            </td>
        </tr> 
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Verification Code"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_Verificationcode" runat="server" Width="174px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td colspan="2">
            <center><asp:Button runat="server" Text="Change Password" ID="btn_ChangePassword" OnClick="btn_ChangePassword_Click" /></center>
        </td>
        </tr>
    </table>
        </div>

    </div>

</asp:Content>

