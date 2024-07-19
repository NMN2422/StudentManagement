using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.Account
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 25;
                lblPercent.Text = "Loading " + progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                Hide();
                StudentApp mainForm = new StudentApp();
                mainForm.ShowDialog();
            }
        }
    }
}
