
namespace StudentManagement.Course
{
    partial class ManageCourse
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
            this.tbCourseid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCoursename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCourse = new System.Windows.Forms.ListBox();
            this.numPeriod = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btFirst = new System.Windows.Forms.Button();
            this.btPrevious = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btLast = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriod)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCourseid
            // 
            this.tbCourseid.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.tbCourseid.Location = new System.Drawing.Point(129, 21);
            this.tbCourseid.Multiline = true;
            this.tbCourseid.Name = "tbCourseid";
            this.tbCourseid.Size = new System.Drawing.Size(204, 28);
            this.tbCourseid.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 54;
            this.label1.Text = "CourseID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCoursename
            // 
            this.tbCoursename.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.tbCoursename.Location = new System.Drawing.Point(129, 71);
            this.tbCoursename.Multiline = true;
            this.tbCoursename.Name = "tbCoursename";
            this.tbCoursename.Size = new System.Drawing.Size(204, 28);
            this.tbCoursename.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 33);
            this.label2.TabIndex = 56;
            this.label2.Text = "Period";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDescrip
            // 
            this.tbDescrip.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.tbDescrip.Location = new System.Drawing.Point(129, 173);
            this.tbDescrip.Multiline = true;
            this.tbDescrip.Name = "tbDescrip";
            this.tbDescrip.Size = new System.Drawing.Size(204, 40);
            this.tbDescrip.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label3.Location = new System.Drawing.Point(3, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 33);
            this.label3.TabIndex = 58;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCourse
            // 
            this.lbCourse.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourse.FormattingEnabled = true;
            this.lbCourse.ItemHeight = 23;
            this.lbCourse.Location = new System.Drawing.Point(378, 40);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(284, 188);
            this.lbCourse.TabIndex = 59;
            this.lbCourse.Click += new System.EventHandler(this.lbCourse_Click);
            this.lbCourse.DoubleClick += new System.EventHandler(this.lbCourse_DoubleClick);
            // 
            // numPeriod
            // 
            this.numPeriod.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.numPeriod.Location = new System.Drawing.Point(130, 124);
            this.numPeriod.Name = "numPeriod";
            this.numPeriod.Size = new System.Drawing.Size(72, 26);
            this.numPeriod.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 33);
            this.label4.TabIndex = 61;
            this.label4.Text = "CourseName";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.SpringGreen;
            this.btCancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btCancel.ForeColor = System.Drawing.Color.Black;
            this.btCancel.Location = new System.Drawing.Point(589, 401);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(138, 34);
            this.btCancel.TabIndex = 65;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.SpringGreen;
            this.btEdit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btEdit.Location = new System.Drawing.Point(157, 401);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(138, 34);
            this.btEdit.TabIndex = 64;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.SpringGreen;
            this.btRemove.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btRemove.Location = new System.Drawing.Point(301, 401);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(138, 34);
            this.btRemove.TabIndex = 63;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btAdd.Location = new System.Drawing.Point(13, 401);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(138, 34);
            this.btAdd.TabIndex = 62;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btFirst
            // 
            this.btFirst.BackColor = System.Drawing.Color.DodgerBlue;
            this.btFirst.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btFirst.Location = new System.Drawing.Point(162, 347);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(97, 34);
            this.btFirst.TabIndex = 66;
            this.btFirst.Text = "|< First";
            this.btFirst.UseVisualStyleBackColor = false;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // btPrevious
            // 
            this.btPrevious.BackColor = System.Drawing.Color.DodgerBlue;
            this.btPrevious.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btPrevious.Location = new System.Drawing.Point(265, 347);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(100, 34);
            this.btPrevious.TabIndex = 67;
            this.btPrevious.Text = "<<Previous";
            this.btPrevious.UseVisualStyleBackColor = false;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.btNext.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btNext.Location = new System.Drawing.Point(371, 347);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(82, 34);
            this.btNext.TabIndex = 68;
            this.btNext.Text = "Next>>";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btLast
            // 
            this.btLast.BackColor = System.Drawing.Color.DodgerBlue;
            this.btLast.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btLast.Location = new System.Drawing.Point(459, 347);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(87, 34);
            this.btLast.TabIndex = 69;
            this.btLast.Text = "Last >|";
            this.btLast.UseVisualStyleBackColor = false;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.lbTotal.Location = new System.Drawing.Point(374, 242);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(131, 33);
            this.lbTotal.TabIndex = 70;
            this.lbTotal.Text = "Total Course: 0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.SpringGreen;
            this.btUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btUpdate.Location = new System.Drawing.Point(445, 401);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(138, 34);
            this.btUpdate.TabIndex = 71;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numPeriod);
            this.panel1.Controls.Add(this.tbDescrip);
            this.panel1.Controls.Add(this.tbCoursename);
            this.panel1.Controls.Add(this.tbCourseid);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 230);
            this.panel1.TabIndex = 72;
            // 
            // ManageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btLast);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbCourse);
            this.Name = "ManageCourse";
            this.Text = "ManageCourse";
            this.Load += new System.EventHandler(this.ManageCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPeriod)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbCourseid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCoursename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCourse;
        private System.Windows.Forms.NumericUpDown numPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Panel panel1;
    }
}