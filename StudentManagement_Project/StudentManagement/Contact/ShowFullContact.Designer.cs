
namespace StudentManagement.Contact
{
    partial class ShowFullContact
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
            this.labelTotalGroup = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelFullAddress = new System.Windows.Forms.Label();
            this.labelAllContact = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.showFullButton = new System.Windows.Forms.Button();
            this.listBoxGroup = new System.Windows.Forms.ListBox();
            this.labelContact = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalGroup
            // 
            this.labelTotalGroup.AutoSize = true;
            this.labelTotalGroup.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalGroup.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalGroup.Location = new System.Drawing.Point(69, 283);
            this.labelTotalGroup.Name = "labelTotalGroup";
            this.labelTotalGroup.Size = new System.Drawing.Size(81, 16);
            this.labelTotalGroup.TabIndex = 49;
            this.labelTotalGroup.Text = "Total Group: 0";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(598, 391);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(140, 32);
            this.cancelButton.TabIndex = 48;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(197, 96);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(541, 258);
            this.dataGridView.TabIndex = 47;
            // 
            // labelFullAddress
            // 
            this.labelFullAddress.AutoSize = true;
            this.labelFullAddress.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullAddress.Location = new System.Drawing.Point(192, 362);
            this.labelFullAddress.Name = "labelFullAddress";
            this.labelFullAddress.Size = new System.Drawing.Size(100, 19);
            this.labelFullAddress.TabIndex = 46;
            this.labelFullAddress.Text = "Full Address:";
            // 
            // labelAllContact
            // 
            this.labelAllContact.AutoSize = true;
            this.labelAllContact.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllContact.Location = new System.Drawing.Point(191, 61);
            this.labelAllContact.Name = "labelAllContact";
            this.labelAllContact.Size = new System.Drawing.Size(115, 27);
            this.labelAllContact.TabIndex = 45;
            this.labelAllContact.Text = "All Contact";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.Location = new System.Drawing.Point(47, 59);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(64, 27);
            this.labelGroup.TabIndex = 44;
            this.labelGroup.Text = "Group";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(197, 390);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(278, 24);
            this.txtBoxSearch.TabIndex = 43;
            this.txtBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSearch_KeyPress);
            // 
            // showFullButton
            // 
            this.showFullButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFullButton.Location = new System.Drawing.Point(598, 58);
            this.showFullButton.Name = "showFullButton";
            this.showFullButton.Size = new System.Drawing.Size(140, 32);
            this.showFullButton.TabIndex = 42;
            this.showFullButton.Text = "Show Full";
            this.showFullButton.UseVisualStyleBackColor = true;
            this.showFullButton.Click += new System.EventHandler(this.showFullButton_Click);
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.Location = new System.Drawing.Point(7, 96);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(160, 160);
            this.listBoxGroup.TabIndex = 41;
            this.listBoxGroup.Click += new System.EventHandler(this.listBoxGroup_Click);
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(295, 9);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(141, 31);
            this.labelContact.TabIndex = 40;
            this.labelContact.Text = "Full Contact";
            // 
            // ShowFullContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(749, 431);
            this.Controls.Add(this.labelTotalGroup);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelFullAddress);
            this.Controls.Add(this.labelAllContact);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.showFullButton);
            this.Controls.Add(this.listBoxGroup);
            this.Controls.Add(this.labelContact);
            this.Name = "ShowFullContact";
            this.Text = "ShowFullContact";
            this.Load += new System.EventHandler(this.ShowFullContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalGroup;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelFullAddress;
        private System.Windows.Forms.Label labelAllContact;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button showFullButton;
        private System.Windows.Forms.ListBox listBoxGroup;
        private System.Windows.Forms.Label labelContact;
    }
}