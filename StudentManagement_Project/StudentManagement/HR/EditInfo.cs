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
namespace StudentManagement.HR
{
    public partial class EditInfo : Form
    {
        MyContact contact = new MyContact();
        HrLogin hr = new HrLogin();
        string err;
        DataTable dt = null;
        public EditInfo()
        {
            InitializeComponent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string user = Global.GlobalUsername;
            string confirm = txtBoxConfirmPassword.Text;
            string mail = txtBoxEmail.Text;
            string fname = txtBoxFname.Text;
            string lname = txtBoxLname.Text;            
            if (verif() == 0)
            {
                MessageBox.Show("Please fill in all the information!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 4)
            {
                MessageBox.Show("Your old password does not match, please re-enter!", "Edit My Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 2)
            {
                MessageBox.Show("Please Enter The Confirmation Password.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 3)
            {
                MessageBox.Show("Confirmation password does not match.\nPlease re-enter the confirmation password!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
            else
            {

                if (!txtBoxEmail.Text.Contains('@') || !txtBoxEmail.Text.Contains('.'))
                {
                    MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    try
                    {
                        if (hr.UpdateHr(fname, lname, user, confirm, mail, ref err))
                        {
                            MessageBox.Show("Your Information Is Edited", "Edit  My Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit My Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit My Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }
        int verif()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = hr.GetHrbyID(Global.GlobalUserID);
            dt = ds.Tables[0];
            if (txtBoxUsername.Text.Trim() == "" || txtBoxEmail.Text.Trim() == "" || txtBoxPassword.Text.Trim() == "" || txtBoxFname.Text.Trim() == "" || txtBoxLname.Text.Trim() == "" || txtBoxOldPassword.Text.Trim() == "")
            {
                return 0;
            }
            else if (txtBoxOldPassword.Text != dt.Rows[0]["password"].ToString().Trim())
            {
                return 4;
            }
            else if (txtBoxConfirmPassword.Text.Trim() == "")
            {
                return 2;
            }
            else if (txtBoxConfirmPassword.Text.Trim() != txtBoxPassword.Text.Trim())
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }
        public void getInfo()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = hr.GetHrbyID(Global.GlobalUserID);
            dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {               
                string fname = (string)dt.Rows[0]["f_name"];
                string lname = (string)dt.Rows[0]["l_name"];
                string mail = (string)dt.Rows[0]["email"];
                txtBoxFname.Text = fname.Trim();
                txtBoxLname.Text = lname.Trim();
                txtBoxEmail.Text = mail.Trim();
                txtBoxUsername.Text = Global.GlobalUsername.Trim();
            }
        }

        private void EditInfo_Load(object sender, EventArgs e)
        {
            getInfo();
        }
    }
}
