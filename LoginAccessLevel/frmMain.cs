using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAccessLevel
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();

            gbxAddUser.Enabled = AccessLevel.FrmMainAddUser;
            gbxCalculation.Enabled = AccessLevel.FrmMainCalculation;
            gbxChangeBackColor.Enabled = AccessLevel.FrmMainChangeBackColor;
            lblUserName.Text = "!" + AccessLevel.FirstName + ", Welcom to your page";
            lblUserName.ForeColor = Color.DarkViolet;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnDefultColor_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkSlateGray;
        }

        private void btnZarb_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (Int32.Parse(txtNumberOne.Text) * Int32.Parse(txtNumberTwo.Text)).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ارور", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaghsim_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (Int32.Parse(txtNumberOne.Text) / Int32.Parse(txtNumberTwo.Text)).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ارور", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTafrigh_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (Int32.Parse(txtNumberOne.Text) - Int32.Parse(txtNumberTwo.Text)).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ارور", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJam_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (Int32.Parse(txtNumberOne.Text) + Int32.Parse(txtNumberTwo.Text)).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"ارور",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditProfile edit = new frmEditProfile();
            edit.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.ShowDialog();
        }
    }
}
