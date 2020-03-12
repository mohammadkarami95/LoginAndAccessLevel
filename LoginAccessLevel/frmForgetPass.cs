using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace LoginAccessLevel
{
    public partial class frmForgetPass : Form
    {
        public frmForgetPass()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-JHATL10\\SQL2019;Initial Catalog=DBLogin;Integrated Security=True");

        string newPass = string.Empty;
        /// <summary>
        /// Create New Password
        /// </summary>
        /// <param name="passLen">length of password</param>
        /// <returns>string</returns>
        private static string CreateRandomPass(int passLen)
        {
            string allowedChar = "abcdefjhigklmnopqrstuvwxyz1234567890";
            byte[] randomByte = new byte[passLen];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomByte);
            char[] chars = new char[passLen];
            int charCount = allowedChar.Length;
            for (int i = 0; i < passLen; i++)
            {
                chars[i] = allowedChar[(int)randomByte[i] % charCount];
            }
            return new string(chars);
        }
        private void UpdatePass(string userName, string pass)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update tblUsers set User_pass=@User_Pass where User_Name=@User_Name";
            cmd.Connection = con;
            cmd.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = userName;
            cmd.Parameters.Add("@User_Pass", SqlDbType.NVarChar).Value = Security.CalculateMD5Hash(pass);
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void frmForgetPass_Load(object sender, EventArgs e)
        {
            this.Height = 163;
            
        }

        private void rbtnSMS_CheckedChanged(object sender, EventArgs e)
        {
            this.Height = 163;
            btnSend.Enabled = true;
        }

        private void rbtnEmail_CheckedChanged(object sender, EventArgs e)
        {
            this.Height = 163;
            btnSend.Enabled = true;
        }

        private void rbtnSecurityQuestion_CheckedChanged(object sender, EventArgs e)
        {
            this.Height = 336;
            btnSend.Enabled = false;
        }

        string answerQuestion = string.Empty;
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
                errorProvider1.SetError(txtUserName, "نام کاربری نمیتواند خالی باشد");
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                SqlDataReader myReader;
                cmd.CommandText = "select * from tblUsers where User_Name=@User_Name";
                cmd.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = txtUserName.Text;
                con.Open();
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    cmbSecurityQuestion.SelectedIndex = cmbSecurityQuestion.Items.IndexOf(myReader[5].ToString());
                    answerQuestion = myReader[6].ToString();
                }
                else
                    MessageBox.Show("کاربری با این نام یافت نشد");
                con.Close();

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Security.CalculateMD5Hash(txtAnswerQuestion.Text.Trim()) == answerQuestion.Trim())
            {
                newPass = CreateRandomPass(12);
                txtPassword.Text = newPass;
                UpdatePass(txtUserName.Text, txtPassword.Text);
            }
            else
                MessageBox.Show("پاسخ سوال امنیتی صحیح نمیباشد");
        }

        private void SendByEmail(string emailAddress)
        {
            newPass = CreateRandomPass(12);

            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress("mohammadkaramisheykhlan@gmail.com", "نرم افزار اداری", Encoding.UTF8);
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(mail.From.Address, " **My_Password** ");
            smtp.Host = "smtp.gmail.com";

            //recipient
            mail.To.Add(new MailAddress(emailAddress));

            mail.Subject = "بازیابی رمز عبور نرم افزار اداری";
            mail.SubjectEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Body = "Your new password is : " + newPass ;
            smtp.Send(mail);

            UpdatePass(txtUserName.Text, newPass);
            MessageBox.Show("کلمه عبور ارسال شد");
        }
        private void SentBySMS(string mobileNumber)
        {

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
                errorProvider1.SetError(txtUserName, "نام کاربری نمیتواند خالی باشد");
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                SqlDataReader myReader;
                cmd.CommandText = "select * from tblUsers where User_Name=@User_Name";
                cmd.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = txtUserName.Text;
                con.Open();
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    if (rbtnEmail.Checked)
                        //SentByEmail(myReader[4].ToString());
                        SendByEmail(myReader[4].ToString());
                    else
                        SentBySMS(myReader[3].ToString());
                }
                else
                    MessageBox.Show("کاربری با این نام یافت نشد");
                con.Close();

            }
        }
    }
}

