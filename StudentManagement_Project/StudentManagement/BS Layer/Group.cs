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
    class Group
    {
        DBMain db = null;

        public Group()
        {
            db = new DBMain();
        }
        public bool AddGroup(string name, int userid, ref string err)
        {
            string sqlString = "Insert Into MyGroup Values('" + name + "',N'" + userid + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateGroup(string name, int groupid, ref string err)
        {
            string sqlString = "Update MyGroup Set name=N'" + name +"'Where id=" + groupid;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool RemoveGroup(int groupid, ref string err)
        {
            string sqlString = "Delete From MyGroup Where id=" + groupid;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet getGroup(int userid)
        {
            string sql = "Select * from MyGroup WHERE userid =" + userid;
            return db.ExecuteQuery(sql, CommandType.Text);
        }
        public bool GroupNameexist(string name, string op, int userid = 0, int groupid = 0)
        {
            string sql="";
            if (op == "add")
            {
                sql = "select * from MyGroup WHERE name='" + name + "'and userid=" + userid ;
            }
            else if (op == "edit")
            {
                sql = "select * from MyGroup WHERE name='" + name + "'and userid=" + userid + "And id<>" + groupid;

            }
            return db.ExecuteQueryBool(sql, CommandType.Text);
        }
    }
}
