using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using DBCONNECTION;

public partial class HomePage_Registration_Bank_Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void send_email()
    {
        string email = txt_Email.Text;
        string username = "User Name :"+ " " +txtusername.Text + "\n";
        string password = "Password :" + " " + txtpwd.Text;
        string content =username + password;
        MailMessage mail = new MailMessage();
        mail.To.Add(email);
        mail.From = new MailAddress("ttinu691@gmail.com");
        mail.Subject = "Message";
        mail.Body = content;
        mail.IsBodyHtml = true;
        System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.EnableSsl = true;
        smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
        smtp.Credentials = new System.Net.NetworkCredential("ttinu691@gmail.com", "8907246218");
        smtp.Send(mail);
    }
    private void clear()
    {
        txtbankname.Text = "";
        txt_branch.Text = "";
        txt_confirmpassword.Text = "";
        txt_Email.Text = "";
        txt_IfscCode.Text = "";
        txt_MobileNo.Text = "";
        txt_SecretCode.Text = "";
        txtpwd.Text = "";
        txtusername.Text = "";

    }
    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        if (drp_BankType.SelectedItem.ToString() == "Bank1")
        {
            ClsConnection obj1 = new ClsConnection();
            SqlConnection con1 = obj1.connect1();
            using (con1)
            {
                con1.Open();
                SqlCommand cmd2 = new SqlCommand("select Count(Bank_Id) from tbl_Bank", con1);
                Int32 count = (Int32)cmd2.ExecuteScalar();
                if (count == 0)
                {
                    string Bank_Id = "Bank" + 1;
                    SqlCommand cmd = new SqlCommand("insert into tbl_Bank values('"+Bank_Id+"','" + txtbankname.Text + "','" + txt_branch.Text + "','" + txt_IfscCode.Text + "','" + txt_SecretCode.Text + "','" + txt_Email.Text + "','" + txt_MobileNo.Text + "','" + txtusername.Text + "','" + txtpwd.Text + "','" + drp_BankType.SelectedItem.ToString() + "')", con1);
                    cmd.ExecuteNonQuery();
                    send_email();
                }
                else if (count > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("select Max(Bank_Id) from tbl_Bank", con1);
                    string max = (string)cmd1.ExecuteScalar();
                    string BankId=max+1;
                    SqlCommand cmd = new SqlCommand("insert into tbl_Bank values('" + BankId + "','" + txtbankname.Text + "','" + txt_branch.Text + "','" + txt_IfscCode.Text + "','" + txt_SecretCode.Text + "','" + txt_Email.Text + "','" + txt_MobileNo.Text + "','" + txtusername.Text + "','" + txtpwd.Text + "','" + drp_BankType.SelectedItem.ToString() + "')", con1);
                    cmd.ExecuteNonQuery();
                    send_email();
                    con1.Close();
                   
                }
            }
        }

        else if (drp_BankType.SelectedItem.ToString() == "Bank2")
        {
            ClsConnection obj2 = new ClsConnection();
            SqlConnection con2 = obj2.connect2();
            using (con2)
            {
                con2.Open();
                SqlCommand cmd2 = new SqlCommand("select Count(Bank_Id) from tbl_Bank", con2);
                Int32 count = (Int32)cmd2.ExecuteScalar();
                if (count == 0)
                {
                    string Bank_Id = "Bank" + 2;
                    SqlCommand cmd = new SqlCommand("insert into tbl_Bank values('" + Bank_Id + "','" + txtbankname.Text + "','" + txt_branch.Text + "','" + txt_IfscCode.Text + "','" + txt_SecretCode.Text + "','" + txt_Email.Text + "','" + txt_MobileNo.Text + "','" + txtusername.Text + "','" + txtpwd.Text + "','" + drp_BankType.SelectedItem.ToString() + "')", con2);
                    cmd.ExecuteNonQuery();
                    send_email();
                }
                else if (count > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("select Max(Bank_Id) from tbl_Bank", con2);
                    string max = (string)cmd1.ExecuteScalar();
                    string BankId = max + 1;
                    SqlCommand cmd = new SqlCommand("insert into tbl_Bank values('" + BankId + "','" + txtbankname.Text + "','" + txt_branch.Text + "','" + txt_IfscCode.Text + "','" + txt_SecretCode.Text + "','" + txt_Email.Text + "','" + txt_MobileNo.Text + "','" + txtusername.Text + "','" + txtpwd.Text + "','" + drp_BankType.SelectedItem.ToString() + "')", con2);
                    cmd.ExecuteNonQuery();
                    send_email();
                    con2.Close();
                }
            }
        }
        else if (drp_BankType.SelectedItem.ToString() == "Bank3")
        {
            ClsConnection obj3 = new ClsConnection();
            SqlConnection con3 = obj3.connect3();
            using (con3)
            {
                con3.Open();
                SqlCommand cmd2 = new SqlCommand("select Count(Bank_Id) from tbl_Bank", con3);
                Int32 count = (Int32)cmd2.ExecuteScalar();
                if (count == 0)
                {
                    string Bank_Id = "Bank" + 3;
                    SqlCommand cmd = new SqlCommand("insert into tbl_Bank values('" + Bank_Id + "','" + txtbankname.Text + "','" + txt_branch.Text + "','" + txt_IfscCode.Text + "','" + txt_SecretCode.Text + "','" + txt_Email.Text + "','" + txt_MobileNo.Text + "','" + txtusername.Text + "','" + txtpwd.Text + "','" + drp_BankType.SelectedItem.ToString() + "')", con3);
                    cmd.ExecuteNonQuery();
                    send_email();
                }
                else if (count > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("select Max(Bank_Id) from tbl_Bank", con3);
                    string max = (string)cmd1.ExecuteScalar();
                    string BankId = max + 1;
                    SqlCommand cmd = new SqlCommand("insert into tbl_Bank values('" + BankId + "','" + txtbankname.Text + "','" + txt_branch.Text + "','" + txt_IfscCode.Text + "','" + txt_SecretCode.Text + "','" + txt_Email.Text + "','" + txt_MobileNo.Text + "','" + txtusername.Text + "','" + txtpwd.Text + "','" + drp_BankType.SelectedItem.ToString() + "')", con3);
                    cmd.ExecuteNonQuery();
                    send_email();
                    con3.Close();
                }
            }
        }
        else
        {
            Alert.Show("Select Any Bank");
        }
        clear();
        Alert.Show("Bank Registration Successfully");
    }
}