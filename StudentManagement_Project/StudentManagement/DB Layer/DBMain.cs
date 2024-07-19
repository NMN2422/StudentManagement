using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using StudentManagement.BS_Layer;
namespace StudentManagement.DB_Layer
{
    class DBMain
    {
        string connStr = "Data Source=NMN;Initial Catalog=ManageStudent1;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMain()
        {
            conn = new SqlConnection(connStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQuery(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open) // luon ktra dong mo, neu mo lien tuc thi se ton tai nguyen
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public int ExecuteQueryInt(string sqlSql,CommandType ct)
        {
            if (conn.State == ConnectionState.Open) // luon ktra dong mo, neu mo lien tuc thi se ton tai nguyen
                conn.Close();
            conn.Open();
            comm.CommandText = sqlSql;
            comm.CommandType = ct;
            int tmp = (int)comm.ExecuteScalar();
            return tmp;
        }
        public bool ExecuteQueryBool(string sql, CommandType ct)
        {// dung de kiem tra khi login
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = sql;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dttmp = new DataTable();
            dttmp.Clear();           
            dttmp = ds.Tables[0];
            if (dttmp.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch(SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        
    }
}
