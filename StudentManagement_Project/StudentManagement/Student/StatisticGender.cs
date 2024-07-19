using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.BS_Layer;
namespace StudentManagement.Student
{
    public partial class StatisticGender : Form
    {
        BLStudent student = new BLStudent();
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        public StatisticGender()
        {
            InitializeComponent();
            if (student.totalgender("Male") < 0)
            {
                genderStudentChart.Series["Gender"].Points.AddXY("Female", student.totalgender("Female"));
            }
            else if (student.totalgender("Female") < 0)
            {
                genderStudentChart.Series["Gender"].Points.AddXY("Male", student.totalgender("Male"));
            }
            else
            {
                genderStudentChart.Series["Gender"].Points.AddXY("Male", student.totalgender("Male"));
                genderStudentChart.Series["Gender"].Points.AddXY("Female", student.totalgender("Female"));
            }
        }

        private void StatisticGender_Load(object sender, EventArgs e)
        {
            // get panels color
            panTotalColor = panTotalStudent.BackColor;
            panMaleColor = panTotalMaleStudent.BackColor;
            panFemaleColor = panTotalFemaleStudent.BackColor;
            // display the values

            double total = Convert.ToDouble(student.totalstudent());
            double totalMale = Convert.ToDouble(student.totalgender("Male"));
            double totalFemale = Convert.ToDouble(student.totalgender("Female"));
            // tinh %, cac ban xem lai phep toan
            // (tong students X 100) / (total students)|
            double maleStudentsPercentage = (totalMale * (100 / total));
            double femaleStudentsPercentage = (totalFemale * (100 / total));
            lblTotalStudents.Text = ("Total Students: " + total.ToString());
            lblMale.Text = ("Male: " + (maleStudentsPercentage.ToString("0.00") + "%"));
            lblFemale.Text = ("Female: " + (femaleStudentsPercentage.ToString("0.00") + "%"));
        }
    }
}
