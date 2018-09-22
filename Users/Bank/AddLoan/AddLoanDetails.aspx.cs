using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DBCONNECTION;

public partial class Users_Bank_AddLoan_AddLoanDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl_BankName.Text = Session["Bank_Name"].ToString();
        txt_BankName.Text = Session["Bank_Name"].ToString(); 
        txt_LoanStartedDate.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
    }
    private void clear()
    {
        txt_Address.Text = "";
        txt_AdharId.Text = "";
        txt_Amount.Text = "";
        //txt_BankName.Text="";
        txt_Income.Text="";
        txt_LoanName.Text="";
        //txt_LoanStartedDate.Text="";
        txt_Name.Text="";
        txt_PanCardNo.Text="";
        txt_RationCardNo.Text="";
    }
    private void insert_data1()
    {
        string bank_id = Session["Bank_Id"].ToString();
        ClsConnection obj1 = new ClsConnection();
        SqlConnection con1 = obj1.connect1();
        using (con1)
        {
            con1.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Bank where Bank_Id='" + bank_id + "' ", con1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_BankName.Text = dr["Bank_Name"].ToString();
                string key = getkeytoencrypt.GetUniqueKey();
                //string A = null;           
                string i = txt_LoanName.Text;
                string loanname = Encrypt.Encryptdata(i, key, true);
                int paymentamount = 0;
                string paymentdate = "No Payment";
                //string scoringfactor = "InSufficient History And Score";
                //string scoringrating = "-1";
                if (drp_LoanDuration.SelectedItem.ToString() == "1Month")
                {
                    string month_firstdate = DateTime.Now.Date.AddDays(10).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddDays(20).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddDays(30).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con1);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                else if (drp_LoanDuration.SelectedItem.ToString() == "3Months")
                {
                    string month_firstdate = DateTime.Now.Date.AddMonths(1).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddMonths(2).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddMonths(3).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con1);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                else if (drp_LoanDuration.SelectedItem.ToString() == "6Months")
                {
                    string month_firstdate = DateTime.Now.Date.AddMonths(2).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddMonths(4).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddMonths(6).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con1);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                else if (drp_LoanDuration.SelectedItem.ToString() == "1Year")
                {
                    string month_firstdate = DateTime.Now.Date.AddMonths(4).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddMonths(8).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddMonths(12).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con1);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                else if (drp_LoanDuration.SelectedItem.ToString() == "3Years")
                {
                    string month_firstdate = DateTime.Now.Date.AddMonths(12).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddMonths(24).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddMonths(36).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con1);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
            }
            con1.Close();
        }
    }
    private void insert_data2()
    {
        string bank_id = Session["Bank_Id"].ToString();
        ClsConnection obj2 = new ClsConnection();
        SqlConnection con2 = obj2.connect2();
        using (con2)
        {
            con2.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Bank where Bank_Id='" + bank_id + "'", con2);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_BankName.Text = dr["Bank_Name"].ToString();
                string key = getkeytoencrypt.GetUniqueKey();
                //string A = null;           
                string i = txt_LoanName.Text;
                string loanname = Encrypt.Encryptdata(i, key, true);
                int paymentamount = 0;
                string paymentdate = "No Payment";
                //string scoringfactor = "InSufficient History And Score";
                //string scoringrating = "-1";
                if (drp_LoanDuration.SelectedItem.ToString() == "1Month")
                {
                    string month_firstdate = DateTime.Now.Date.AddDays(10).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddDays(20).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddDays(30).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con2);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                else if (drp_LoanDuration.SelectedItem.ToString() == "3Months")
                {
                    string month_firstdate = DateTime.Now.Date.AddMonths(1).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddMonths(2).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddMonths(3).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con2);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                else if (drp_LoanDuration.SelectedItem.ToString() == "6Months")
                {
                    string month_firstdate = DateTime.Now.Date.AddMonths(2).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddMonths(4).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddMonths(6).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con2);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                else if (drp_LoanDuration.SelectedItem.ToString() == "1Year")
                {
                    string month_firstdate = DateTime.Now.Date.AddMonths(4).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddMonths(8).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddMonths(12).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con2);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                else if (drp_LoanDuration.SelectedItem.ToString() == "3Years")
                {
                    string month_firstdate = DateTime.Now.Date.AddMonths(12).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddMonths(24).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddMonths(36).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con2);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                //Alert.Show("Loan Saved");
            }
            dr.Close();
            con2.Close();

        }
        
    }
    private void insert_data3()
    {
        ClsConnection obj3 = new ClsConnection();
        SqlConnection con3 = obj3.connect3();
        using (con3)
        {
            con3.Open();
            string bank_id = Session["Bank_Id"].ToString();
            SqlCommand cmd = new SqlCommand("select * from tbl_Bank where Bank_Id='" + bank_id + "'", con3);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_BankName.Text = dr["Bank_Name"].ToString();
                string key = getkeytoencrypt.GetUniqueKey();
                //string A = null;           
                string i = txt_LoanName.Text;
                string loanname = Encrypt.Encryptdata(i, key, true);
                int paymentamount = 0;
                string paymentdate = "No Payment";
                //string scoringfactor = "InSufficient History And Score";
                //string scoringrating = "-1";
                if (drp_LoanDuration.SelectedItem.ToString() == "1Month")
                {
                    string month_firstdate = DateTime.Now.Date.AddDays(10).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddDays(20).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddDays(30).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con3);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                else if (drp_LoanDuration.SelectedItem.ToString() == "3Months")
                {
                    string month_firstdate = DateTime.Now.Date.AddMonths(1).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddMonths(2).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddMonths(3).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con3);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                else if (drp_LoanDuration.SelectedItem.ToString() == "6Months")
                {
                    string month_firstdate = DateTime.Now.Date.AddMonths(2).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddMonths(4).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddMonths(6).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con3);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                else if (drp_LoanDuration.SelectedItem.ToString() == "1Year")
                {
                    string month_firstdate = DateTime.Now.Date.AddMonths(4).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddMonths(8).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddMonths(12).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con3);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                else if (drp_LoanDuration.SelectedItem.ToString() == "3Years")
                {
                    string month_firstdate = DateTime.Now.Date.AddMonths(12).ToString("dd/MM/yyyy");
                    string month_seconddate = DateTime.Now.Date.AddMonths(24).ToString("dd/MM/yyyy");
                    string month_thirddate = DateTime.Now.Date.AddMonths(36).ToString("dd/MM/yyyy");
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_Loan values('" + bank_id + "','" + txt_BankName.Text + "','" + txt_LoanStartedDate.Text + "' , '" + month_firstdate + "','" + month_seconddate + "','" + month_thirddate + "','" + txt_Name.Text + "','" + txt_AdharId.Text + "','" + txt_PanCardNo.Text + "','" + txt_RationCardNo.Text + "','" + txt_Income.Text + "','" + txt_Address.Text + "','" + loanname + "','" + drp_LoanDuration.SelectedItem.ToString() + "', '" + txt_Amount.Text + "','" + txt_Amount.Text + "','" + paymentdate + "','" + paymentamount + "','" + drp_Status.SelectedItem.ToString() + "','" + key + "')", con3);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                    Alert.Show("Loan Saved");
                }
                //Alert.Show("Loan Saved");
            }
            dr.Close();
            con3.Close();
        }
    }
    private void insert_details()
    {
        ClsConnection obj1 = new ClsConnection();
        SqlConnection con1 = obj1.connect1();
        ClsConnection obj2 = new ClsConnection();
        SqlConnection con2 = obj2.connect2();
        ClsConnection obj3 = new ClsConnection();
        SqlConnection con3 = obj3.connect3();
        using (con1)
        {
            string bank_id = Session["Bank_Id"].ToString();
            con1.Open();
            SqlCommand cmd5 = new SqlCommand("select * from tbl_Loan where AdharId='" + txt_AdharId.Text + "'", con1);
            SqlDataReader dr2 = cmd5.ExecuteReader();
            if (dr2.Read())
            {
                string PanCardNo = dr2["PanCardNo"].ToString();
                string RationCardNo = dr2["RationCardNo"].ToString();
                string Bank_Id = dr2["Bank_Id"].ToString();
                if (txt_PanCardNo.Text != PanCardNo || txt_RationCardNo.Text != RationCardNo)
                {
                    Alert.Show("Invalid");

                }
                else
                {
                    insert_data1();
                }
            }
            else
            {

                insert_data1();
            }
            dr2.Close();
            con1.Close();
        }
        using (con2)
        {
            con2.Open();
            string bank_id = Session["Bank_Id"].ToString();
            SqlCommand cmd5 = new SqlCommand("select * from tbl_Loan where AdharId='" + txt_AdharId.Text + "'", con2);
            SqlDataReader dr2 = cmd5.ExecuteReader();
            if (dr2.Read())
            {
                string PanCardNo = dr2["PanCardNo"].ToString();
                string RationCardNo = dr2["RationCardNo"].ToString();
                string Bank_Id = dr2["Bank_Id"].ToString();
                if (txt_PanCardNo.Text != PanCardNo || txt_RationCardNo.Text != RationCardNo)
                {
                    Alert.Show("Invalid");

                }
                else
                {
                    insert_data2();
                }
            }
            else
            {
                insert_data2();
            }
            dr2.Close();
            con2.Close();
        }
        using (con3)
        {
            con3.Open();
            string bank_id = Session["Bank_Id"].ToString();
            SqlCommand cmd5 = new SqlCommand("select * from tbl_Loan where AdharId='" + txt_AdharId.Text + "'", con3);
            SqlDataReader dr2 = cmd5.ExecuteReader();
            if (dr2.Read())
            {
                string PanCardNo = dr2["PanCardNo"].ToString();
                string RationCardNo = dr2["RationCardNo"].ToString();
                string Bank_Id = dr2["Bank_Id"].ToString();
                if (txt_PanCardNo.Text != PanCardNo || txt_RationCardNo.Text != RationCardNo)
                {
                    Alert.Show("Invalid");

                }
                else
                {
                    insert_data3();
                }
            }
            else
            {
                insert_data3();
            }
            dr2.Close();
            con3.Close();
        }
    }
    protected void btn_AddLoan_Click(object sender, EventArgs e)
    {
        insert_details();
        clear();
    }
}