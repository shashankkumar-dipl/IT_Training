namespace InterfaceImplementation
{
    public class Program
    {
        public static void Main(String[] args)
        {

        }
    }

    interface ISave
    {
        void Save()
        {
            Console.WriteLine("This is Save method implementation");
        }
    }

    interface IDelete
    {
        void Delete()
        {
            Console.WriteLine("This is Delete method implementation");

        }
    }

    public class Module:interface
    {

    }
}