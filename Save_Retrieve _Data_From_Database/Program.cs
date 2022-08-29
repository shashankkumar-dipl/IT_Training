using System;
using System.Data.SqlClient;
using System.Data;

//Write a program in C# where you will be saving some employees to the database (First create table
//named Employee with Id, Name, Address). and save the records from console . User will input the
//details from console and that should be saved to database. Another method should be written
//Where we can pull all the records from database and show that on the console.



namespace Save_Retrieve__Data_From_Database_Exercise
{
    class Program
    {
        string conString = "data source= D147XYP3\\SQLEXPRESS; database=Training ; integrated security= SSPI";
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ReadData();
        }

        public void InsertData()
        {
            SqlConnection con = new SqlConnection(conString);


            try
            {
                Console.WriteLine("Enter EMP-ID:");
                string eid = Console.ReadLine();
                Console.WriteLine("\n");

                Console.WriteLine("Enter EMP-NAME:");
                string ename = Console.ReadLine();
                Console.WriteLine("\n");

                Console.WriteLine("Enter EMP-ADDRESS:");
                string eadd = Console.ReadLine();
                Console.WriteLine("\n");

                string insertCommand = "insert into Save_Retrieve__Data_From_Database_Exercise values(" + eid + ",'" + ename + "','" + eadd + "')";
                SqlCommand comm = new SqlCommand(insertCommand, con);
                comm.CommandType = CommandType.Text;
                con.Open();
                Console.WriteLine(comm.ExecuteNonQuery());
                con.Close();
                Console.WriteLine("DATA INSERTED...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }            
        public void ReadData()
        {
            try
            {
                string sqlQuery = "SELECT * FROM Save_Retrieve__Data_From_Database_Exercise";
                SqlConnection con = new SqlConnection(conString);

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                sqlCommand.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader["eid"] + "     ||     " + sqlDataReader["ename"] + "     ||     " + sqlDataReader["eadd"] + "\n");
                }
                con.Close();
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }        
    }
}
