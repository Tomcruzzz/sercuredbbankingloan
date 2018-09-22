using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DBCONNECTION;

public partial class HomePage_Login_ChangePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_ChangePassword_Click(object sender, EventArgs e)
    {
        string email = Session["Email1"].ToString();
        ClsConnection obj = new ClsConnection();
        SqlConnection con1 = obj.connect1();
        ClsConnection obj1 = new ClsConnection();
        SqlConnection con2 = obj1.connect2();
        ClsConnection obj2 = new ClsConnection();
        SqlConnection con3 = obj2.connect3();
        using (con1)
        {
            con1.Open();
            SqlCommand cmd=new SqlCommand("update tbl_Bank set Password='"+txt_NewPassword.Text+"' where Email='"+email+"'",con1);
            cmd.ExecuteNonQuery();
            con1.Close();
        }
        using (con2)
        {
            con2.Open();
            SqlCommand cmd=new SqlCommand("update tbl_Bank set Password='"+txt_NewPassword.Text+"' where Email='"+email+"'",con2);
            cmd.ExecuteNonQuery();
            con2.Close();
        }
        using (con3)
        {
            con3.Open();
            SqlCommand cmd=new SqlCommand("update tbl_Bank set Password='"+txt_NewPassword.Text+"' where Email='"+email+"'",con3);
            cmd.ExecuteNonQuery();
            con3.Close();
        }
        Alert.Show("Password Changed");
    }
}