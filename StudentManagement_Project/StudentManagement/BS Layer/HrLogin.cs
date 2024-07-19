using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using StudentManagement.DB_Layer;
namespace StudentManagement.BS_Layer
{
   
    class HrLogin
    {
        DBMain db = null;
        public HrLogin()
        {
            db = new DBMain();
        }
        public bool checkmail(string mail)
        {
            string sqlString = "SELECT email FROM HumanResource WHERE email ='" + mail+"'";
            return db.ExecuteQueryBool(sqlString, CommandType.Text);
        }
        public bool AddHr(string fname, string lname, string user, string pass, string email, ref string err)
        {
            string sqlString = "Insert Into HumanResource Values('" + fname + "',N'" + lname + "',N'" + user + "',N'" + pass + "',N'" +email+ "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateHr(string fname, string lname, string user, string pass, string email, ref string err)
        {
            string sqlString = "Update HumanResource Set f_name='" + fname + "',l_name='" + lname +"',password='"+pass+"',email='"+email+ "'Where username='"+user+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool RemoveScore(string user, ref string err)
        {
            string sqlString = "Delete From HumanResource Where username='" + user + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool Userexist(string user, string op, int userid=0)
        {
            string sql = "";
            if (op == "register")
            {
                sql = "Select * from HumanResource Where username='" + user + "'";
            }
            else if(op=="edit")
            {
                sql = "select * from HumanResource where username='" + user + "'And id<>"+userid;
                    
            }
            return db.ExecuteQueryBool(sql, CommandType.Text);
        }
        public DataSet GetHrbyID(int userid)
        {

            string sql = "Select * From HumanResource where id=" + userid;
            return db.ExecuteQuery(sql, CommandType.Text);
        }
        public bool Updatepass(string pass, string email, ref string err)
        {
            string sql = "UPDATE HumanResource SET password ='" + pass + "' WHERE email='" + email + "'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public DataSet getuser(string sql)
        {
            
            return db.ExecuteQuery(sql, CommandType.Text);
        }
    }
    
}
