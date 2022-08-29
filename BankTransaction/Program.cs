using System;
using System.Data.SqlClient;
using System.Data;

namespace BankTransactionExercise
{
    class Program
    {
        SqlConnection con = new SqlConnection("data source= D147XYP3\\SQLEXPRESS; database=Training ; integrated security= SSPI"); //connection string

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Transaction();
        }

        public void Transaction()
        {
            con.Open();
            SqlTransaction transacation = con.BeginTransaction();
            try
            {
                string query1 = "update BankAccount set Amount=Amount+5000 where AccNo ='ACC1'";
                SqlCommand cmd1 = new SqlCommand(query1, con, transacation);
                cmd1.ExecuteNonQuery();

                string query2 = "update BankAccount set Amount = Amount-1000 where AccNo = 'ACC2'";
                SqlCommand cmd2 = new SqlCommand(query2, con, transacation);
                cmd2.ExecuteNonQuery();
                transacation.Commit();
                Console.WriteLine("Transaction Completed");
            }
            catch (Exception e)
            {
                transacation.Rollback();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
