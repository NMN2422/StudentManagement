
namespace StudentManagement.Student
{
    partial class StatisticGender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.lblFemale = new System.Windows.Forms.Label();
            this.genderStudentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panTotalFemaleStudent = new System.Windows.Forms.Panel();
            this.panTotalMaleStudent = new System.Windows.Forms.Panel();
            this.panTotalStudent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.genderStudentChart)).BeginInit();
            this.panTotalFemaleStudent.SuspendLayout();
            this.panTotalMaleStudent.SuspendLayout();
            this.panTotalStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudents.ForeColor = System.Drawing.Color.White;
            this.lblTotalStudents.Location = new System.Drawing.Point(85, 41);
            this.lblTotalStudents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(111, 19);
            this.lblTotalStudents.TabIndex = 0;
            this.lblTotalStudents.Text = "Total Student:";
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMale.ForeColor = System.Drawing.Color.White;
            this.lblMale.Location = new System.Drawing.Point(8, 30);
            this.lblMale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(47, 19);
            this.lblMale.TabIndex = 1;
            this.lblMale.Text = "Male:";
            // 
            // lblFemale
            // 
            this.lblFemale.AutoSize = true;
            this.lblFemale.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemale.ForeColor = System.Drawing.Color.White;
            this.lblFemale.Location = new System.Drawing.Point(13, 30);
            this.lblFemale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(63, 19);
            this.lblFemale.TabIndex = 2;
            this.lblFemale.Text = "Female:";
            // 
            // genderStudentChart
            // 
            this.genderStudentChart.BackColor = System.Drawing.Color.DeepSkyBlue;
            chartArea1.BackColor = System.Drawing.Color.DeepSkyBlue;
            chartArea1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            chartArea1.Name = "ChartArea1";
            this.genderStudentChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.genderStudentChart.Legends.Add(legend1);
            this.genderStudentChart.Location = new System.Drawing.Point(11, 194);
            this.genderStudentChart.Margin = new System.Windows.Forms.Padding(2);
            this.genderStudentChart.Name = "genderStudentChart";
            this.genderStudentChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.genderStudentChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.DeepSkyBlue;
            series1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Gender";
            this.genderStudentChart.Series.Add(series1);
            this.genderStudentChart.Size = new System.Drawing.Size(353, 210);
            this.genderStudentChart.TabIndex = 6;
            this.genderStudentChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "studentStatisticsTitle";
            title1.Text = "Gender Statistics";
            this.genderStudentChart.Titles.Add(title1);
            // 
            // panTotalFemaleStudent
            // 
            this.panTotalFemaleStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panTotalFemaleStudent.Controls.Add(this.lblFemale);
            this.panTotalFemaleStudent.Location = new System.Drawing.Point(188, 112);
            this.panTotalFemaleStudent.Margin = new System.Windows.Forms.Padding(2);
            this.panTotalFemaleStudent.Name = "panTotalFemaleStudent";
            this.panTotalFemaleStudent.Size = new System.Drawing.Size(176, 81);
            this.panTotalFemaleStudent.TabIndex = 9;
            // 
            // panTotalMaleStudent
            // 
            this.panTotalMaleStudent.BackColor = System.Drawing.Color.LimeGreen;
            this.panTotalMaleStudent.Controls.Add(this.lblMale);
            this.panTotalMaleStudent.Location = new System.Drawing.Point(11, 112);
            this.panTotalMaleStudent.Margin = new System.Windows.Forms.Padding(2);
            this.panTotalMaleStudent.Name = "panTotalMaleStudent";
            this.panTotalMaleStudent.Size = new System.Drawing.Size(176, 81);
            this.panTotalMaleStudent.TabIndex = 8;
            // 
            // panTotalStudent
            // 
            this.panTotalStudent.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panTotalStudent.Controls.Add(this.lblTotalStudents);
            this.panTotalStudent.Location = new System.Drawing.Point(11, 11);
            this.panTotalStudent.Margin = new System.Windows.Forms.Padding(2);
            this.panTotalStudent.Name = "panTotalStudent";
            this.panTotalStudent.Size = new System.Drawing.Size(353, 100);
            this.panTotalStudent.TabIndex = 7;
            // 
            // StatisticGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 405);
            this.Controls.Add(this.genderStudentChart);
            this.Controls.Add(this.panTotalFemaleStudent);
            this.Controls.Add(this.panTotalMaleStudent);
            this.Controls.Add(this.panTotalStudent);
            this.Name = "StatisticGender";
            this.Text = "StatisticGender";
            this.Load += new System.EventHandler(this.StatisticGender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genderStudentChart)).EndInit();
            this.panTotalFemaleStudent.ResumeLayout(false);
            this.panTotalFemaleStudent.PerformLayout();
            this.panTotalMaleStudent.ResumeLayout(false);
            this.panTotalMaleStudent.PerformLayout();
            this.panTotalStudent.ResumeLayout(false);
            this.panTotalStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.DataVisualization.Charting.Chart genderStudentChart;
        private System.Windows.Forms.Panel panTotalFemaleStudent;
        private System.Windows.Forms.Panel panTotalMaleStudent;
        private System.Windows.Forms.Panel panTotalStudent;
    }
}