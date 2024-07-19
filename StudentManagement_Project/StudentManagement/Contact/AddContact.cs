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

namespace StudentManagement.Contact
{
    public partial class AddContact : Form
    {
        MyContact contact = new MyContact();
        Group group = new Group();
        string err;
        DataTable dt = null;
        public AddContact()
        {
            InitializeComponent();
        }

        private void AddContact_Load(object sender, EventArgs e)
        {
            getGroup();
        }
        bool verIf()
        {
            if (txtBoxFname.Text.Trim() == "" || txtBoxLname.Text.Trim() == "" || txtBoxEmail.Text.Trim() == "" || comboBoxGroup.Text.Trim() == "" || txtBoxPhone.Text.Trim() == "" || txtBoxAddress.Text.Trim() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void getGroup()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = group.getGroup(Global.GlobalUserID);
            dt = ds.Tables[0];
            comboBoxGroup.DataSource = dt;
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "id";
            comboBoxGroup.SelectedItem = null;
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            if (verIf())
            {
                MessageBox.Show("Please fill in all the information!", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string fname = txtBoxFname.Text;
                string lname = txtBoxLname.Text;
                int groupid = Convert.ToInt32(comboBoxGroup.SelectedValue.ToString().Trim());
                string phone = txtBoxPhone.Text;
                string email = txtBoxEmail.Text;
                string address = txtBoxAddress.Text;
                if (!contact.MailGroupexist(groupid, email, "add"))
                {
                    try
                    {
                       
                        if (contact.AddContact(fname, lname, groupid, phone, email, address, Global.GlobalUserID,ref err))
                        {
                            txtBoxFname.Clear();
                            txtBoxLname.Clear();
                            txtBoxEmail.Clear();
                            txtBoxAddress.Clear();
                            txtBoxPhone.Clear();
                            comboBoxGroup.SelectedItem = null;
                            
                            MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Email already exists in group " + comboBoxGroup.Text + "!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
