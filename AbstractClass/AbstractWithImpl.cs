using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class AbstractWithImpl
    {
        abstract public void Save();

        public void Delete()
        {
            Console.WriteLine("Executing from abstract class - Delete() method.");
        }
    }

    interface ITest
    {
        public void Delete1()
        {
            Console.WriteLine("Executing from abstract class - Delete() method.");
        }
    }

    public class DerivedClass : AbstractWithImpl, ITest
    {
        public override void Save()
        {
            Console.WriteLine("Executing from inherited class, overridden method Save()");
        }

        public void Delete()
        {
            Console.WriteLine();
        }
    }
}
