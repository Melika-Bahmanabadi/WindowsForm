using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmStudent : Form
    {
        string std_id_sarasari;

        public frmStudent()
        {
            InitializeComponent();
        }

        public frmStudent(string std_id_ersali)
        {
            InitializeComponent();
            std_id_sarasari = std_id_ersali;
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            Student s = new Student();
            s.StudentID = std_id_sarasari;

            DataTable dt = s.search();

            if (dt.Rows[0]["gender"].ToString() == "زن")
            {
                this.Text = " خوش آمدید خانم " + dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();

            }
            else
            {
                    this.Text = "خوش آمدید آقای  " + dt.Rows[0]["firstName"].ToString() + " " + dt.Rows[0]["lastName"].ToString();

            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.BookName = txtBookName.Text;
            b.AuthorName = txtAuthorName.Text;
            DataSet ds= b.search_book_by_name();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds.Tables["tblSearchBook"];

        }

      
    }
}
