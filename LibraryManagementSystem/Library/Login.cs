using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    class Login
    {
        string userName = "", password = "", typeUser = "";

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string TypeUser
        {
            get { return typeUser; }
            set { typeUser = value; }
        }

        public DataTable login()
        {
            SqlConnection con = new SqlConnection
           ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("DetecUserType", con);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@userName", userName);
            da.SelectCommand.Parameters.AddWithValue("@password", password);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;


        }
    }
}
