
namespace StudentManagement.Student
{
    partial class ManageStudent
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
            this.btCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbStid = new System.Windows.Forms.TextBox();
            this.dgManageStudent = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgManageStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.SpringGreen;
            this.btCancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCancel.Location = new System.Drawing.Point(849, 491);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(183, 34);
            this.btCancel.TabIndex = 36;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label6.Location = new System.Drawing.Point(18, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 33);
            this.label6.TabIndex = 35;
            this.label6.Text = "Gender";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLname
            // 
            this.tbLname.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.tbLname.Location = new System.Drawing.Point(122, 118);
            this.tbLname.Multiline = true;
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(182, 28);
            this.tbLname.TabIndex = 34;
            this.tbLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLname_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label5.Location = new System.Drawing.Point(17, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 33);
            this.label5.TabIndex = 33;
            this.label5.Text = "Phone";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label4.Location = new System.Drawing.Point(18, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 33);
            this.label4.TabIndex = 32;
            this.label4.Text = "BirthDate";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "LastName";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 33);
            this.label2.TabIndex = 30;
            this.label2.Text = "FirstName";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "StudentID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtBirth
            // 
            this.dtBirth.CustomFormat = "dd/MM/yyyy";
            this.dtBirth.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.dtBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirth.Location = new System.Drawing.Point(122, 173);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(185, 26);
            this.dtBirth.TabIndex = 26;
            this.dtBirth.Value = new System.DateTime(1995, 12, 24, 0, 0, 0, 0);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.tbPhone.Location = new System.Drawing.Point(122, 275);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(184, 28);
            this.tbPhone.TabIndex = 25;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // tbFname
            // 
            this.tbFname.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.tbFname.Location = new System.Drawing.Point(121, 61);
            this.tbFname.Multiline = true;
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(182, 28);
            this.tbFname.TabIndex = 24;
            this.tbFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFname_KeyPress);
            // 
            // tbStid
            // 
            this.tbStid.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.tbStid.Location = new System.Drawing.Point(121, 13);
            this.tbStid.Multiline = true;
            this.tbStid.Name = "tbStid";
            this.tbStid.Size = new System.Drawing.Size(183, 28);
            this.tbStid.TabIndex = 23;
            this.tbStid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStid_KeyPress);
            // 
            // dgManageStudent
            // 
            this.dgManageStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgManageStudent.Location = new System.Drawing.Point(347, 52);
            this.dgManageStudent.Name = "dgManageStudent";
            this.dgManageStudent.Size = new System.Drawing.Size(742, 415);
            this.dgManageStudent.TabIndex = 37;
            this.dgManageStudent.Click += new System.EventHandler(this.dgManageStudent_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.tbSearch.Location = new System.Drawing.Point(559, 17);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(280, 28);
            this.tbSearch.TabIndex = 38;
            this.tbSearch.Text = "Search ID/Phone";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btAdd.Location = new System.Drawing.Point(16, 491);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(183, 34);
            this.btAdd.TabIndex = 39;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label7.Location = new System.Drawing.Point(17, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 33);
            this.label7.TabIndex = 41;
            this.label7.Text = "Address";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic);
            this.tbAddress.Location = new System.Drawing.Point(122, 335);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(182, 45);
            this.tbAddress.TabIndex = 40;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btSearch.Location = new System.Drawing.Point(445, 13);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(98, 34);
            this.btSearch.TabIndex = 45;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.lbTotal.Location = new System.Drawing.Point(954, 16);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(123, 28);
            this.lbTotal.TabIndex = 46;
            this.lbTotal.Text = "Total Student:";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.SpringGreen;
            this.btRemove.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btRemove.Location = new System.Drawing.Point(231, 491);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(183, 34);
            this.btRemove.TabIndex = 47;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.SpringGreen;
            this.btEdit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btEdit.Location = new System.Drawing.Point(445, 491);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(183, 34);
            this.btEdit.TabIndex = 48;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.SpringGreen;
            this.btUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btUpdate.Location = new System.Drawing.Point(656, 491);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(183, 34);
            this.btUpdate.TabIndex = 49;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbLname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtBirth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.tbFname);
            this.panel1.Controls.Add(this.tbStid);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 447);
            this.panel1.TabIndex = 50;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.rbFemale.Location = new System.Drawing.Point(204, 231);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(60, 19);
            this.rbFemale.TabIndex = 53;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.rbMale.Location = new System.Drawing.Point(123, 231);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(50, 19);
            this.rbMale.TabIndex = 52;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btRefresh.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btRefresh.Location = new System.Drawing.Point(347, 12);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(92, 35);
            this.btRefresh.TabIndex = 51;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1101, 537);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgManageStudent);
            this.Controls.Add(this.btCancel);
            this.Name = "ManageStudent";
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgManageStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbStid;
        private System.Windows.Forms.DataGridView dgManageStudent;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
    }
}