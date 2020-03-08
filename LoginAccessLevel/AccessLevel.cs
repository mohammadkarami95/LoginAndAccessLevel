using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LoginAccessLevel
{
    class AccessLevel
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-JHATL10\\SQL2019;Initial Catalog=DBLogin;Integrated Security=True");

        //PROPERTIES OF ACCESS LEVEL CLASS
        private static string _userName = string.Empty;
        public static string UserName
        {
            get { return _userName;}
		    set { _userName = value;}
	    }
	

        private static string _firstName = string.Empty;
        public static string FirstName
        {
            get { return _firstName;}
            set { _firstName = value;}
	    }
	
        private static bool _frmMainChangeBackColor = false;
        public static bool FrmMainChangeBackColor
        {
            get { return _frmMainChangeBackColor;}
            set { _frmMainChangeBackColor = value;}
        }
	
        private static bool _frmMainAddUser = false;
        public static bool FrmMainAddUser
        {
            get { return _frmMainAddUser;}
            set { _frmMainAddUser = value;}
        }
	
        private static bool _frmMainCalculation = false;
        public static bool FrmMainCalculation
        {
            get { return _frmMainCalculation; }
            set { _frmMainCalculation = value; }
        }
        // END OF PROPERTIES IMPLEMENTATION


        public void SetAccess(string userName)
        {
            SqlCommand sqlCmdSet = new SqlCommand();
            sqlCmdSet.CommandText = "select * from tblAccessLevel where User_Name = @User_Name";
            sqlCmdSet.Connection = con;
            sqlCmdSet.Parameters.Add("@User_Name", SqlDbType.NVarChar).Value = userName;

            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(sqlCmdSet);
            data.Fill(dt);

            AccessLevel.FrmMainAddUser = (bool)dt.Rows[0][1];
            AccessLevel.FrmMainCalculation = (bool)dt.Rows[0][3];
            AccessLevel.FrmMainChangeBackColor = (bool)dt.Rows[0][2];
        }
    }
}
