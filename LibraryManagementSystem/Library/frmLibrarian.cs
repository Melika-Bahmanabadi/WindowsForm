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
    public partial class frmLibrarian : Form
    {
        public frmLibrarian()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void t3txtBookPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void t1btnRegister_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.StudentID = t1txtStudentID.Text;
            s.FirstName = t1txtFirstName.Text;
            s.LastName = t1txtLastName.Text;
            s.Field = t1cbField.Text;
            s.Section = t1cbSection.Text;
            s.Inning = t1cbInning.Text;
            s.MobileNo = t1txtMobileNo.Text;
            s.PhoneNo = t1txtPhoneNo.Text;
            s.Email = t1txtEmail.Text;
           
            if (t1rbFemale.Checked == true)
            {
                s.Gender = "زن";
            }
            else if (t1rbMale.Checked == true)
            {
                s.Gender = "مرد";
            }
            if (t1rbSingle.Checked==true)
            {
                s.MaritalStatus = "مجرد";
            }
            else if (t1rbMarried.Checked == true)
            {
                s.MaritalStatus = "متاهل";
            }


            s.BirthdayDate = t1txtBirthYear.Text + "/" + t1txtBirthMonth.Text + "/" + t1txtBirthDay.Text;
            s.EducationStartDate = t1txtStartEducationYear.Text+"/"+t1txtStartEducationMonth.Text+"/"+t1txtStartEducationDay.Text;
            s.EducationEndDate = t1txtEndEducationYear.Text + "/" + t1txtEndEducationMonth.Text + "/" + t1txtEndEducationDay.Text;


            s.BorrowedBookQty = "0";
            //s.insertStudent();
            DataTable dt = s.search();
            if (dt.Rows.Count == 0)
                s.insertStudent();
            else
                MessageBox.Show("این دانشجو قبلا ثبت نام شده است.");

            //خالی شدن آیتم ها پس از زدن دکمه ثبت نام

            t1txtStudentID.Text = "";
            t1txtFirstName.Text = "";
            t1txtLastName.Text = "";
            t1cbField.Text = "";
            t1cbSection.Text = "";
            t1cbInning.Text = "";
            t1txtMobileNo.Text = "";
            t1txtPhoneNo.Text = "";
            t1txtEmail.Text = "";

            t1rbFemale.Checked = false;
            t1rbMale.Checked = false;
            t1rbSingle.Checked = false;
            t1rbMarried.Checked = false;

            t1txtBirthYear.Text = "";
            t1txtBirthMonth.Text = "";
            t1txtBirthDay.Text = "";

            t1txtStartEducationYear.Text = "";
            t1txtStartEducationMonth.Text = "";
            t1txtStartEducationDay.Text = "";

            t1txtEndEducationYear.Text = "";
            t1txtEndEducationMonth.Text = "";
            t1txtEndEducationDay.Text = "";







        }

        private void t3btnInsert_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.BookCategorizationNo = t3txtCategorizationNo.Text;
            b.BookName = t3txtBookName.Text;
            b.AuthorName = t3txtAuthorName.Text;
            b.BookQty = t3txtBookQty.Text;
            b.ISBN1 = t3txtISBN.Text;
            b.PublisherName = t3txtPublisherName.Text;
            b.PublishYear = t3txtPublishYear.Text;
            b.EditionNo = t3txtEditionNo.Text;
            b.PrintQty = t3txtPrintQty.Text;
            b.BookPrice = t3txtBookPrice.Text;

            //b.insertBook();

            DataTable dt = b.search();
            if (dt.Rows.Count == 0)
                b.insertBook();
            else
                MessageBox.Show("این کتاب قبلا ثبت شده است.");


            //خالی کردن آیتم ها بعد از زدن دکمه درج

            t3txtCategorizationNo.Text = "";
            t3txtBookName.Text = "";
            t3txtAuthorName.Text = "";
            t3txtBookQty.Text = "";
            t3txtISBN.Text = "";
            t3txtPublisherName.Text = "";
            t3txtPublishYear.Text = "";
            t3txtEditionNo.Text = "";
            t3txtPrintQty.Text = "";
            t3txtBookPrice.Text = "";


        }

        private void t2btnDelete_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.StudentID = head_t2txtStudentID.Text;
            s.deleteStudent();

            //خالی شدن آیتم ها پس از زدن دکمه حدف


            head_t2txtStudentID.Text = "";
            t2txtFirstName.Text = "";
            t2txtLastName.Text = "";
            t2cbField.Text = "";
            t2cbSection.Text = "";
            t2cbInning.Text = "";
            t2txtMobileNo.Text = "";
            t2txtPhoneNo.Text = "";
            t2txtEmail.Text = "";
            t2txtBorrowedBook.Text = "";

            t2rbFemale.Checked = false;
            t2rbMale.Checked = false;
            t2rbSingle.Checked = false;
            t2rbMarried.Checked = false;

            t2txtBirthYear.Text = "";
            t2txtBirthMonth.Text = "";
            t2txtBirthDay.Text = "";

            t2txtStartEducationYear.Text = "";
            t2txtStartEducationMonth.Text = "";
            t2txtStartEducationDay.Text = "";

            t2txtEndEducationYear.Text = "";
            t2txtEndEducationMonth.Text = "";
            t2txtEndEducationDay.Text = "";


            t2panel.Enabled = false;

        }

        private void t2btnSearch_Click(object sender, EventArgs e)
        {
            
            Student s = new Student();
            s.StudentID = head_t2txtStudentID.Text;
            DataTable dt = s.search();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("این دانشجو قبلا ثبت نام نشده است.");
            }

            else
            {
                t2panel.Enabled = true;
                t2txtFirstName.Text = dt.Rows[0]["firstName"].ToString();
                t2txtLastName.Text = dt.Rows[0]["lastName"].ToString();
                t2cbField.Text = dt.Rows[0]["field"].ToString();
                t2cbSection.Text = dt.Rows[0]["section"].ToString();
                t2cbInning.Text = dt.Rows[0]["inning"].ToString();
                t2txtMobileNo.Text = dt.Rows[0]["mobileNo"].ToString();
                t2txtPhoneNo.Text = dt.Rows[0]["phoneNo"].ToString();
                t2txtEmail.Text = dt.Rows[0]["email"].ToString();
                t2txtBorrowedBook.Text = dt.Rows[0]["borrowedBookQty"].ToString();

                if (dt.Rows[0]["gender"].ToString() == "زن")
                    t2rbFemale.Checked = true;
                else if (dt.Rows[0]["gender"].ToString() == "مرد")
                    t2rbMale.Checked = true;


                if (dt.Rows[0]["maritalStatus"].ToString() == "مجرد")
                    t2rbSingle.Checked = true;
                else if (dt.Rows[0]["maritalStatus"].ToString() == "متاهل")
                    t2rbMarried.Checked = true;


                string[] bd = dt.Rows[0]["birthdayDate"].ToString().Split('/');

                t2txtBirthYear.Text = bd[0];
                t2txtBirthMonth.Text = bd[1];
                t2txtBirthDay.Text = bd[2];


                string[] esd = dt.Rows[0]["educationStartDate"].ToString().Split('/');

                t2txtStartEducationYear.Text = esd[0];
                t2txtStartEducationMonth.Text = esd[1];
                t2txtStartEducationDay.Text = esd[2];



                string[] eed = dt.Rows[0]["educationEndDate"].ToString().Split('/');

                t2txtEndEducationYear.Text = eed[0];
                t2txtEndEducationMonth.Text = eed[1];
                t2txtEndEducationDay.Text = eed[2];

            }



        }

        private void t2btnEdit_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.StudentID = head_t2txtStudentID.Text;
            s.FirstName = t2txtFirstName.Text;
            s.LastName = t2txtLastName.Text;
            s.Field = t2cbField.Text;
            s.Section = t2cbSection.Text;
            s.Inning = t2cbInning.Text;
            s.MobileNo = t2txtMobileNo.Text;
            s.PhoneNo = t2txtPhoneNo.Text;
            s.BorrowedBookQty = t2txtBorrowedBook.Text;
            s.Email = t2txtEmail.Text;
            if (t2rbFemale.Checked == true)
            {
                s.Gender = "زن";
            }
            else if (t2rbMale.Checked == true)
            {
                s.Gender = "مرد";
            }
            if (t2rbSingle.Checked == true)
            {
                s.MaritalStatus = "مجرد";
            }
            else if (t2rbMarried.Checked == true)
            {
                s.MaritalStatus = "متاهل";
            }
            s.BirthdayDate = t2txtBirthYear.Text + "/" + t2txtBirthMonth.Text + "/" + t2txtBirthDay.Text;
            s.EducationStartDate = t2txtStartEducationYear.Text + "/" + t2txtStartEducationMonth.Text + "/" + t2txtStartEducationDay.Text;
            s.EducationEndDate = t2txtEndEducationYear.Text + "/" + t2txtEndEducationMonth.Text + "/" + t2txtEndEducationDay.Text;
            s.updateStudent();


            //خالی شدت آیتم ها پس از زدن دکمه ویرایش



            head_t2txtStudentID.Text = "";
            t2txtFirstName.Text = "";
            t2txtLastName.Text = "";
            t2cbField.Text = "";
            t2cbSection.Text = "";
            t2cbInning.Text = "";
            t2txtMobileNo.Text = "";
            t2txtPhoneNo.Text = "";
            t2txtEmail.Text = "";
            t2txtBorrowedBook.Text = "";

            t2rbFemale.Checked = false;
            t2rbMale.Checked = false;
            t2rbSingle.Checked = false;
            t2rbMarried.Checked = false;

            t2txtBirthYear.Text = "";
            t2txtBirthMonth.Text = "";
            t2txtBirthDay.Text = "";

            t2txtStartEducationYear.Text = "";
            t2txtStartEducationMonth.Text = "";
            t2txtStartEducationDay.Text = "";

            t2txtEndEducationYear.Text = "";
            t2txtEndEducationMonth.Text = "";
            t2txtEndEducationDay.Text = "";


            t2panel.Enabled = false;


        }

        private void head_t4btnSearch_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.BookCategorizationNo = head_t4txtCategorizationNo.Text;
            DataTable dt = b.search();

            if (dt.Rows.Count == 0)
                MessageBox.Show("این کتاب قبلا ثبت نشده است.");
            else
            {
                t4panel.Enabled = true;

                t4txtBookName.Text = dt.Rows[0]["bookName"].ToString();
                t4txtAuthorName.Text = dt.Rows[0]["authorName"].ToString();
                t4txtBookQty.Text = dt.Rows[0]["bookQty"].ToString();
                t4txtISBN.Text = dt.Rows[0]["ISBN"].ToString();
                t4txtPublisherName.Text = dt.Rows[0]["publisherName"].ToString();
                t4txtPublishYear.Text = dt.Rows[0]["publishYear"].ToString();
                t4txtEditionNo.Text = dt.Rows[0]["editionNo"].ToString();
                t4txtPrintQty.Text = dt.Rows[0]["printQty"].ToString();
                t4txtBookPrice.Text = dt.Rows[0]["bookPrice"].ToString();
            }

        }

        private void t4btnDelete_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.BookCategorizationNo = head_t4txtCategorizationNo.Text;
            b.deleteBook();


            //خالی کردن آیتم ها بعد از زدن دکمه ویرایش

            head_t4txtCategorizationNo.Text = "";
            t4txtBookName.Text = "";
            t4txtAuthorName.Text = "";
            t4txtBookQty.Text = "";
            t4txtISBN.Text = "";
            t4txtPublisherName.Text = "";
            t4txtPublishYear.Text = "";
            t4txtEditionNo.Text = "";
            t4txtPrintQty.Text = "";
            t4txtBookPrice.Text = "";

            t4panel.Enabled = false;


        }

        private void t4btnEdit_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.BookCategorizationNo = head_t4txtCategorizationNo.Text;
            b.BookName = t4txtBookName.Text;
            b.AuthorName = t4txtAuthorName.Text;
            b.BookQty = t4txtBookQty.Text;
            b.ISBN1 = t4txtISBN.Text;
            b.PublisherName = t4txtPublisherName.Text;
            b.PublishYear = t4txtPublishYear.Text;
            b.EditionNo = t4txtEditionNo.Text;
            b.PrintQty = t4txtPrintQty.Text;
            b.BookPrice = t4txtBookPrice.Text;
            b.updateBook();

            //خالی کردن آیتم ها بعد از زدن دکمه ویرایش

            head_t4txtCategorizationNo.Text = "";
            t4txtBookName.Text = "";
            t4txtAuthorName.Text = "";
            t4txtBookQty.Text = "";
            t4txtISBN.Text = "";
            t4txtPublisherName.Text = "";
            t4txtPublishYear.Text = "";
            t4txtEditionNo.Text = "";
            t4txtPrintQty.Text = "";
            t4txtBookPrice.Text = "";

            t4panel.Enabled = false;



        }

        private void t2rbMarried_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void t1txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void t5btnBorrow_Click(object sender, EventArgs e)
        {

            int tkd = 6, tkm = -1;

            //code for tkd

            Student s = new Student();
            s.StudentID = t5txtBorrowtStudentID.Text;
            DataTable  dts = s.search();

            if (dts.Rows.Count == 0)
            {
                MessageBox.Show("چنین دانشجویی نداریم");
            }
            else
            {
                tkd = Convert.ToInt32(dts.Rows[0]["borrowedBookQty"].ToString());
            }
            
           
            //code for tkm

            Book b = new Book();
            b.BookCategorizationNo = t5txtBorrowCategorizationNo.Text;
            DataTable dtb = b.search();

            if (dtb.Rows.Count == 0)
            {
                MessageBox.Show("چنین کتابی نداریم");

            }
            else
            {
                tkm = Convert.ToInt32(dtb.Rows[0]["bookQty"].ToString());
            }

            if (tkd < 5 && tkm > 0)
            {
                Borrow borrow = new Borrow();
                borrow.StudentID = t5txtBorrowtStudentID.Text;
                borrow.BookCategorizationNo = t5txtBorrowCategorizationNo.Text;
                borrow.BorrowDate = t5txtBorrowYear.Text + "/" + t5txtBorrowMonth.Text + "/" + t5txtBorrowDay.Text;
                borrow.insertBorrow();

                tkm --;
                tkd ++;

                s.BorrowedBookQty = Convert.ToString(tkd);
                s.edit_std_amanat();


                b.BookQty = Convert.ToString(tkm);
                b.edit_book_amanat();

            }
            else if(tkd==5)
            {
                MessageBox.Show("دانشجوی گرامی شما حداکثر5 کتاب می توانید به امانت داشته باشید. لطفا یکی از آن ها را بازگردانید");
            }
            else if(tkm == 0)
            {
                MessageBox.Show("کتاب به امانت دیگری است. لطفا رزرو کنید");
            }


            t5txtBorrowtStudentID.Text = "";
            t5txtBorrowCategorizationNo.Text = "";
            t5txtBorrowYear.Text = "";
            t5txtBorrowMonth.Text = "";
            t5txtBorrowDay.Text = "";



        }

        private void t5btnReturn_Click(object sender, EventArgs e)
        {
            int tkd=6, tkm=-1;

            //code for tkd

            Student s = new Student();
            s.StudentID = t5txtReturntStudentID.Text;
            DataTable dts = s.search();

            if (dts.Rows.Count == 0)
            {
                MessageBox.Show("چنین دانشجویی نداریم");
            }
            else
            {
                tkd = Convert.ToInt32(dts.Rows[0]["borrowedBookQty"].ToString());
            }

            //code for tkm

            Book b = new Book();
            b.BookCategorizationNo = t5txtReturnCategorizationNo.Text;
            DataTable dtb = b.search();

            if (dtb.Rows.Count == 0)
            {
                MessageBox.Show("چنین کتابی نداریم");

            }
            else
            {
                tkm = Convert.ToInt32(dtb.Rows[0]["bookQty"].ToString());
            }

            if (tkd == 0)
            {
                MessageBox.Show("این دانشجو کتابی در دست امانت ندارد");
            }

            if ( (dts.Rows.Count != 0) && (dtb.Rows.Count != 0) && (tkd !=0) )
            {
                Borrow borrow = new Borrow();
                borrow.StudentID = t5txtReturntStudentID.Text;
                borrow.BookCategorizationNo = t5txtReturnCategorizationNo.Text;
                borrow.ReturnDate = t5txtReturnYear.Text + "/" + t5txtReturnMonth.Text + "/" + t5txtReturnDay.Text;
                borrow.updateBorrow();

                tkm++;
                tkd--;

                s.BorrowedBookQty = Convert.ToString(tkd);
                s.edit_std_amanat();

                b.BookQty = Convert.ToString(tkm);
                b.edit_book_amanat();
            }


            t5txtReturntStudentID.Text = "";
            t5txtReturnCategorizationNo.Text = "";
            t5txtReturnYear.Text = "";
            t5txtReturnMonth.Text = "";
            t5txtReturnDay.Text = "";




        }
    }
}
