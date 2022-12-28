using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;

namespace DatabaseProject
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\harun\source\repos\DatabaseProject\DatabaseProject\App_Data\Database1.mdf;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();
        }

        protected void btnekle_Click(object sender, EventArgs e)
        {
           
           if(string.IsNullOrEmpty(tbxkitapad.Text) && string.IsNullOrEmpty(tbxyazarad.Text) && string.IsNullOrEmpty(tbxpage.Text) && string.IsNullOrEmpty(tbxbooknumber.Text))
            {


            }
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Books values('"+tbxkitapad.Text+"','"+tbxyazarad.Text+"','"+ int.Parse(tbxpage.Text)+ "','"+ int.Parse(tbxbooknumber.Text)+"')";
            cmd.ExecuteNonQuery();

            

            tbxkitapad.Text = "";
            tbxyazarad.Text = "";
            tbxpage.Text = "";
            tbxbooknumber.Text = "";

            
            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();
        }


        protected void btnbookadd_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Books set BookCount = BookCount + "+int.Parse(tbxaddingbooknumber.Text)+" where BookName = '"+tbxaddingbookname.Text+"'";
            cmd.ExecuteNonQuery();

            tbxaddingbookname.Text = "";
            tbxaddingbooknumber.Text = "";

            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();

        }






        public void disp_book_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "(select * from Books)";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridViewBook.DataSource = dt;
            GridViewBook.DataBind();

        }
        
        protected void btnlistele_Click(object sender, EventArgs e)
        {
            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();
        }

        protected void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Books where BookName = '"+tbxkitapad.Text+"'";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "delete from Books where BookID = '" + int.Parse(tbxıdnumber.Text) + "'";
            cmd1.ExecuteNonQuery();

            tbxkitapad.Text = "";
            tbxıdnumber.Text = "";

            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();

        }

        //protected void btnguncelle_Click(object sender, EventArgs e)
        //{
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "update Books set BookName='"+tbxkitapad.Text+"', WritersName='"+tbxyazarad.Text+"', PageCount='"+int.Parse(tbxpage.Text)+"', BookCount='"+int.Parse(tbxbooknumber.Text)+"' where BookID = " + int.Parse(tbxıdnumber.Text) + "";
        //    cmd.ExecuteNonQuery();

        //    tbxkitapad.Text = "";
        //    tbxyazarad.Text = "";
        //    tbxpage.Text = "";
        //    tbxbooknumber.Text = "";

        //    disp_book_data();
        //    disp_student_data();
        //    disp_fine_data();
        //    disp_taken_data();
        //    disp_borrow_data();

        //}

        protected void btnstudentinsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Students values('" + tbxstudentname.Text + "','" + tbxstudentsurname.Text + "', '" + tbxstudentid.Text + "')";
            cmd.ExecuteNonQuery();

            tbxstudentname.Text = "";
            tbxstudentsurname.Text = "";
            tbxstudentid.Text = "";

            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();

        }
        public void disp_student_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "(select * from Students)";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            GridViewStudent.DataSource = dt1;
            GridViewStudent.DataBind();

        }

        protected void btnstudentdelete_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Students where StudentSchoolID = '" + tbxstudentid.Text + "' ";
            cmd.ExecuteNonQuery();

            tbxstudentname.Text = "";


            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();
        }

        protected void btnstudentupdate_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Students set StudentName='" + tbxstudentname.Text + "', StudentSurName='" + tbxstudentsurname.Text + "', StudentSchoolID='" + tbxstudentid.Text + "'  where StudentID = " + int.Parse(tbxstudentoldıd.Text) + "";
            cmd.ExecuteNonQuery();

            tbxstudentoldıd.Text = "";

            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();
        }

        protected void btnstudentview_Click(object sender, EventArgs e)
        {
            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();
        }

        protected void btnborrowinsert_Click(object sender, EventArgs e)
        {

            var selectedBookId = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "(select BookID from Books where BookName = '" + tbxbooknameborrow.Text + "')";
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {

                while (rdr.Read())
                {
                    selectedBookId = rdr.GetInt32(0); //The 0 stands for "the 0'th column", so the first column of the result.

                }
                
            }
            

            var selectedStudentId = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "(select StudentID from Students where StudentSchoolID = '" + tbxstudentidborrow.Text + "')";
            using (SqlDataReader rdr1 = cmd1.ExecuteReader())
            {

                while (rdr1.Read())
                {
                    selectedStudentId = rdr1.GetInt32(0); //The 0 stands for "the 0'th column", so the first column of the result.

                }

            }

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into Taken_Books values('" + selectedBookId + "', '" + selectedStudentId + "', '" + 0 + "' )";
            cmd2.ExecuteNonQuery();

            tbxbooknameborrow.Text = "";
            tbxstudentidborrow.Text = "";



            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();

        }

        public void disp_borrow_data()
        {
            SqlCommand cmd5 = con.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "(select * from view2)";
            cmd5.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd5);
            da2.Fill(dt2);
            GridViewBorrow.DataSource = dt2;
            GridViewBorrow.DataBind();

        }

        protected void btnborrowdelete_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "delete from Taken_Books where TakenID = '"+tbxbookborrowingoldid.Text+"'";
            //cmd.ExecuteNonQuery();

            //tbxbookborrowingoldid.Text = "";

            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();
        }

        protected void btnborrowupdate_Click(object sender, EventArgs e)
        {



            var selectedBookId = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "(select BookID from Books where BookName = '"+tbxbooknameborrow.Text+"')";
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                
                while (rdr.Read())
                {
                    selectedBookId = rdr.GetInt32(0); //The 0 stands for "the 0'th column", so the first column of the result.
                    
                }
            }

            var selectedStudentId = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "(select StudentID from Students where StudentSchoolID = '" + tbxstudentidborrow.Text + "')";
            using (SqlDataReader rdr1 = cmd1.ExecuteReader())
            {
                
                while (rdr1.Read())
                {
                    selectedStudentId = rdr1.GetInt32(0); //The 0 stands for "the 0'th column", so the first column of the result.

                }
            }

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "update Taken_Books set IsGiven = 1 where BookID = '"+ selectedBookId + "' and StudentID = '" + selectedStudentId + "' and IsGiven = 0 ";
            cmd2.ExecuteNonQuery();

            tbxstudentidborrow.Text = "";
            tbxbooknameborrow.Text = "";

            var selectedTakenID = 0;
            SqlCommand cmd4 = con.CreateCommand();
            cmd4.CommandText = "(select TakenID from Taken_Books where StudentID = '" + selectedStudentId + "' and BookID =  '" + selectedBookId + "'    )";
            using (SqlDataReader rdr3 = cmd4.ExecuteReader())
            {

                while (rdr3.Read())
                {
                    selectedTakenID = rdr3.GetInt32(0); //The 0 stands for "the 0'th column", so the first column of the result.

                }

            }

            
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "update Taken_Dates set GivenDate= GETDATE() where TakenID = '" + selectedTakenID + "' ";
            cmd3.ExecuteNonQuery();

            var selectedTakenDAteID = 0;
            SqlCommand cmd8 = con.CreateCommand();
            cmd8.CommandText = "(select TakenDateID from Taken_Dates where TakenID =  '" + selectedTakenID + "'    )";
            using (SqlDataReader rdr8 = cmd8.ExecuteReader())
            {

                while (rdr8.Read())
                {
                    selectedTakenDAteID = rdr8.GetInt32(0); //The 0 stands for "the 0'th column", so the first column of the result.

                }

            }


            DateTime dt1 = new DateTime();
            SqlCommand cmd6 = con.CreateCommand();
            cmd6.CommandText = "(select TakenDate from Taken_Dates where TakenID = '" + selectedTakenID + "'   )";
            using (SqlDataReader rdr5 = cmd6.ExecuteReader())
            {

                while (rdr5.Read())
                {
                    dt1 = rdr5.GetDateTime(0); //The 0 stands for "the 0'th column", so the first column of the result.

                }

            }

            DateTime dt2 = dt1.AddDays(10);

            DateTime dt3 = DateTime.Now; 

            if (dt3.Date > dt2.Date)
            {
                SqlCommand cmd7 = con.CreateCommand();
                cmd7.CommandType = CommandType.Text;
                cmd7.CommandText = "insert into Fine values (0, 50,'" + selectedStudentId + "','" + selectedTakenDAteID + "') ";
                cmd7.ExecuteNonQuery();
            }
     
            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();



        }

        protected void btnborrowview_Click(object sender, EventArgs e)
        {
            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();
        }

        protected void btntakenview_Click(object sender, EventArgs e)
        {
            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();
        }
        public void disp_taken_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "(select * from Taken_Dates)";
            cmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt2);
            GridViewTaken.DataSource = dt2;
            GridViewTaken.DataBind();

        }

        protected void btnfineview_Click(object sender, EventArgs e)
        {
            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();
        }

        public void disp_fine_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "(select * from view1)";
            cmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt2);
            GridViewFine.DataSource = dt2;
            GridViewFine.DataBind();

        }


        protected void btnfinedelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Fine where FineID = '"+ int.Parse(tbxfineoldid.Text) + "'";
            cmd.ExecuteNonQuery();


            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();
        }

       

        protected void btnfinepaid_Click (object sender, EventArgs e)
        {


            var selectedStudentId = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "(select StudentID from Students where StudentSchoolID = '" + tbxfinepayedamount.Text + "')";
            using (SqlDataReader rdr1 = cmd1.ExecuteReader())
            {

                while (rdr1.Read())
                {
                    selectedStudentId = rdr1.GetInt32(0); //The 0 stands for "the 0'th column", so the first column of the result.

                }
            }

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "update Fine set IsPaid = 1 where  StudentID = '" + selectedStudentId + "' and IsPaid = 0 ";
            cmd2.ExecuteNonQuery();


            disp_book_data();
            disp_student_data();
            disp_fine_data();
            disp_taken_data();
            disp_borrow_data();
        }

    }
}
