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
namespace StudentManagement.Course
{
    public partial class PrintCourse : Form
    {
        BLCourse course = new BLCourse();
        DataTable dtListc = null;
        CourseExport export = new CourseExport();
        public PrintCourse()
        {
            InitializeComponent();
        }

        private void PrintCourse_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id as [Course ID], label as [Course Name], period [Period], description AS [Description] FROM Course";
            fillGrid(sql);
        }
        public void fillGrid(string command)
        {
            dtListc = new DataTable();
            dtListc.Clear();
            DataSet ds = course.Get(command);
            dtListc = ds.Tables[0];
            dgCourselst.ReadOnly = true;
            dgCourselst.RowTemplate.Height = 80;
            dgCourselst.DataSource = dtListc;
            dgCourselst.AllowUserToAddRows = false;
        }

        private void btWord_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCourselst.Rows.Count > 0)
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        export.exportDataToWord(dgCourselst, saveFileDialog1.FileName);
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
            System.Data.DataTable dt = (System.Data.DataTable)dgCourselst.DataSource;
            try
            {
                if (dgCourselst.Rows.Count > 0)
                {
                    saveFileDialog1.Filter = "Excel (.xlsx)|.xlsx";
                    saveFileDialog1.FileName = ".xlsx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        export.exportDataToExcel(dt, "Course", "Course List", saveFileDialog1.FileName);
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
            if (dgCourselst.Rows.Count > 0)
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
                            export.exportDataToPDF(dgCourselst, saveFileDialog1.FileName);
                            MessageBox.Show("Data Exported Successfully !!!", "Notification");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:" + ex.Message);
                        }
                    }
                }
            }
        }

        

        private void dgCourselst_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet tmp, tmp1;
            tmp = course.GetCourseByID(Convert.ToInt32(dgCourselst.CurrentRow.Cells[0].Value));
            tmp1 = course.GetStudentByCourse(Convert.ToInt32(dgCourselst.CurrentRow.Cells[0].Value));
            ListStudentByCourse lst = new ListStudentByCourse();
            DataTable dt = new DataTable(), dt1 = new DataTable();
            dt = tmp.Tables[0];
            dt1 = tmp1.Tables[0];
            lst.dataGridView1.DataSource = dt1;

            lst.lbCourse.Text = "Course Name:" + dt.Rows[0]["label"].ToString();
            lst.ShowDialog();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
