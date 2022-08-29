using System;
using System.Data.SqlClient;
using System.Data;


namespace Employee_Connected_Disconnected_Architechture
{
    class Program
    {
        SqlConnection con = new SqlConnection("data source= D147XYP3\\SQLEXPRESS; database=Training ; integrated security= SSPI"); //connection string

        static void Main(string[] args)
        {
            Program program = new Program();
            //program.empConnectedArch();
            program.empDisconnectedArch();
        }

        public void empConnectedArch()
        {
            /*string sqlQuery = "INSERT INTO Employee Values(1001,'Harry','01.01.2019',3000)";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
            sqlCommand.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            con.Close();
            Console.WriteLine("Data Inserted");*/


            using (con)
            {
                con.Open();
                var sqlQuery = "INSERT INTO Employee Values(@EMPID, @EMPNAME, @EMPDOJ, @EMPSALARY)";

                using (var cmd = new SqlCommand(sqlQuery,con))
                {
                    cmd.CommandText = "Insert Into Employee Values('" + promotext.Text + "', '" + adminemail.Text.ToString() + "' , '" + adminmob.Text.ToString() + "')";


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void empDisconnectedArch()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet d = new DataSet();
            string sqlQuery = "INSERT INTO Employee Values(1002,'Sam','30.12.2002',8000)";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
            sqlCommand.CommandType = CommandType.Text;
            sqlDataAdapter.InsertCommand = sqlCommand;
            con.Open();
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Data Inserted");
            


        }
    }
}
