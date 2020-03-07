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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-JHATL10\\SQL2019;Initial Catalog=DBLogin;Integrated Security=True");
        private void frmLogin_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("select * from tblSundry",con);
            data.Fill(dt);
            bool checkAdminReg = (bool)dt.Rows[0]["RegisteredAdminPass"];
            if (checkAdminReg == false)
            {
                frmAddAdmin admin = new frmAddAdmin();
                admin.ShowDialog();
            }
        }
    }
}
