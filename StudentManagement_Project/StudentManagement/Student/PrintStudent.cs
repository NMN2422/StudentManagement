using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Data.SqlClient;
using StudentManagement.BS_Layer;
using StudentManagement.DB_Layer;
namespace StudentManagement.Student
{
    public partial class PrintStudent : Form
    {
        DataTable dtListst = null;
        BLStudent dbStudent = new BLStudent();
        StudentExport export = new StudentExport();
        public PrintStudent()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dtListst = new DataTable();
            dtListst.Clear();
            DataSet ds = dbStudent.GetStudent();
            dtListst = ds.Tables[0];
            dgPrintStudent.DataSource = dtListst;
            rbNo.Checked = true;
            rbAll.Checked = true;
            dtFirst.Enabled = false;
            dtSecond.Enabled = false;
        }
        private void btCheck_Click(object sender, EventArgs e)
        {
            string check;
            if (rbNo.Checked)
            {
                if (rbMale.Checked)
                {
                    check = "Male";
                    
                }
                else if (rbFemale.Checked)
                {
                    check = "Female";
                    
                }
                else
                {
                    check = "All";
                }
                dtListst = new DataTable();
                dtListst.Clear();
                DataSet ds = dbStudent.Getgender(check);
                dtListst = ds.Tables[0];
                dgPrintStudent.DataSource = dtListst;
            }
            else
            {
                if (rbMale.Checked)
                {
                    check = "Male";

                }
                else if (rbFemale.Checked)
                {
                    check = "Female";

                }
                else
                {
                    check = "All";
                }
                dtListst = new DataTable();
                dtListst.Clear();
                DataSet ds = dbStudent.Getgenderwithrange(check,dtFirst.Value.ToString(),dtSecond.Value.ToString());
                dtListst = ds.Tables[0];
                dgPrintStudent.DataSource = dtListst;
            }
            

        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            dtFirst.Enabled = true;
            dtSecond.Enabled = true;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            dtFirst.Enabled = false;
            dtSecond.Enabled = false;
        }
        #region rationCheck
        private void rbMale_Click(object sender, EventArgs e)
        {
            rbMale.Checked = true;
            rbAll.Checked = false;
            rbFemale.Checked = false;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            rbAll.Checked = false;
            rbMale.Checked = false;
            rbFemale.Checked = true;
        }

        private void rbAll_Click(object sender, EventArgs e)
        {
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbAll.Checked = true;
        }
        #endregion

        private void btWord_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgPrintStudent.Rows.Count > 0)
                {
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        export.exportDataToWord(dgPrintStudent, saveFileDialog1.FileName);
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
            System.Data.DataTable dt = (System.Data.DataTable)dgPrintStudent.DataSource;
            try
            {
                if (dgPrintStudent.Rows.Count > 0)
                {
                    saveFileDialog1.Filter = "Excel (.xlsx)|.xlsx";
                    saveFileDialog1.FileName = ".xlsx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        export.exportDataToExcel(dt, "Student", "Student List", saveFileDialog1.FileName);
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
            if (dgPrintStudent.Rows.Count > 0)
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
                            export.exportDataToPDF(dgPrintStudent, saveFileDialog1.FileName);
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
    }
}
