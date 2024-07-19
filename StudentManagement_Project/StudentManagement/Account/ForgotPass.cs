using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using StudentManagement.BS_Layer;
namespace StudentManagement.Account
{
    public partial class ForgotPass : Form
    {
        AccountLogin account = new AccountLogin();
        HrLogin hr = new HrLogin();
        string verifycode,err;
        public static string toEmail;
        
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {
            txtBoxVertificationCode.Enabled = false;
            sendEmailButton.Enabled = false;
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            if (account.checkEmail(txtBoxEmail.Text.ToString()) == true || hr.checkmail(txtBoxEmail.Text.ToString()) == true)
            {
                string fromEmail, pass, messageBody;
                Random rand = new Random();
                verifycode = (rand.Next(999999)).ToString();
                MailMessage mailMessage = new MailMessage();
                toEmail = txtBoxEmail.Text.ToString();
                fromEmail = "toannht.12c5bc.1920@gmail.com"; //mail va pass mong muon
                pass = "bame18082002";
                messageBody = "You are requesting a password reset. Your verification code: " + verifycode + ". Please do not give the verification code to anyone to protect the account.";
                mailMessage.To.Add(toEmail);
                mailMessage.From = new MailAddress(fromEmail);
                mailMessage.Body = messageBody;
                mailMessage.Subject = "Password Reseting Code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com"); //khoa r :((((((((
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromEmail, pass);
                try
                {
                    smtp.Send(mailMessage);
                    MessageBox.Show("Verification code sent successfully", "Forgot Password");
                    txtBoxEmail.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Email does not match any accounts.\nPlease enter the correct email address you registered with!", "Forgot Password");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            Application.Restart();
        }

        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxNewPassword.Text.Trim() == txtBoxConfirmPassword.Text.Trim())
            {
                resetPasswordButton.Enabled = true;
            }
            else
            {
                resetPasswordButton.Enabled = false;
            }
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            //if (verifycode == txtBoxVertificationCode.Text.Trim()) verify di that roi
            
                toEmail = txtBoxEmail.Text;
                if (txtBoxNewPassword.Text == txtBoxConfirmPassword.Text)
                {
                    if (radioStudentButton.Checked == false && radioHRButton.Checked == false)
                    {
                        MessageBox.Show("Please select user type!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (radioStudentButton.Checked)
                    {
                        string email =toEmail;
                        string pass =txtBoxConfirmPassword.Text;
                        account.Updatepass(pass, email, ref err);
                        MessageBox.Show("Password reset successful.", "Forgot Password");
                    }
                    else if (radioHRButton.Checked)
                    {
                        string email = toEmail;
                        string pass = txtBoxConfirmPassword.Text;
                        hr.Updatepass(pass, email, ref err);
                        MessageBox.Show("Password reset successful.", "Forgot Password");
                    }

                }
                else if (txtBoxNewPassword.Text.Trim() == "" || txtBoxConfirmPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill in all the information!", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Passwords are not the same.", "Forgot Password");
                }
            
            //else
            //{
            //    MessageBox.Show("The verification code is incorrect. Please re-enter!", "Forgot Password");
            //}
        }
    }
}
