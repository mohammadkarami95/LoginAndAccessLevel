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
namespace LoginAccessLevel
{
    public partial class frmAddAdmin : Form
    {
        public frmAddAdmin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-JHATL10\\SQL2019;Initial Catalog=DBLogin;Integrated Security=True");

        //CAPTCHA CODE
        string captcha;
        System.Speech.Synthesis.SpeechSynthesizer speech = new System.Speech.Synthesis.SpeechSynthesizer();
        private void SpeechCaptcha()
        {
            speech.Volume = 100;
            foreach (char objChar in captcha.ToCharArray())
            {
                speech.Speak(objChar.ToString());
            }
        }

        private string RandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 99999).ToString();
        }
        private void RefreshCaptcha()
        {
            Login.CaptchaImage captchaImage = new Login.CaptchaImage(RandomNumber(), 140, 60);
            pbxCaptcha.Image = captchaImage.Image;
            captcha = captchaImage.Text;
        }
        //CAPTCHA CODE ADDED


        /// <summary>
        /// ADD ADMIN REGISTERATION TO SQL SERVER
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string CalculateMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputByte = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputByte);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString().ToLower();
        }
        private void AddAdmin()
        {
            SqlCommand cmd_AddAdmin = new SqlCommand();
            cmd_AddAdmin.CommandText = "insert into tblUsers(User_Name, User_Pass, First_Name, Mobile_Number, Email_Address, Security_Question, Answer_Question)values (@User_Name, @User_Pass, @First_Name, @Mobile_Number, @Email_Address, @Security_Question, @Answer_Question)";
            cmd_AddAdmin.Connection = con;
            cmd_AddAdmin.Parameters.Add("@First_Name",SqlDbType.NVarChar).Value = txtNameFamily.Text;
            cmd_AddAdmin.Parameters.Add("@User_Name",SqlDbType.NVarChar).Value = txtUserName.Text;
            cmd_AddAdmin.Parameters.Add("@User_Pass",SqlDbType.NVarChar).Value = CalculateMD5Hash(txtPassword.Text);
            cmd_AddAdmin.Parameters.Add("@Mobile_Number",SqlDbType.NVarChar).Value = txtMobileNumber.Text;
            cmd_AddAdmin.Parameters.Add("@Email_Address",SqlDbType.NVarChar).Value = txtEmail.Text;
            cmd_AddAdmin.Parameters.Add("@Security_Question",SqlDbType.NVarChar).Value = cmbSecurityQuestion.Text;
            cmd_AddAdmin.Parameters.Add("@Answer_Question", SqlDbType.NVarChar).Value = CalculateMD5Hash(txtAnswerQuestion.Text);
            cmd_AddAdmin.ExecuteNonQuery();
        }
        private void AccessLevel(string userName)
        {
            SqlCommand cmd_AccessLevel = new SqlCommand();
            cmd_AccessLevel.CommandText = "insert into tblAccessLevel(User_Name, Can_Add_User, Can_Change_backColor, Can_Calculation) values (@User_Name, @Can_Add_User, @Can_Change_backColor, @Can_Calculation)";
            cmd_AccessLevel.Connection = con;
            cmd_AccessLevel.Parameters.Add("@User_name", SqlDbType.NVarChar).Value = userName;
            cmd_AccessLevel.Parameters.Add("@Can_Add_User", SqlDbType.Bit).Value = true;
            cmd_AccessLevel.Parameters.Add("@Can_Change_BackColor", SqlDbType.Bit).Value = true;
            cmd_AccessLevel.Parameters.Add("@Can_Calculation", SqlDbType.Bit).Value = true;
            cmd_AccessLevel.ExecuteNonQuery();
        }
        private void SetRegisteredAdmin()
        {
            SqlCommand cmd_RegAdmin = new SqlCommand();
            cmd_RegAdmin.CommandText = "update tblSundry set RegisteredAdminPass=@RegisteredAdminPass";
            cmd_RegAdmin.Connection = con;
            cmd_RegAdmin.Parameters.Add("@RegisteredAdminPass", SqlDbType.Bit).Value = true;
            cmd_RegAdmin.ExecuteNonQuery();
        }
        /// <summary>
        /// END OF ADD TO ADMIN REGIRSTERATION METHODS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNameFamily.Text))
                errorProvider1.SetError(txtNameFamily, "لطفا نام و نام خانوادگی را وارد کنید");
            else if (string.IsNullOrWhiteSpace(txtUserName.Text))
                errorProvider1.SetError(txtUserName, "لطفا یوزر نیم را وارد کنید");
            else if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text != txtConfirmation.Text)
            {
                errorProvider1.SetError(txtPassword, "لطفا پسورد را وارد کنید");
                errorProvider1.SetError(txtConfirmation, "لطفا پسورد را تایید کنید");
            }
            else if (string.IsNullOrWhiteSpace(txtMobileNumber.Text))
                errorProvider1.SetError(txtMobileNumber, "لطفا شماره موبایل را وارد کنید");
            else if (string.IsNullOrWhiteSpace(txtAnswerQuestion.Text))
                errorProvider1.SetError(txtAnswerQuestion, "لطفا به سوال امنیتی پاسخ دهید");
            else if (txtCaptchaCode.Text != captcha)
                errorProvider1.SetError(txtCaptchaCode, "لطفا کد کپچا را وارد کنید");
            else
            {
                con.Open();
                AddAdmin();
                AccessLevel(txtUserName.Text);
                SetRegisteredAdmin();
                con.Close();
                this.Close();
            }
            
        }

        private void frmAddAdmin_Load(object sender, EventArgs e)
        {
            RefreshCaptcha();
            cmbSecurityQuestion.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshCaptcha();
        }

        private void btnCaptchaSpeech_Click(object sender, EventArgs e)
        {
            SpeechCaptcha();
        }
    }
}
