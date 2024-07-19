
namespace StudentManagement.Contact
{
    partial class AddContact
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
            this.labelTittle = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addContactButton = new System.Windows.Forms.Button();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.txtBoxLname = new System.Windows.Forms.TextBox();
            this.txtBoxFname = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.BackColor = System.Drawing.Color.Transparent;
            this.labelTittle.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.Location = new System.Drawing.Point(106, 9);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(148, 32);
            this.labelTittle.TabIndex = 86;
            this.labelTittle.Text = "Add Contact";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(209, 291);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 28);
            this.cancelButton.TabIndex = 85;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addContactButton
            // 
            this.addContactButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContactButton.Location = new System.Drawing.Point(14, 291);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(120, 28);
            this.addContactButton.TabIndex = 84;
            this.addContactButton.Text = "Add Contact";
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(94, 117);
            this.comboBoxGroup.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(235, 28);
            this.comboBoxGroup.TabIndex = 83;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddress.Location = new System.Drawing.Point(94, 212);
            this.txtBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(235, 62);
            this.txtBoxAddress.TabIndex = 81;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(24, 212);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(67, 19);
            this.labelAddress.TabIndex = 82;
            this.labelAddress.Text = "Address:";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhone.Location = new System.Drawing.Point(94, 147);
            this.txtBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(235, 26);
            this.txtBoxPhone.TabIndex = 79;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(38, 153);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(49, 19);
            this.labelPhone.TabIndex = 80;
            this.labelPhone.Text = "Phone:";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.BackColor = System.Drawing.Color.Transparent;
            this.labelGroup.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(37, 123);
            this.labelGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(51, 19);
            this.labelGroup.TabIndex = 78;
            this.labelGroup.Text = "Group:";
            // 
            // txtBoxLname
            // 
            this.txtBoxLname.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLname.Location = new System.Drawing.Point(94, 86);
            this.txtBoxLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxLname.Name = "txtBoxLname";
            this.txtBoxLname.Size = new System.Drawing.Size(235, 26);
            this.txtBoxLname.TabIndex = 76;
            // 
            // txtBoxFname
            // 
            this.txtBoxFname.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFname.Location = new System.Drawing.Point(94, 56);
            this.txtBoxFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxFname.Name = "txtBoxFname";
            this.txtBoxFname.Size = new System.Drawing.Size(235, 26);
            this.txtBoxFname.TabIndex = 74;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(10, 92);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(83, 19);
            this.labelLastName.TabIndex = 77;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(7, 62);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(88, 19);
            this.labelFirstName.TabIndex = 75;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(42, 186);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 19);
            this.labelEmail.TabIndex = 73;
            this.labelEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(94, 181);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(235, 26);
            this.txtBoxEmail.TabIndex = 72;
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(352, 344);
            this.Controls.Add(this.labelTittle);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addContactButton);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.txtBoxLname);
            this.Controls.Add(this.txtBoxFname);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtBoxEmail);
            this.Name = "AddContact";
            this.Text = "AddContact";
            this.Load += new System.EventHandler(this.AddContact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox txtBoxLname;
        private System.Windows.Forms.TextBox txtBoxFname;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
    }
}