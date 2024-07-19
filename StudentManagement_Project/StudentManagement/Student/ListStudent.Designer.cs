
namespace StudentManagement.Student
{
    partial class ListStudent
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
            this.dgStudentList = new System.Windows.Forms.DataGridView();
            this.btExit = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgStudentList
            // 
            this.dgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudentList.Location = new System.Drawing.Point(12, 12);
            this.dgStudentList.Name = "dgStudentList";
            this.dgStudentList.Size = new System.Drawing.Size(824, 366);
            this.dgStudentList.TabIndex = 0;
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btExit.ForeColor = System.Drawing.Color.DarkGray;
            this.btExit.Location = new System.Drawing.Point(242, 404);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(183, 34);
            this.btExit.TabIndex = 37;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btRefresh.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btRefresh.Location = new System.Drawing.Point(442, 404);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(183, 34);
            this.btRefresh.TabIndex = 40;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // ListStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.dgStudentList);
            this.Name = "ListStudent";
            this.Text = "ListStudent";
            this.Load += new System.EventHandler(this.ListStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStudentList;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btRefresh;
    }
}