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
    class BLScore
    {
        DBMain db = null;

        public BLScore()
        {
            db = new DBMain();
        }
        public bool AddScore(int stid, int courseid, double score, string cdescription, ref string err)
        {
            string sqlString = "Insert Into Score Values('" + stid + "',N'" + courseid+ "',N'" + score + "',N'" + cdescription + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool RemoveScore(int stid,int courseid,ref string err)
        {
            string sqlString = "Delete From Score Where student_id=" + stid + " and course_id=" + courseid;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateScore(int stid, int courseid, double score, string cdescription, ref string err)
        {
            string sqlString = "Update Score Set student_score=" + score + ",description='" + cdescription + "'Where student_id="+stid+" And course_id="+courseid;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet GetScore()
        {
            string sqlString = "Select Score.student_id AS [Student ID], Student.fname as [First Name], Student.lname AS [Last Name], Score.course_id AS [Course ID], Course.label AS [Course Name], Score.student_score AS [Score], Score.description AS [Description] " +
                "FROM Student INNER JOIN Score ON Student.id=Score.student_id INNER JOIN Course ON Course.id=Score.course_id";
            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
        public DataSet GetavarageScore(string course)//average score by course **
        {
            string sqlString = "Select AverageGrade FROM (Select Course.[label], AVG(Score.student_score) as AverageGrade " +
                "From Course, Score where Course.id = Score.course_id GROUP BY Course.label) as GRADE WHERE GRADE.label ='" + course + "'";
            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
        public DataSet getCourseScore(int courseid) //course score
        {
            string sqlString= "SELECT Score.student_id AS [Student ID], Student.fname AS [First Name], Student.lname AS [Last Name], Score.course_id AS [Course ID], Course.label AS [Course Name], Score.student_score AS [Score], Score.description AS [Description] " +
                "FROM Student INNER JOIN Score ON Student.id=Score.student_id INNER JOIN Course ON Course.id=Score.course_id WHERE Score.course_id=" + courseid;
            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
        public DataSet getStudentScore(int stdid)
        {
            string sqlString = "SELECT Score.student_id AS [Student ID], Student.fname AS [First Name], Student.lname AS [Last Name], Score.course_id AS [Course ID], Course.label AS [Course Name], Score.student_score AS [Score], Score.description AS [Description] " +
                " FROM Student INNER JOIN Score ON Student.id=Score.student_id INNER JOIN Course ON Course.id=Score.course_id WHERE Score.student_id=" + stdid;
            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
        public DataSet getaverageScoreAllcourse()// score of all course. tuong tu ham ** tren
        {
            string sqlString = "SELECT [label] AS [Course Name] ,AVG(student_score) AS [Average Score By Course] FROM Score JOIN Course ON Score.course_id = Course.id GROUP BY [label]";
            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
        public int getStudentPass()
        {
            string sqlString = "SELECT COUNT([Student ID]) FROM (SELECT student_id AS [Student ID], AVG(student_score) AS [Average Score By Student] " +
                "FROM Score GROUP BY student_id) AS TBSV WHERE [Average Score By Student]>=5";
            return db.ExecuteQueryInt(sqlString, CommandType.Text);
        }
        public int getStudentFail()
        {
            string sqlString = "SELECT COUNT([Student ID]) FROM (SELECT student_id AS [Student ID], AVG(student_score) AS [Average Score By Student] " +
                "FROM Score GROUP BY student_id) AS TBSV WHERE [Average Score By Student]<5";
            return db.ExecuteQueryInt(sqlString, CommandType.Text);
        }
        public int getRateStd(int below, int greaterEqual)
        {
            string sqlString = "SELECT COUNT([Student ID]) FROM (SELECT student_id AS [Student ID], AVG(student_score) AS [Average Score By Student] " +
                "FROM Score GROUP BY student_id) AS TBSV WHERE [Average Score By Student] <" + below + " and [Average Score By Student] >=" + greaterEqual;
            return db.ExecuteQueryInt(sqlString, CommandType.Text);
        }


    }
}
