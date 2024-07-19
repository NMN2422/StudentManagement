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
    public partial class ListStudentByCourse : Form
    {
        public ListStudentByCourse()
        {
            InitializeComponent();
        }
        CourseExport export = new CourseExport();
        private void ListStudentByCourse_Load(object sender, EventArgs e)
        {
            lbTotal.Text = "Total Student: " + dataGridView1.Rows.Count.ToString().Trim();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btWord_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        export.exportStudentListToWord(dataGridView1, saveFileDialog1.FileName, lbCourse.Text.Trim());
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
    }
}
