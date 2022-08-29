using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class Account
    {
        public string Name { get; set; }
        public int AccountNo { get; set; }
        public static double rateOfInterest;


        public Account(string name, int accountNo)
        {
            this.Name = name;
            this.AccountNo = accountNo;

        }

        static Account()
        {
            rateOfInterest = 5.6;
        }

        public void display()
        {
            Console.WriteLine("Account No : "+ AccountNo+" Name : "+ Name+" Rate of interest : "+ rateOfInterest);
        }

    }

}
