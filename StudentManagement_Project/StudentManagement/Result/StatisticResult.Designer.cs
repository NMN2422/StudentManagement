
namespace StudentManagement.Result
{
    partial class StatisticResult
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartRating = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelWeak = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelFairlyGood = new System.Windows.Forms.Label();
            this.labelGood = new System.Windows.Forms.Label();
            this.labelExcellent = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.flowLayoutPanelCourse = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFail = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelStaticbyResult = new System.Windows.Forms.Label();
            this.labelStaticbyCourse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRating
            // 
            this.chartRating.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartRating.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartRating.Legends.Add(legend1);
            this.chartRating.Location = new System.Drawing.Point(661, 276);
            this.chartRating.Name = "chartRating";
            this.chartRating.Size = new System.Drawing.Size(293, 385);
            this.chartRating.TabIndex = 33;
            this.chartRating.Text = "chart1";
            title1.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "TitleRating";
            title1.Text = "Statistic By Rating";
            this.chartRating.Titles.Add(title1);
            // 
            // chartResult
            // 
            this.chartResult.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.chartResult.Legends.Add(legend2);
            this.chartResult.Location = new System.Drawing.Point(184, 364);
            this.chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Result";
            this.chartResult.Series.Add(series1);
            this.chartResult.Size = new System.Drawing.Size(320, 301);
            this.chartResult.TabIndex = 32;
            this.chartResult.Text = "chart1";
            title2.Name = "TitleResult";
            title2.Text = "Statistic By Result";
            this.chartResult.Titles.Add(title2);
            // 
            // resultChart
            // 
            this.resultChart.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.resultChart.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.resultChart.Legends.Add(legend3);
            this.resultChart.Location = new System.Drawing.Point(225, 11);
            this.resultChart.Name = "resultChart";
            this.resultChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.resultChart.Size = new System.Drawing.Size(456, 304);
            this.resultChart.TabIndex = 31;
            this.resultChart.Text = "chart1";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title";
            title3.Text = "Result Chart";
            this.resultChart.Titles.Add(title3);
            // 
            // labelWeak
            // 
            this.labelWeak.AutoSize = true;
            this.labelWeak.BackColor = System.Drawing.Color.Transparent;
            this.labelWeak.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeak.Location = new System.Drawing.Point(735, 241);
            this.labelWeak.Name = "labelWeak";
            this.labelWeak.Size = new System.Drawing.Size(100, 20);
            this.labelWeak.TabIndex = 30;
            this.labelWeak.Text = "Weak: 0.00 %";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.BackColor = System.Drawing.Color.Transparent;
            this.labelAverage.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverage.Location = new System.Drawing.Point(735, 193);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(116, 20);
            this.labelAverage.TabIndex = 29;
            this.labelAverage.Text = "Average: 0.00 %";
            // 
            // labelFairlyGood
            // 
            this.labelFairlyGood.AutoSize = true;
            this.labelFairlyGood.BackColor = System.Drawing.Color.Transparent;
            this.labelFairlyGood.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFairlyGood.Location = new System.Drawing.Point(735, 153);
            this.labelFairlyGood.Name = "labelFairlyGood";
            this.labelFairlyGood.Size = new System.Drawing.Size(136, 20);
            this.labelFairlyGood.TabIndex = 28;
            this.labelFairlyGood.Text = "Fairly Good: 0.00 %";
            // 
            // labelGood
            // 
            this.labelGood.AutoSize = true;
            this.labelGood.BackColor = System.Drawing.Color.Transparent;
            this.labelGood.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGood.Location = new System.Drawing.Point(735, 108);
            this.labelGood.Name = "labelGood";
            this.labelGood.Size = new System.Drawing.Size(94, 20);
            this.labelGood.TabIndex = 27;
            this.labelGood.Text = "Good: 0.00 %";
            // 
            // labelExcellent
            // 
            this.labelExcellent.AutoSize = true;
            this.labelExcellent.BackColor = System.Drawing.Color.Transparent;
            this.labelExcellent.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExcellent.Location = new System.Drawing.Point(735, 64);
            this.labelExcellent.Name = "labelExcellent";
            this.labelExcellent.Size = new System.Drawing.Size(124, 20);
            this.labelExcellent.TabIndex = 26;
            this.labelExcellent.Text = "Excellent: 0.00 %";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.BackColor = System.Drawing.Color.Transparent;
            this.labelRating.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.Location = new System.Drawing.Point(735, 16);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(133, 19);
            this.labelRating.TabIndex = 25;
            this.labelRating.Text = "Statistic by Rating";
            // 
            // flowLayoutPanelCourse
            // 
            this.flowLayoutPanelCourse.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelCourse.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelCourse.Location = new System.Drawing.Point(42, 41);
            this.flowLayoutPanelCourse.Name = "flowLayoutPanelCourse";
            this.flowLayoutPanelCourse.Size = new System.Drawing.Size(168, 274);
            this.flowLayoutPanelCourse.TabIndex = 24;
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.BackColor = System.Drawing.Color.Transparent;
            this.labelFail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFail.Location = new System.Drawing.Point(38, 453);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(86, 20);
            this.labelFail.TabIndex = 23;
            this.labelFail.Text = "Fail: 0.00 %";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(38, 409);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(90, 20);
            this.labelPass.TabIndex = 22;
            this.labelPass.Text = "Pass: 0.00 %";
            // 
            // labelStaticbyResult
            // 
            this.labelStaticbyResult.AutoSize = true;
            this.labelStaticbyResult.BackColor = System.Drawing.Color.Transparent;
            this.labelStaticbyResult.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticbyResult.Location = new System.Drawing.Point(38, 361);
            this.labelStaticbyResult.Name = "labelStaticbyResult";
            this.labelStaticbyResult.Size = new System.Drawing.Size(134, 19);
            this.labelStaticbyResult.TabIndex = 21;
            this.labelStaticbyResult.Text = "Statistic by Result";
            // 
            // labelStaticbyCourse
            // 
            this.labelStaticbyCourse.AutoSize = true;
            this.labelStaticbyCourse.BackColor = System.Drawing.Color.Transparent;
            this.labelStaticbyCourse.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticbyCourse.Location = new System.Drawing.Point(38, 11);
            this.labelStaticbyCourse.Name = "labelStaticbyCourse";
            this.labelStaticbyCourse.Size = new System.Drawing.Size(136, 19);
            this.labelStaticbyCourse.TabIndex = 20;
            this.labelStaticbyCourse.Text = "Statistic by Course";
            // 
            // StatisticResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1056, 667);
            this.Controls.Add(this.chartRating);
            this.Controls.Add(this.chartResult);
            this.Controls.Add(this.resultChart);
            this.Controls.Add(this.labelWeak);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelFairlyGood);
            this.Controls.Add(this.labelGood);
            this.Controls.Add(this.labelExcellent);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.flowLayoutPanelCourse);
            this.Controls.Add(this.labelFail);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelStaticbyResult);
            this.Controls.Add(this.labelStaticbyCourse);
            this.Name = "StatisticResult";
            this.Text = "StatisticResult";
            this.Load += new System.EventHandler(this.StatisticResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRating;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart resultChart;
        private System.Windows.Forms.Label labelWeak;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelFairlyGood;
        private System.Windows.Forms.Label labelGood;
        private System.Windows.Forms.Label labelExcellent;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCourse;
        private System.Windows.Forms.Label labelFail;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelStaticbyResult;
        private System.Windows.Forms.Label labelStaticbyCourse;
    }
}