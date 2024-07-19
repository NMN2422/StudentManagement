
namespace StudentManagement.Student
{
    partial class AddStudent
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
            this.tbStid = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbStu = new System.Windows.Forms.PictureBox();
            this.btUpload = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).BeginInit();
            this.SuspendLayout();
            // 
            // tbStid
            // 
            this.tbStid.Location = new System.Drawing.Point(144, 39);
            this.tbStid.Multiline = true;
            this.tbStid.Name = "tbStid";
            this.tbStid.Size = new System.Drawing.Size(184, 28);
            this.tbStid.TabIndex = 0;
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(144, 91);
            this.tbFname.Multiline = true;
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(184, 28);
            this.tbFname.TabIndex = 1;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(144, 314);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(184, 28);
            this.tbPhone.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(504, 39);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(184, 80);
            this.tbAddress.TabIndex = 3;
            // 
            // dtBirth
            // 
            this.dtBirth.CustomFormat = "dd/MM/yyyy";
            this.dtBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirth.Location = new System.Drawing.Point(144, 207);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(184, 20);
            this.dtBirth.TabIndex = 4;
            this.dtBirth.Value = new System.DateTime(1995, 12, 24, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "StudentID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Location = new System.Drawing.Point(144, 269);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(49, 17);
            this.cbMale.TabIndex = 9;
            this.cbMale.Text = "Male";
            this.cbMale.UseVisualStyleBackColor = true;
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Location = new System.Drawing.Point(248, 269);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(60, 17);
            this.cbFemale.TabIndex = 10;
            this.cbFemale.Text = "Female";
            this.cbFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "FirstName";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "LastName";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "BirthDate";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label5.Location = new System.Drawing.Point(12, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(144, 154);
            this.tbLname.Multiline = true;
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(184, 28);
            this.tbLname.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 33);
            this.label6.TabIndex = 16;
            this.label6.Text = "Gender";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label7.Location = new System.Drawing.Point(385, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.8F);
            this.label8.Location = new System.Drawing.Point(385, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 33);
            this.label8.TabIndex = 18;
            this.label8.Text = "Picture";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbStu
            // 
            this.pbStu.BackColor = System.Drawing.Color.White;
            this.pbStu.Location = new System.Drawing.Point(508, 191);
            this.pbStu.Name = "pbStu";
            this.pbStu.Size = new System.Drawing.Size(180, 100);
            this.pbStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStu.TabIndex = 19;
            this.pbStu.TabStop = false;
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(508, 309);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(183, 22);
            this.btUpload.TabIndex = 20;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btAdd.Location = new System.Drawing.Point(508, 377);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(183, 34);
            this.btAdd.TabIndex = 21;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btCancel.ForeColor = System.Drawing.Color.DarkGray;
            this.btCancel.Location = new System.Drawing.Point(146, 377);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(183, 34);
            this.btCancel.TabIndex = 22;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.pbStu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFemale);
            this.Controls.Add(this.cbMale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.tbStid);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStid;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbStu;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCancel;
    }
}