using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAccessLevel
{
    public partial class frmEditProfile : Form
    {
        public frmEditProfile()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-JHATL10\\SQL2019;Initial Catalog=DBLogin;Integrated Security=True");

        private void frmEditProfile_Load(object sender, EventArgs e)
        {
            Login.CaptchaImage captcha = new Login.CaptchaImage();
            captcha.RefreshCaptcha(pbxCaptcha);
            cmbSecurityQuestion.SelectedIndex = 0;

            SqlCommand sqlCmdEdit = new SqlCommand();
            sqlCmdEdit.CommandText = "select * from tblUsers where User_Name=@User_Name";
            sqlCmdEdit.Connection = con;
            sqlCmdEdit.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = AccessLevel.UserName;

            SqlDataAdapter data = new SqlDataAdapter(sqlCmdEdit);
            DataTable dt = new DataTable();
            data.Fill(dt);
            txtEmail.Text = dt.Rows[0][4].ToString();
            txtMobileNumber.Text = dt.Rows[0][3].ToString();
            cmbSecurityQuestion.Text = dt.Rows[0][5].ToString();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Login.CaptchaImage oCaptchaImage = new Login.CaptchaImage();
           oCaptchaImage.RefreshCaptcha(pbxCaptcha);
        }

        private void btnCaptchaSpeech_Click(object sender, EventArgs e)
        {
            Login.CaptchaImage oCaptchaImage = new Login.CaptchaImage();
            oCaptchaImage.SpeechCaptcha();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || txtNewPassword.Text != txtConfirmationNewPass.Text)
            {
                errorProvider1.SetError(txtNewPassword, "لطفا پسورد را وارد کنید");
                errorProvider1.SetError(txtConfirmationNewPass, "لطفا پسورد را تایید کنید");
            }
            else if (string.IsNullOrWhiteSpace(txtMobileNumber.Text))
                errorProvider1.SetError(txtMobileNumber, "لطفا شماره موبایل را وارد کنید");
            else if (string.IsNullOrWhiteSpace(txtAnswerQuestion.Text))
                errorProvider1.SetError(txtAnswerQuestion, "لطفا به سوال امنیتی پاسخ دهید");
            else if (txtCaptchaCode.Text != Login.CaptchaImage.Captcha)
                errorProvider1.SetError(txtCaptchaCode, "لطفا کد کپچا را وارد کنید");
            else
            {
                SqlCommand sqlCmdEdit = new SqlCommand();
                sqlCmdEdit.CommandText = "update tblUsers set User_Pass=@User_Pass, Mobile_Number=@Mobile_Number, Email_Address=@Email_Address, Answer_Question=@Answer_Question, Security_Question=@Security_Question  where User_Name=@User_Name";
                sqlCmdEdit.Connection = con;

                con.Open();

                sqlCmdEdit.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = AccessLevel.UserName;
                sqlCmdEdit.Parameters.Add("@User_Pass", SqlDbType.NVarChar).Value = Security.CalculateMD5Hash(txtNewPassword.Text);
                sqlCmdEdit.Parameters.Add("@Mobile_Number", SqlDbType.NVarChar).Value = txtMobileNumber.Text;
                sqlCmdEdit.Parameters.Add("@Email_Address", SqlDbType.NVarChar).Value = txtEmail.Text;
                sqlCmdEdit.Parameters.Add("@Security_Question", SqlDbType.NVarChar).Value = cmbSecurityQuestion.Text;
                sqlCmdEdit.Parameters.Add("@Answer_Question", SqlDbType.NVarChar).Value = Security.CalculateMD5Hash(txtAnswerQuestion.Text);
                sqlCmdEdit.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("ویرایش باموفقیت انجام شد ", "ثبت", MessageBoxButtons.OK);
                this.Close();
            }

        }
    }
}
