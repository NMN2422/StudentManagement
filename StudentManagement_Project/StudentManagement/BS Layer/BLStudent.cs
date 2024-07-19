using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using StudentManagement.DB_Layer;
namespace StudentManagement.BS_Layer
{
    class BLStudent
    {
        DBMain db = null;
        
        public BLStudent()
        {
            db = new DBMain();
        }
        
        public DataSet GetStudent()
        {
            return db.ExecuteQuery("select * from Student", CommandType.Text);
        }
        public DataSet GetStudentForScore()
        {
            return db.ExecuteQuery(" select id,fname,lname,bdate from Student",CommandType.Text);
        }
        public bool AddStudent(int id, string fname, string lname, string bdate, string gender, string phone, string address, string pic,
            ref string err) //sua pic lai de luu anh ko dc :(((
        {
            
            string sqlString = "Insert Into Student Values('" + id + "',N'" + fname + "',N'" + lname + "',N'" + bdate + "',N'" + gender + 
                "',N'" + phone + "',N'" +address + "',N'" + pic + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool RemoveStudent(int id,ref string err) 
        {

            string sqlString = "Delete From Student Where id="+id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateStudent(int id, string fname, string lname, string bdate, string gender, string phone, string address, string pic,
            ref string err)
        {
            string sqlString = "Update Student Set fname=N'"+ fname + "',lname='" + lname + "',bdate='" + bdate + "',gender='" + gender +
                "',phone='" + phone + "',address='" + address + "',picture='" + pic + "'Where id="+id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet SearchStudent(string search)
        {
            string sqlString = "SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS[Address], picture AS[Image] FROM Student WHERE " +
                "Concat(id,phone) like '%" + search + "%'";
               
            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
        public DataSet Getgenderwithrange(string check,string date1,string date2)
        {
            string sqlString;
            if (check=="Male")
            {
                 sqlString = "SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] FROM Student " +
                "WHERE (bdate BETWEEN'" + date1 + "' AND '" + date2 + "')"+"AND gender='Male'";
            }
            else if(check=="Female")
            {
                 sqlString = "SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] FROM Student " +
                "WHERE (bdate BETWEEN'" + date1 + "' AND '" + date2 + "' )"+"AND gender='Female'";
            }
            else
            {
                sqlString = "SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] FROM Student " +
                "WHERE (bdate BETWEEN'" + date1 + "' AND '" + date2 + "')";
            }
            return db.ExecuteQuery(sqlString, CommandType.Text);

        }
        public DataSet Getgender(string check)
        {
            string sqlString;
            if (check == "Male")
            {
                sqlString="SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] " +
                    "FROM Student WHERE gender = 'Male'";
            }
            else if (check == "Female")
            {
                sqlString = "SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] " +
                    "FROM Student WHERE gender = 'Female'";
            }
            else
            {
                sqlString = "SELECT id AS [Student ID],fname AS [First Name], lname AS [Last Name], bdate AS [Birthdate], gender AS [Gender], phone AS [Phone], address AS [Address], picture AS [Image] " +
                        "FROM Student ";
                
            }
            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
        public int totalgender(string gender)
        {
            string sql;
            if (gender == "Male")
            {
                sql = "select Count(*) from Student where gender='Male'";
            }
            else
            {
                sql = "select Count(*) from Student where gender='Female'";
            }
            return db.ExecuteQueryInt(sql, CommandType.Text);
        }
        public int totalstudent()
        {
            string sql = "select Count(*) From Student";
            return db.ExecuteQueryInt(sql, CommandType.Text);
        }
        public DataSet Get(string sql)
        {
            return db.ExecuteQuery(sql, CommandType.Text);
        }
    }
}
