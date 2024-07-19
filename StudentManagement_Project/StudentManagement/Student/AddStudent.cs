using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

using StudentManagement.BS_Layer;
using StudentManagement.DB_Layer;
namespace StudentManagement.Student
{
    public partial class AddStudent : Form
    {
        string err;
        DataTable dtListst = null;
        BLStudent dbStudent = new BLStudent();
        public AddStudent()
        {
            InitializeComponent();
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BLStudent tmp = new BLStudent();
                string gender = "Male";
                if (cbFemale.Checked)
                {
                    gender = "Female";
                }
                Image img = pbStu.Image;
                //ImageConverter convert = new ImageConverter();
                //byte[] arr = (byte[])convert.ConvertTo(img, typeof(byte[]));
                var temp = ImageToByteArray(img);
                string st= "";
                tmp.AddStudent(Convert.ToInt32(this.tbStid.Text), this.tbFname.Text, this.tbLname.Text, this.dtBirth.Value.ToString(),
                    gender, this.tbPhone.Text, this.tbAddress.Text,st, ref err);
                MessageBox.Show("Complete");

            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }




        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            string img = "";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                img = opf.FileName.ToString();
                pbStu.ImageLocation = img;
                pbStu.Image = Image.FromFile(opf.FileName);
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
