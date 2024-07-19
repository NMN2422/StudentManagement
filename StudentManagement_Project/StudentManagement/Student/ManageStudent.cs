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
using StudentManagement.BS_Layer;
using StudentManagement.DB_Layer;
namespace StudentManagement.Student
{
    public partial class ManageStudent : Form
    {
        bool check;
        string err;
        DataTable dtListst = null;
        BLStudent dbStudent = new BLStudent();
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtListst = new DataTable();
                dtListst.Clear();
                DataSet ds = dbStudent.GetStudent();
                dtListst = ds.Tables[0];
                dgManageStudent.DataSource = dtListst;
                tbStid.ResetText();
                tbFname.ResetText();
                tbLname.ResetText();
                dtBirth.ResetText();
                tbPhone.ResetText();
                rbFemale.Checked = false;
                rbMale.Checked = false;
                tbAddress.ResetText();

                
                btCancel.Enabled = false;
                btUpdate.Enabled = false;
                panel1.Enabled = false;
                
                btRemove.Enabled = true;              
                btAdd.Enabled = true;
                btEdit.Enabled = true;
                
                int count = dgManageStudent.Rows.Count - 1;
                lbTotal.Text = ("Total Student:" + count);


            }
            catch (SqlException)
            {
                MessageBox.Show("Can not get data");
            }
            
        }
        public void showdata()
        {
            tbStid.Text= dgManageStudent.CurrentRow.Cells[0].Value.ToString();
            tbFname.Text= dgManageStudent.CurrentRow.Cells[1].Value.ToString();
            tbLname.Text= dgManageStudent.CurrentRow.Cells[2].Value.ToString();
            dtBirth.Text= dgManageStudent.CurrentRow.Cells[3].Value.ToString();
            if (dgManageStudent.CurrentRow.Cells[4].Value.ToString().Trim() == "Female")
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }
            tbPhone.Text= dgManageStudent.CurrentRow.Cells[5].Value.ToString();
            tbAddress.Text= dgManageStudent.CurrentRow.Cells[6].Value.ToString();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            check = true;
            //clear panel
            tbStid.ResetText();
            tbFname.ResetText();
            tbLname.ResetText();
            dtBirth.ResetText();
            tbPhone.ResetText();
            rbFemale.Checked = false;
            rbMale.Checked = false;
            tbAddress.ResetText();
            //enable button
            btUpdate.Enabled = true;
            btCancel.Enabled = true;
            panel1.Enabled = true;
            //disable some button
            btEdit.Enabled = false;
            btRemove.Enabled = false;
            btAdd.Enabled = false;

            tbStid.Focus();

        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            check = false;
            panel1.Enabled = true;
            int r = dgManageStudent.CurrentCell.RowIndex;
            tbStid.Text = dgManageStudent.Rows[r].Cells[0].Value.ToString();
            //accept cancel/update
            btUpdate.Enabled = true;
            btCancel.Enabled = true;
            //reject
            btEdit.Enabled = false;
            btRemove.Enabled = false;
            
            btAdd.Enabled = false;
            tbStid.Enabled = false;
            //
            tbFname.Focus();
        }
        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                
                int r = dgManageStudent.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dgManageStudent.Rows[r].Cells[0].Value.ToString());
                DialogResult confirm;
                confirm = MessageBox.Show("Are you sure?", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK)
                {
                    dbStudent.RemoveStudent(id, ref err);
                    LoadData();
                    MessageBox.Show("Delete Complete");
                }
                else
                {

                }
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }
            
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (check)
            {
                try //them
                {
                    BLStudent tmp = new BLStudent();
                    string gender = "Male";
                    if (rbFemale.Checked)
                    {
                        gender = "Female";
                    }
                    //Image img = pbStu.Image;
                    //ImageConverter convert = new ImageConverter();
                    //byte[] arr = (byte[])convert.ConvertTo(img, typeof(byte[]));
                    string st = "";
                    tmp.AddStudent(Convert.ToInt32(this.tbStid.Text.Trim()), this.tbFname.Text.Trim(), this.tbLname.Text.Trim(), this.dtBirth.Value.ToString(),
                        gender.Trim(), this.tbPhone.Text.Trim(), this.tbAddress.Text.Trim(), st, ref err);
                    LoadData();
                    MessageBox.Show("Complete");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Can not Add");
                }
            }
            else //sua
            {
                try
                {
                    BLStudent tmp = new BLStudent();
                    string gender = "Male";
                    if (rbFemale.Checked)
                    {
                        gender = "Female";
                    }
                    string st = "";
                    tmp.UpdateStudent(Convert.ToInt32(this.tbStid.Text.Trim()), this.tbFname.Text.Trim(), this.tbLname.Text.Trim(), this.dtBirth.Value.ToString(),
                        gender.Trim(), this.tbPhone.Text.Trim(), this.tbAddress.Text.Trim(), st, ref err);
                    LoadData();
                    MessageBox.Show("Complete!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Can not Update");
                }
            }
           
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbStid.ResetText();
            tbFname.ResetText();
            tbLname.ResetText();
            dtBirth.ResetText();
            tbPhone.ResetText();
            rbFemale.Checked = false;
            rbMale.Checked = false;
            tbAddress.ResetText();
            //
            btCancel.Enabled = false;
            btUpdate.Enabled = false;
            panel1.Enabled = false;
            //
            btEdit.Enabled = true;
            btRemove.Enabled = true;
            btAdd.Enabled = true;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the information you need to search!", "Search Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string tmp = tbSearch.Text;
                dtListst = new DataTable();
                dtListst.Clear();
                DataSet ds = dbStudent.SearchStudent(tmp);
                dtListst = ds.Tables[0];
                dgManageStudent.DataSource = dtListst;
                int count = dgManageStudent.Rows.Count - 1;
                lbTotal.Text = ("Total Student:" + count);
                tbSearch.Clear();
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tbStid_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ko cho nhap chu~
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ko cho nhap so
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgManageStudent_Click(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
