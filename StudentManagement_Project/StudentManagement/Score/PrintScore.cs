using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using StudentManagement.BS_Layer;
using StudentManagement.DB_Layer;
namespace StudentManagement.Score
{
    public partial class PrintScore : Form
    {
        bool check;
        string err;
        int index;
        string data = "Score";
        DataTable dtListsc = null, dtListcourse = null, dtLststu = null;
        BLCourse dbCourse = new BLCourse();
        BLScore dbScore = new BLScore();
        BLStudent dbStudent = new BLStudent();
        ScoreExport export = new ScoreExport();
        private void PrintScore_Load(object sender, EventArgs e)
        {
            string sql = "Select id AS [Student ID],fname AS [First Name],lname AS [Last Name] From Student";
            dtLststu = new DataTable();
            dtLststu.Clear();
            DataSet ds = dbStudent.Get(sql);
            dtLststu = ds.Tables[0];
            dgStudentlist.DataSource = dtLststu;
            dgScorelist.ReadOnly = true;
            dgScorelist.RowTemplate.Height = 35;
            getscore();
            dgScorelist.AllowUserToAddRows = false;

            getcourse();
        }

        public PrintScore()
        {
            InitializeComponent();
        }
        public void getscore()
        {
            dtListsc = new DataTable();
            dtListsc.Clear();
            DataSet ds = dbScore.GetScore();
            ds = dbScore.GetScore();
            dtListsc = ds.Tables[0];
            dgScorelist.DataSource = dtListsc;
        }

        private void btWord_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgScorelist.Rows.Count > 0)
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        export.exportDataToWord(dgScorelist, saveFileDialog1.FileName);
                    }
                    MessageBox.Show("Data Exported Successfully !!!", "Notification");
                }
                else
                {
                    MessageBox.Show("No Record To Export !!!", "Notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = (System.Data.DataTable)dgScorelist.DataSource;
            try
            {
                if (dgScorelist.Rows.Count > 0)
                {
                    saveFileDialog1.Filter = "Excel (.xlsx)|.xlsx";
                    saveFileDialog1.FileName = ".xlsx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        export.exportDataToExcel(dt, "Score", "Score List", saveFileDialog1.FileName);
                        MessageBox.Show("Data Exported Successfully !!!", "Notification");
                    }

                }
                else
                {
                    MessageBox.Show("No Record To Export !!!", "Notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btPdf_Click(object sender, EventArgs e)
        {
            if (dgScorelist.Rows.Count > 0)
            {
                saveFileDialog1.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog1.FileName = ".pdf"; bool fileError = false;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        try
                        {
                            File.Delete(saveFileDialog1.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            export.exportDataToPDF(dgScorelist, saveFileDialog1.FileName);
                            MessageBox.Show("Data Exported Successfully !!!", "Notification");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Notification");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbCourse_Click(object sender, EventArgs e)
        {
            dtListcourse = new DataTable();
            dtListcourse.Clear();
            DataSet ds = dbCourse.GetCourseScore(int.Parse(lbCourse.SelectedValue.ToString()));
            dtListcourse = ds.Tables[0];
            dgScorelist.DataSource = dtListcourse;
        }

        private void dgStudentlist_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Score.student_id AS [Student ID], Student.fname AS [First Name], Student.lname AS [Last Name], Score.course_id AS [Course ID], Course.label AS [Course Name], Score.student_score AS [Score], Score.description AS [Description] " +
                "FROM Student INNER JOIN Score ON Student.id=Score.student_id INNER JOIN Course ON Course.id=Score.course_id WHERE Score.student_id=" + int.Parse(dgStudentlist.CurrentRow.Cells[0].Value.ToString());
            dtLststu = new DataTable();
            dtLststu.Clear();
            DataSet ds = dbStudent.Get(sql);
            dtLststu = ds.Tables[0];
            dgScorelist.DataSource = dtLststu;
        }

        public void getcourse()
        {
            dtListcourse = new DataTable();
            dtListcourse.Clear();
            DataSet ds = dbCourse.GetCourse();
            dtListcourse = ds.Tables[0];
            lbCourse.DataSource = dtListcourse;
            lbCourse.DisplayMember = "label";
            lbCourse.ValueMember = "id";
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            getscore();
        }
    }
}
