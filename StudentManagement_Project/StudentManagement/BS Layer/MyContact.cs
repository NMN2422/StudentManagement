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
    class MyContact
    {
        DBMain db = null;

        public MyContact()
        {
            db = new DBMain();
        }
        public bool AddContact(string fname, string lname, int group_id, string phone, string email, string address,int userid, ref string err)
        {
            string sqlString = "Insert Into MyContact Values('" + fname + "',N'" + lname + "',N'" + group_id + "',N'" + phone + "',N'" + email + "',N'" + address +"',N'"+userid+ "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateContact(int contactid, string fname, string lname, int group_id, string phone, string email, string address, ref string err)
        {
            string sqlString = "Update MyContact Set fname=N'" + fname + "',lname='" + lname + "',group_id=" + group_id + ",phone='" + phone + "',email='" + email+"',address='"+address+"'Where id=" + contactid;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool RemoveContact(int contactid, ref string err)
        {
            string sqlString = "Delete From MyContact Where id=" + contactid;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet getcontactid(int contactid)
        {
            string sql = "SELECT id AS [Contact ID], CONCAT(fname,' ',lname) AS [Full Name], group_id AS [Group ID], phone AS [Phone], email AS [Email], picture AS [Image], userid AS [User ID] FROM MyContact WHERE id=" + contactid;
            return db.ExecuteQuery(sql, CommandType.Text);
        }
        public bool MailGroupexist(int group_id, string email, string op, int Contactid = 0)
        {
            string sql = "";
            if (op == "add")
            {
                sql = "select * from MyContact WHERE group_id="+group_id+" and email='"+@email+"'";
            }
            else if (op == "edit")
            {
                sql = "select * from MyContact WHERE group_id=" + group_id + " and email='" + @email + "'And id<>"+Contactid;

            }
            return db.ExecuteQueryBool(sql, CommandType.Text);
        }
        public DataSet selectContactlst(string cmd)
        {
            return db.ExecuteQuery(cmd, CommandType.Text);
        }
        public DataSet selectContactlst(string cmd,int id)
        {
            string sql = cmd + id;
            return db.ExecuteQuery(sql, CommandType.Text);
        }
    }
}
