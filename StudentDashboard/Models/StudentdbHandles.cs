using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StudentDashboard.Models
{
    //Creating a new class
    public class StudentdbHandles
    {
        #region Fields
        private SqlConnection con;
        private DataSet ds;
        SqlCommand cmd;
        #endregion

        #region DataConnection
        private void connection()
        {
            string conString = ConfigurationManager.ConnectionStrings["Studentcon"].ToString();
            con = new SqlConnection(conString);

        }
        #endregion

        #region GetAllDetails
        //Retrieving all student details 
        public List<StudentModel> GetAllDetails()
        {
            connection();
            con.Open();
            List<StudentModel> students = new List<StudentModel>();
            string query = "select * from StudentRegForm";
            cmd = new SqlCommand(query, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adap.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    students.Add(new StudentModel { ID = Convert.ToInt32(row["ID"]), FirstName = row["FirstName"].ToString() });
                }
            }
            return students;

        }

        internal void InsertDetails()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region InsertDetails
        //Creating a new Student record
        public bool InsertDetails(StudentModel sm)
        {
            connection();
            con.Open();
            string query = "insert into StudentRegForm values(@LastName,@FirstName,@Gender,@City,@County)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@LastName", sm.LastName));
            cmd.Parameters.Add(new SqlParameter("@FirstName", sm.FirstName));
            cmd.Parameters.Add(new SqlParameter("@Gender", sm.FirstName));
            cmd.Parameters.Add(new SqlParameter("@City", sm.City));
            cmd.Parameters.Add(new SqlParameter("@Country", sm.Country));
            int num = cmd.ExecuteNonQuery();
            
            if (num >= 1)
                return true;
            else
                return false;

        }
        #endregion

        #region Update
        // Update the student record
        public bool UpdateDetails(StudentModel sm)
        {
            connection();
            con.Open();
            string query = "update StudentRegForm set ID=@ID,Lastname=@LastName,FirstName=@FirstName,Gender=@Gender,City=@City,County=@County";
            cmd = new SqlCommand(query, con);
            //cmd.Parameters.Add(new SqlParameter("@ID", sm.ID));
            cmd.Parameters.Add(new SqlParameter("@LastName", sm.LastName));
            cmd.Parameters.Add(new SqlParameter("@FirstName", sm.FirstName));
            cmd.Parameters.Add(new SqlParameter("@Gender", sm.FirstName));
            cmd.Parameters.Add(new SqlParameter("@City", sm.City));
            cmd.Parameters.Add(new SqlParameter("@Country", sm.Country));
            int num = cmd.ExecuteNonQuery();

            if (num >= 1)
                return true;
            else
                return false;

        }
        #endregion
    }
}