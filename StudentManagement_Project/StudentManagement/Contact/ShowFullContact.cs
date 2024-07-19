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
    public partial class ShowFullContact : Form
    {
        MyContact contact = new MyContact();
        Group group = new Group();
        int pos;
        string err;
        DataTable dt = null;
        public ShowFullContact()
        {
            InitializeComponent();
        }

        private void ShowFullContact_Load(object sender, EventArgs e)
        {
            getGroup();
            fillGrid("SELECT fname AS [First Name], lname AS [Last Name], [name] AS [Group Name], phone AS [Phone], email AS [Email], [address] AS [Address] " +
                "FROM MyContact INNER JOIN MyGroup ON MyContact.group_id = MyGroup.id and MyContact.userid = MyGroup.userid WHERE MyContact.userid=" + Global.GlobalUserID);
        }
        void getGroup()
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = group.getGroup(Global.GlobalUserID);
            dt = ds.Tables[0];
            listBoxGroup.DataSource = dt;
            listBoxGroup.ValueMember = "id";
            listBoxGroup.DisplayMember = "name";
            listBoxGroup.SelectedItem = null;
            //Show Total Group
            labelTotalGroup.Text = "Total Group: " + dt.Rows.Count;
        }
        public static bool IsOdd(int value)
        {
            return value % 2 == 0;
        }
        void fillGrid(string feature) //
        {
            dt = new DataTable();
            dt.Clear();
            DataSet ds = contact.selectContactlst(feature);
            dt = ds.Tables[0];
            dataGridView.ReadOnly = true;           
            dataGridView.RowTemplate.Height = 80;
            dataGridView.DataSource = dt;
           
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            dataGridView.AllowUserToAddRows = false;
        }

        private void listBoxGroup_Click(object sender, EventArgs e)
        {
            //display the selected course data
            pos = Convert.ToInt32(listBoxGroup.SelectedValue.ToString().Trim());
            fillGrid("SELECT fname AS [First Name], lname AS [Last Name], [name] AS [Group Name], phone AS [Phone], email AS [Email], [address] AS [Address] " +
                "FROM MyContact INNER JOIN MyGroup ON MyContact.group_id = MyGroup.id and MyContact.userid = MyGroup.userid WHERE MyContact.userid= " + Global.GlobalUserID + " and MyContact.group_id=" + pos);
        }

        private void showFullButton_Click(object sender, EventArgs e)
        {
            fillGrid("SELECT fname AS [First Name], lname AS [Last Name], [name] AS [Group Name], phone AS [Phone], email AS [Email], [address] AS [Address] " +
                "FROM MyContact INNER JOIN MyGroup ON MyContact.group_id = MyGroup.id and MyContact.userid = MyGroup.userid WHERE MyContact.userid=" + Global.GlobalUserID);
        }

        private void txtBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            fillGrid("SELECT fname AS [First Name], lname AS [Last Name], [name] AS [Group Name], phone AS [Phone], email AS [Email], [address] AS [Address] " +
                "FROM MyContact INNER JOIN MyGroup ON MyContact.group_id = MyGroup.id and MyContact.userid = MyGroup.userid WHERE MyContact.userid=" + Global.GlobalUserID + " and MyContact.[address] LIKE '%" + txtBoxSearch.Text.Trim() + "%'");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
