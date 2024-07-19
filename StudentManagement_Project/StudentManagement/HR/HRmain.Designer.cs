
namespace StudentManagement.HR
{
    partial class HRmain
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
            this.selectContactButton = new System.Windows.Forms.Button();
            this.removeContactButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRemoveContact = new System.Windows.Forms.Label();
            this.showFullListButton = new System.Windows.Forms.Button();
            this.editContactButton = new System.Windows.Forms.Button();
            this.addContactButton = new System.Windows.Forms.Button();
            this.labelSelectGroupRemove = new System.Windows.Forms.Label();
            this.removeGroupButton = new System.Windows.Forms.Button();
            this.comboBoxSelectGroupRemove = new System.Windows.Forms.ComboBox();
            this.panelRemoveGroup = new System.Windows.Forms.Panel();
            this.panelEditGroup = new System.Windows.Forms.Panel();
            this.comboBoxGroupNameEdit = new System.Windows.Forms.ComboBox();
            this.labelSelectGroup = new System.Windows.Forms.Label();
            this.editGroupButton = new System.Windows.Forms.Button();
            this.txtBoxNewGroupName = new System.Windows.Forms.TextBox();
            this.labelNewName = new System.Windows.Forms.Label();
            this.txtBoxAddGroupName = new System.Windows.Forms.TextBox();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.panelAddGroup = new System.Windows.Forms.Panel();
            this.labelEnterGroupName = new System.Windows.Forms.Label();
            this.labelTittleGroup = new System.Windows.Forms.Label();
            this.labelTittleContact = new System.Windows.Forms.Label();
            this.labelXuyet = new System.Windows.Forms.Label();
            this.labelRefresh = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelXuyetThang = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelLogout = new System.Windows.Forms.Label();
            this.labelEditInfo = new System.Windows.Forms.Label();
            this.cbRemove = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panelRemoveGroup.SuspendLayout();
            this.panelEditGroup.SuspendLayout();
            this.panelAddGroup.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectContactButton
            // 
            this.selectContactButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectContactButton.ForeColor = System.Drawing.Color.Coral;
            this.selectContactButton.Location = new System.Drawing.Point(179, 32);
            this.selectContactButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectContactButton.Name = "selectContactButton";
            this.selectContactButton.Size = new System.Drawing.Size(95, 23);
            this.selectContactButton.TabIndex = 10;
            this.selectContactButton.Text = "Select Contact";
            this.selectContactButton.UseVisualStyleBackColor = true;
            this.selectContactButton.Click += new System.EventHandler(this.selectContactButton_Click);
            // 
            // removeContactButton
            // 
            this.removeContactButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeContactButton.ForeColor = System.Drawing.Color.Coral;
            this.removeContactButton.Location = new System.Drawing.Point(2, 66);
            this.removeContactButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeContactButton.Name = "removeContactButton";
            this.removeContactButton.Size = new System.Drawing.Size(272, 31);
            this.removeContactButton.TabIndex = 6;
            this.removeContactButton.Text = "Remove";
            this.removeContactButton.UseVisualStyleBackColor = true;
            this.removeContactButton.Click += new System.EventHandler(this.removeContactButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbRemove);
            this.panel2.Controls.Add(this.selectContactButton);
            this.panel2.Controls.Add(this.labelRemoveContact);
            this.panel2.Controls.Add(this.removeContactButton);
            this.panel2.Location = new System.Drawing.Point(11, 240);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 111);
            this.panel2.TabIndex = 22;
            // 
            // labelRemoveContact
            // 
            this.labelRemoveContact.AutoSize = true;
            this.labelRemoveContact.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoveContact.ForeColor = System.Drawing.Color.White;
            this.labelRemoveContact.Location = new System.Drawing.Point(2, 14);
            this.labelRemoveContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRemoveContact.Name = "labelRemoveContact";
            this.labelRemoveContact.Size = new System.Drawing.Size(111, 17);
            this.labelRemoveContact.TabIndex = 8;
            this.labelRemoveContact.Text = "Enter Contact ID:";
            // 
            // showFullListButton
            // 
            this.showFullListButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFullListButton.ForeColor = System.Drawing.Color.Coral;
            this.showFullListButton.Location = new System.Drawing.Point(11, 355);
            this.showFullListButton.Margin = new System.Windows.Forms.Padding(2);
            this.showFullListButton.Name = "showFullListButton";
            this.showFullListButton.Size = new System.Drawing.Size(124, 31);
            this.showFullListButton.TabIndex = 21;
            this.showFullListButton.Text = "Show Full List";
            this.showFullListButton.UseVisualStyleBackColor = true;
            this.showFullListButton.Click += new System.EventHandler(this.showFullListButton_Click);
            // 
            // editContactButton
            // 
            this.editContactButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editContactButton.ForeColor = System.Drawing.Color.Coral;
            this.editContactButton.Location = new System.Drawing.Point(11, 173);
            this.editContactButton.Margin = new System.Windows.Forms.Padding(2);
            this.editContactButton.Name = "editContactButton";
            this.editContactButton.Size = new System.Drawing.Size(124, 31);
            this.editContactButton.TabIndex = 20;
            this.editContactButton.Text = "Edit";
            this.editContactButton.UseVisualStyleBackColor = true;
            this.editContactButton.Click += new System.EventHandler(this.editContactButton_Click);
            // 
            // addContactButton
            // 
            this.addContactButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContactButton.ForeColor = System.Drawing.Color.Coral;
            this.addContactButton.Location = new System.Drawing.Point(11, 129);
            this.addContactButton.Margin = new System.Windows.Forms.Padding(2);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(124, 31);
            this.addContactButton.TabIndex = 16;
            this.addContactButton.Text = "Add";
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // labelSelectGroupRemove
            // 
            this.labelSelectGroupRemove.AutoSize = true;
            this.labelSelectGroupRemove.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectGroupRemove.ForeColor = System.Drawing.Color.White;
            this.labelSelectGroupRemove.Location = new System.Drawing.Point(22, 14);
            this.labelSelectGroupRemove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectGroupRemove.Name = "labelSelectGroupRemove";
            this.labelSelectGroupRemove.Size = new System.Drawing.Size(84, 17);
            this.labelSelectGroupRemove.TabIndex = 8;
            this.labelSelectGroupRemove.Text = "Select Group:";
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGroupButton.ForeColor = System.Drawing.Color.Coral;
            this.removeGroupButton.Location = new System.Drawing.Point(5, 42);
            this.removeGroupButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(238, 31);
            this.removeGroupButton.TabIndex = 6;
            this.removeGroupButton.Text = "Remove";
            this.removeGroupButton.UseVisualStyleBackColor = true;
            this.removeGroupButton.Click += new System.EventHandler(this.removeGroupButton_Click);
            // 
            // comboBoxSelectGroupRemove
            // 
            this.comboBoxSelectGroupRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSelectGroupRemove.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectGroupRemove.FormattingEnabled = true;
            this.comboBoxSelectGroupRemove.Location = new System.Drawing.Point(112, 7);
            this.comboBoxSelectGroupRemove.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSelectGroupRemove.Name = "comboBoxSelectGroupRemove";
            this.comboBoxSelectGroupRemove.Size = new System.Drawing.Size(132, 25);
            this.comboBoxSelectGroupRemove.TabIndex = 7;
            // 
            // panelRemoveGroup
            // 
            this.panelRemoveGroup.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelRemoveGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRemoveGroup.Controls.Add(this.labelSelectGroupRemove);
            this.panelRemoveGroup.Controls.Add(this.removeGroupButton);
            this.panelRemoveGroup.Controls.Add(this.comboBoxSelectGroupRemove);
            this.panelRemoveGroup.Location = new System.Drawing.Point(363, 330);
            this.panelRemoveGroup.Margin = new System.Windows.Forms.Padding(2);
            this.panelRemoveGroup.Name = "panelRemoveGroup";
            this.panelRemoveGroup.Size = new System.Drawing.Size(251, 78);
            this.panelRemoveGroup.TabIndex = 19;
            // 
            // panelEditGroup
            // 
            this.panelEditGroup.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelEditGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditGroup.Controls.Add(this.comboBoxGroupNameEdit);
            this.panelEditGroup.Controls.Add(this.labelSelectGroup);
            this.panelEditGroup.Controls.Add(this.editGroupButton);
            this.panelEditGroup.Controls.Add(this.txtBoxNewGroupName);
            this.panelEditGroup.Controls.Add(this.labelNewName);
            this.panelEditGroup.Location = new System.Drawing.Point(363, 214);
            this.panelEditGroup.Margin = new System.Windows.Forms.Padding(2);
            this.panelEditGroup.Name = "panelEditGroup";
            this.panelEditGroup.Size = new System.Drawing.Size(251, 104);
            this.panelEditGroup.TabIndex = 18;
            // 
            // comboBoxGroupNameEdit
            // 
            this.comboBoxGroupNameEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxGroupNameEdit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGroupNameEdit.FormattingEnabled = true;
            this.comboBoxGroupNameEdit.Location = new System.Drawing.Point(112, 7);
            this.comboBoxGroupNameEdit.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGroupNameEdit.Name = "comboBoxGroupNameEdit";
            this.comboBoxGroupNameEdit.Size = new System.Drawing.Size(132, 25);
            this.comboBoxGroupNameEdit.TabIndex = 7;
            // 
            // labelSelectGroup
            // 
            this.labelSelectGroup.AutoSize = true;
            this.labelSelectGroup.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectGroup.ForeColor = System.Drawing.Color.White;
            this.labelSelectGroup.Location = new System.Drawing.Point(22, 14);
            this.labelSelectGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectGroup.Name = "labelSelectGroup";
            this.labelSelectGroup.Size = new System.Drawing.Size(84, 17);
            this.labelSelectGroup.TabIndex = 8;
            this.labelSelectGroup.Text = "Select Group:";
            // 
            // editGroupButton
            // 
            this.editGroupButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGroupButton.ForeColor = System.Drawing.Color.Coral;
            this.editGroupButton.Location = new System.Drawing.Point(5, 67);
            this.editGroupButton.Margin = new System.Windows.Forms.Padding(2);
            this.editGroupButton.Name = "editGroupButton";
            this.editGroupButton.Size = new System.Drawing.Size(238, 31);
            this.editGroupButton.TabIndex = 6;
            this.editGroupButton.Text = "Edit";
            this.editGroupButton.UseVisualStyleBackColor = true;
            this.editGroupButton.Click += new System.EventHandler(this.editGroupButton_Click);
            // 
            // txtBoxNewGroupName
            // 
            this.txtBoxNewGroupName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewGroupName.Location = new System.Drawing.Point(112, 35);
            this.txtBoxNewGroupName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNewGroupName.Name = "txtBoxNewGroupName";
            this.txtBoxNewGroupName.Size = new System.Drawing.Size(132, 24);
            this.txtBoxNewGroupName.TabIndex = 5;
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewName.ForeColor = System.Drawing.Color.White;
            this.labelNewName.Location = new System.Drawing.Point(2, 37);
            this.labelNewName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(106, 17);
            this.labelNewName.TabIndex = 4;
            this.labelNewName.Text = "Enter New Name:";
            // 
            // txtBoxAddGroupName
            // 
            this.txtBoxAddGroupName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddGroupName.Location = new System.Drawing.Point(112, 8);
            this.txtBoxAddGroupName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAddGroupName.Name = "txtBoxAddGroupName";
            this.txtBoxAddGroupName.Size = new System.Drawing.Size(133, 24);
            this.txtBoxAddGroupName.TabIndex = 5;
            // 
            // addGroupButton
            // 
            this.addGroupButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupButton.ForeColor = System.Drawing.Color.Coral;
            this.addGroupButton.Location = new System.Drawing.Point(9, 36);
            this.addGroupButton.Margin = new System.Windows.Forms.Padding(2);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(238, 31);
            this.addGroupButton.TabIndex = 6;
            this.addGroupButton.Text = "Add";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // panelAddGroup
            // 
            this.panelAddGroup.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAddGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddGroup.Controls.Add(this.addGroupButton);
            this.panelAddGroup.Controls.Add(this.txtBoxAddGroupName);
            this.panelAddGroup.Controls.Add(this.labelEnterGroupName);
            this.panelAddGroup.Location = new System.Drawing.Point(363, 126);
            this.panelAddGroup.Margin = new System.Windows.Forms.Padding(2);
            this.panelAddGroup.Name = "panelAddGroup";
            this.panelAddGroup.Size = new System.Drawing.Size(251, 78);
            this.panelAddGroup.TabIndex = 17;
            // 
            // labelEnterGroupName
            // 
            this.labelEnterGroupName.AutoSize = true;
            this.labelEnterGroupName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterGroupName.ForeColor = System.Drawing.Color.White;
            this.labelEnterGroupName.Location = new System.Drawing.Point(2, 11);
            this.labelEnterGroupName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterGroupName.Name = "labelEnterGroupName";
            this.labelEnterGroupName.Size = new System.Drawing.Size(114, 17);
            this.labelEnterGroupName.TabIndex = 4;
            this.labelEnterGroupName.Text = "Enter Group Name:";
            // 
            // labelTittleGroup
            // 
            this.labelTittleGroup.AutoSize = true;
            this.labelTittleGroup.BackColor = System.Drawing.Color.Transparent;
            this.labelTittleGroup.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleGroup.ForeColor = System.Drawing.Color.Black;
            this.labelTittleGroup.Location = new System.Drawing.Point(454, 82);
            this.labelTittleGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittleGroup.Name = "labelTittleGroup";
            this.labelTittleGroup.Size = new System.Drawing.Size(87, 30);
            this.labelTittleGroup.TabIndex = 15;
            this.labelTittleGroup.Text = "GROUP";
            // 
            // labelTittleContact
            // 
            this.labelTittleContact.AutoSize = true;
            this.labelTittleContact.BackColor = System.Drawing.Color.Transparent;
            this.labelTittleContact.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleContact.ForeColor = System.Drawing.Color.Black;
            this.labelTittleContact.Location = new System.Drawing.Point(42, 82);
            this.labelTittleContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittleContact.Name = "labelTittleContact";
            this.labelTittleContact.Size = new System.Drawing.Size(121, 30);
            this.labelTittleContact.TabIndex = 13;
            this.labelTittleContact.Text = "CONTACT";
            // 
            // labelXuyet
            // 
            this.labelXuyet.AutoSize = true;
            this.labelXuyet.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXuyet.ForeColor = System.Drawing.Color.White;
            this.labelXuyet.Location = new System.Drawing.Point(213, 41);
            this.labelXuyet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelXuyet.Name = "labelXuyet";
            this.labelXuyet.Size = new System.Drawing.Size(13, 17);
            this.labelXuyet.TabIndex = 6;
            this.labelXuyet.Text = "|";
            // 
            // labelRefresh
            // 
            this.labelRefresh.AutoSize = true;
            this.labelRefresh.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefresh.ForeColor = System.Drawing.Color.White;
            this.labelRefresh.Location = new System.Drawing.Point(105, 42);
            this.labelRefresh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(51, 17);
            this.labelRefresh.TabIndex = 5;
            this.labelRefresh.Text = "Refresh";
            this.labelRefresh.Click += new System.EventHandler(this.labelRefresh_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelHeader.Controls.Add(this.labelXuyet);
            this.panelHeader.Controls.Add(this.labelRefresh);
            this.panelHeader.Controls.Add(this.labelXuyetThang);
            this.panelHeader.Controls.Add(this.labelWelcome);
            this.panelHeader.Controls.Add(this.labelLogout);
            this.panelHeader.Controls.Add(this.labelEditInfo);
            this.panelHeader.Location = new System.Drawing.Point(2, 1);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(619, 71);
            this.panelHeader.TabIndex = 14;
            // 
            // labelXuyetThang
            // 
            this.labelXuyetThang.AutoSize = true;
            this.labelXuyetThang.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXuyetThang.ForeColor = System.Drawing.Color.White;
            this.labelXuyetThang.Location = new System.Drawing.Point(145, 40);
            this.labelXuyetThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelXuyetThang.Name = "labelXuyetThang";
            this.labelXuyetThang.Size = new System.Drawing.Size(13, 17);
            this.labelXuyetThang.TabIndex = 4;
            this.labelXuyetThang.Text = "|";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(12, 8);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(145, 17);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome Back Full Name";
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.ForeColor = System.Drawing.Color.White;
            this.labelLogout.Location = new System.Drawing.Point(174, 42);
            this.labelLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(49, 17);
            this.labelLogout.TabIndex = 3;
            this.labelLogout.Text = "Log out";
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            // 
            // labelEditInfo
            // 
            this.labelEditInfo.AutoSize = true;
            this.labelEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelEditInfo.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditInfo.ForeColor = System.Drawing.Color.White;
            this.labelEditInfo.Location = new System.Drawing.Point(12, 41);
            this.labelEditInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEditInfo.Name = "labelEditInfo";
            this.labelEditInfo.Size = new System.Drawing.Size(82, 17);
            this.labelEditInfo.TabIndex = 2;
            this.labelEditInfo.Text = "Edit My Info";
            this.labelEditInfo.Click += new System.EventHandler(this.labelEditInfo_Click);
            // 
            // cbRemove
            // 
            this.cbRemove.FormattingEnabled = true;
            this.cbRemove.Location = new System.Drawing.Point(5, 34);
            this.cbRemove.Name = "cbRemove";
            this.cbRemove.Size = new System.Drawing.Size(168, 21);
            this.cbRemove.TabIndex = 23;
            // 
            // HRmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(626, 416);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.showFullListButton);
            this.Controls.Add(this.editContactButton);
            this.Controls.Add(this.addContactButton);
            this.Controls.Add(this.panelRemoveGroup);
            this.Controls.Add(this.panelEditGroup);
            this.Controls.Add(this.panelAddGroup);
            this.Controls.Add(this.labelTittleGroup);
            this.Controls.Add(this.labelTittleContact);
            this.Controls.Add(this.panelHeader);
            this.Name = "HRmain";
            this.Text = "HRmain";
            this.Load += new System.EventHandler(this.HRmain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelRemoveGroup.ResumeLayout(false);
            this.panelRemoveGroup.PerformLayout();
            this.panelEditGroup.ResumeLayout(false);
            this.panelEditGroup.PerformLayout();
            this.panelAddGroup.ResumeLayout(false);
            this.panelAddGroup.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectContactButton;
        private System.Windows.Forms.Button removeContactButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRemoveContact;
        private System.Windows.Forms.Button showFullListButton;
        private System.Windows.Forms.Button editContactButton;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.Label labelSelectGroupRemove;
        private System.Windows.Forms.Button removeGroupButton;
        private System.Windows.Forms.ComboBox comboBoxSelectGroupRemove;
        private System.Windows.Forms.Panel panelRemoveGroup;
        private System.Windows.Forms.Panel panelEditGroup;
        private System.Windows.Forms.ComboBox comboBoxGroupNameEdit;
        private System.Windows.Forms.Label labelSelectGroup;
        private System.Windows.Forms.Button editGroupButton;
        private System.Windows.Forms.TextBox txtBoxNewGroupName;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.TextBox txtBoxAddGroupName;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.Panel panelAddGroup;
        private System.Windows.Forms.Label labelEnterGroupName;
        private System.Windows.Forms.Label labelTittleGroup;
        private System.Windows.Forms.Label labelTittleContact;
        private System.Windows.Forms.Label labelXuyet;
        private System.Windows.Forms.Label labelRefresh;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelXuyetThang;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Label labelEditInfo;
        private System.Windows.Forms.ComboBox cbRemove;
    }
}