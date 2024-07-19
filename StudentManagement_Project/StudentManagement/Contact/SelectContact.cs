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
    public partial class SelectContact : Form
    {
        MyContact contact = new MyContact();
        string err;
        DataTable dt = null;
        int a;

        public SelectContact()
        {
            InitializeComponent();
        }

        private void SelectContact_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Clear();
            string sql = "SELECT id AS [Contact ID], CONCAT(fname,' ',lname) AS [Full Name], group_id AS [Group ID] FROM MyContact WHERE userid =";
            DataSet ds = contact.selectContactlst(sql,Global.GlobalUserID);
            dt = ds.Tables[0];
            dataGridView.DataSource = dt;
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
        }
        public int getid()
        {
            int b = a;
            return b;
        }


    }
}
