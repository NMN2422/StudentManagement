using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.BS_Layer;

namespace StudentManagement.Account
{
    public partial class CreateAccount : Form
    {
        AccountLogin account = new AccountLogin();
        HrLogin hr = new HrLogin();
        string err;
        public CreateAccount()
        {
            InitializeComponent();
        }
        public int verif()
        {
            if (tbUsername.Text.Trim() == "" || tbEmail.Text.Trim() == "" || tbPassword.Text.Trim() == "" || tbFname.Text.Trim() == "" || tbLname.Text.Trim() == "")
            {
                return 0;
            }
            else if (tbConfirmpass.Text.Trim() == "")
            {
                return 2;
            }
            else if (tbConfirmpass.Text.Trim() != tbPassword.Text.Trim())
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }
        public void clearFields()
        {
            tbFname.Clear();
            tbLname.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            tbConfirmpass.Clear();
            tbEmail.Clear();
            rbHr.Checked = false;
            rbStudent.Checked = false;
            
        }
        private void CreateAccount_Load(object sender, EventArgs e)
        {


        }

        private void lbSignin_Click(object sender, EventArgs e)
        {
            Hide();
            Application.Restart();
        }

        private void btSignup_Click(object sender, EventArgs e)
        {
            string user = tbUsername.Text;
            string confirm = tbConfirmpass.Text;
            string mail = tbEmail.Text;
            string fname = tbFname.Text;
            string lname = tbLname.Text;
            if (verif() == 0)
            {
                MessageBox.Show("Please fill in all the information!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 2)
            {
                MessageBox.Show("Please Enter The Confirmation Password.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif() == 3)
            {
                MessageBox.Show("Confirmation password does not match.\nPlease re-enter the confirmation password!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (account.checkUser(user) == true || hr.Userexist(user, "register") == true)
            {
                MessageBox.Show("Username was existed", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                if (!tbEmail.Text.Contains('@') || !tbEmail.Text.Contains('.'))
                {
                    MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    if (rbStudent.Checked == false && rbHr.Checked == false)
                    {
                        MessageBox.Show("Please select user type!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (rbStudent.Checked)
                    {
                        try
                        {
                            if (account.AddAcc(fname, lname, user, confirm, mail,ref err))
                            {
                                clearFields();
                                MessageBox.Show("Registered An Account Successfully.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                Application.Restart();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else if (rbHr.Checked)
                    {
                        try
                        {
                            if (hr.AddHr(fname, lname, user, confirm, mail,ref err))
                            {
                                clearFields();
                                MessageBox.Show("Registered An Account Successfully.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                Application.Restart();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }
    }
}
