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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-JHATL10\\SQL2019;Initial Catalog=DBLogin;Integrated Security=True");

        /// ADD USER TO SQL SERVER
        private void AddUser()
        {
            SqlCommand cmd_AddUser = new SqlCommand();
            cmd_AddUser.CommandText = "insert into tblUsers(User_Name, User_Pass, First_Name)values (@User_Name, @User_Pass, @First_Name)";
            cmd_AddUser.Connection = con;
            cmd_AddUser.Parameters.Add("@First_Name", SqlDbType.NVarChar).Value = txtNameFamilyAdd.Text;
            cmd_AddUser.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = txtUserNameAdd.Text;
            cmd_AddUser.Parameters.Add("@User_Pass", SqlDbType.NVarChar).Value = Security.CalculateMD5Hash(txtPasswordAdd.Text);
            cmd_AddUser.ExecuteNonQuery();
        }
        private void AccessLevel(string userName)
        {
            SqlCommand cmd_AccessLevel = new SqlCommand();
            cmd_AccessLevel.CommandText = "insert into tblAccessLevel(User_Name, Can_Add_User, Can_Change_BackColor, Can_Calculation) values (@User_Name, @Can_Add_User, @Can_Change_backColor, @Can_Calculation)";
            cmd_AccessLevel.Connection = con;
            cmd_AccessLevel.Parameters.Add("@User_name", SqlDbType.NVarChar).Value = userName;
            cmd_AccessLevel.Parameters.Add("@Can_Add_User", SqlDbType.Bit).Value = false;
            cmd_AccessLevel.Parameters.Add("@Can_Change_BackColor", SqlDbType.Bit).Value = ckbChangeColorAdd.Checked;
            cmd_AccessLevel.Parameters.Add("@Can_Calculation", SqlDbType.Bit).Value = ckbCalculationAdd.Checked;
            cmd_AccessLevel.ExecuteNonQuery();
        }

        private void UpdateAccessLevel(string userName)
        {
            SqlCommand sqlCmd_UpdateAccess = new SqlCommand();
            sqlCmd_UpdateAccess.CommandText = "update tblAccessLevel set Can_Add_User=@Can_Add_User, Can_Change_BackColor=@Can_Change_BackColor, Can_Calculation=@Can_Calculation where User_Name=@User_Name";
            sqlCmd_UpdateAccess.Connection = con;
            sqlCmd_UpdateAccess.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = userName;
            sqlCmd_UpdateAccess.Parameters.Add("@Can_Add_User", SqlDbType.NVarChar).Value = ckbAddUserEdit.Checked;
            sqlCmd_UpdateAccess.Parameters.Add("@Can_Change_BackColor", SqlDbType.NVarChar).Value = ckbChangeColorEdit.Checked;
            sqlCmd_UpdateAccess.Parameters.Add("@Can_Calculation", SqlDbType.NVarChar).Value = ckbCalculationEdit.Checked;
            sqlCmd_UpdateAccess.ExecuteNonQuery();
        }

        private void LoadUsersInfo()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("select * from tblUsers", con);
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            txtUserNameEdit.ResetText();
            txtPasswordEdit.ResetText();
            txtConfirmationEdit.ResetText();
            txtMobileNumberEdit.ResetText();
            txtEmailEdit.ResetText();
            cmbSecurityQuestionEdit.SelectedIndex = -1;
            txtAnswerQuestionEdit.ResetText();
            txtNameFamilyEdit.ResetText();
            ckbCalculationEdit.Checked = false;
            ckbChangeColorEdit.Checked = false;
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            Login.CaptchaImage captcha = new Login.CaptchaImage();
            captcha.RefreshCaptcha(pbxCaptcha);
            LoadUsersInfo();

            cmbSearch.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Login.CaptchaImage captcha = new Login.CaptchaImage();
            captcha.RefreshCaptcha(pbxCaptcha);
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            Login.CaptchaImage captcha = new Login.CaptchaImage();
            captcha.SpeechCaptcha();
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNameFamilyAdd.Text))
                errorProvider1.SetError(txtNameFamilyAdd, "لطفان نام و نام خانوادگی را وارد کنید ");
            else if (string.IsNullOrWhiteSpace(txtUserNameAdd.Text))
                errorProvider1.SetError(txtUserNameAdd, "لطفا یورنیم را وارد کنید");
            else if (string.IsNullOrWhiteSpace(txtPasswordAdd.Text))
            {
                errorProvider1.SetError(txtPasswordAdd, "لطفا پسورد را وارد کنید");
                errorProvider1.SetError(txtConfimationAdd, "لطفا پسورد را تایید کنید ");
            }
            else if (txtCaptchaCode.Text != Login.CaptchaImage.Captcha)
                errorProvider1.SetError(txtCaptchaCode, "لطفا کد کپچا را به درستی وارد کنید");
            else
            {
                try
                {
                    con.Open();
                    AddUser();
                    AccessLevel(txtUserNameAdd.Text);
                    con.Close();
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد","پیام موفقیت در ثبت", MessageBoxButtons.OK,MessageBoxIcon.None);
                    txtNameFamilyAdd.ResetText();
                    txtUserNameAdd.ResetText();
                    txtPasswordAdd.ResetText();
                    txtConfimationAdd.ResetText();
                    txtCaptchaCode.ResetText();
                    ckbChangeColorAdd.Checked = false;
                    ckbCalculationAdd.Checked = false;
                    DataTable dt = new DataTable();
                    SqlDataAdapter data = new SqlDataAdapter("select * from tblUsers", con);
                    data.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("هنگام ثبت در دیتابیس خطایی رخ داد.لطفا چک کنید", "خطا در ثبت", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUserNameEdit.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameFamilyEdit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMobileNumberEdit.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmailEdit.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbSecurityQuestionEdit.SelectedIndex = cmbSecurityQuestionEdit.Items.IndexOf(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());

            SqlCommand sqlCmdAccess = new SqlCommand();
            sqlCmdAccess.CommandText = "select * from tblAccessLevel where User_Name=@User_Name";
            sqlCmdAccess.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            sqlCmdAccess.Connection = con;

            try
            {
                SqlDataAdapter data = new SqlDataAdapter(sqlCmdAccess);
                DataTable dt = new DataTable();
                data.Fill(dt);
                if ((bool)dt.Rows[0][1]) // If the user was an administrator, it would be impossible to edit the checkboxes.
                {
                    gbxAccessLevel.Enabled = false;
                }
                else
                {
                    gbxAccessLevel.Enabled = true;
                }

                ckbCalculationEdit.Checked = (bool)dt.Rows[0][3];
                ckbChangeColorEdit.Checked = (bool)dt.Rows[0][2];
                ckbAddUserEdit.Checked = (bool)dt.Rows[0][1];
            }
            catch (Exception)
            {

            }

        }

        private bool IsControlsEmpty()
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNameFamilyEdit.Text))
                errorProvider1.SetError(txtNameFamilyEdit, "لطفا نام و نام خانوادگی را وارد کنید");
            //else if (string.IsNullOrWhiteSpace(txtUserNameEdit.Text))
            //    errorProvider1.SetError(txtUserNameEdit, "لطفا یوزر نیم را وارد کنید");
            else if (string.IsNullOrWhiteSpace(txtPasswordEdit.Text) || txtPasswordEdit.Text != txtConfirmationEdit.Text)
            {
                errorProvider1.SetError(txtPasswordEdit, "لطفا پسورد را وارد کنید");
                errorProvider1.SetError(txtConfirmationEdit, "لطفا پسورد را تایید کنید");
            }
            else if (string.IsNullOrWhiteSpace(txtMobileNumberEdit.Text))
                errorProvider1.SetError(txtMobileNumberEdit, "لطفا شماره موبایل را وارد کنید");
            //else if (string.IsNullOrWhiteSpace(txtAnswerQuestionEdit.Text))
            //    errorProvider1.SetError(txtAnswerQuestionEdit, "لطفا به سوال امنیتی پاسخ دهید");
            else
                return true;
            return false;
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (IsControlsEmpty())
            {

                SqlCommand sqlCmd_Edit = new SqlCommand();
                sqlCmd_Edit.CommandText = "update tblUsers set User_Pass=@User_Pass, First_Name=@First_Name, Mobile_Number=@Mobile_Number, Email_Address=@Email_Address, Security_Question=@Security_Question, Answer_Question=@Answer_Question where User_Name=@User_Name";
                sqlCmd_Edit.Connection = con;

                sqlCmd_Edit.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = txtUserNameEdit.Text;
                sqlCmd_Edit.Parameters.Add("@User_Pass", SqlDbType.NVarChar).Value = Security.CalculateMD5Hash(txtPasswordEdit.Text);
                sqlCmd_Edit.Parameters.Add("@First_Name", SqlDbType.NVarChar).Value = txtNameFamilyEdit.Text;
                sqlCmd_Edit.Parameters.Add("@Mobile_Number", SqlDbType.NVarChar).Value = txtMobileNumberEdit.Text;
                sqlCmd_Edit.Parameters.Add("@Security_Question", SqlDbType.NVarChar).Value = cmbSecurityQuestionEdit.Text;
                sqlCmd_Edit.Parameters.Add("@Answer_Question", SqlDbType.NVarChar).Value = Security.CalculateMD5Hash(txtAnswerQuestionEdit.Text);
                sqlCmd_Edit.Parameters.Add("@Email_Address", SqlDbType.NVarChar).Value = txtEmailEdit.Text;

                con.Open();
                sqlCmd_Edit.ExecuteNonQuery();
                UpdateAccessLevel(txtUserNameEdit.Text);
                con.Close();
                MessageBox.Show("اطلاعات با موفقیت ویرایش شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadUsersInfo();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ckbAddUserEdit.Checked)
            {
                MessageBox.Show("مدیر سیستم قابل حذف شدن نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                SqlCommand sqlCmd_DeleteUser = new SqlCommand();
                sqlCmd_DeleteUser.CommandText = "delete from tblUsers where User_Name=@User_Name";
                sqlCmd_DeleteUser.Connection = con;
                sqlCmd_DeleteUser.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = txtUserNameEdit.Text;


                try
                {
                    con.Open();
                    sqlCmd_DeleteUser.ExecuteNonQuery();
                    LoadUsersInfo();
                    con.Close();
                    MessageBox.Show("کاربر مورد نظر با موفقیت حذف شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (Exception)
                {
                    MessageBox.Show("در حذف از دیتابیس مشکلی رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            if(cmbSearch.SelectedIndex == 0)
            {
                cmd.CommandText = "select * from tblUsers where User_Name=@User_Name";
                cmd.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = txtSearch.Text.Trim();
            }
            else
            {
                cmd.CommandText = "select * from tblUsers where First_Name=@First_Name";
                cmd.Parameters.Add("@First_Name", SqlDbType.NVarChar).Value = txtSearch.Text.Trim();
            
            }
            cmd.Connection = con;
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
