using System.Text.RegularExpressions;

namespace ExceptionHandling
{ 
    public class Program
    {
        public static void Main(String[] args)
        {

            /*
            int i = 9;

            try
            {
                Console.WriteLine(i / 0);
                throw new CustomException("This is a custom exception");

            }
            catch(CustomException e)
            {
               Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This message is from finally block");
            }
            */

            Console.WriteLine("Enter Email Address");
            string email = Console.ReadLine();
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            try
            {
                if (regex.IsMatch(email))
                {
                    Console.WriteLine("Valid E-Mail");
                }
                else
                {
                    throw new CustomException("Invalid E-Mail");
                }
            }
            catch(CustomException e)
            {
                Console.WriteLine(e.Message);
            }
                        
        }
    }

        public class CustomException : Exception
        {
            public CustomException(string message) : base(message)
            {
                Console.WriteLine("Exception Occured - " + message); 
            } 
            
        /*
            public CustomException()
            {
            Console.WriteLine("Parameteless COnstructor");
            }
        */
        }
}