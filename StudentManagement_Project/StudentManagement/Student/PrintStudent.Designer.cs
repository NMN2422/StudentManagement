
namespace StudentManagement.Student
{
    partial class PrintStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btCheck = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtSecond = new System.Windows.Forms.DateTimePicker();
            this.dtFirst = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPrintStudent = new System.Windows.Forms.DataGridView();
            this.btWord = new System.Windows.Forms.Button();
            this.btExcel = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrintStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbAll);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.btCheck);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 120);
            this.panel1.TabIndex = 0;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.rbAll.Location = new System.Drawing.Point(19, 53);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(39, 19);
            this.rbAll.TabIndex = 55;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.Click += new System.EventHandler(this.rbAll_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.rbFemale.Location = new System.Drawing.Point(127, 53);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(60, 19);
            this.rbFemale.TabIndex = 54;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.Click += new System.EventHandler(this.rbFemale_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.rbMale.Location = new System.Drawing.Point(73, 53);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(50, 19);
            this.rbMale.TabIndex = 53;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.Click += new System.EventHandler(this.rbMale_Click);
            // 
            // btCheck
            // 
            this.btCheck.BackColor = System.Drawing.Color.DodgerBlue;
            this.btCheck.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btCheck.Location = new System.Drawing.Point(698, 49);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(95, 34);
            this.btCheck.TabIndex = 41;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = false;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNo);
            this.panel2.Controls.Add(this.rbYes);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtSecond);
            this.panel2.Controls.Add(this.dtFirst);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(204, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 100);
            this.panel2.TabIndex = 3;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.rbNo.Location = new System.Drawing.Point(163, 16);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(40, 19);
            this.rbNo.TabIndex = 57;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.rbYes.Location = new System.Drawing.Point(107, 16);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 19);
            this.rbYes.TabIndex = 56;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label3.Location = new System.Drawing.Point(238, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "And";
            // 
            // dtSecond
            // 
            this.dtSecond.CustomFormat = "yyyy - MM - dd";
            this.dtSecond.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.dtSecond.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSecond.Location = new System.Drawing.Point(277, 49);
            this.dtSecond.Name = "dtSecond";
            this.dtSecond.Size = new System.Drawing.Size(124, 22);
            this.dtSecond.TabIndex = 9;
            this.dtSecond.Value = new System.DateTime(2022, 6, 19, 0, 0, 0, 0);
            // 
            // dtFirst
            // 
            this.dtFirst.CustomFormat = "yyyy - MM - dd";
            this.dtFirst.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.dtFirst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFirst.Location = new System.Drawing.Point(107, 50);
            this.dtFirst.Name = "dtFirst";
            this.dtFirst.Size = new System.Drawing.Size(125, 22);
            this.dtFirst.TabIndex = 8;
            this.dtFirst.Value = new System.DateTime(2022, 6, 19, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "BirthDate Between";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Use Date Range";
            // 
            // dgPrintStudent
            // 
            this.dgPrintStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPrintStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrintStudent.Location = new System.Drawing.Point(12, 138);
            this.dgPrintStudent.Name = "dgPrintStudent";
            this.dgPrintStudent.Size = new System.Drawing.Size(842, 247);
            this.dgPrintStudent.TabIndex = 1;
            // 
            // btWord
            // 
            this.btWord.BackColor = System.Drawing.Color.DodgerBlue;
            this.btWord.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btWord.Location = new System.Drawing.Point(139, 404);
            this.btWord.Name = "btWord";
            this.btWord.Size = new System.Drawing.Size(183, 34);
            this.btWord.TabIndex = 40;
            this.btWord.Text = "Save To Word";
            this.btWord.UseVisualStyleBackColor = false;
            this.btWord.Click += new System.EventHandler(this.btWord_Click);
            // 
            // btExcel
            // 
            this.btExcel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btExcel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btExcel.Location = new System.Drawing.Point(361, 404);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(183, 34);
            this.btExcel.TabIndex = 41;
            this.btExcel.Text = "Save To Excel";
            this.btExcel.UseVisualStyleBackColor = false;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btCancel.ForeColor = System.Drawing.Color.DarkGray;
            this.btCancel.Location = new System.Drawing.Point(570, 404);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(183, 34);
            this.btCancel.TabIndex = 43;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // PrintStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.btWord);
            this.Controls.Add(this.dgPrintStudent);
            this.Controls.Add(this.panel1);
            this.Name = "PrintStudent";
            this.Text = "PrintStudent";
            this.Load += new System.EventHandler(this.PrintStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrintStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtSecond;
        private System.Windows.Forms.DateTimePicker dtFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPrintStudent;
        private System.Windows.Forms.Button btWord;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}