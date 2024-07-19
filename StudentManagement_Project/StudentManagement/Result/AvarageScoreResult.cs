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
using System.IO;
using StudentManagement.DB_Layer;
using StudentManagement.BS_Layer;

namespace StudentManagement.Result
{
    public partial class AvarageScoreResult : Form
    {
        DataTable dtList = null,dttmp=null;
        BLResult dbResult = new BLResult();
        ResultExport exportToWord=new ResultExport();
        public AvarageScoreResult()
        {
            InitializeComponent();
        }

        private void AvarageScore_Load(object sender, EventArgs e)
        {
            string course = insert();
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dtList.Clear();
            DataSet ds = dbResult.GetSdata(course);
            dtList = ds.Tables[0];
            dataGridView1.DataSource = dtList;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns.Add("Result", "Result");
            int count = dataGridView1.Columns.Count;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[count - 2].Value) >= 5)
                    dataGridView1.Rows[i].Cells[count - 1].Value = "Passed";
                else
                    dataGridView1.Rows[i].Cells[count - 1].Value = "Failed";
            }
            for(int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            tbResult.Enabled = false;
            tbStid.Enabled = false;
            tbAvg.Enabled = false;
            

        }
        public string insert()
        {
            string tmp = "select [label] from Course";
            string chuoi = "";
            dtList = new DataTable();
            dtList.Clear();
            DataSet ds = dbResult.GetDataFromCM(tmp);
            dtList = ds.Tables[0];
            dataGridView1.DataSource = dtList;
            int a = dataGridView1.RowCount - 1;
            for(int i = 0; i < a; i++)
            {
                chuoi += "[" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "], ";
            }
            chuoi += "[" + dataGridView1.Rows[a].Cells[0].Value.ToString() + "]";
            //MessageBox.Show(chuoi);
            return chuoi;

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Columns.Count;
            tbStid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbAvg.Text = dataGridView1.CurrentRow.Cells[count - 2].Value.ToString();
            tbResult.Text = dataGridView1.CurrentRow.Cells[count - 1].Value.ToString();
        }


        

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Remove("Result");//tren kia add thi cai nay xoa di ??
                string course = insert();
                string tmp = tbSearch.Text.Trim();
                //
                dataGridView1.ReadOnly = true;
                dataGridView1.RowTemplate.Height = 80;
                //dtList.Clear();
                DataSet ds = dbResult.DataSearch(course, tmp);
                //dtList = ds.Tables[0];
                /*dataGridView1.DataSource = dtList;*/ //???????
                dataGridView1.AllowUserToAddRows = false;
                //
                dttmp = new DataTable();
                dttmp.Clear();
                dttmp = ds.Tables[0];
                dataGridView1.DataSource = dttmp;
                dttmp.Columns.Add("Result");
                int end = dataGridView1.Columns.Count;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[end - 2].Value) >= 5)
                    {
                        dttmp.Rows[i]["Result"] = "Pass";

                    }
                    else
                    {
                        dttmp.Rows[i]["Result"] = "Failed";
                    }
                }
                dataGridView1.Columns.RemoveAt(0);
                if (dttmp.Rows.Count > 0)
                {
                    int end1 = dataGridView1.Columns.Count;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[end1 - 2].Value) >= 5)
                        {
                            dttmp.Rows[i]["Result"] = "Pass";
                            dataGridView1.Rows[i].Cells[end1 - 1].Value = dttmp.Rows[i]["Result"].ToString();

                        }
                        else
                        {
                            dttmp.Rows[i]["Result"] = "Failed";
                            dataGridView1.Rows[i].Cells[end1 - 1].Value = dttmp.Rows[i]["Result"].ToString();
                        }
                    }
                }
                dataGridView1.DataSource = null; // reset bang truoc khi load.
                dataGridView1.DataSource = dttmp;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

            
        }
    }
}
