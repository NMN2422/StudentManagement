
namespace StudentManagement.Course
{
    partial class PrintCourse
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
            this.btPdf = new System.Windows.Forms.Button();
            this.btExcel = new System.Windows.Forms.Button();
            this.btWord = new System.Windows.Forms.Button();
            this.dgCourselst = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourselst)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btCancel.ForeColor = System.Drawing.Color.DarkGray;
            this.btCancel.Location = new System.Drawing.Point(12, 9);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(138, 34);
            this.btCancel.TabIndex = 71;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btPdf
            // 
            this.btPdf.BackColor = System.Drawing.Color.SpringGreen;
            this.btPdf.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btPdf.Location = new System.Drawing.Point(376, 385);
            this.btPdf.Name = "btPdf";
            this.btPdf.Size = new System.Drawing.Size(142, 34);
            this.btPdf.TabIndex = 69;
            this.btPdf.Text = "Save To PDF";
            this.btPdf.UseVisualStyleBackColor = false;
            this.btPdf.Click += new System.EventHandler(this.btPdf_Click);
            // 
            // btExcel
            // 
            this.btExcel.BackColor = System.Drawing.Color.SpringGreen;
            this.btExcel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btExcel.Location = new System.Drawing.Point(212, 385);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(145, 34);
            this.btExcel.TabIndex = 68;
            this.btExcel.Text = "Save To Excel";
            this.btExcel.UseVisualStyleBackColor = false;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // btWord
            // 
            this.btWord.BackColor = System.Drawing.Color.SpringGreen;
            this.btWord.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btWord.Location = new System.Drawing.Point(44, 385);
            this.btWord.Name = "btWord";
            this.btWord.Size = new System.Drawing.Size(146, 34);
            this.btWord.TabIndex = 67;
            this.btWord.Text = "Save To Word";
            this.btWord.UseVisualStyleBackColor = false;
            this.btWord.Click += new System.EventHandler(this.btWord_Click);
            // 
            // dgCourselst
            // 
            this.dgCourselst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourselst.Location = new System.Drawing.Point(12, 49);
            this.dgCourselst.Name = "dgCourselst";
            this.dgCourselst.Size = new System.Drawing.Size(533, 314);
            this.dgCourselst.TabIndex = 66;
            this.dgCourselst.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCourselst_CellDoubleClick);
            // 
            // PrintCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(570, 435);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btPdf);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.btWord);
            this.Controls.Add(this.dgCourselst);
            this.Name = "PrintCourse";
            this.Text = "PrintCourse";
            this.Load += new System.EventHandler(this.PrintCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCourselst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btPdf;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.Button btWord;
        private System.Windows.Forms.DataGridView dgCourselst;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}