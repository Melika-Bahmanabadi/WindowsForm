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
    class Book
    {
        string bookCategorizationNo = "", bookName = "", authorName = "", bookQty = "", ISBN = "", publisherName = "",
            publishYear = "", editionNo = "", printQty = "", bookPrice = "";

        public string AuthorName
        {
            get
            {
                return authorName;
            }

            set
            {
                authorName = value;
            }
        }

        public string BookCategorizationNo
        {
            get
            {
                return bookCategorizationNo;
            }

            set
            {
                bookCategorizationNo = value;
            }
        }

        public string BookName
        {
            get
            {
                return bookName;
            }

            set
            {
                bookName = value;
            }
        }

        public string BookPrice
        {
            get
            {
                return bookPrice;
            }

            set
            {
                bookPrice = value;
            }
        }

        public string BookQty
        {
            get
            {
                return bookQty;
            }

            set
            {
                bookQty = value;
            }
        }

        public string EditionNo
        {
            get
            {
                return editionNo;
            }

            set
            {
                editionNo = value;
            }
        }

        public string ISBN1
        {
            get
            {
                return ISBN;
            }

            set
            {
                ISBN = value;
            }
        }

        public string PrintQty
        {
            get
            {
                return printQty;
            }

            set
            {
                printQty = value;
            }
        }

        public string PublisherName
        {
            get
            {
                return publisherName;
            }

            set
            {
                publisherName = value;
            }
        }

        public string PublishYear
        {
            get
            {
                return publishYear;
            }

            set
            {
                publishYear = value;
            }
        }


        public void insertBook()
        {
            SqlConnection con = new SqlConnection
                ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;Connect Timeout=30");

            SqlCommand cmd = new SqlCommand("InsertBook",con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bookCategorizationNo", bookCategorizationNo);
            cmd.Parameters.AddWithValue("@bookName", bookName);
            cmd.Parameters.AddWithValue("@authorName", authorName);
            cmd.Parameters.AddWithValue("@bookQty", bookQty);
            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            cmd.Parameters.AddWithValue("@publisherName", publisherName);
            cmd.Parameters.AddWithValue("@publishYear", publishYear);
            cmd.Parameters.AddWithValue("@editionNo", editionNo);
            cmd.Parameters.AddWithValue("@printQty", printQty);
            cmd.Parameters.AddWithValue("@bookPrice", bookPrice);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات کتاب با موفقیت ثبت شد.", "ثبت");



            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
                
            }
        }

        public void deleteBook()
        {
            SqlConnection con = new SqlConnection
            ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("DeleteBook", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bookCategorizationNo", BookCategorizationNo);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات کتاب با موفقیت حذف شد.", "حدف");

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);

            }
        }

        public void updateBook()
        {


            SqlConnection con = new SqlConnection
               ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("UpdateBook", con);

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@bookCategorizationNo", BookCategorizationNo);
            cmd.Parameters.AddWithValue("@bookName", BookName);
            cmd.Parameters.AddWithValue("@authorName", AuthorName);
            cmd.Parameters.AddWithValue("@bookQty", BookQty);
            cmd.Parameters.AddWithValue("@ISBN", ISBN1);
            cmd.Parameters.AddWithValue("@publisherName", PublisherName);
            cmd.Parameters.AddWithValue("@publishYear", PublishYear);
            cmd.Parameters.AddWithValue("@editionNo", EditionNo);
            cmd.Parameters.AddWithValue("@printQty", PrintQty);
            cmd.Parameters.AddWithValue("@bookPrice", BookPrice);
          
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات کتاب با موفقیت به روز رسانی شد.", "به روز رسانی");

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);

            }


        }

        public DataTable search()
        {
            SqlConnection con = new SqlConnection
          ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("SearchBookByID", con);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@bookCategorizationNo", bookCategorizationNo);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;


        }

        public DataSet search_book_by_name()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SearchBookByName", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@bookName",BookName);
            da.SelectCommand.Parameters.AddWithValue("@authorName",AuthorName);

            DataSet ds = new DataSet();
            da.Fill(ds,"tblSearchBook");
            return ds;
        }

        public void edit_book_amanat()
        {

            SqlConnection con = new SqlConnection
               ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("UpdateBook_bookQty", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bookCategorizationNo", BookCategorizationNo);
            cmd.Parameters.AddWithValue("@bookQty", BookQty);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
         
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);

            }

        }


    }
}
