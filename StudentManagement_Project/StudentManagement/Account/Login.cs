using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.BS_Layer;
namespace StudentManagement.Account
{
    public partial class Login : Form
    {
        DataTable dtListsc = null;
        AccountLogin acc = new AccountLogin();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        bool verif()
        {
            if (tbUsername.Text.Trim() == "" || tbPassword.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                {
                    return true;
                }
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            string permission = "HumanResourse";
            if (!verif())
            {
                MessageBox.Show("Please enter your account and password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rbStudent.Checked == false && rbHr.Checked == false)
            {
                MessageBox.Show("Please select the permission to login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (rbHr.Checked)
                    {
                        permission = "HumanResource";//xac dinh bang can lay tt
                    }
                    else
                    {
                        permission = "Login";
                    }
                    //
                    string user = tbUsername.Text;
                    string pass= tbPassword.Text;
                    dtListsc = new DataTable();
                    dtListsc.Clear();
                    DataSet ds = acc.getdatalogin(permission,user,pass);
                    dtListsc = ds.Tables[0];
                    if (dtListsc.Rows.Count > 0)
                    {
                        int userID = Convert.ToInt32(dtListsc.Rows[0][0].ToString());
                        string username = dtListsc.Rows[0][3].ToString().Trim();
                        Global.SetGlobalUserID(userID);//**********
                        Global.SetGlobalUsername(username);
                        tbPassword.Clear();
                        tbUsername.Clear();
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Please check Username or Password again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btCreateAc_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount crt = new CreateAccount();
            crt.ShowDialog();
        }

        private void btForgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPass fp = new ForgotPass();
            fp.ShowDialog();
        }

       
    }
}
