
namespace StudentManagement.Score
{
    partial class PrintScore
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
            this.lbCourse = new System.Windows.Forms.ListBox();
            this.dgScorelist = new System.Windows.Forms.DataGridView();
            this.dgStudentlist = new System.Windows.Forms.DataGridView();
            this.btCancel = new System.Windows.Forms.Button();
            this.btPdf = new System.Windows.Forms.Button();
            this.btExcel = new System.Windows.Forms.Button();
            this.btWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgScorelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCourse
            // 
            this.lbCourse.FormattingEnabled = true;
            this.lbCourse.Location = new System.Drawing.Point(12, 99);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(120, 186);
            this.lbCourse.TabIndex = 0;
            this.lbCourse.Click += new System.EventHandler(this.lbCourse_Click);
            // 
            // dgScorelist
            // 
            this.dgScorelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScorelist.Location = new System.Drawing.Point(153, 68);
            this.dgScorelist.Name = "dgScorelist";
            this.dgScorelist.Size = new System.Drawing.Size(439, 314);
            this.dgScorelist.TabIndex = 1;
            // 
            // dgStudentlist
            // 
            this.dgStudentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudentlist.Location = new System.Drawing.Point(598, 99);
            this.dgStudentlist.Name = "dgStudentlist";
            this.dgStudentlist.Size = new System.Drawing.Size(190, 223);
            this.dgStudentlist.TabIndex = 2;
            this.dgStudentlist.Click += new System.EventHandler(this.dgStudentlist_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btCancel.ForeColor = System.Drawing.Color.DarkGray;
            this.btCancel.Location = new System.Drawing.Point(12, 12);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(138, 34);
            this.btCancel.TabIndex = 56;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btPdf
            // 
            this.btPdf.BackColor = System.Drawing.Color.SpringGreen;
            this.btPdf.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btPdf.Location = new System.Drawing.Point(495, 404);
            this.btPdf.Name = "btPdf";
            this.btPdf.Size = new System.Drawing.Size(183, 34);
            this.btPdf.TabIndex = 59;
            this.btPdf.Text = "Save To PDF";
            this.btPdf.UseVisualStyleBackColor = false;
            this.btPdf.Click += new System.EventHandler(this.btPdf_Click);
            // 
            // btExcel
            // 
            this.btExcel.BackColor = System.Drawing.Color.SpringGreen;
            this.btExcel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btExcel.Location = new System.Drawing.Point(295, 404);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(183, 34);
            this.btExcel.TabIndex = 58;
            this.btExcel.Text = "Save To Excel";
            this.btExcel.UseVisualStyleBackColor = false;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // btWord
            // 
            this.btWord.BackColor = System.Drawing.Color.SpringGreen;
            this.btWord.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btWord.Location = new System.Drawing.Point(91, 404);
            this.btWord.Name = "btWord";
            this.btWord.Size = new System.Drawing.Size(183, 34);
            this.btWord.TabIndex = 57;
            this.btWord.Text = "Save To Word";
            this.btWord.UseVisualStyleBackColor = false;
            this.btWord.Click += new System.EventHandler(this.btWord_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 60;
            this.label1.Text = "CourseList";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label2.Location = new System.Drawing.Point(320, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 33);
            this.label2.TabIndex = 61;
            this.label2.Text = "ScoreList";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label3.Location = new System.Drawing.Point(645, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 33);
            this.label3.TabIndex = 62;
            this.label3.Text = "StudentList";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btReset.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btReset.Location = new System.Drawing.Point(495, 35);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(96, 30);
            this.btReset.TabIndex = 63;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // PrintScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPdf);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.btWord);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.dgStudentlist);
            this.Controls.Add(this.dgScorelist);
            this.Controls.Add(this.lbCourse);
            this.Name = "PrintScore";
            this.Text = "PrintScore";
            this.Load += new System.EventHandler(this.PrintScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgScorelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCourse;
        private System.Windows.Forms.DataGridView dgScorelist;
        private System.Windows.Forms.DataGridView dgStudentlist;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btPdf;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.Button btWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}