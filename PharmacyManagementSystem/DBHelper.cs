using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem
{
    class DBHelper
    {
        // static string SERVER_NAME = "DESKTOP-F7UFU4N";
        static string SERVER_NAME = "LAPTOP-V4CJ4PPI";

        private static SqlConnection createConnection() 
        { 
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source="+SERVER_NAME+";database=PharmacyDB;integrated security =True";
            return con;
        } 

        public static DataSet getData(String query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = createConnection();
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static void setData(String query,String msg)
        {
            SqlConnection con = createConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
