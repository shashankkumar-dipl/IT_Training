using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Citizen
    {
        string name;
        int age;
        public Address address;

        public Citizen(string name, int age, Address address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void display()
        {
            Console.WriteLine("Name - " + name +
                                "\nAge - " + age +
                                "\nAddress - " + address.addressline + " " + address.city + " " + address.state);
        }

    }    
}
