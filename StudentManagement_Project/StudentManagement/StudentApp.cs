using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.Student;
using StudentManagement.Course;
using StudentManagement.Score;
using StudentManagement.Result;
namespace StudentManagement
{
    public partial class StudentApp : Form
    {
        public StudentApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region student
        private void addStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStudent std = new AddStudent();
            std.Show();
        }

        private void listStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListStudent lst = new ListStudent();
            lst.Show();
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudent mst = new ManageStudent();
            mst.Show();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticGender sta = new StatisticGender();
            sta.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudent prt = new PrintStudent();
            prt.Show();
        }
        #endregion
        #region course
        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourse mnc = new ManageCourse();
            mnc.Show();
        }
        #endregion

        private void listCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListStudentByCourse lst = new ListStudentByCourse();
            lst.Show();
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintCourse prt = new PrintCourse();
            prt.Show();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScore mng = new ManageScore();
            mng.Show();
        }

        private void avarageOfScoreByResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvarageScoreResult avg = new AvarageScoreResult();
            avg.Show();
        }

        private void statisticResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticResult stt = new StatisticResult();
            stt.Show();
        }

        private void averageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AverageScore avg = new AverageScore();
            avg.Show();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintScore prt = new PrintScore();
            prt.Show();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
