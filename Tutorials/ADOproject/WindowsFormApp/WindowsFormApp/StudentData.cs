using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace Tuc.School.LogicTier
{
    public class StudentData
    {
        public DataSet GetStudentDB(string connectionString)
        {
            string selectSQL = "select StudentName, StudentNumber, SchoolName, ClassName, Grade from" +
                " StudentData order by StudentName";

            //Define the ADO.NET objects
            SqlConnection con = new SqlConnection(connectionString);

            SqlDataAdapter da = new SqlDataAdapter(selectSQL, con);

            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        public DataSet getSchoolsDB(string connectionString)
        {
            string selectSQL = "SELECT * FROM School";
            //string selectSQL = "SELECT TOP 1000 [SchoolId],[SchoolName],[Description],[Address],[Phone],[Postcode],[PostAddress] FROM [School].[dbo].[School]";
            SqlConnection con = new SqlConnection(connectionString);

            SqlDataAdapter da = new SqlDataAdapter(selectSQL, con);

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void insertQuery(string connectionString, string insertSQL)
        {
            try
            {
                //string insertSQL = "";
                SqlConnection con = new SqlConnection(connectionString);

                SqlDataAdapter da = new SqlDataAdapter(insertSQL, con);

                da.InsertCommand = new SqlCommand(insertSQL, con);
                da.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
