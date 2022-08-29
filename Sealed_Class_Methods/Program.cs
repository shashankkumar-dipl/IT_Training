namespace Sealed_Class_Methods
{ 
    public class Program
    {
        public static void Main(String[] args)
        {
            
        }
    }
    

    //SEALED keyword is used to restrict a class and mothods from being inherited.
    //When using sealed keyword in method, it should be used only along with OVERRIDE keyword.
    sealed public class sealedClass
    {
        public int a;
    }

    public class normalClass : sealedClass
    {

    }

    public class SealedBase
    {
        public virtual void method()
        {

        }      
    }

    public class SealedMethod : SealedBase
    {
        public sealed override void method()
        {
            
        }
    }

    public class SealedDerived : SealedMethod
    {
        public override void method()
        {

        }
    }
}



