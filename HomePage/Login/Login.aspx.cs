using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DBCONNECTION;

public partial class HomePage_Login_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            load_branches();
        }
    }
    private void load_branches()
    {
        ClsConnection obj = new ClsConnection();
        SqlConnection con1 = obj.connect1();
        ClsConnection obj1 = new ClsConnection();
        SqlConnection con2 = obj1.connect2();
        ClsConnection obj2 = new ClsConnection();
        SqlConnection con3 = obj2.connect3();
        using (con1)
        {
            con1.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select Branch,Bank_Id from tbl_Bank where Bank_No='" + drp_usertype.SelectedItem.ToString() + "'", con1);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                drp_branch.DataSource = dt;
                drp_branch.DataTextField = "Branch";
                drp_branch.DataValueField = "Bank_Id";
                drp_branch.DataBind();
            }

            con1.Close();
        }
        using (con2)
        {
            con2.Open();
            SqlDataAdapter adp1 = new SqlDataAdapter("select Branch,Bank_Id from tbl_Bank where Bank_No='" + drp_usertype.SelectedItem.ToString() + "'", con2);
            DataTable dt1 = new DataTable();
            adp1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                drp_branch.DataSource = dt1;
                drp_branch.DataTextField = "Branch";
                drp_branch.DataValueField = "Bank_Id";
                drp_branch.DataBind();
            }
            con2.Close();
        }
        using (con3)
        {
            con3.Open();
            SqlDataAdapter adp2 = new SqlDataAdapter("select Branch,Bank_Id from tbl_Bank where Bank_No='" + drp_usertype.SelectedItem.ToString() + "'", con3);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);
            if (dt2.Rows.Count > 0)
            {
                drp_branch.DataSource = dt2;
                drp_branch.DataTextField = "Branch";
                drp_branch.DataValueField = "Bank_Id";
                drp_branch.DataBind();
            }
            con3.Close();
        }
    }
    protected void drp_usertype_SelectedIndexChanged(object sender, EventArgs e)
    {
        load_branches();
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        ClsConnection obj = new ClsConnection();
        SqlConnection con1 = obj.connect1();
        ClsConnection obj1 = new ClsConnection();
        SqlConnection con2 = obj1.connect2();
        ClsConnection obj2 = new ClsConnection();
        SqlConnection con3 = obj2.connect3();
        using (con1)
        {
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("Select UserName,Password,Bank_Id,Bank_Name from tbl_Bank where Bank_No='" + drp_usertype.SelectedItem.ToString() + "' AND Branch='"+drp_branch.SelectedItem.ToString()+"'", con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                string user_name=dr1["UserName"].ToString();
                string password = dr1["Password"].ToString();
                string bank_id=dr1["Bank_Id"].ToString();
                string bank_name = dr1["Bank_Name"].ToString();
                if (txtusername.Text == user_name && txtpassword.Text == password)
                {
                    Session["Bank_Id"] = bank_id;
                    Session["Bank_Name"] = bank_name;
                    Response.Redirect("~/Users/Bank/AddLoan/AddLoanDetails.aspx");
                }
                else
                {
                    Alert.Show("Invalid UserName && Password !!");
                }
            }
            dr1.Close();
            con1.Close();
        }
        using (con2)
        {
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("Select UserName,Password,Bank_Id,Bank_Name from tbl_Bank where Bank_No='" + drp_usertype.SelectedItem.ToString() + "' AND Branch='" + drp_branch.SelectedItem.ToString() + "'", con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                string user_name = dr2["UserName"].ToString();
                string password = dr2["Password"].ToString();
                string bank_id = dr2["Bank_Id"].ToString();
                string bank_name = dr2["Bank_Name"].ToString();
                if (txtusername.Text == user_name && txtpassword.Text == password)
                {
                    Session["Bank_Id"] = bank_id;
                    Session["Bank_Name"] = bank_name;
                    Response.Redirect("~/Users/Bank/AddLoan/AddLoanDetails.aspx");
                }
                else
                {
                    Alert.Show("Invalid UserName && Password !!");
                }
            }
            dr2.Close();
            con2.Close();
        }
        using (con3)
        {
            con3.Open();
            SqlCommand cmd3 = new SqlCommand("Select UserName,Password,Bank_Id,Bank_Name from tbl_Bank where Bank_No='" + drp_usertype.SelectedItem.ToString() + "' AND Branch='" + drp_branch.SelectedItem.ToString() + "'", con3);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                string user_name = dr3["UserName"].ToString();
                string password = dr3["Password"].ToString();
                string bank_id = dr3["Bank_Id"].ToString();
                string bank_name = dr3["Bank_Name"].ToString();
                if (txtusername.Text == user_name && txtpassword.Text == password)
                {
                    Session["Bank_Id"] = bank_id;
                    Session["Bank_Name"] = bank_name;
                    Response.Redirect("~/Users/Bank/AddLoan/AddLoanDetails.aspx");
                }
                else
                {
                    Alert.Show("Invalid UserName && Password !!");
                }
            }
            dr3.Close();
            con3.Close();
        }
    }
    
}