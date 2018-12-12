using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Library
{
    class Student
    {
        string studentID = "", firstName = "", lastName = "", field = "", section = "", inning = "", mobileNo = "",
            phoneNo = "", email = "", borrowedBookQty = "", gender = "", maritalStatus = "", birthdayDate = "",
            educationStartDate = "", educationEndDate = "";

        public string BirthdayDate
        {
            get
            {
                return birthdayDate;
            }

            set
            {
                birthdayDate = value;
            }
        }

        public string BorrowedBookQty
        {
            get
            {
                return borrowedBookQty;
            }

            set
            {
                borrowedBookQty = value;
            }
        }

        public string EducationEndDate
        {
            get
            {
                return educationEndDate;
            }

            set
            {
                educationEndDate = value;
            }
        }

        public string EducationStartDate
        {
            get
            {
                return educationStartDate;
            }

            set
            {
                educationStartDate = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Field
        {
            get
            {
                return field;
            }

            set
            {
                field = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Inning
        {
            get
            {
                return inning;
            }

            set
            {
                inning = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string MaritalStatus
        {
            get
            {
                return maritalStatus;
            }

            set
            {
                maritalStatus = value;
            }
        }

        public string MobileNo
        {
            get
            {
                return mobileNo;
            }

            set
            {
                mobileNo = value;
            }
        }

        public string PhoneNo
        {
            get
            {
                return phoneNo;
            }

            set
            {
                phoneNo = value;
            }
        }

        public string Section
        {
            get
            {
                return section;
            }

            set
            {
                section = value;
            }
        }

        public string StudentID
        {
            get
            {
                return studentID;
            }

            set
            {
                studentID = value;
            }
        }


        public void insertStudent()
        {
            SqlConnection con = new SqlConnection
                ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("InsertStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@studentID", StudentID);
            cmd.Parameters.AddWithValue("@firstName", FirstName);
            cmd.Parameters.AddWithValue("@lastName", LastName);
            cmd.Parameters.AddWithValue("@field", Field);
            cmd.Parameters.AddWithValue("@section", Section);
            cmd.Parameters.AddWithValue("@inning", Inning);
            cmd.Parameters.AddWithValue("@mobileNo", MobileNo);
            cmd.Parameters.AddWithValue("@phoneNo", PhoneNo);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@borrowedBookQty", BorrowedBookQty);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@maritalStatus", MaritalStatus);
            cmd.Parameters.AddWithValue("@birthdayDate", BirthdayDate);
            cmd.Parameters.AddWithValue("@educationStartDate", EducationStartDate);
            cmd.Parameters.AddWithValue("@educationEndDate", EducationEndDate);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات دانشجو با موفقیت ثبت شد", "ثبت");

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
                
            }
        }
        
        public void deleteStudent()
    {
        SqlConnection con = new SqlConnection
            ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

        SqlCommand cmd = new SqlCommand("DeleteStudent", con);

        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@studentID", StudentID);

        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("اطلاعات دانشجو با موفقیت حذف شد.", "حدف");

        }
        catch (SqlException err)
        {
            MessageBox.Show(err.Message);

        }
    }

        public void updateStudent()
        {
            SqlConnection con = new SqlConnection
                ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("UpdateStudent", con);

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@studentID", StudentID);
            cmd.Parameters.AddWithValue("@firstName", FirstName);
            cmd.Parameters.AddWithValue("@lastName", LastName);
            cmd.Parameters.AddWithValue("@field", Field);
            cmd.Parameters.AddWithValue("@section", Section);
            cmd.Parameters.AddWithValue("@inning", Inning);
            cmd.Parameters.AddWithValue("@mobileNo", MobileNo);
            cmd.Parameters.AddWithValue("@phoneNo", PhoneNo);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@borrowedBookQty", BorrowedBookQty);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@maritalStatus", MaritalStatus);
            cmd.Parameters.AddWithValue("@birthdayDate", BirthdayDate);
            cmd.Parameters.AddWithValue("@educationStartDate", EducationStartDate);
            cmd.Parameters.AddWithValue("@educationEndDate", EducationEndDate);



            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات دانشجو با موفقیت به روز رسانی شد.", "به روز رسانی");

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

            SqlDataAdapter da = new SqlDataAdapter("SearchStudentById", con);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@studentID", studentID);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        public void edit_std_amanat(){
            
            SqlConnection con = new SqlConnection
               ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("UpdateStudent_borrowedBookQty", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@studentID", StudentID); 
            cmd.Parameters.AddWithValue("@borrowedBookQty", BorrowedBookQty);
        
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
