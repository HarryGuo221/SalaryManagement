using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    class DAO
    {
        public static string constr = @"Integrated Security=SSPI;database=gmx_SalaryManagement;server=HARRY";

        public static int ExecuteNonQuery(string sql)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }

        public static Object ExecuteScalar(string sql)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            Object ob = cmd.ExecuteScalar();
            conn.Close();
            return ob;
        }

        public static DataTable GetTable(string sql)
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            try
            {
                adp.Fill(ds);
                adp.Dispose();
                conn.Close();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count<=0)
                    {
                        return null;
                    }
                    return ds.Tables[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                throw;
            }
        }
    }
}
