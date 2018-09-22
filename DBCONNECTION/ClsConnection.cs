using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DBCONNECTION
{
    public class ClsConnection
    {
        SqlConnection Con;
        SqlConnection Con1;
        SqlConnection Con2;
        SqlConnection Con3;
        public ClsConnection()
        {
            Con = new SqlConnection("Data Source=D-PC\\SQLEXPRESS;Initial Catalog=SecureMining;Integrated Security=True");
            Con1 = new SqlConnection("Data Source=D-PC\\SQLEXPRESS;Initial Catalog=SecureMining1;Integrated Security=True");
            Con2 = new SqlConnection("Data Source=D-PC\\SQLEXPRESS;Initial Catalog=SecureMining2;Integrated Security=True");
            Con3 = new SqlConnection("Data Source=D-PC\\SQLEXPRESS;Initial Catalog=SecureMining3;Integrated Security=True");
        }
        public SqlConnection connect()
        {
            return Con;
        }
        public SqlConnection connect1()
        {
            return Con1;
        }
        public SqlConnection connect2()
        {
            return Con2;
        }
        public SqlConnection connect3()
        {
            return Con3;
        }
    }
}
