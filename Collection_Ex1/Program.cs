namespace Collection_Ex1
{
    public class Program
    {
        public static void Main(String[] Args)
        {

        }
    } 

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class Address : Employee
    {

    }
}