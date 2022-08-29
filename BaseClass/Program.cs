namespace BaseClass
{
    public class Program
    {
        public static void Main(String[] args)
        {
            DerivedBaseClassUse emp = new DerivedBaseClassUse("Rahul", "adjfhs kdjhf sdkjfh");
                emp.display();

        }

        

    }
    public class BaseCLassUse
    {
        public string name;

        public BaseCLassUse(string name)
        {
            this.name = name;
        }
    }

    public class DerivedBaseClassUse:BaseCLassUse
    {
        private string address;
        public DerivedBaseClassUse(string name, string address):base(name)
        {
            this.address = address;
        }

        public void display()
        {
            Console.WriteLine("Name - " + base.name +
                                "\nAddress - " + this.address);
        }

    }

    


}