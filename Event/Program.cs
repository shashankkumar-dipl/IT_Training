namespace Event1
{
    public delegate void HandleEvent();

    public class Program
    {
        public static event HandleEvent evt;
        public static void Main(String[] args)
        {
            evt += new HandleEvent(FirstMethod);
            evt += new HandleEvent(SecondMethod);
            evt += new HandleEvent(ThirdMethod);
            evt.Invoke();

        }

        static void FirstMethod()
        {
            Console.WriteLine("Calling First Method.");
        }

        static void SecondMethod()
        {
            Console.WriteLine("Calling Second Method.");
        }

        static void ThirdMethod()
        {
            Console.WriteLine("Calling Third Method.");
        }
    }
}