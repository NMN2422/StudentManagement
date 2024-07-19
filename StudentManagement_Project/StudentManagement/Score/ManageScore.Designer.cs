
namespace StudentManagement.Score
{
    partial class ManageScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbStid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAverage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btShowstudent = new System.Windows.Forms.Button();
            this.btShowscore = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 29;
            this.label1.Text = "StudentID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStid
            // 
            this.tbStid.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.tbStid.Location = new System.Drawing.Point(126, 20);
            this.tbStid.Multiline = true;
            this.tbStid.Name = "tbStid";
            this.tbStid.Size = new System.Drawing.Size(150, 28);
            this.tbStid.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label2.Location = new System.Drawing.Point(10, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 33);
            this.label2.TabIndex = 31;
            this.label2.Text = "Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbScore
            // 
            this.tbScore.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.tbScore.Location = new System.Drawing.Point(126, 121);
            this.tbScore.Multiline = true;
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(150, 28);
            this.tbScore.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label3.Location = new System.Drawing.Point(3, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 33);
            this.label3.TabIndex = 33;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.tbDescription.Location = new System.Drawing.Point(126, 174);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(150, 38);
            this.tbDescription.TabIndex = 32;
            // 
            // cbCourse
            // 
            this.cbCourse.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(126, 68);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(150, 28);
            this.cbCourse.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 33);
            this.label4.TabIndex = 35;
            this.label4.Text = "SelectCourse";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btAdd.Location = new System.Drawing.Point(94, 404);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(138, 34);
            this.btAdd.TabIndex = 49;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.SpringGreen;
            this.btRemove.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btRemove.Location = new System.Drawing.Point(447, 404);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(138, 34);
            this.btRemove.TabIndex = 50;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAverage
            // 
            this.btAverage.BackColor = System.Drawing.Color.DodgerBlue;
            this.btAverage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btAverage.Location = new System.Drawing.Point(610, 12);
            this.btAverage.Name = "btAverage";
            this.btAverage.Size = new System.Drawing.Size(138, 34);
            this.btAverage.TabIndex = 51;
            this.btAverage.Text = "Average";
            this.btAverage.UseVisualStyleBackColor = false;
            this.btAverage.Click += new System.EventHandler(this.btAverage_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 322);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btShowstudent
            // 
            this.btShowstudent.BackColor = System.Drawing.Color.DodgerBlue;
            this.btShowstudent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btShowstudent.Location = new System.Drawing.Point(326, 12);
            this.btShowstudent.Name = "btShowstudent";
            this.btShowstudent.Size = new System.Drawing.Size(138, 34);
            this.btShowstudent.TabIndex = 53;
            this.btShowstudent.Text = "Show Student";
            this.btShowstudent.UseVisualStyleBackColor = false;
            this.btShowstudent.Click += new System.EventHandler(this.btShowstudent_Click);
            // 
            // btShowscore
            // 
            this.btShowscore.BackColor = System.Drawing.Color.DodgerBlue;
            this.btShowscore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btShowscore.Location = new System.Drawing.Point(862, 12);
            this.btShowscore.Name = "btShowscore";
            this.btShowscore.Size = new System.Drawing.Size(138, 34);
            this.btShowscore.TabIndex = 54;
            this.btShowscore.Text = "Show Score";
            this.btShowscore.UseVisualStyleBackColor = false;
            this.btShowscore.Click += new System.EventHandler(this.btShowscore_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.SpringGreen;
            this.btCancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btCancel.ForeColor = System.Drawing.Color.Black;
            this.btCancel.Location = new System.Drawing.Point(804, 404);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(138, 34);
            this.btCancel.TabIndex = 55;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.SpringGreen;
            this.btUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btUpdate.Location = new System.Drawing.Point(624, 404);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(138, 34);
            this.btUpdate.TabIndex = 73;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.SpringGreen;
            this.btEdit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btEdit.Location = new System.Drawing.Point(270, 404);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(138, 34);
            this.btEdit.TabIndex = 72;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbCourse);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.tbScore);
            this.panel1.Controls.Add(this.tbStid);
            this.panel1.Location = new System.Drawing.Point(4, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 268);
            this.panel1.TabIndex = 74;
            // 
            // ManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btShowscore);
            this.Controls.Add(this.btShowstudent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btAverage);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Name = "ManageScore";
            this.Text = "ManageScore";
            this.Load += new System.EventHandler(this.ManageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAverage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btShowstudent;
        private System.Windows.Forms.Button btShowscore;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Panel panel1;
    }
}