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

namespace StudentManagement.Score
{
    public partial class ManageScore : Form
    {
        bool check;
        string err;
        int index;
        string data = "Score";
        DataTable dtListsc = null,dtListcourse=null,dtLststu=null;
        BLCourse dbCourse = new BLCourse();
        BLScore dbScore = new BLScore();
        BLStudent dbStudent = new BLStudent();
        public ManageScore()
        {
            InitializeComponent();
        }

        private void ManageScore_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            dtListcourse = new DataTable();
            dtListcourse.Clear();
            DataSet ds = dbCourse.GetCourse();
            dtListcourse = ds.Tables[0];
            cbCourse.DataSource = dtListcourse;
            cbCourse.ValueMember = "id";
            cbCourse.DisplayMember = "label";
            //lbCourse.SelectedItem = null;
            //datagridview
            dtListsc = new DataTable();
            dtListsc.Clear();
            ds = dbScore.GetScore();
            dtListsc = ds.Tables[0];
            dataGridView1.DataSource = dtListsc;
            //
            dtLststu = new DataTable();
            dtLststu.Clear();
            ds = dbStudent.GetStudentForScore();
            dtLststu = ds.Tables[0];
                

            //
            showdata();
            cbCourse.SelectedIndex = -1;
            //
            tbStid.ResetText();
            cbCourse.ResetText();
            tbScore.ResetText();
            tbDescription.ResetText();
            //
            btCancel.Enabled = false;
            btUpdate.Enabled = false;
            panel1.Enabled = false;
            //
            btRemove.Enabled = true;
            btAdd.Enabled = true;
            btEdit.Enabled = true;
        }
        public void showdata()
        {
            if (data == "Student")
            {
                tbStid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            }
            else if(data=="Score")
            {
                tbStid.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbCourse.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
                tbScore.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
                tbDescription.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            check = true;
            tbStid.ResetText();
            cbCourse.ResetText();
            tbScore.ResetText();
            tbDescription.ResetText();
            if (tbStid.Enabled == false)
            {
                tbStid.Enabled = true;
            }
            if (cbCourse.Enabled == false)
            {
                cbCourse.Enabled = true;
            }
            //
            btUpdate.Enabled = true;
            btCancel.Enabled = true;
            panel1.Enabled = true;
            //
            btEdit.Enabled = false;
            btRemove.Enabled = false;
            btAdd.Enabled = false;
            //
            tbStid.Focus();
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            check = false;
            panel1.Enabled = true;
            int r = dataGridView1.CurrentCell.RowIndex;
            tbStid.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            tbStid.Enabled = false;
            cbCourse.Enabled = false;
           
            //accept cancel/update
            btUpdate.Enabled = true;
            btCancel.Enabled = true;
            //reject
            btEdit.Enabled = false;
            btRemove.Enabled = false;

            btAdd.Enabled = false;
            tbStid.Enabled = false;
            //
            cbCourse.Focus();
        }
        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int std=0, course=0;
                if (data == "Student")
                {
                    MessageBox.Show("Please choose Show Score");

                }
                else
                {
                    std = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    course = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    DialogResult confirm;
                    confirm = MessageBox.Show("Are you sure?", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (confirm == DialogResult.OK)
                    {
                        dbScore.RemoveScore(std, course, ref err);
                        LoadData();
                        MessageBox.Show("Delete Complete");
                    }
                    else
                    {

                    }
                }               
               
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }
        }
        public bool verify()
        {
            if (tbStid.Text.Trim() == "" || cbCourse.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            int std = Convert.ToInt32(tbStid.Text);
            int course = Convert.ToInt32(cbCourse.SelectedValue);
            double stdscore = Convert.ToDouble(tbScore.Text);
            string des = tbDescription.Text;
            if (check)
            {
                
                if (verify())
                {
                    try //them
                    {
                        dbScore.AddScore(std, course, stdscore, des, ref err);
                        LoadData();
                        MessageBox.Show("Complete");

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Can not Add");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Student ID and select Course.", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else //sua
            {
                if (verify())
                {
                    try //them
                    {
                        dbScore.UpdateScore(std, course,stdscore,des, ref err);
                        LoadData();
                        MessageBox.Show("Complete");

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Can not Update");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Student ID and select Course.", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbStid.ResetText();
            cbCourse.ResetText();
            tbScore.ResetText();
            tbDescription.ResetText();
            btCancel.Enabled = false;
            btUpdate.Enabled = false;
            panel1.Enabled = false;
            //
            btEdit.Enabled = true;
            btRemove.Enabled = true;
            btAdd.Enabled = true;
        }


        #region support
        private void btShowscore_Click(object sender, EventArgs e)
        {
            data = "Score";
            
            LoadData();
            
        }

        private void btAverage_Click(object sender, EventArgs e)
        {
            AverageScore avg = new AverageScore();
            avg.Show();
        }

       
        private void btShowstudent_Click(object sender, EventArgs e)
        {
            data = "Student";
            LoadData();
            dataGridView1.DataSource = dtLststu;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            showdata();
        }
        #endregion
    }
}
