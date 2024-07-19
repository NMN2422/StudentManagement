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

    class BLResult
    {
        DBMain db = null;

        public BLResult()
        {
            db = new DBMain();
        }
        public DataSet GetSdata(string course)
        {
            string sqlString = "SELECT student_id as [Student ID], fname AS [First Name], lname as [Last Name], " + course + " ,ROUND(GOOD.[Average Score],2) AS [Average Score] " +
                "FROM (Select * FROM(select  DTB.[label], DTB.student_score, fname, lname, id from(Select [label],[student_id], course_id, student_score  " +
                "From Score Inner JOIN  Course on course_id = id Group by student_score, course_id, [label], student_id) as DTB " +
                "Inner JOIN Student on DTB.student_id = id) as OK PIVOT(SUM(student_score) FOR OK.[label] IN(" + course + ")) AS PVTTable) " +
                "AS MUCH INNER JOIN (Select student_id, AVG(Score.student_score) AS [Average Score] FROM Score Group by student_id) AS GOOD ON student_id = MUCH.id";
            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
        public DataSet GetDataFromCM(string sql)
        {
            return db.ExecuteQuery(sql, CommandType.Text);
        }
        public DataSet DataSearch(string course,string txt)
        {
            string sqlString = "SELECT * FROM (SELECT student_id as [Student ID], fname AS [First Name], lname as [Last Name], " + course + " ,ROUND(GOOD.[Average Score],2) AS [Average Score] " +
                "FROM (Select * FROM(select  DTB.[label], DTB.student_score, fname, lname, id from(Select [label],[student_id], course_id, student_score  " +
                "From Score Inner JOIN  Course on course_id = id Group by student_score, course_id, [label], student_id) as DTB " +
                "Inner JOIN Student on DTB.student_id = id) as OK PIVOT(SUM(student_score) FOR OK.[label] IN (" + course + ")) AS PVTTable) " +
                "AS MUCH INNER JOIN (Select student_id, AVG(Score.student_score) AS [Average Score] FROM Score Group by student_id) AS GOOD ON student_id = MUCH.id) AS kho " +
                "WHERE CONCAT([Student ID],[First Name],[Last Name]) LIKE '%" + txt.Trim() + "%'";
            return db.ExecuteQuery(sqlString, CommandType.Text);
        }
       
        
    }
   
    

    
}
