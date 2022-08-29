using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }

        public void takeInput(int id, string name, int salary)
        {

            this.Id = id;
            this.Name = name;
            this.Salary = salary;

        }

        public void printData()
        {
            Console.WriteLine("\nNAME = " + Name +
                              "\nId = " + Id +
                              "\nSalary = " + Salary);
        }
    }
}
