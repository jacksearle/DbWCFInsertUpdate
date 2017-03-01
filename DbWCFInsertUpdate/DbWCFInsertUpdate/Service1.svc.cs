using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DbWCFInsertUpdate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //public DataSet SelectUserDetails()
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=SSPI;");
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM [TEST].[dbo].[TEST_TABLE]");
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    sda.Fill(ds);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    return (ds);
        //}

        public string InsertUserInformation(UserDetails userInfo)
        {
            string Message;
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=SSPI;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TEST_TABLE(ID, FNAME, SNAME) VALUES(@ID, @FNAME, @SNAME)", con);
            cmd.Parameters.AddWithValue("@ID", userInfo.ID);
            cmd.Parameters.AddWithValue("@FNAME", userInfo.FNAME);
            cmd.Parameters.AddWithValue("@SNAME", userInfo.SNAME);
            int result = cmd.ExecuteNonQuery();
            if(result == 1)
            {
                Message = userInfo.ID + "Details inserted succesfully";
            }
            else
            {
                Message = userInfo.ID + "Insert failure";
            }
            con.Close();
            return Message;
        }

        public string UpdateUserInformation(UserDetails userInfo)
        {
            string Message;
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=SSPI;");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TEST_TABLE SET FNAME=@FNAME, SNAME=@SNAME WHERE ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", userInfo.ID);
            cmd.Parameters.AddWithValue("@FNAME", userInfo.FNAME);
            cmd.Parameters.AddWithValue("@SNAME", userInfo.SNAME);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = userInfo.ID + "Details updated succesfully";
            }
            else
            {
                Message = userInfo.ID + "Update failure";
            }
            con.Close();
            return Message;
        }
    }
}
