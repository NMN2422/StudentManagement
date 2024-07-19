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
using StudentManagement.Contact;
namespace StudentManagement.HR
{
    public partial class HRmain : Form
    {

        Group group = new Group();
        MyContact contact=new MyContact();
        DataTable dt = null,dt2=null;
        HrLogin hr = new HrLogin();
        string err;
        int id;// for select contact
        public HRmain()
        {
            InitializeComponent();
        }

        private void HRmain_Load(object sender, EventArgs e)
        {
            getgroup();
            getUsername();
            getcontact();
        }
        public void getUsername()
        {
            string sql = "SELECT * FROM HumanResource WHERE id =" + Global.GlobalUserID;
            dt = new DataTable();
            dt.Clear();
            DataSet ds = hr.getuser(sql);
            dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                
                string fname = (string)dt.Rows[0]["f_name"];
                string lname = (string)dt.Rows[0]["l_name"];
                labelWelcome.Text = "Welcome Back " + fname.Trim() + " " + lname.Trim();
            }
        }
        public void getcontact()
        {
            string sql = "SELECT * FROM MyContact WHERE userid =" + Global.GlobalUserID;
            dt = new DataTable();
            dt.Clear();
            DataSet ds = contact.selectContactlst(sql);
            dt = ds.Tables[0];
            cbRemove.DataSource = dt;
            cbRemove.DisplayMember = "id";
            cbRemove.ValueMember = "id";
        }

        public void getgroup()
        {
            dt2 = new DataTable();
            dt2.Clear();
            DataSet ds = group.getGroup(Global.GlobalUserID);
            dt2 = ds.Tables[0];
            txtBoxAddGroupName.Clear();
            txtBoxNewGroupName.Clear();
            comboBoxGroupNameEdit.DataSource = dt2;
            comboBoxGroupNameEdit.DisplayMember = "name";
            comboBoxGroupNameEdit.ValueMember = "id";
            comboBoxGroupNameEdit.SelectedItem = null;
            comboBoxSelectGroupRemove.DataSource = dt2;
            comboBoxSelectGroupRemove.DisplayMember = "name";
            comboBoxSelectGroupRemove.ValueMember = "id";
            comboBoxSelectGroupRemove.SelectedItem = null;
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            string groupName = txtBoxAddGroupName.Text.Trim();
            if (!groupName.Trim().Equals(""))
            {
                if (!group.GroupNameexist(groupName, "add", Global.GlobalUserID))
                {
                    try
                    {
                        if (group.AddGroup(groupName, Global.GlobalUserID,ref err))
                        {
                            getgroup();
                            MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("The group name already exists.\nPlease enter another group name!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter the name of the group you want to add!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void editGroupButton_Click(object sender, EventArgs e)
        {
            string newGroupName = txtBoxNewGroupName.Text.Trim();
            int groupID = Convert.ToInt32(comboBoxGroupNameEdit.SelectedValue.ToString().Trim());
            if (!newGroupName.Trim().Equals(""))
            {
                try
                {
                    if (!group.GroupNameexist(newGroupName, "edit", Global.GlobalUserID, groupID))
                    {
                        try
                        {
                            if (group.UpdateGroup(newGroupName, groupID,ref err))
                            {
                                getgroup();
                                MessageBox.Show("Group Edited", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("The group name already exists.\nPlease enter another group name!", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter the name of the group you want to edit!", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void removeGroupButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Group", "Remove Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (group.RemoveGroup(Convert.ToInt32(comboBoxSelectGroupRemove.SelectedValue.ToString().Trim()),ref err))
                    {
                        getgroup();
                        MessageBox.Show("Group Deleted", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void removeContactButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Contact", "Remove Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (contact.RemoveContact(Convert.ToInt32(cbRemove.Text.Trim()), ref err))
                    {
                        MessageBox.Show("Contact Deleted", "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void showFullListButton_Click(object sender, EventArgs e)
        {
            ShowFullContact showFullContact = new ShowFullContact();
            showFullContact.ShowDialog();
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            AddContact addContactForm = new AddContact();
            addContactForm.ShowDialog();
        }

        private void editContactButton_Click(object sender, EventArgs e)
        {
            EditContact editContactForm = new EditContact();

            editContactForm.ShowDialog();
        }

        private void selectContactButton_Click(object sender, EventArgs e)
        {
            SelectContact selectContact= new SelectContact();
            
            
            if (selectContact.ShowDialog() == DialogResult.Cancel)
            {
                id = selectContact.getid();
                cbRemove.Text = id.ToString();
            }
            

        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Application.Restart();
        }

        private void labelRefresh_Click(object sender, EventArgs e)
        {
            getUsername();
        }

        private void labelEditInfo_Click(object sender, EventArgs e)
        {
            EditInfo editMyInfo = new EditInfo();
            editMyInfo.ShowDialog(this);
        }
    }
}
