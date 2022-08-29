namespace AbstractClass
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //InheritAbstract instance = new InheritAbstract();
            //instance.draw();
            //instance.doImplementation();

            AbstractWithImpl abstractWithImpl = new DerivedClass();
            abstractWithImpl.Save();
            abstractWithImpl.Delete();
        }
    }

    public abstract class AbstractClass
    {
        public abstract void draw();

        public void doImplementation()
        {
            Console.WriteLine("This is from abstract class method");
        }
    }

    
}

