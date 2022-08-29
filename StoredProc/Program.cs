using System;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace StoredProc
{
    class Program
    {
        SqlConnection con = new SqlConnection("data source= D147XYP3\\SQLEXPRESS; database=Training ; integrated security= SSPI"); //connection string

        static void Main(string[] args)
        {
            //InsertRecords();
            //storedProc();
        }


        /*public static void InsertRecords() // Insert data using Stored Procedure
        {
            try
            {
                SqlConnection con = new SqlConnection("data source= D147XYP3\\SQLEXPRESS; database=Training ; integrated security= SSPI"); //connection string
                               
                string storedProc = "sp_InsertRecord";
                SqlCommand cmd = new SqlCommand(storedProc, con); //(query to be executed, connection)
                cmd.CommandType = CommandType.StoredProcedure; //mentioning it is stored procedure

                cmd.Parameters.Add("@StudentName", SqlDbType.NVarChar);
                cmd.Parameters[0].Value = "NewName";

                cmd.Parameters.Add("@StudentEmail", SqlDbType.NVarChar);
                cmd.Parameters[1].Value = "abc@gmail.com";

                cmd.Parameters.Add("@StudentClass", SqlDbType.Int);
                cmd.Parameters[2].Value = 5;

                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Rows Effected = " + rowCount);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }*/

        public void storedProc() // Insert data using Stored Procedure
        {
            try
            {
                //SqlConnection con = new SqlConnection("data source= D147XYP3\\SQLEXPRESS; database=Training ; integrated security= SSPI"); //connection string

                string storedProc = "StoredProc";
                SqlCommand cmd = new SqlCommand(storedProc, con); //(query to be executed, connection)
                cmd.CommandType = CommandType.StoredProcedure; //mentioning it is stored procedure

                cmd.Parameters.Add("@EmpName", SqlDbType.NVarChar);
                cmd.Parameters[0].Value = "Rahul";
                cmd.Parameters[0].Value = "Sam";

                cmd.Parameters.Add("@EmpEmail", SqlDbType.NVarChar);
                cmd.Parameters[1].Value = "rahul@gmail.com";
                cmd.Parameters[1].Value = "sam@gmail.com";

                cmd.Parameters.Add("@EmpSalary", SqlDbType.Int);
                cmd.Parameters[2].Value = 20000;
                cmd.Parameters[2].Value = 70000;

                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Rows Effected = " + rowCount);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void getEmail() //Fetch data using Stored Procedure
        {
            string storedProc = "TestProcedureProc";
            SqlCommand cmd = new SqlCommand(storedProc, con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            int result = cmd.ExecuteNonQuery();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader["StudentEmail"]));
                }
            }
            //Console.WriteLine(email);
            con.Close();
        }


        public void ConnectedArch()
        {
            string sqlQuery = "SELECT * FROM Accounts";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
            sqlCommand.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.Write(sqlDataReader["CustomerName"]);
                Console.WriteLine(sqlDataReader["Balance"]);
            }
            con.Close();

        }

        public void DisconnectedArch()
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sqlQuery = "SELECT * FROM Accounts";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
            sqlCommand.CommandType = CommandType.Text;
            sqlAdapter.SelectCommand = sqlCommand;
            sqlAdapter.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                Console.Write(ds.Tables[0].Rows[i]["CustomerName"]);
                Console.WriteLine(ds.Tables[0].Rows[i]["Balance"]);
            }
        }


        public void UsePooling()
        {
            var stopwatch = new Stopwatch();
            SqlConnection conWithPooling = new SqlConnection("Server=tcp:dovertraining.database.windows.net,1433;Initial Catalog=testdatabase;Persist Security Info=False;User ID=praveen;Password=Training@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Pooling=true;");

            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                conWithPooling.Open();
                conWithPooling.Close();
            }
            stopwatch.Stop();
            Console.WriteLine("Time taken : {0} ms", stopwatch.ElapsedMilliseconds);
        }

        public void WithoutUsingPool()
        {
            var stopwatch = new Stopwatch();
            SqlConnection conWithoutPooling = new SqlConnection("Server=tcp:dovertraining.database.windows.net,1433;Initial Catalog=testdatabase;Persist Security Info=False;User ID=praveen;Password=Training@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Pooling=false;");

            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                conWithoutPooling.Open();
                conWithoutPooling.Close();
            }
            stopwatch.Stop();
            Console.WriteLine("Time taken without pooling: {0} ms", stopwatch.ElapsedMilliseconds);
        }

    }
}
