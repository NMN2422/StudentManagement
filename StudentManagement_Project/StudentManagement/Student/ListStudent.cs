using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using StudentManagement.BS_Layer;
using StudentManagement.DB_Layer;

namespace StudentManagement.Student
{
    public partial class ListStudent : Form
    {
        BLStudent dbStudent = new BLStudent();
        DataTable dtListst = null;
        public ListStudent()
        {
            InitializeComponent();
        }

        private void ListStudent_Load(object sender, EventArgs e)
        {
            LoadData();
        
        }
        void LoadData()
        {
            dtListst = new DataTable();
            dtListst.Clear();
            DataSet ds = dbStudent.GetStudent();
            dtListst = ds.Tables[0];
            dgStudentList.DataSource = dtListst;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
