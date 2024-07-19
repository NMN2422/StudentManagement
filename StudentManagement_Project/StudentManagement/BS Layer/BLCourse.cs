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
    class BLCourse
    {
        DBMain db = null;
        
        public BLCourse()
        {
            db = new DBMain();
        }
        
        public bool AddCourse(int cid,string cname,int cperiod,string cdescription,ref string err)
        {
            string sqlString = "Insert Into Course Values('" + cid + "',N'" + cname + "',N'" + cperiod + "',N'" + cdescription + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text,ref err);
        }
        public bool UpdateCourse(int cid, string cname, int cperiod, string cdescription,ref string err)
        {
            string sqlString = "Update Course Set label=N'" + cname + "',period=" + cperiod + ",description='" + cdescription + "'Where id="+cid;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text,ref err);
        }
        public bool RemoveCourse(int cid,ref string err)
        {
            string sqlString = "Delete From Course Where id=" + cid;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        
        public DataSet GetCourse()
        {
            return db.ExecuteQuery("Select* From Course ", CommandType.Text);
        }
        public DataSet GetCourseScore(int courseid)
        {
            string sql = "SELECT Score.student_id AS [Student ID], Student.fname AS [First Name], Student.lname AS [Last Name], Score.course_id AS [Course ID], Course.label AS [Course Name], Score.student_score AS [Score], Score.description AS [Description] " +
                "FROM Student INNER JOIN Score ON Student.id=Score.student_id INNER JOIN Course ON Course.id=Score.course_id WHERE Score.course_id=" + courseid;
            return db.ExecuteQuery(sql, CommandType.Text);
        }
        public DataSet checkCourseName(string coursename, int cid)
        {
            string sqlString = "SELECT * FROM Course WHERE label='" + coursename + "'And id<>" + cid;

            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
        public DataSet GetCourseByID(int id)
        {
            string sqlString = "Select *From Course Where id=" + id;
            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
        public DataSet GetStudentByCourse(int cid)
        {
            string sqlString= "SELECT Student.id AS [Student ID],Student.fname AS [First Name], Student.lname AS [Last Name], Course.[description] AS [Description] FROM Student " +
                "INNER JOIN Score ON Student.id=Score.student_id INNER JOIN Course ON Course.id=Score.course_id WHERE Score.course_id =" + cid;
            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
        public DataSet Get(string sql)
        {
            return db.ExecuteQuery(sql, CommandType.Text);
        }
    }
}
