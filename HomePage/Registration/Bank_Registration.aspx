<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MasterPage/General.master" AutoEventWireup="true" CodeFile="Bank_Registration.aspx.cs" Inherits="HomePage_Registration_Bank_Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 175px;
        }
        .auto-style2 {
            width: 197px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div align="center">
        <h3>
            BANK REGISTRATION</h3>
       <table bgcolor="White">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label6" runat="server" Text="Bank Type"></asp:Label>
                    <br />
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="drp_BankType" runat="server">
                        <asp:ListItem>----Select---</asp:ListItem>
                        <asp:ListItem>Bank1</asp:ListItem>
                        <asp:ListItem>Bank2</asp:ListItem>
                        <asp:ListItem>Bank3</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </td>
                
                <td class="auto-style2">
                    &nbsp;</td>
                
           </tr>
                <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="BankName"></asp:Label>
                    <br />
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtbankname" runat="server" Width="174px"></asp:TextBox>
                    <br />
                </td>
                
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtbankname" ErrorMessage="Fill This Field" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                
           </tr>
           <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Branch"></asp:Label>
                    <br />
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txt_branch" runat="server" Width="174px"></asp:TextBox>
                </td>
               
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_branch" ErrorMessage="Fill This Field" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style1">
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="IFSC Code"></asp:Label>
                    <br />
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txt_IfscCode" runat="server" Width="174px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_IfscCode" ErrorMessage="Fill This Field" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Secret Code"></asp:Label>
                    <br />
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txt_SecretCode" runat="server" MaxLength="5" style="margin-left: 0px" Width="174px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_SecretCode" ErrorMessage="Fill This Field" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
               </tr> 
           <tr>                   
              
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Text="Mobile No"></asp:Label>
                    <br />
                </td>
                <td class="auto-style2">
                    <br />
                    <asp:TextBox ID="txt_MobileNo" runat="server" Width="174px"></asp:TextBox>
                    <br />
                </td> 
                <td class="auto-style2">
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_MobileNo" ErrorMessage="Fill This Field" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_MobileNo" ErrorMessage="Invalid Mobile No" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                    </td> 
            </tr>
           <tr>                   
              
                <td class="auto-style1">
                    <asp:Label ID="Label7" runat="server" Text="Email Id"></asp:Label>
                    <br />
                </td>
                <td class="auto-style2">
                    <br />
                    <asp:TextBox ID="txt_Email" runat="server" Width="174px"></asp:TextBox>
                    <br />
                </td>
                
                <td class="auto-style2">
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txt_Email" ErrorMessage="Fill This Field" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_Email" ErrorMessage="Invalid Email Id" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                
            </tr>
           
                        
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label13" runat="server" Text="UserName"></asp:Label>
                    <br />
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtusername" runat="server" Width="174px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtusername" ErrorMessage="Fill This Field" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
&nbsp;&nbsp;
                    <br />
                </td>
                </tr>
           <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label14" runat="server" Text="Password"></asp:Label>
                    <br />
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" Width="174px"></asp:TextBox>
                    <br />

                </td>
                <td class="auto-style2">
&nbsp;

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtpwd" ErrorMessage="Fill This Field" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>

                </td>
            </tr>
           <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label15" runat="server" Text="Confirm Password"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txt_confirmpassword" runat="server" TextMode="Password" Width="171px"></asp:TextBox>

                </td>
                <td class="auto-style2">
&nbsp;&nbsp;
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txt_confirmpassword" ErrorMessage="Fill This Field" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
&nbsp;<br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd" ControlToValidate="txt_confirmpassword" ErrorMessage="Password Don'tMatch" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator>
                    
                </td>
            </tr>
           <tr>
                <td colspan="2">
                 <center><asp:Button ID="btn_Submit" runat="server" onclick="btn_Submit_Click" 
                        Text="Submit" style="height: 26px" /></center>
                        </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        
    </div>
</asp:Content>

