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

public partial class HomePage_Login_ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_CheckEmail_Click(object sender, EventArgs e)
    {
        string email = txt_Email.Text;
        string verification_code = "WERTYDF123";
        MailMessage mail = new MailMessage();
        mail.To.Add(email);
        mail.From = new MailAddress("ttinu691@gmail.com");
        mail.Subject = "Message";
        mail.Body = verification_code;
        mail.IsBodyHtml = true;
        System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.EnableSsl = true;
        smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
        smtp.Credentials = new System.Net.NetworkCredential("ttinu691@gmail.com", "8907246218");
        smtp.Send(mail);
        Session["Email1"] = email;
        Response.Redirect("~/HomePage/Login/ChangePassword.aspx");
    }
}