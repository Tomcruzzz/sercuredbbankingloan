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
        if (!IsPostBack)
        {
            getloandetails();
        }
        txt_PaymentAmount.Visible = false;
        lbl_Pay.Visible = false;
        //lbl_Score.Visible = false;
        //drp_Scoring.Visible = false;
    }
    private void getloandetails()
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
            string Loan_Id = Session["Loan_Id"].ToString();
            SqlCommand cmd = new SqlCommand("select * from tbl_Loan where Loan_Id='" + Loan_Id + "' AND Bank_Id='"+bank_id+"'", con1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_BankName.Text = dr["BankName"].ToString();
                txt_LoanStartedDate.Text = dr["Loan_StartedDate"].ToString();
                txt_Name.Text = dr["Name"].ToString();
                txt_LoanName.Text = dr["LoanName"].ToString();
                txt_Amount.Text = dr["LoanAmount"].ToString();
                txt_Balance.Text = dr["Balance"].ToString();
            }
            con1.Close();
        }
        using (con2)
        {
            con2.Open();
            string bank_id = Session["Bank_Id"].ToString();
            string Loan_Id = Session["Loan_Id"].ToString();
            SqlCommand cmd = new SqlCommand("select * from tbl_Loan where Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con2);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_BankName.Text = dr["BankName"].ToString();
                txt_LoanStartedDate.Text = dr["Loan_StartedDate"].ToString();
                txt_Name.Text = dr["Name"].ToString();
                txt_LoanName.Text = dr["LoanName"].ToString();
                txt_Amount.Text = dr["LoanAmount"].ToString();
                txt_Balance.Text = dr["Balance"].ToString();
            }
            con2.Close();
        }
        using (con3)
        {
            con3.Open();
            string bank_id = Session["Bank_Id"].ToString();
            string Loan_Id = Session["Loan_Id"].ToString();
            SqlCommand cmd = new SqlCommand("select * from tbl_Loan where Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con3);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_BankName.Text = dr["BankName"].ToString();
                txt_LoanStartedDate.Text = dr["Loan_StartedDate"].ToString();
                txt_Name.Text = dr["Name"].ToString();
                txt_LoanName.Text = dr["LoanName"].ToString();
                txt_Amount.Text = dr["LoanAmount"].ToString();
                txt_Balance.Text = dr["Balance"].ToString();
            }
            con3.Close();
        }
    }
    private void clear()
    {
        txt_Amount.Text = "";
        txt_Balance.Text = "";
        txt_BankName.Text = "";
        txt_LoanName.Text = "";
        txt_LoanStartedDate.Text = "";
        txt_Name.Text = "";
        txt_PaymentAmount.Text="";

    }
    private void update_loandetails()
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
            string Loan_Id = Session["Loan_Id"].ToString();
            string paymentdate = DateTime.Now.Date.ToString("dd/MM/yyyy");
            SqlCommand cmd = new SqlCommand("select * from tbl_Loan where Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                {
                    string payment_status = dr["Status"].ToString();
                    DateTime Loan_FirstDate =Convert.ToDateTime(dr["Loan_FirstDate"].ToString());
                    DateTime Loan_SecondDate =Convert.ToDateTime(dr["Loan_SecondDate"].ToString());
                    DateTime Loan_ThirdDate =Convert.ToDateTime(dr["Loan_ThirdDate"].ToString());
                    DateTime Loan_issuedDate =Convert.ToDateTime(txt_LoanStartedDate.Text);
                    if (payment_status == "Pending")
                    {
                        int oldbalance = Convert.ToInt32(txt_Balance.Text);
                        int paymentamount = Convert.ToInt32(txt_PaymentAmount.Text);
                        int newbalance = oldbalance - paymentamount;
                        txt_Balance.Text = newbalance.ToString();
                        SqlCommand cmd1 = new SqlCommand("update tbl_Loan set PaymentAmount='" + txt_PaymentAmount.Text + "',Balance='" + newbalance + "',PaymentDate='" + paymentdate + "',Status='" + drp_Status.SelectedItem.ToString() + "' where BankName='" + txt_BankName.Text + "' AND Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con1);
                        dr.Close();
                        cmd1.ExecuteNonQuery();
                    }
                    else
                    {
                        if (payment_status == "Not Paid" || payment_status == "First Payment" || payment_status == "Second Payment")
                        {
                            if (Loan_issuedDate < Loan_FirstDate || Loan_issuedDate < Loan_SecondDate || Loan_issuedDate < Loan_ThirdDate)
                            {
                                int oldbalance = Convert.ToInt32(txt_Balance.Text);
                                int paymentamount = Convert.ToInt32(txt_PaymentAmount.Text);
                                int newbalance = oldbalance - paymentamount;
                                txt_Balance.Text = newbalance.ToString();
                                //string scoringfactor = "Regular Payment";
                                //string scoringrating;
                                if (paymentamount >= 1000)
                                {
                                    //scoringrating = "1000";
                                    SqlCommand cmd2 = new SqlCommand("update tbl_Loan set PaymentAmount='" + txt_PaymentAmount.Text + "',Balance='" + newbalance + "',PaymentDate='" + paymentdate + "',Status='" + drp_Status.SelectedItem.ToString() + "' where BankName='" + txt_BankName.Text + "' AND Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con1);
                                    dr.Close();
                                    cmd2.ExecuteNonQuery();
                                    Alert.Show("Loan Details Updated");

                                }
                                else if (paymentamount < 1000)
                                {
                                    //scoringrating = "589";
                                    SqlCommand cmd2 = new SqlCommand("update tbl_Loan set PaymentAmount='" + txt_PaymentAmount.Text + "',Balance='" + newbalance + "',PaymentDate='" + paymentdate + "',Status='" + drp_Status.SelectedItem.ToString() + "' where BankName='" + txt_BankName.Text + "' AND Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con1);
                                    dr.Close();
                                    cmd2.ExecuteNonQuery();
                                    Alert.Show("Loan Details Updated");

                                }
                              }            
                            }
                        
                        else if (payment_status == "Third Payment")
                        {
                            Alert.Show("All Payment Done");
                        }
                        
                        
                    }
                    
                //txt_BankName.Text = dr["Bank_Name"].ToString();
                   
                }
            con1.Close();
        }
        using (con2)
        {
            con2.Open();
            string Loan_Id = Session["Loan_Id"].ToString();
            string bank_id = Session["Bank_Id"].ToString();
            string paymentdate = DateTime.Now.Date.ToString("dd/MM/yyyy");
            SqlCommand cmd = new SqlCommand("select * from tbl_Loan where Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con2);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string payment_status = dr["Status"].ToString();
                DateTime Loan_FirstDate = Convert.ToDateTime(dr["Loan_FirstDate"].ToString());
                DateTime Loan_SecondDate = Convert.ToDateTime(dr["Loan_SecondDate"].ToString());
                DateTime Loan_ThirdDate = Convert.ToDateTime(dr["Loan_ThirdDate"].ToString());
                DateTime Loan_issuedDate = Convert.ToDateTime(txt_LoanStartedDate.Text);
                if (payment_status == "Pending")
                {
                    int oldbalance = Convert.ToInt32(txt_Balance.Text);
                    int paymentamount = Convert.ToInt32(txt_PaymentAmount.Text);
                    int newbalance = oldbalance - paymentamount;
                    txt_Balance.Text = newbalance.ToString();
                    SqlCommand cmd2 = new SqlCommand("update tbl_Loan set PaymentAmount='" + txt_PaymentAmount.Text + "',Balance='" + newbalance + "',PaymentDate='" + paymentdate + "',Status='" + drp_Status.SelectedItem.ToString() + "' where BankName='" + txt_BankName.Text + "' AND Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con2);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    if (payment_status == "Not Paid" || payment_status == "First Payment" || payment_status == "Second Payment")
                    {
                        if (Loan_issuedDate < Loan_FirstDate || Loan_issuedDate < Loan_SecondDate || Loan_issuedDate < Loan_ThirdDate)
                        {
                            int oldbalance = Convert.ToInt32(txt_Balance.Text);
                            int paymentamount = Convert.ToInt32(txt_PaymentAmount.Text);
                            int newbalance = oldbalance - paymentamount;
                            txt_Balance.Text = newbalance.ToString();
                            //string scoringfactor = "Regular Payment";
                            //string scoringrating;
                            if (paymentamount >= 1000)
                            {
                                //scoringrating = "1000";
                                SqlCommand cmd2 = new SqlCommand("update tbl_Loan set PaymentAmount='" + txt_PaymentAmount.Text + "',Balance='" + newbalance + "',PaymentDate='" + paymentdate + "',Status='" + drp_Status.SelectedItem.ToString() + "' where BankName='" + txt_BankName.Text + "' AND Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con2);
                                dr.Close();
                                cmd2.ExecuteNonQuery();
                                Alert.Show("Loan Details Updated");

                            }
                            else if (paymentamount < 1000)
                            {
                                //scoringrating = "589";
                                SqlCommand cmd2 = new SqlCommand("update tbl_Loan set PaymentAmount='" + txt_PaymentAmount.Text + "',Balance='" + newbalance + "',PaymentDate='" + paymentdate + "',Status='" + drp_Status.SelectedItem.ToString() + "' where BankName='" + txt_BankName.Text + "' AND Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con2);
                                dr.Close();
                                cmd2.ExecuteNonQuery();
                                Alert.Show("Loan Details Updated");

                            }
                        }
                    }

                    else if (payment_status == "Third Payment")
                    {
                        Alert.Show("All Payment Done");
                    }


                }

                //txt_BankName.Text = dr["Bank_Name"].ToString();

            }

            con2.Close();
        }
        using (con3)
        {
            con3.Open();
            string bank_id = Session["Bank_Id"].ToString();
            string Loan_Id = Session["Loan_Id"].ToString();
            string paymentdate = DateTime.Now.Date.ToString("dd/MM/yyyy");
            SqlCommand cmd = new SqlCommand("select * from tbl_Loan where Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con3);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string payment_status = dr["Status"].ToString();
                DateTime Loan_FirstDate = Convert.ToDateTime(dr["Loan_FirstDate"].ToString());
                DateTime Loan_SecondDate = Convert.ToDateTime(dr["Loan_SecondDate"].ToString());
                DateTime Loan_ThirdDate = Convert.ToDateTime(dr["Loan_ThirdDate"].ToString());
                DateTime Loan_issuedDate = Convert.ToDateTime(txt_LoanStartedDate.Text);
                if (payment_status == "Pending")
                {
                    int oldbalance = Convert.ToInt32(txt_Balance.Text);
                    int paymentamount = Convert.ToInt32(txt_PaymentAmount.Text);
                    int newbalance = oldbalance - paymentamount;
                    txt_Balance.Text = newbalance.ToString();
                    SqlCommand cmd2 = new SqlCommand("update tbl_Loan set PaymentAmount='" + txt_PaymentAmount.Text + "',Balance='" + newbalance + "',PaymentDate='" + paymentdate + "',Status='" + drp_Status.SelectedItem.ToString() + "' where BankName='" + txt_BankName.Text + "' AND Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con3);
                    dr.Close();
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    if (payment_status == "Not Paid" || payment_status == "First Payment" || payment_status == "Second Payment")
                    {
                        if (Loan_issuedDate < Loan_FirstDate || Loan_issuedDate < Loan_SecondDate || Loan_issuedDate < Loan_ThirdDate)
                        {
                            int oldbalance = Convert.ToInt32(txt_Balance.Text);
                            int paymentamount = Convert.ToInt32(txt_PaymentAmount.Text);
                            int newbalance = oldbalance - paymentamount;
                            txt_Balance.Text = newbalance.ToString();
                            //string scoringfactor = "Regular Payment";
                            //string scoringrating;
                            if (paymentamount >= 1000)
                            {
                                //scoringrating = "1000";
                                SqlCommand cmd2 = new SqlCommand("update tbl_Loan set PaymentAmount='" + txt_PaymentAmount.Text + "',Balance='" + newbalance + "',PaymentDate='" + paymentdate + "',Status='" + drp_Status.SelectedItem.ToString() + "' where BankName='" + txt_BankName.Text + "' AND Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con3);
                                dr.Close();
                                cmd2.ExecuteNonQuery();
                                Alert.Show("Loan Details Updated");

                            }
                            else if (paymentamount < 1000)
                            {
                                //scoringrating = "589";
                                SqlCommand cmd2 = new SqlCommand("update tbl_Loan set PaymentAmount='" + txt_PaymentAmount.Text + "',Balance='" + newbalance + "',PaymentDate='" + paymentdate + "',Status='" + drp_Status.SelectedItem.ToString() + "' where BankName='" + txt_BankName.Text + "' AND Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con3);
                                dr.Close();
                                cmd2.ExecuteNonQuery();
                                Alert.Show("Loan Details Updated");

                            }
                        }
                    }

                    else if (payment_status == "Third Payment")
                    {
                        Alert.Show("All Payment Done");
                    }


                }

                //txt_BankName.Text = dr["Bank_Name"].ToString();

            }

            con3.Close();
        }
        clear();
    }
    private void view_loandetails()
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
            string Loan_Id = Session["Loan_Id"].ToString();
            string bank_id = Session["Bank_Id"].ToString();
            SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Loan where Loan_Id='" + Loan_Id + "' AND Bank_Id='" + bank_id + "'", con1);
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
            string Loan_Id = Session["Loan_Id"].ToString();
            string bank_id = Session["Bank_Id"].ToString();
            SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Loan where Bank_Id='" + bank_id + "' AND Bank_Id='" + bank_id + "'", con2);
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
            string Loan_Id = Session["Loan_Id"].ToString();
            string bank_id = Session["Bank_Id"].ToString();
            SqlDataAdapter adp = new SqlDataAdapter("select * from tbl_Loan where Bank_Id='" + bank_id + "' AND Bank_Id='" + bank_id + "'", con3);
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
    protected void btn_AddLoan_Click(object sender, EventArgs e)
    {
        update_loandetails();
        view_loandetails();
    }
    protected void drp_Status_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(drp_Status.SelectedItem.ToString()=="Pending")
        {
             txt_PaymentAmount.Visible=false;
             lbl_Pay.Visible = false;
             //lbl_Score.Visible = true;
             //drp_Scoring.Visible = true;
        }
        else
        {
             txt_PaymentAmount.Visible=true;
             lbl_Pay.Visible = true;
            // lbl_Score.Visible = true;
             //drp_Scoring.Visible = true;
        }
    }
}