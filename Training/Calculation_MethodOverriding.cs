using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Calculation_MethodOverriding
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public double add(double x, double y)
        {
            return x + y;
        }

        public virtual void calculate()
        {
            Console.WriteLine("Calling from Base Class");
            

        }
    }

    public class DerivedCalculation : Calculation_MethodOverriding
    {
        public override void calculate()
        {
            Console.WriteLine("Calling from Derived Class");

        }
    }
     
}
