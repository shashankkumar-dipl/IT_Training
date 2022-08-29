using System.Collections.Generic;
using System.IO;
namespace GenericCollections
    
{ 
    public class Program
    {
        public static void Main(String[] args)
        {

            ///LIST
            /*
            List<string> listItems = new List<string>();
            listItems.Add("1");
            listItems.Add("2");
            listItems.Add("3");
            listItems.Add("4");

            foreach (string item in listItems)
            {
                Console.WriteLine(item);
            }
            */
            
            /*
            List<Student> studentList = new List<Student>();

            Student student1 = new Student();
            student1.Name = "Shashank";
            student1.RollNo = 232300;
            studentList.Add(student1);
            Console.WriteLine(studentList);
            */

            ///SORTED LIST
            /*
            SortedSet<string> sortedList = new SortedSet<string>();
            sortedList.Add("Z");
            sortedList.Add("H");
            sortedList.Add("A");
            foreach(string s in sortedList)
            {
                Console.WriteLine(s);   
            }
            */


            ///HASHSET
            /*
            HashSet<string> hashSet = new HashSet<string>();
            Student student2 = new Student();
            student2.Name = "Ram";
            student2.RollNo = 21313;
            hashSet.Add(student2.Name);
            hashSet.Add(student2.RollNo);
            */


            ///STACK
            /*
            var nameInStack = new Stack<string>();
            nameInStack.Push("Z\n");
            nameInStack.Push("A");
            nameInStack.Push("S");

            foreach(string name in nameInStack)
            {
                Console.WriteLine(name);
            }

            nameInStack.Pop();
            foreach (string name in nameInStack)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peak of Stack - " + nameInStack.Peek());
            */

            //QUEUE
            /*
            var nameInQueue = new Queue<string>();
            nameInQueue.Enqueue("A");
            nameInQueue.Enqueue("B");
            nameInQueue.Enqueue("C\n");
            foreach (string s in nameInQueue)
            {
                Console.WriteLine(s);
            }

            nameInQueue.Dequeue();
            foreach (string s in nameInQueue)
            {
                Console.WriteLine(s);
            }
            */

            var linkedList = new LinkedList<string>();
            linkedList.AddLast("a");
            linkedList.AddLast("b");
            linkedList.AddLast("c");
            foreach(var item in linkedList)
            {
                Console.WriteLine(item);
            }

            LinkedListNode<string> node = linkedList.Find("b");
            linkedList.AddBefore(node, "before");
            linkedList.AddAfter(node, "after");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

        }
    }

    public class Student
    {
        public string Name { get; set; }    
        public int RollNo { get; set; }
    }

   
}