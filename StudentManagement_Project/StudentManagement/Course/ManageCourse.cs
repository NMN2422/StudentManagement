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

namespace StudentManagement.Course
{
    public partial class ManageCourse : Form
    {
        bool check;
        string err;
        int index;
        string data;
        DataTable dtListc = null;
        BLCourse dbCourse = new BLCourse();
       
        public ManageCourse()
        {
            InitializeComponent();
        }

        private void ManageCourse_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            dtListc = new DataTable();
            dtListc.Clear();
            DataSet ds = dbCourse.GetCourse();
            dtListc = ds.Tables[0];
            lbCourse.DataSource = dtListc;
            lbCourse.ValueMember = "id";
            lbCourse.DisplayMember = "label";
            //lbCourse.SelectedItem = null;
            int r = dtListc.Rows.Count;
            lbTotal.Text = "Total Course:" + r;
            //
            tbCourseid.ResetText();
            tbCoursename.ResetText();
            tbDescrip.ResetText();
            numPeriod.ResetText();
            //
            btCancel.Enabled = false;
            btUpdate.Enabled = false;
            panel1.Enabled = false;
            //
            btRemove.Enabled = true;
            btAdd.Enabled = true;
            btEdit.Enabled = true;
        }
        public void showdata(int index)
        {
            DataRow dr = dtListc.Rows[index];
            tbCourseid.Text = dr.ItemArray[0].ToString();
            tbCoursename.Text = dr.ItemArray[1].ToString();
            numPeriod.Value = int.Parse(dr.ItemArray[2].ToString());
            tbDescrip.Text = dr.ItemArray[3].ToString();
        }

        private void lbCourse_Click(object sender, EventArgs e)
        {
            index = lbCourse.SelectedIndex;
            showdata(index);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            check = true;
            int tmp = dtListc.Rows.Count + 1;
            tbCourseid.Text = tmp.ToString();
            tbCoursename.ResetText();
            tbDescrip.ResetText();
            numPeriod.ResetText();
            //
            btUpdate.Enabled = true;
            btCancel.Enabled = true;
            panel1.Enabled = true;
            //
            btEdit.Enabled = false;
            btRemove.Enabled = false;
            btAdd.Enabled = false;

            tbDescrip.Focus();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            check = false;
            panel1.Enabled = true;
            int r = lbCourse.SelectedIndex;
            tbCourseid.Text = dtListc.Rows[r].ItemArray[0].ToString();
            //accept cancel/update
            btUpdate.Enabled = true;
            btCancel.Enabled = true;
            //reject
            btEdit.Enabled = false;
            btRemove.Enabled = false;
            btAdd.Enabled = false;
            tbCourseid.Enabled = false;
            //
            tbCoursename.Focus();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int r = lbCourse.SelectedIndex;
                int id=int.Parse(dtListc.Rows[r].ItemArray[0].ToString());
                
                DialogResult confirm;
                confirm = MessageBox.Show("Are you sure?", "Answer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK)
                {
                    dbCourse.RemoveCourse(id, ref err);
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
                string cname = tbCoursename.Text;
                int cid = Convert.ToInt32(tbCourseid.Text);
                //ktra co course nay hay chua
                dtListc = new DataTable();
                dtListc.Clear();
                DataSet ds = dbCourse.checkCourseName(cname,cid);
                dtListc = ds.Tables[0];
                if (dtListc.Rows.Count == 0)//neu ko coo
                {
                        try
                        {
                            BLCourse tmp = new BLCourse();
                            tmp.AddCourse(cid, cname, Convert.ToInt32(this.numPeriod.Value), this.tbDescrip.Text, ref err);
                            LoadData();
                            MessageBox.Show("Complete","Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Cannot Add","Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                }
                else//neu co roi
                {
                  MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                                     
                
            }
            else //sua
            {
                try
                {
                    BLCourse tmp = new BLCourse();
                    tmp.UpdateCourse(Convert.ToInt32(tbCourseid.Text), tbCoursename.Text.Trim(), Convert.ToInt32(this.numPeriod.Value), this.tbDescrip.Text.Trim(), ref err);
                    LoadData();
                    MessageBox.Show("Complete", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Can not Update");
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbCourseid.ResetText();
            tbCoursename.ResetText();
            tbDescrip.ResetText();
            numPeriod.ResetText();
            //
            btCancel.Enabled = false;
            btUpdate.Enabled = false;
            panel1.Enabled = false;
            //
            btEdit.Enabled = true;
            btRemove.Enabled = true;
            btAdd.Enabled = true;
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            lbCourse.SelectedIndex = index;
            showdata(index);
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index -= 1;
                lbCourse.SelectedIndex = index;
                showdata(index);
            }
            else
            {
                MessageBox.Show("This is the first course", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (index<(dtListc.Rows.Count-1))
            {
                index += 1;
                lbCourse.SelectedIndex = index;
                showdata(index);
            }
            else
            {
                MessageBox.Show("This is the last course", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void btLast_Click(object sender, EventArgs e)
        {
            index = dtListc.Rows.Count - 1;
            lbCourse.SelectedIndex = index;
            showdata(index);
        }
        private void lbCourse_DoubleClick(object sender, EventArgs e)
        {
            DataSet tmp, tmp1;
            tmp = dbCourse.GetCourseByID(Convert.ToInt32(lbCourse.SelectedValue));
            tmp1 = dbCourse.GetStudentByCourse(Convert.ToInt32(lbCourse.SelectedValue));
            ListStudentByCourse lst = new ListStudentByCourse();
            DataTable dt=new DataTable(), dt1=new DataTable();
            dt = tmp.Tables[0];
            dt1 = tmp1.Tables[0];
            lst.dataGridView1.DataSource = dt1;

            lst.lbCourse.Text = "Course Name:" + dt.Rows[0]["label"].ToString();
            lst.ShowDialog();
           
        }
    }
}
