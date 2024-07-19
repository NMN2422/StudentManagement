
namespace StudentManagement.Account
{
    partial class ForgotPass
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
            this.label2 = new System.Windows.Forms.Label();
            this.radioHRButton = new System.Windows.Forms.RadioButton();
            this.radioStudentButton = new System.Windows.Forms.RadioButton();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.resetPasswordButton = new System.Windows.Forms.Button();
            this.txtBoxVertificationCode = new System.Windows.Forms.TextBox();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.labelVertificationCode = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "User Type:";
            // 
            // radioHRButton
            // 
            this.radioHRButton.AutoSize = true;
            this.radioHRButton.BackColor = System.Drawing.Color.Transparent;
            this.radioHRButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHRButton.ForeColor = System.Drawing.Color.Black;
            this.radioHRButton.Location = new System.Drawing.Point(363, 87);
            this.radioHRButton.Name = "radioHRButton";
            this.radioHRButton.Size = new System.Drawing.Size(111, 20);
            this.radioHRButton.TabIndex = 52;
            this.radioHRButton.TabStop = true;
            this.radioHRButton.Text = "Human Resource";
            this.radioHRButton.UseVisualStyleBackColor = false;
            // 
            // radioStudentButton
            // 
            this.radioStudentButton.AutoSize = true;
            this.radioStudentButton.BackColor = System.Drawing.Color.Transparent;
            this.radioStudentButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStudentButton.ForeColor = System.Drawing.Color.Black;
            this.radioStudentButton.Location = new System.Drawing.Point(230, 87);
            this.radioStudentButton.Name = "radioStudentButton";
            this.radioStudentButton.Size = new System.Drawing.Size(68, 20);
            this.radioStudentButton.TabIndex = 51;
            this.radioStudentButton.TabStop = true;
            this.radioStudentButton.Text = "Student";
            this.radioStudentButton.UseVisualStyleBackColor = false;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelNewPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.Location = new System.Drawing.Point(90, 216);
            this.labelNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(106, 19);
            this.labelNewPassword.TabIndex = 46;
            this.labelNewPassword.Text = "New Password:";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.BackColor = System.Drawing.Color.Transparent;
            this.labelNote.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(184, 50);
            this.labelNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(239, 15);
            this.labelNote.TabIndex = 50;
            this.labelNote.Text = "Enter your email for resetting your password.";
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(230, 249);
            this.txtBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(267, 26);
            this.txtBoxConfirmPassword.TabIndex = 49;
            this.txtBoxConfirmPassword.UseSystemPasswordChar = true;
            this.txtBoxConfirmPassword.TextChanged += new System.EventHandler(this.txtBoxConfirmPassword_TextChanged);
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.Enabled = false;
            this.resetPasswordButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordButton.Location = new System.Drawing.Point(230, 303);
            this.resetPasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(267, 34);
            this.resetPasswordButton.TabIndex = 45;
            this.resetPasswordButton.Text = "Reset";
            this.resetPasswordButton.UseVisualStyleBackColor = true;
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            // 
            // txtBoxVertificationCode
            // 
            this.txtBoxVertificationCode.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVertificationCode.Location = new System.Drawing.Point(230, 169);
            this.txtBoxVertificationCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxVertificationCode.Name = "txtBoxVertificationCode";
            this.txtBoxVertificationCode.Size = new System.Drawing.Size(192, 26);
            this.txtBoxVertificationCode.TabIndex = 44;
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelForgotPassword.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPassword.Location = new System.Drawing.Point(211, 9);
            this.labelForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(207, 35);
            this.labelForgotPassword.TabIndex = 39;
            this.labelForgotPassword.Text = "Forgot Password";
            // 
            // labelVertificationCode
            // 
            this.labelVertificationCode.AutoSize = true;
            this.labelVertificationCode.BackColor = System.Drawing.Color.Transparent;
            this.labelVertificationCode.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVertificationCode.Location = new System.Drawing.Point(67, 176);
            this.labelVertificationCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVertificationCode.Name = "labelVertificationCode";
            this.labelVertificationCode.Size = new System.Drawing.Size(126, 19);
            this.labelVertificationCode.TabIndex = 43;
            this.labelVertificationCode.Text = "Verification Code:";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(64, 256);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(128, 19);
            this.labelConfirmPassword.TabIndex = 47;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(165, 128);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 19);
            this.labelEmail.TabIndex = 42;
            this.labelEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(230, 121);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(316, 26);
            this.txtBoxEmail.TabIndex = 40;
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewPassword.Location = new System.Drawing.Point(230, 209);
            this.txtBoxNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.Size = new System.Drawing.Size(267, 26);
            this.txtBoxNewPassword.TabIndex = 48;
            this.txtBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailButton.Location = new System.Drawing.Point(452, 166);
            this.sendEmailButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(94, 34);
            this.sendEmailButton.TabIndex = 41;
            this.sendEmailButton.Text = "Send";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::StudentManagement.Properties.Resources.cancelButton1;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(13, 6);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(67, 48);
            this.backButton.TabIndex = 54;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(669, 363);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioHRButton);
            this.Controls.Add(this.radioStudentButton);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.txtBoxConfirmPassword);
            this.Controls.Add(this.resetPasswordButton);
            this.Controls.Add(this.txtBoxVertificationCode);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.labelVertificationCode);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxNewPassword);
            this.Controls.Add(this.sendEmailButton);
            this.Name = "ForgotPass";
            this.Text = "ForgotPass";
            this.Load += new System.EventHandler(this.ForgotPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioHRButton;
        private System.Windows.Forms.RadioButton radioStudentButton;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.Button resetPasswordButton;
        private System.Windows.Forms.TextBox txtBoxVertificationCode;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.Label labelVertificationCode;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.Button backButton;
    }
}