using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using StudentManagement.DB_Layer;
namespace StudentManagement.BS_Layer
{
    class AccountLogin
    {
        DBMain db = null;
        
        public AccountLogin()
        {
            db = new DBMain();
        }
        public bool checkEmail(string mail)
        {
            string sqlString = "SELECT email FROM Login WHERE email ='" + mail+"'";
            return db.ExecuteQueryBool(sqlString, CommandType.Text);
        }
        public bool checkUser(string user)
        {
            string sqlString = "SELECT username FROM login WHERE username ='" + user + "'";
            return db.ExecuteQueryBool(sqlString, CommandType.Text);
        }
        public bool AddAcc(string fname, string lname, string user, string pass, string email, ref string err)
        {
            string sqlString = "Insert Into Login Values('" + fname + "',N'" + lname + "',N'" + user + "',N'" + pass + "',N'" + email + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateAcc(string fname, string lname, string user, string pass, string email, ref string err)
        {
            string sqlString = "Update Login Set f_name='" + fname + "',l_name='" + lname + "',password='" + pass + "',email='" + email + "'Where username='" + user + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool RemoveAcc(string user, ref string err)
        {
            string sqlString = "Delete From Login Where username='" + user + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool Userexist(string user, string op, int userid)
        {
            string sql = "";
            if (op == "register")
            {
                sql = "Select * from Login Where username='" + user + "'";
            }
            else if (op == "edit")
            {
                sql = "select * from Login where username='" + user + "'And id<>" + userid;

            }
            return db.ExecuteQueryBool(sql, CommandType.Text);
        }
        public DataSet getaccount(string sql)
        {
            return db.ExecuteQuery(sql, CommandType.Text);
        }
        public DataSet getdatalogin(string sql,string user,string pass)
        {
            string sqlString= "SELECT * FROM [" + sql + "] WHERE username ='"+user+"'And password='"+pass+"'";
            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
        public bool Updatepass(string pass, string email,ref string  err)
        {
            string sql = "UPDATE Login SET password ='" + pass + "'WHERE email='" + email + "'";
            return db.MyExecuteNonQuery(sql, CommandType.Text,ref err);
        }
        
    }
    
}
