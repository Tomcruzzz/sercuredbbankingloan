using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DBCONNECTION;


public partial class Users_Bank_ViewLoan_ViewLoan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl_BankName.Text = Session["Bank_Name"].ToString();
    }
    private void clear()
    {
        //txt_AdharId.Text = "";
        //txt_Key.Text = "";

    }
    private void get_adhardetails()
    {
        try
        {
            ClsConnection obj1 = new ClsConnection();
            SqlConnection con1 = obj1.connect1();
            ClsConnection obj2 = new ClsConnection();
            SqlConnection con2 = obj2.connect2();
            ClsConnection obj3 = new ClsConnection();
            SqlConnection con3 = obj3.connect3();
            ClsConnection obj = new ClsConnection();
            SqlConnection con = obj.connect();
            using (con)
            {
                con.Open();
                //string Bank_id = Session["Bank_Id"].ToString();
                //SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Loan where Bank_Id='" + Bank_id + "' AND AdharId='" + txt_AdharId.Text + "'", con1);
                SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Loan where  AdharId='" + txt_AdharId.Text + "'", con1);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dl_DB1.DataSource = dt;
                    dl_DB1.DataBind();
                    
                }
                else
                {
                    //Alert.Show("Not Found in Bank2 & Bank3 !!");
                }
                con1.Close();
            }
            using (con2)
            {
                con2.Open();
                //string Bank_id = Session["Bank_Id"].ToString();
                SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Loan where  AdharId='" + txt_AdharId.Text + "'", con2);
                //SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Loan where Bank_Id='" + Bank_id + "' AND AdharId='" + txt_AdharId.Text + "'", con2);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dl_DB2.DataSource = dt;
                    dl_DB2.DataBind();
                }
                else
                {
                    //Alert.Show("Not Found in Bank1 & Bank3  !!");
                }
                con2.Close();
            }
            using (con3)
            {
                con3.Open();
                //string Bank_id = Session["Bank_Id"].ToString();
                SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Loan where  AdharId='" + txt_AdharId.Text + "'", con3);
                //SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Loan where Bank_Id='" + Bank_id + "' AND AdharId='" + txt_AdharId.Text + "'", con3);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dl_DB3.DataSource = dt;
                    dl_DB3.DataBind();
                }
                else
                {
                    //Alert.Show("Not Found in Bank1 & Bank2  !!");
                }
                con3.Close();
            }
        }
        catch (Exception exp)
        {
        }
                
    }
    
    
    protected void btn_Find_Click(object sender, EventArgs e)
    {
        get_adhardetails();
        clear();

    }
    private void get_keydetails()
    {
        try
        {
            ClsConnection obj1 = new ClsConnection();
            SqlConnection con1 = obj1.connect1();
            ClsConnection obj2 = new ClsConnection();
            SqlConnection con2 = obj2.connect2();
            ClsConnection obj3 = new ClsConnection();
            SqlConnection con3 = obj3.connect3();
            ClsConnection obj = new ClsConnection();
            SqlConnection con = obj.connect();
            using (con1)
            {
                con1.Open();
                string Bank_id = Session["Bank_Id"].ToString();
                SqlCommand cmd = new SqlCommand("select KeyInfo from tbl_Loan where Bank_Id='" + Bank_id + "' AND AdharId='" + txt_AdharId.Text + "'", con1);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_Key.Text = dr["KeyInfo"].ToString();
                }
                con1.Close();
            }
            using (con2)
            {
                con2.Open();
                string Bank_id = Session["Bank_Id"].ToString();
                SqlCommand cmd = new SqlCommand("select KeyInfo from tbl_Loan where Bank_Id='" + Bank_id + "' AND AdharId='" + txt_AdharId.Text + "'", con2);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_Key.Text = dr["KeyInfo"].ToString();
                }
                con2.Close();
            }
            using (con3)
            {
                con3.Open();
                string Bank_id = Session["Bank_Id"].ToString();
                SqlCommand cmd = new SqlCommand("select KeyInfo from tbl_Loan where Bank_Id='" + Bank_id + "' AND AdharId='" + txt_AdharId.Text + "'", con3);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_Key.Text = dr["KeyInfo"].ToString();
                }
                con3.Close();
            }
        }
        catch (Exception exp)
        {
        }
    }
    protected void chk_GetKey_CheckedChanged(object sender, EventArgs e)
    {
        
    }
    
    protected void dl_DB1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        ClsConnection obj1 = new ClsConnection();
        SqlConnection con1 = obj1.connect1();
        //ClsConnection obj2 = new ClsConnection();
        //SqlConnection con2 = obj2.connect2();
        //ClsConnection obj3 = new ClsConnection();
        //SqlConnection con3 = obj3.connect3();
        //ClsConnection obj = new ClsConnection();
        //SqlConnection con = obj.connect();
        try
        {
            if (e.CommandName == "Item")
                //get_keydetails();
                using (con1)
                {
                    con1.Open();
                    foreach (var item in dl_DB1.Items)
                    {
                        Label lbl_loanname = (Label)dl_DB1.Items[e.Item.ItemIndex].FindControl("lbl_LoanName");

                        string Bank_id = Session["Bank_Id"].ToString();
                        SqlCommand cmd = new SqlCommand("select KeyInfo from tbl_Loan where Bank_Id='" + Bank_id + "' AND AdharId='" + txt_AdharId.Text + "' AND LoanName='"+lbl_loanname.Text+"'", con1);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            txt_Key.Text = dr["KeyInfo"].ToString();   
                            string decrypted_data = Decrypt.Decryption(lbl_loanname.Text, true, txt_Key.Text);
                            dr.Close();
                            lbl_loanname.Text = decrypted_data;
                        }
                        
                    }
                    con1.Close();
                }
            
        }
        catch (Exception exp)
        {
        }

    }
    protected void dl_DB2_ItemCommand(object source, DataListCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Item")
                get_keydetails();
                foreach (var item in dl_DB2.Items)
                {
                    Label lbl_loanname = (Label)dl_DB2.Items[e.Item.ItemIndex].FindControl("lbl_LoanName1");
                    string decrypted_data = Decrypt.Decryption(lbl_loanname.Text, true, txt_Key.Text);
                    lbl_loanname.Text = decrypted_data;
                }
            
        }
        catch (Exception exp)
        {
        }
    }
    protected void dl_DB3_ItemCommand(object source, DataListCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Item")
                get_keydetails();
                foreach (var item in dl_DB3.Items)
                {
                    Label lbl_loanname = (Label)dl_DB3.Items[e.Item.ItemIndex].FindControl("lbl_LoanName2");
                    string decrypted_data = Decrypt.Decryption(lbl_loanname.Text, true, txt_Key.Text);
                    lbl_loanname.Text = decrypted_data;
                }
            
        }
        catch (Exception exp)
        {
        }
    }
    private void get_loanfailures()
    {
        try
        {
            ClsConnection obj1 = new ClsConnection();
            SqlConnection con1 = obj1.connect1();
            ClsConnection obj2 = new ClsConnection();
            SqlConnection con2 = obj2.connect2();
            ClsConnection obj3 = new ClsConnection();
            SqlConnection con3 = obj3.connect3();
            ClsConnection obj = new ClsConnection();
            SqlConnection con = obj.connect();
            using (con)
            {
                con.Open();
                string Bank_id = Session["Bank_Id"].ToString();
                SqlCommand cmd = new SqlCommand("select * from tbl_LoanFailure where Bank_Id='" + Bank_id + "' AND AdharId='" + txt_AdharId.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Alert.Show("Loan Failure Datas Already Stored in Another Database");
                }
                else
                {
                    using (con1)
                    {
                        con1.Open();
                        SqlCommand cmd2 = new SqlCommand("select * from tbl_Loan where Bank_Id='" + Bank_id + "' AND AdharId='" + txt_AdharId.Text + "' AND Status='Pending'", con1);
                        dr.Close();
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        if (dr2.Read())
                        {
                            string bank_id = dr2["Bank_Id"].ToString();
                            int loan_id = Convert.ToInt32(dr2["Loan_Id"].ToString());
                            string bankname = dr2["BankName"].ToString();
                            string adharid = dr2["AdharId"].ToString();
                            string name = dr2["Name"].ToString();
                            string loanname = dr2["LoanName"].ToString();
                            string amount = dr2["LoanAmount"].ToString();
                            string status = dr2["Status"].ToString();
                            string Key = dr2["KeyInfo"].ToString();
                            SqlCommand cmd3 = new SqlCommand("insert into tbl_LoanFailure values('" + bank_id + "','" + loan_id + "','" + bankname + "','" + adharid + "','" + name + "','" + loanname + "','" + amount + "','" + status + "','" + Key + "')", con);
                            dr2.Close();
                            cmd3.ExecuteNonQuery();
                            Alert.Show("Loan Failure Datas are Stored in Another Database");
                        }

                        con1.Close();
                    }
                    using (con2)
                    {
                        con2.Open();
                        SqlCommand cmd2 = new SqlCommand("select * from tbl_Loan where Bank_Id='" + Bank_id + "' AND AdharId='" + txt_AdharId.Text + "' AND Status='Pending'", con2);
                        dr.Close();
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        if (dr2.Read())
                        {
                            string bank_id = dr2["Bank_Id"].ToString();
                            int loan_id = Convert.ToInt32(dr2["Loan_Id"].ToString());
                            string bankname = dr2["BankName"].ToString();
                            string adharid = dr2["AdharId"].ToString();
                            string name = dr2["Name"].ToString();
                            string loanname = dr2["LoanName"].ToString();
                            string amount = dr2["LoanAmount"].ToString();
                            string status = dr2["Status"].ToString();
                            string Key = dr2["KeyInfo"].ToString();
                            SqlCommand cmd3 = new SqlCommand("insert into tbl_LoanFailure values('" + bank_id + "','" + loan_id + "','" + bankname + "','" + adharid + "','" + name + "','" + loanname + "','" + amount + "','" + status + "','" + Key + "')", con);
                            dr2.Close();
                            cmd3.ExecuteNonQuery();
                            Alert.Show("Loan Failure Datas are Stored in Another Database");
                        }

                        con2.Close();
                    }
                    using (con3)
                    {
                        con3.Open();
                        SqlCommand cmd2 = new SqlCommand("select * from tbl_Loan where Bank_Id='" + Bank_id + "' AND AdharId='" + txt_AdharId.Text + "' AND Status='Pending'", con3);
                        dr.Close();
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        if (dr2.Read())
                        {
                            string bank_id = dr2["Bank_Id"].ToString();
                            int loan_id = Convert.ToInt32(dr2["Loan_Id"].ToString());
                            string bankname = dr2["BankName"].ToString();
                            string adharid = dr2["AdharId"].ToString();
                            string name = dr2["Name"].ToString();
                            string loanname = dr2["LoanName"].ToString();
                            string amount = dr2["LoanAmount"].ToString();
                            string status = dr2["Status"].ToString();
                            string Key = dr2["KeyInfo"].ToString();
                            SqlCommand cmd3 = new SqlCommand("insert into tbl_LoanFailure values('" + bank_id + "','" + loan_id + "','" + bankname + "','" + adharid + "','" + name + "','" + loanname + "','" + amount + "','" + status + "','" + Key + "')", con);
                            dr2.Close();
                            cmd3.ExecuteNonQuery();
                            Alert.Show("Loan Failure Datas are Stored in Another Database");
                        }

                        con3.Close();
                    }

                    con.Close();
                }

            }
        }
            
        catch (Exception exp)
        {
        }
        
    }
    
    protected void lnk_LoanFailure_DB1_Click(object sender, EventArgs e)
    {
        get_loanfailures();
    }
    protected void lnk_LoanFailure_DB2_Click(object sender, EventArgs e)
    {
        get_loanfailures();
    }
    protected void lnk_LoanFailure_DB3_Click(object sender, EventArgs e)
    {
        get_loanfailures();
    }
}
   