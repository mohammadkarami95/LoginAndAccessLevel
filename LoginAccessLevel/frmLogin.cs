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
using System.IO;
using System.Diagnostics;

namespace LoginAccessLevel
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-JHATL10\\SQL2019;Initial Catalog=DBLogin;Integrated Security=True");

        private void SetTextUserName()
        {
            txtUserName.Text = "نام کاربری";
            txtUserName.ForeColor = Color.Gray;
        }
        private void SetTextPassword()
        {
            txtPassword.Text = "رمز عبور";
            txtPassword.ForeColor = Color.Gray;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            /*dar in file ma tedade dafeati ke shakhs UserName va Password ro eshtebah vared mikonad ro minevisim
            age tedade dafeate eshtebah bishtar az 5 bar shod be user migim ke 1 deyghe dge emtehan kon
            edameye in ghesmat dar Click Event vorude Login Form hast.*/
            if (!File.Exists(Path.GetTempPath() + "\\" + "frmLogin.txt"))
            {
                using(FileStream fs = File.Open(Path.GetTempPath() + "\\" + "frmLogin.txt", FileMode.CreateNew))
                {
                    using(StreamWriter sr = new StreamWriter(fs))
                    {
                        sr.WriteLine(DateTime.Now.AddMinutes(-20).ToString());
                        sr.Write("0");
                    }
                }
            }
            txtUserName.Focus();
            SetTextUserName();
            SetTextPassword();
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("select * from tblSundry",con);//in class az sql mikhandad
            data.Fill(dt);//ba in code table dt ro por mikonim
            bool checkAdminReg = (bool)dt.Rows[0]["RegisteredAdminPass"];
            if (checkAdminReg == false)
            {
                frmAddAdmin admin = new frmAddAdmin();
                admin.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// We add the information to the file to limit the login.
        /// </summary>
        /// <typeparam name="T">Type of First Value</typeparam>
        /// <typeparam name="U">Type of second value</typeparam>
        /// <param name="num">Value that you want to add in file.</param>
        /// <param name="index">Index of Line in File that you want to change.</param>
        private void SaveCounter<T, U>(T num, U index)
        {
            var lines = File.ReadAllLines(Path.GetTempPath() + "\\" + "frmLogin.txt");
            lines[ Int32.Parse(index.ToString())] = num.ToString();
            File.WriteAllLines(Path.GetTempPath() + "\\" + "frmLogin.txt",lines);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(Path.GetTempPath() + "\\" + "frmLogin.txt");
            string getDate = lines[0];
            int counter = Int32.Parse(lines[1]);
            DateTime savedTime = DateTime.Parse(getDate);
            DateTime curentTime = DateTime.Now;
            TimeSpan result = curentTime.Subtract(savedTime);
            int ckeckTime = result.Minutes;

            if (ckeckTime >= 1)
            {
                errorProvider1.Clear();
                if (string.IsNullOrWhiteSpace(txtUserName.Text) || txtUserName.Text == "نام کاربری")
                    errorProvider1.SetError(txtUserName, "لطفا یوزر نیم خود را وارد کنید");
                else if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == "رمز عبور")
                    errorProvider1.SetError(txtPassword, "لطفا پسورد را وارد کنید");
                else
                {
                    SqlCommand sqlCmdLogin = new SqlCommand();
                    sqlCmdLogin.CommandType = CommandType.Text;
                    sqlCmdLogin.Connection = con;
                    SqlDataReader myReader = null;
                    con.Open();
                    sqlCmdLogin.CommandText = "select * from tblUsers where (User_Name=@User_Name) and (User_Pass=@User_Pass)";
                    sqlCmdLogin.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = txtUserName.Text;
                    sqlCmdLogin.Parameters.Add("@User_Pass", SqlDbType.NVarChar).Value = Security.CalculateMD5Hash(txtPassword.Text);
                    myReader = sqlCmdLogin.ExecuteReader();
                    if (myReader.Read())
                    {
                        AccessLevel access = new AccessLevel();
                        AccessLevel.UserName = txtUserName.Text;
                        AccessLevel.FirstName = myReader[2].ToString();
                        access.SetAccess(txtUserName.Text);
                        myReader.Close();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا کلمه بور شما اشتباه است!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SaveCounter <int, int> (++counter, 1);
                        if(counter == 5)
                        {
                            SaveCounter <DateTime, int> (DateTime.Now, 0);
                            SaveCounter<int, int>(0, 1);
                        }
                    }
                    con.Close();
                }
            }
            else
                MessageBox.Show("لطفا 1  دقیقه دیگر امتحان کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.ForeColor == Color.Black)
                return;
            txtUserName.Text = string.Empty;
            txtUserName.ForeColor = Color.Black;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty)
                SetTextUserName();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.ForeColor == Color.Black)
                return;
            txtPassword.Text = string.Empty;
            txtPassword.ForeColor = Color.Black;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                SetTextPassword();
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPass forgetPass = new frmForgetPass();
            forgetPass.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("TabTip.exe");
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");
            Process.Start(keyboardPath);
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

    }
}
