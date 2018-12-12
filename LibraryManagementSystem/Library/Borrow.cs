using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    class Borrow
    {
        string studentID = "", bookCategorizationNo = "", borrowDate = "", returnDate = "";

        public string StudentID
        {
            get {return studentID; }

            set {studentID = value;}
        }
        public string BookCategorizationNo
        {
            get {return bookCategorizationNo;}

            set { bookCategorizationNo = value; }
        }

        public string BorrowDate
        {
            get {return borrowDate;}

            set{borrowDate = value;}
        }

        public string ReturnDate
        {
            get {return returnDate;}

            set {returnDate = value;}
        }

        public void insertBorrow()
        {

            SqlConnection con = new SqlConnection
               ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("InsertBorrow", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@studentID", StudentID);
            cmd.Parameters.AddWithValue("@bookCategorizationNo", BookCategorizationNo);
            cmd.Parameters.AddWithValue("@borrowDate", BorrowDate);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("کتاب مورد نظر با موفقیت به امانت داده شد", "امانت");

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);

            }

        }
        public void updateBorrow()
        {
            SqlConnection con = new SqlConnection
              ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("UpdateBorrow", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@studentID", StudentID);
            cmd.Parameters.AddWithValue("@bookCategorizationNo", BookCategorizationNo);
            cmd.Parameters.AddWithValue("@returnDate", ReturnDate);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("کتاب مورد نظر با موفقیت بازگشت داده شد", "بازگشت");

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);

            }

        }

      
    }
}
