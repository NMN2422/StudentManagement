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
    public partial class EditContact : Form
    {
        MyContact contact = new MyContact();
        Group group = new Group();
        string err;
        DataTable dt = null;
        int id;
        public EditContact()
        {
            InitializeComponent();
        }

        private void EditContact_Load(object sender, EventArgs e)
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
        public void fillSelectContact()
        {
            SelectContact selectContact = new SelectContact();


            if (selectContact.ShowDialog() == DialogResult.Cancel)
            {
                id = selectContact.getid();
                txtContactID.Text = id.ToString();
            }
            
            string sql = "SELECT * FROM MyContact WHERE id=" + id;
            dt = new DataTable();
            dt.Clear();
            DataSet ds = contact.selectContactlst(sql);
            dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                txtBoxFname.Text = dt.Rows[0]["fname"].ToString().Trim();
                txtBoxLname.Text = dt.Rows[0]["lname"].ToString().Trim();
                txtBoxEmail.Text = dt.Rows[0]["email"].ToString().Trim();
                txtBoxAddress.Text = dt.Rows[0]["address"].ToString().Trim();
                txtBoxPhone.Text = dt.Rows[0]["phone"].ToString().Trim();
                comboBoxGroup.SelectedValue = Convert.ToInt32(dt.Rows[0]["group_id"].ToString().Trim());
                               
            }
        }

        private void selectContactButton_Click(object sender, EventArgs e)
        {
            fillSelectContact();
        }

        private void editContactButton_Click(object sender, EventArgs e)
        {
            int contactID = Convert.ToInt32(txtContactID.Text);
            string fname = txtBoxFname.Text;
            string lname = txtBoxLname.Text;
            int groupid = Convert.ToInt32(comboBoxGroup.SelectedValue.ToString().Trim());
            string phone = txtBoxPhone.Text;
            string email = txtBoxEmail.Text;
            string address = txtBoxAddress.Text;
            
            if (verIf())
            {
                MessageBox.Show("Please fill in all the information!", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (!contact.MailGroupexist(groupid, email, "edit", contactID))
                {
                    try
                    {
                        
                        if (contact.UpdateContact(contactID, fname, lname, groupid, phone, email, address,ref err))
                        {
                            txtBoxFname.Clear();
                            txtBoxLname.Clear();
                            txtBoxEmail.Clear();
                            txtBoxAddress.Clear();
                            txtBoxPhone.Clear();
                            comboBoxGroup.SelectedItem = null;
                            txtContactID.Clear();
                            MessageBox.Show("Contact Edited", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Email already exists in group " + comboBoxGroup.Text + "!", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
