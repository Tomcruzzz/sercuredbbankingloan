<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MasterPage/General.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="HomePage_Login_Login" %>

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

<td style="width: 3300px">

    <table>
    <tr>
     <td rowspan="7">
         <asp:Image ID="Image3" runat="server" Height="200px" 
             ImageUrl="~/HomePage/images/3.jpg" Width="200px" />
     </td>
            <td style="width: 127px">
                <asp:Label ID="Label3" runat="server" Text="Bank Type"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="drp_usertype" runat="server" style="margin-left: 0px" 
                    AutoPostBack="True" onselectedindexchanged="drp_usertype_SelectedIndexChanged">
                    <asp:ListItem>---Select---</asp:ListItem>
                    <asp:ListItem>Bank1</asp:ListItem>
                    <asp:ListItem>Bank2</asp:ListItem>
                    <asp:ListItem>Bank3</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 127px">
                <asp:Label ID="Label4" runat="server" Text="Branch"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="drp_branch" runat="server" style="margin-left: 0px">
                    <asp:ListItem>---Select---</asp:ListItem>
                </asp:DropDownList>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 127px">
                <asp:Label ID="Label1" runat="server" Text="UserName "></asp:Label>
                <br />
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtusername" runat="server" Width="126px"></asp:TextBox>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 127px">
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                <br />
            </td>
            <td class="auto-style1">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="125px"></asp:TextBox>
                <br />
                <br />
            </td>
        </tr>
        
        <tr>
            <td colspan="2">
                &nbsp;
              <center>  <asp:Button ID="btnlogin" runat="server" onclick="btnlogin_Click" Text="Login" 
                    Width="53px" /></center>
            </td>
            
            
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/HomePage/Login/EmailVerify_Fp.aspx">Forgot Password</asp:LinkButton>
            </td>
    <td>
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/HomePage/Login/EmailVerify_Cp.aspx">Change Password</asp:LinkButton>
            </td>        
            
        </tr>
    </table>
&nbsp;

</td>
<td style="width: 908px">
    &nbsp;</td>
</tr>
</table>
        </div>
</asp:Content>

