using System;


namespace Event2
{
    public delegate void HandleEvent(string str);
    public class Program
    {
        public static void CatchEvent(string str)
        {
            Console.WriteLine("Method is Calling");
        }
        public static void Main(String[] args)
        {
            //   Operation operation = new Operation();
            //   operation.evt += new HandleEvent(CatchEvent);
            //   operation.Action("Calling the Event");
        }              
        
    }

    public class Operation
    {
        public event HandleEvent evt;

        public void Action(string str)
        {
            if(evt != null)
            {
                evt(str);
                Console.WriteLine("String after operation - " + str);
            }

            else
            {
                Console.WriteLine("Event is not fired.");
            }
        } 
    }
}