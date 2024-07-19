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
    public partial class AverageScore : Form
    {
        BLScore dbScore =new BLScore();
        DataTable dtListsc = null;
        public AverageScore()
        {
            InitializeComponent();
        }

        private void AverageScore_Load(object sender, EventArgs e)
        {
            dtListsc = new DataTable();
            dtListsc.Clear();
            DataSet ds = dbScore.getaverageScoreAllcourse();
            dtListsc = ds.Tables[0];
            dataGridView1.DataSource = dtListsc;
        }
    }
}
