/*
namespace Problem_MethodOverriding
{
   public class Program
    {
        public static void Main(String[] args)
        {
            AnimalEats DerivedAnimalEats = new DerivedAnimalEats();
            DerivedAnimalEats.eats();
            DerivedAnimalEats.show();
        }

    }

    public class AnimalEats
    {
        public string eatType;
        public virtual void eats()
        {
            Console.WriteLine();
        }
        
    }
    public class DerivedAnimalEats : AnimalEats
    {
        public override void eats()
        {
            Console.WriteLine("Calling from Derived Class");

        }
    }

}
*/