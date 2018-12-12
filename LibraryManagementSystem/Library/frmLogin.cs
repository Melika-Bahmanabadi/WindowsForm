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

namespace Library
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login l = new Login();

            l.UserName = txtUserName.Text;
            l.Password = txtPasswprd.Text;

            DataTable dt = l.login();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("نام کاربری یا رمز عبور را اشتباه وارد کرده اید.");
            }

            else if(dt.Rows[0]["typeUser"].ToString()== "librarian")
            {
                frmLibrarian f = new frmLibrarian();
                f.Show();

            }

            else if (dt.Rows[0]["typeUser"].ToString() == "student")
            {
                frmStudent f = new frmStudent(txtUserName.Text);
                f.Show();

            }
        }
    }
}
