
namespace StudentManagement.Account
{
    partial class Login
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btForgot = new System.Windows.Forms.Button();
            this.btCreateAc = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.rbHr = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.Location = new System.Drawing.Point(369, 193);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(162, 23);
            this.tbPassword.TabIndex = 41;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUsername.Location = new System.Drawing.Point(369, 142);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(162, 23);
            this.tbUsername.TabIndex = 36;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Black;
            this.labelWelcome.Location = new System.Drawing.Point(371, 73);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(157, 38);
            this.labelWelcome.TabIndex = 33;
            this.labelWelcome.Text = "WELCOME";
            // 
            // btForgot
            // 
            this.btForgot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btForgot.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btForgot.ForeColor = System.Drawing.Color.DarkGray;
            this.btForgot.Location = new System.Drawing.Point(327, 340);
            this.btForgot.Margin = new System.Windows.Forms.Padding(2);
            this.btForgot.Name = "btForgot";
            this.btForgot.Size = new System.Drawing.Size(227, 37);
            this.btForgot.TabIndex = 32;
            this.btForgot.Text = "Forgot Password";
            this.btForgot.UseVisualStyleBackColor = false;
            this.btForgot.Click += new System.EventHandler(this.btForgot_Click);
            // 
            // btCreateAc
            // 
            this.btCreateAc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btCreateAc.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateAc.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btCreateAc.Location = new System.Drawing.Point(327, 298);
            this.btCreateAc.Margin = new System.Windows.Forms.Padding(2);
            this.btCreateAc.Name = "btCreateAc";
            this.btCreateAc.Size = new System.Drawing.Size(227, 37);
            this.btCreateAc.TabIndex = 31;
            this.btCreateAc.Text = "Create New Account";
            this.btCreateAc.UseVisualStyleBackColor = false;
            this.btCreateAc.Click += new System.EventHandler(this.btCreateAc_Click);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(328, 257);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(227, 37);
            this.btLogin.TabIndex = 30;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // rbHr
            // 
            this.rbHr.AutoSize = true;
            this.rbHr.BackColor = System.Drawing.Color.Transparent;
            this.rbHr.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHr.ForeColor = System.Drawing.Color.Black;
            this.rbHr.Location = new System.Drawing.Point(446, 230);
            this.rbHr.Margin = new System.Windows.Forms.Padding(2);
            this.rbHr.Name = "rbHr";
            this.rbHr.Size = new System.Drawing.Size(108, 20);
            this.rbHr.TabIndex = 35;
            this.rbHr.TabStop = true;
            this.rbHr.Text = "HumanResource";
            this.rbHr.UseVisualStyleBackColor = false;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.BackColor = System.Drawing.Color.Transparent;
            this.rbStudent.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStudent.ForeColor = System.Drawing.Color.Black;
            this.rbStudent.Location = new System.Drawing.Point(328, 231);
            this.rbStudent.Margin = new System.Windows.Forms.Padding(2);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(68, 20);
            this.rbStudent.TabIndex = 34;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::StudentManagement.Properties.Resources.user;
            this.pictureBox5.Location = new System.Drawing.Point(390, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(103, 65);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.pictureBox6.Image = global::StudentManagement.Properties.Resources.key2;
            this.pictureBox6.Location = new System.Drawing.Point(335, 193);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 28);
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.pictureBox3.Image = global::StudentManagement.Properties.Resources.login;
            this.pictureBox3.Location = new System.Drawing.Point(335, 142);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.pictureBox2.Location = new System.Drawing.Point(328, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 43);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.pictureBox4.Location = new System.Drawing.Point(328, 131);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(226, 43);
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentManagement.Properties.Resources.test;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 425);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.btForgot);
            this.Controls.Add(this.btCreateAc);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.rbHr);
            this.Controls.Add(this.rbStudent);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btForgot;
        private System.Windows.Forms.Button btCreateAc;
        private System.Windows.Forms.Button btLogin;
        public System.Windows.Forms.RadioButton rbHr;
        public System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}