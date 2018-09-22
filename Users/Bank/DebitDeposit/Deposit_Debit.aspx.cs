using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DBCONNECTION;
using System.Net.Mail;

public partial class Users_Bank_DebitDeposit_Deposit_Debit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl_BankName.Text = Session["Bank_Name"].ToString();
    }
    private void send_email()
    {
        ClsConnection obj1 = new ClsConnection();
        SqlConnection con1 = obj1.connect1();
        ClsConnection obj2 = new ClsConnection();
        SqlConnection con2 = obj2.connect2();
        ClsConnection obj3 = new ClsConnection();
        SqlConnection con3 = obj3.connect3();
        using (con1)
        {
            con1.Open();
            string bank_id = Session["Bank_Id"].ToString();
            SqlCommand cmd = new SqlCommand("select * from tbl_Bank where Bank_Id='" + bank_id + "'", con1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand cmd2 = new SqlCommand("select Right(Account_No,3) from tbl_DebitDeposit where EmailId='" + txt_EmailId.Text + "'", con1);
                dr.Close();
                string acc_no = (string)cmd2.ExecuteScalar();
                string email = txt_EmailId.Text;
                MailMessage mail = new MailMessage();
                mail.To.Add(email);
                mail.From = new MailAddress("ttinu691@gmail.com");
                mail.Subject = "Message";
                string name = "Name :" + txt_Name.Text;
                string Acc_no = "Account No :" + "xxxxxxxxxxxxxxxxx" + acc_no;
                string amount = "Your Account Credited is" + txt_Amount.Text;
                mail.Body = name + " " + Acc_no + " " + amount + " ";
                mail.IsBodyHtml = true;
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtp.Credentials = new System.Net.NetworkCredential("ttinu691@gmail.com", "8907246218");
                smtp.Send(mail);
            }
            con1.Close();
        }
        using (con2)
        {
            con2.Open();
            string bank_id = Session["Bank_Id"].ToString();
            SqlCommand cmd = new SqlCommand("select * from tbl_Bank where Bank_Id='" + bank_id + "'", con2);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand cmd2 = new SqlCommand("select Right(Account_No,3) from tbl_DebitDeposit where EmailId='" + txt_EmailId.Text + "'", con2);
                dr.Close();
                string acc_no = (string)cmd2.ExecuteScalar();
                string email = txt_EmailId.Text;
                MailMessage mail = new MailMessage();
                mail.To.Add(email);
                mail.From = new MailAddress("ttinu691@gmail.com");
                mail.Subject = "Message";
                string name = "Name :" + txt_Name.Text;
                string Acc_no = "Account No :" + "xxxxxxxxxxxxxxxxx" + acc_no;
                string amount = "Your Account Credited is" + txt_Amount.Text;
                mail.Body = name + " " + Acc_no + " " + amount + " ";
                mail.IsBodyHtml = true;
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtp.Credentials = new System.Net.NetworkCredential("ttinu691@gmail.com", "8907246218");
                smtp.Send(mail);
            }
            con2.Close();
        }
        using (con3)
        {
            con3.Open();
            string bank_id = Session["Bank_Id"].ToString();
            SqlCommand cmd = new SqlCommand("select * from tbl_Bank where Bank_Id='" + bank_id + "'", con3);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand cmd2 = new SqlCommand("select Right(Account_No,3) from tbl_DebitDeposit where EmailId='" + txt_EmailId.Text + "'", con3);
                dr.Close();
                string acc_no = (string)cmd2.ExecuteScalar();
                string email = txt_EmailId.Text;
                MailMessage mail = new MailMessage();
                mail.To.Add(email);
                mail.From = new MailAddress("ttinu691@gmail.com");
                mail.Subject = "Message";
                string name = "Name :" + txt_Name.Text;
                string Acc_no = "Account No :" + "xxxxxxxxxxxxxxxxx" + acc_no;
                string amount = "Your Account Credited is" + txt_Amount.Text;
                mail.Body = name + " " + Acc_no + " " + amount + " ";
                mail.IsBodyHtml = true;
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtp.Credentials = new System.Net.NetworkCredential("ttinu691@gmail.com", "8907246218");
                smtp.Send(mail);
            }
            con3.Close();
        }


    }
    private void clear()
    {
        txt_AccountNo.Text = "";
        txt_AdharNo.Text = "";
        txt_Amount.Text = "";
        txt_Date.Text = "";
        txt_EmailId.Text = "";
        txt_MobileNo.Text = "";
        txt_Name.Text = "";


    }
    private void get_debitdetails()
    {
        ClsConnection obj1 = new ClsConnection();
        SqlConnection con1 = obj1.connect1();
        ClsConnection obj2 = new ClsConnection();
        SqlConnection con2 = obj2.connect2();
        ClsConnection obj3 = new ClsConnection();
        SqlConnection con3 = obj3.connect3();
        using (con1)
        {
            con1.Open();
            string bank_id = Session["Bank_Id"].ToString();
            SqlCommand cmd = new SqlCommand("select * from tbl_Bank where Bank_Id='" + bank_id + "'", con1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand cmd2 = new SqlCommand("insert into tbl_DebitDeposit values('"+txt_AccountNo.Text+"','"+txt_Name.Text+"','"+txt_AdharNo.Text+"','"+txt_Amount.Text+"','"+txt_MobileNo.Text+"','"+txt_EmailId.Text+"','"+txt_Date.Text+"')", con1);
                dr.Close();
                cmd2.ExecuteNonQuery();
            }
            con1.Close();
        }
        using (con2)
        {
            con2.Open();
            string bank_id = Session["Bank_Id"].ToString();
            SqlCommand cmd = new SqlCommand("select * from tbl_Bank where Bank_Id='" + bank_id + "'", con2);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand cmd2 = new SqlCommand("insert into tbl_DebitDeposit values('" + txt_AccountNo.Text + "','" + txt_Name.Text + "','" + txt_AdharNo.Text + "','" + txt_Amount.Text + "','" + txt_MobileNo.Text + "','" + txt_EmailId.Text + "','" + txt_Date.Text + "')", con2);
                dr.Close();
                cmd2.ExecuteNonQuery();
            }
            con2.Close();
        }
        using (con3)
        {
            con3.Open();
            string bank_id = Session["Bank_Id"].ToString();
            SqlCommand cmd = new SqlCommand("select * from tbl_Bank where Bank_Id='" + bank_id + "'", con3);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand cmd2 = new SqlCommand("insert into tbl_DebitDeposit values('" + txt_AccountNo.Text + "','" + txt_Name.Text + "','" + txt_AdharNo.Text + "','" + txt_Amount.Text + "','" + txt_MobileNo.Text + "','" + txt_EmailId.Text + "','" + txt_Date.Text + "')", con3);
                dr.Close();
                cmd2.ExecuteNonQuery();
            }
            con3.Close();
        }
        send_email();
        clear();
        Alert.Show("Debit Card Details Saved");
    }
    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        get_debitdetails();
    }
}