<%@ Page Title="" Language="C#" MasterPageFile="~/Users/Bank/MasterPage/Admin.master" AutoEventWireup="true" CodeFile="ViewLoan.aspx.cs" Inherits="Users_Bank_ViewLoan_ViewLoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 400px;
        }
        .auto-style3 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
    <table style="height: 100px; width: 655px;">
        <tr>
            <td colspan="2"><center><h3>View Loan Details </h3>&nbsp;</center></td>
        </tr>
         <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Red" Text="Bank Name :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_BankName" runat="server" Font-Bold="True" Font-Size="Medium" Text="Label" ForeColor="Red"></asp:Label>
                &nbsp;<br />
            </td>
        </tr>
         <tr>
    <td>
        <asp:Label ID="Label13" runat="server" Text="Adhar Id"></asp:Label>
    </td>
    <td class="auto-style1">
        <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_AdharId" runat="server" />
    &nbsp;<br />
        <br />
              </td>
    <td class="auto-style2">
                  <asp:Button ID="btn_Find" runat="server" Text="Search" OnClick="btn_Find_Click" />
         
                  </td>
             <td>
               
              </td>
             </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Key"></asp:Label>
                </td>
               <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txt_Key" runat="server" />
                   <br />
                   <br />
               </td>
               <td>
                   &nbsp;</td>
           </tr>
       <tr>
    <td colspan="4">
        <asp:DataList ID="dl_DB1" runat="server" CellPadding="4" ForeColor="#333333" RepeatColumns="1" RepeatDirection="Horizontal" Width="644px" OnItemCommand="dl_DB1_ItemCommand">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#EFF3FB" />
            <ItemTemplate>
                <table class="auto-style3">
                    <tr>
                        <td colspan="5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="#6600FF" Text='<%# bind("BankName") %>'></asp:Label>
                            &nbsp;</td>
                      
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label27" runat="server" Font-Bold="True" Text="Name :"></asp:Label>
                        </td>
                         <td colspan="2">
                             <asp:Label ID="Label28" runat="server" Font-Bold="True" Text='<%# bind("Name") %>'></asp:Label>
                        </td>
                         <td>
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Address :"></asp:Label>
                        </td>
                         <td>
                             <asp:Label ID="Label29" runat="server" Font-Bold="True" Text='<%# bind("Address") %>'></asp:Label>
                             <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label34" runat="server" Font-Bold="True" Text="Adhar Id :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label35" runat="server" Font-Bold="True" Text='<%# bind("AdharId") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label36" runat="server" Font-Bold="True" Text="Income :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label37" runat="server" Font-Bold="True" Text='<%# bind("Income") %>'></asp:Label>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label30" runat="server" Font-Bold="True" Text="Pan Card No :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label31" runat="server" Font-Bold="True" Text='<%# bind("PanCardNo") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label32" runat="server" Font-Bold="True" Text="Ration Card No :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label33" runat="server" Font-Bold="True" Text='<%# bind("RationCardNo") %>'></asp:Label>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label15" runat="server" Font-Bold="True" Text="Loan Date :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label16" runat="server" Font-Bold="True" Text='<%# bind("Loan_StartedDate") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Issued Amount :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label18" runat="server" Font-Bold="True" Text='<%# bind("LoanAmount") %>'></asp:Label>
                        </td>
                        
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label38" runat="server" Font-Bold="True" Text="Loan Name :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="lbl_LoanName" runat="server" Font-Bold="True" ForeColor="#0000CC" Text='<%# bind("LoanName") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label40" runat="server" Font-Bold="True" Text="Payment Status :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label41" runat="server" Font-Bold="True" ForeColor="Red" Text='<%# bind("Status") %>'></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label19" runat="server" Font-Bold="True" Text="Last Payment :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label20" runat="server" Font-Bold="True" Text='<%# bind("PaymentDate") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label21" runat="server" Font-Bold="True" Text="Balance :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label22" runat="server" Font-Bold="True" Text='<%# bind("Balance") %>'></asp:Label>
                            <br />
                        </td>
                       
                    </tr>
                        <tr>
                        <td colspan="2">
                            <asp:LinkButton ID="lnk_Decrypt" runat="server" CommandName="Item">Decrypt</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton ID="lnk_LoanFailure_DB1" runat="server" OnClick="lnk_LoanFailure_DB1_Click">Loan Failure</asp:LinkButton>
                        </td>
                        <td>&nbsp;</td>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
        <br />
    </td>
           </tr>
        <tr>
    <td colspan="4">
        <asp:DataList ID="dl_DB2" runat="server" CellPadding="4" ForeColor="#333333" RepeatColumns="1" RepeatDirection="Horizontal" Width="644px" OnItemCommand="dl_DB2_ItemCommand">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#EFF3FB" />
            <ItemTemplate>
                <table class="auto-style3">
                    <tr>
                        <td colspan="5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="#6600FF" Text='<%# bind("BankName") %>'></asp:Label>
                            &nbsp;</td>
                      
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label27" runat="server" Font-Bold="True" Text="Name :"></asp:Label>
                        </td>
                         <td colspan="2">
                             <asp:Label ID="Label28" runat="server" Font-Bold="True" Text='<%# bind("Name") %>'></asp:Label>
                        </td>
                         <td>
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Address :"></asp:Label>
                        </td>
                         <td>
                             <asp:Label ID="Label29" runat="server" Font-Bold="True" Text='<%# bind("Address") %>'></asp:Label>
                             <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label34" runat="server" Font-Bold="True" Text="Adhar Id :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label35" runat="server" Font-Bold="True" Text='<%# bind("AdharId") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label36" runat="server" Font-Bold="True" Text="Income :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label37" runat="server" Font-Bold="True" Text='<%# bind("Income") %>'></asp:Label>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label30" runat="server" Font-Bold="True" Text="Pan Card No :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label31" runat="server" Font-Bold="True" Text='<%# bind("PanCardNo") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label32" runat="server" Font-Bold="True" Text="Ration Card No :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label33" runat="server" Font-Bold="True" Text='<%# bind("RationCardNo") %>'></asp:Label>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label15" runat="server" Font-Bold="True" Text="Loan Date :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label16" runat="server" Font-Bold="True" Text='<%# bind("Loan_StartedDate") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Issued Amount :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label18" runat="server" Font-Bold="True" Text='<%# bind("LoanAmount") %>'></asp:Label>
                        </td>
                        
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label38" runat="server" Font-Bold="True" Text="Loan Name :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="lbl_LoanName1" runat="server" Font-Bold="True" ForeColor="#0000CC" Text='<%# bind("LoanName") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label40" runat="server" Font-Bold="True" Text="Payment Status :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label41" runat="server" Font-Bold="True" ForeColor="Red" Text='<%# bind("Status") %>'></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label19" runat="server" Font-Bold="True" Text="Last Payment :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label20" runat="server" Font-Bold="True" Text='<%# bind("PaymentDate") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label21" runat="server" Font-Bold="True" Text="Balance :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label22" runat="server" Font-Bold="True" Text='<%# bind("Balance") %>'></asp:Label>
                            <br />
                        </td>
                       
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>&nbsp;</td>
                        <td colspan="2">
                            <br />
                            <br />
                        </td>
                    </tr>
                    
                    <tr>
                        <td colspan="2">
                            <asp:LinkButton ID="lnk_Decrypt" runat="server" CommandName="Item">Decrypt</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton ID="lnk_LoanFailure_DB2" runat="server" OnClick="lnk_LoanFailure_DB2_Click">Loan Failure</asp:LinkButton>
                        </td>
                        <td>&nbsp;</td>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
        <br />
    </td>
           </tr>

       <tr>
    <td colspan="4">
        <asp:DataList ID="dl_DB3" runat="server" CellPadding="4" ForeColor="#333333" RepeatColumns="1" RepeatDirection="Horizontal" Width="644px" OnItemCommand="dl_DB3_ItemCommand">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#EFF3FB" />
            <ItemTemplate>
                <table class="auto-style3">
                    <tr>
                        <td colspan="5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="#6600FF" Text='<%# bind("BankName") %>'></asp:Label>
                            &nbsp;</td>
                      
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label27" runat="server" Font-Bold="True" Text="Name :"></asp:Label>
                        </td>
                         <td colspan="2">
                             <asp:Label ID="Label28" runat="server" Font-Bold="True" Text='<%# bind("Name") %>'></asp:Label>
                        </td>
                         <td>
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Address :"></asp:Label>
                        </td>
                         <td>
                             <asp:Label ID="Label29" runat="server" Font-Bold="True" Text='<%# bind("Address") %>'></asp:Label>
                             <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label34" runat="server" Font-Bold="True" Text="Adhar Id :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label35" runat="server" Font-Bold="True" Text='<%# bind("AdharId") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label36" runat="server" Font-Bold="True" Text="Income :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label37" runat="server" Font-Bold="True" Text='<%# bind("Income") %>'></asp:Label>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label30" runat="server" Font-Bold="True" Text="Pan Card No :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label31" runat="server" Font-Bold="True" Text='<%# bind("PanCardNo") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label32" runat="server" Font-Bold="True" Text="Ration Card No :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label33" runat="server" Font-Bold="True" Text='<%# bind("RationCardNo") %>'></asp:Label>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label15" runat="server" Font-Bold="True" Text="Loan Date :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label16" runat="server" Font-Bold="True" Text='<%# bind("Loan_StartedDate") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label17" runat="server" Font-Bold="True" Text="Issued Amount :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label18" runat="server" Font-Bold="True" Text='<%# bind("LoanAmount") %>'></asp:Label>
                        </td>
                        
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label38" runat="server" Font-Bold="True" Text="Loan Name :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="lbl_LoanName2" runat="server" Font-Bold="True" ForeColor="#0000CC" Text='<%# bind("LoanName") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label40" runat="server" Font-Bold="True" Text="Payment Status :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label41" runat="server" Font-Bold="True" ForeColor="Red" Text='<%# bind("Status") %>'></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label19" runat="server" Font-Bold="True" Text="Last Payment :"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="Label20" runat="server" Font-Bold="True" Text='<%# bind("PaymentDate") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label21" runat="server" Font-Bold="True" Text="Balance :"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label22" runat="server" Font-Bold="True" Text='<%# bind("Balance") %>'></asp:Label>
                            <br />
                        </td>
                       
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:LinkButton ID="lnk_Decrypt" runat="server" CommandName="Item">Decrypt</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton ID="lnk_LoanFailure_DB3" runat="server" OnClick="lnk_LoanFailure_DB3_Click">Loan Failure</asp:LinkButton>
                        </td>
                        <td>&nbsp;</td>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
        <br />
    </td>
           </tr> 

    </table>
        </div>
</asp:Content>

