using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }

      
       public void takeInput(int id, string name)
        {

            this.Id = id;
            this.Name = name;

        }

        public void printData()
        {
            Console.WriteLine("NAME = " + Name + "\nId = " + Id);
        }
    }


    
}
