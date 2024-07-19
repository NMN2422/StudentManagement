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

namespace StudentManagement.Result
{
    public partial class StatisticResult : Form
    {
        BLCourse dbCourse = new BLCourse();
        BLScore dbScore = new BLScore();
        BLStudent dbStudent = new BLStudent();
        DataTable dtListsc = null;
        public StatisticResult()
        {
            InitializeComponent();
        }

        private void StatisticResult_Load(object sender, EventArgs e)
        {
            dtListsc = new DataTable();
            dtListsc.Clear();
            DataSet ds = dbScore.getaverageScoreAllcourse();
            dtListsc = ds.Tables[0];
            foreach(DataRow row in dtListsc.Rows)
            {
                Label coursename = new Label();
                coursename.Text = row["Course Name"].ToString().Trim() + ": " + String.Format("{0:0.00}", Convert.ToDouble(row["Average Score By Course"].ToString().Trim()));
                this.flowLayoutPanelCourse.Controls.Add(coursename);
                resultChart.Series.Add(row["Course Name"].ToString().Trim());
                resultChart.Series[row["Course Name"].ToString().Trim()].Points.AddY(Convert.ToDouble(row[1].ToString()));
            }
            resultChart.Series.Add("Maximum Score");
            resultChart.Series["Maximum Score"].Points.AddY(10);
            double numpass = dbScore.getStudentPass();
            double numfail = dbScore.getStudentFail();
            labelPass.Text = "Pass:" + String.Format("{0:0.00}", (numpass * 100 / (numpass + numfail))) + "%";
            labelFail.Text = "Fail:" + String.Format("{0:0.00}", (numfail * 100 / (numpass + numfail))) + "%";
            double numExcellent = (double)dbScore.getRateStd(10, 9) * 100 / (numpass + numfail);
            double numGood = (double)dbScore.getRateStd(9, 8) * 100 / (numpass + numfail);
            double numFairlyGood = (double)dbScore.getRateStd(8, 7) * 100 / (numpass + numfail);
            double numAverage = (double)dbScore.getRateStd(7, 5) * 100 / (numpass + numfail);
            double numWeak = numfail * 100 / (numpass + numfail);
            labelExcellent.Text = "Excellent: " + String.Format("{0:0.00}", numExcellent) + " %";
            labelGood.Text = "Good: " + String.Format("{0:0.00}", numGood) + " %";
            labelFairlyGood.Text = "Fairly Good: " + String.Format("{0:0.00}", numFairlyGood) + " %";
            labelAverage.Text = "Average: " + String.Format("{0:0.00}", numAverage) + " %";
            labelWeak.Text = "Weak: " + String.Format("{0:0.00}", numWeak) + " %";
            chartResult.Series["Result"].Points.AddXY("Pass", numpass);
            chartResult.Series["Result"].Points.AddXY("Fail", numfail);
            string[] rate = new string[] { "Excellent", "Good", "Fairly Good", "Average", "Weak" };
            double[] rating = new double[] { numExcellent, numGood, numFairlyGood, numAverage, numWeak };
            for (int i = 0; i < 5; i++)
            {
                chartRating.Series.Add(rate[i]).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
                chartRating.Series[rate[i]].Points.AddY(rating[i]);
            }
        }
    }
}
