using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DBCONNECTION;

public partial class Users_Bank_UpdateLoan_EditLoan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        get_loandetails();
    }
    private void get_loandetails()
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
            SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Loan where Bank_Id='" + bank_id + "'", con1);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                grd_EditLoan.DataSource = dt;
                grd_EditLoan.DataBind();
            }
            con1.Close();
        }
        using (con2)
        {
            con2.Open();
            string bank_id = Session["Bank_Id"].ToString();
            SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Loan where Bank_Id='" + bank_id + "'", con2);
            DataTable dt1 = new DataTable();
            adp.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                grd_EditLoan.DataSource = dt1;
                grd_EditLoan.DataBind();
            }
            con2.Close();
        }
        using (con3)
        {
            con3.Open();
            string bank_id = Session["Bank_Id"].ToString();
            SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Loan where Bank_Id='" + bank_id + "'", con3);
            DataTable dt2 = new DataTable();
            adp.Fill(dt2);
            if (dt2.Rows.Count > 0)
            {
                grd_EditLoan.DataSource = dt2;
                grd_EditLoan.DataBind();
            }
            con3.Close();
        }
    }
    protected void grd_EditLoan_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string Loan_Id = grd_EditLoan.DataKeys[Convert.ToInt32(e.CommandArgument)].Value.ToString();
        Session["Loan_Id"] = Loan_Id;
        Response.Redirect("~/Users/Bank/UpdateLoan/UpdateLoanDetails.aspx");
    }
}