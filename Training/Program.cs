//SHASHANK KUMAR
//C# - TRAINING CODE SNIPPETS
namespace Training
{
    public class Program
    {
        
        /*
        delegate int Operation(int x, int y);
        public static void Main(String[] args)
        {

            //ANONYMOUS METHODS
            Operation op = delegate (int x, int y)
            {
                return x + y;

            };

            Console.WriteLine("Sum = " + op(1,2));
        */
        //***********************************************************************************************


            //FROM STUDENT CLASS

            /*
            Student student = new Student();
            student.takeInput(1, "Shashank");
            student.printData();
            */
            //**************************************************************************************************
            //FROM EMPLOYEE CLASS
            /*
            Employee employee1 = new Employee();
            employee1.takeInput(001, "Rahul", 30050);
            employee1.printData();

            Employee employee2 = new Employee();
            employee2.takeInput(002, "Sanjeev", 25000);
            employee2.printData();
            */
            //**************************************************************************************************
            //FROM SHAPE CLASS
            /*
            Shape circle = new Shape();
            Console.WriteLine("Area of Circle (using default values) = " + circle.getCircleArea());
            Console.WriteLine("Area of Circle = " + circle.getCircleArea(5));

            Shape rectangle = new Shape();
            Console.WriteLine("Area of Rectangle (using default values) = " + rectangle.getRectangleArea());
            Console.WriteLine("Area of Rectangle = " + rectangle.getRectangleArea(8,9));
            */
            //**************************************************************************************************
            //FROM ACCOUNT CLASS
            /*
            Account a = new Account("Jyotish", 54232323);
            a.display();

            Account b = new Account("Ram", 23232323);
            b.display();
            */
            //**************************************************************************************************

            //FROM StructRectangle CLASS
            /*
            StructRectangle rectangle1 = new StructRectangle();
            rectangle1.height = 20;
            rectangle1.width = 5;
            Console.WriteLine("Rectangle Height = " + rectangle1.height + "\n Rectangle Width = " + rectangle1.width);


            StructRectangle rectangle2 = new StructRectangle();
            rectangle2.height = 20;
            rectangle2.width = 5;
            Console.WriteLine("Rectangle Height = " + rectangle2.height + "\n Rectangle Width = " + rectangle2.width);


            StructRectangle rectangle3 = new StructRectangle(10,2);
            rectangle3.areaOfReactangle();
            */
            //**************************************************************************************************

            //FROM EnumClass CLASS
            /*
            Console.WriteLine("Enter a number from 0 to 6 : \n");
            int no = Convert.ToInt32(Console.ReadLine());

            
            switch (no)
            {
                case 0:
                Console.WriteLine("You have selected = " + EnumClass.weekdays.Sunday);
                    break;
                case 1:
                    Console.WriteLine("You have selected = " + EnumClass.weekdays.Monday);
                    break;
                case 2:
                    Console.WriteLine("You have selected = " + EnumClass.weekdays.Tuesday);
                    break;
                case 3:
                    Console.WriteLine("You have selected = " + EnumClass.weekdays.Wednesday);
                    break;
                case 4:
                    Console.WriteLine("You have selected = " + EnumClass.weekdays.Thursday);
                    break;
                case 5:
                    Console.WriteLine("You have selected = " + EnumClass.weekdays.Friday);
                    break;
                case 6:
                    Console.WriteLine("You have selected = " + EnumClass.weekdays.Saturday);
                    break;
            }
            */

            //Approach 2 in image of ENUM (Typcasting - EnumClass weekdays = (weekdays)no)

            //**************************************************************************************************

            //FROM EmpSalary and EmpDetails Class (INHERITENCE)
            /*
            EmpDetails emp = new EmpDetails();
            Console.WriteLine(emp.empName + " with EMP-ID " + emp.empid + " is getting salary of INR " + emp.salary);
            */

            //**************************************************************************************************


            //FROM Vehicle, Accessories and Car Class (INHERITENCE)
            /*
            Car car = new Car();
            car.brand = "Honda";
            car.mirror= "Medium Size";
            car.wiper = "Flexible";
            car.wheels = "Alloy";
            car.price = 800000;
            car.model = "Amaze";

            Console.WriteLine("Car Details :\n" +
                              "Brand - " + car.brand + "\n" +
                              "Model - " + car.model + "\n" +
                              "Price - " + car.price + "\n" +
                              "Mirror - " + car.mirror + "\n" +
                              "Wiper - " + car.wiper + "\n" +
                              "Wheel Type - " + car.wheels + "\n");
            */

            //**************************************************************************************************


            //FROM Address and CItizen CLASS
            /*
            Address address = new Address("H no -9, Whitefield", "Bengaluru", "Karnataka");
            Citizen citizen = new Citizen("Rahul", 40, address);
            citizen.display();
            */

            //**************************************************************************************************


            //FROM Calculation_MethodOverloading CLASS
            /*
            Calculation_MethodOverloading checkSum = new Calculation_MethodOverloading();
            Console.WriteLine("intSum = " + checkSum.add(1,2) + "\ndoubleSum = " + checkSum.add(1.5, 2.3));
            */

            //**************************************************************************************************

            //FROM Calculation_MethodOverriding CLASS
            /*
            Calculation_MethodOverriding derivedCalculation = new DerivedCalculation();
            derivedCalculation.calculate();

            derivedCalculation=new Calculation_MethodOverriding();
            derivedCalculation.calculate();
            */

            //**************************************************************************************************



            //FROM MyStatcisClass CLASS
            /*
            Console.WriteLine(MyStaticClass.PI);
            Console.WriteLine("Cube = " + MyStaticClass.cube(10));
            */
            //**************************************************************************************************


            /*SOLUTION-1
                                     * int x = 10;
                                    if (x % 2 == 0)
                                    {
                                        Console.WriteLine(x + " is Even Number.");
                                    }
                                    else
                                    {
                                        Console.WriteLine(x + " is Odd Number.");
                                    }
                                    Console.ReadLine();
                                    */

            //*********************************************************************

            /*SOLUTION-2
                                    Console.WriteLine("Enter a number");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Entered Number = " + x);

                                    if (x % 2 == 0)
                                    {
                                        Console.WriteLine(x + " is Even Number.");
                                    }
                                    else
                                    {
                                        Console.WriteLine(x + " is Odd Number.");
                                    }
                                    */

            //**********************************************************************

            /*
SOLUTION - 3
            Console.WriteLine("Enter the Mark");
            int mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered Mark = " + mark);

            if (mark < 0 || mark >100)
            {
                Console.WriteLine("Invalid Marks");
            }
            else if (mark >= 0 && mark <=50)
            {
                Console.WriteLine("Candidate Failed");
            }
            else if (mark >= 51 && mark <= 60)
            {
                Console.WriteLine("Grade Scored = E1");
            }
            else if (mark >= 61 && mark <= 70)
            {
                Console.WriteLine("Grade Scored = D1");
            }
            else if (mark >= 71 && mark <= 80)
            {
                Console.WriteLine("Grade Scored = C1");
            }
            else if (mark >= 81 && mark <= 90)
            {
                Console.WriteLine("Grade Scored = B1");
            }
            else if (mark >= 91 && mark <= 100)
            {
                Console.WriteLine("Grade Scored = A1");
            }
            */

            //********************************************************************

            //SOLUTION - 4
            /*
            Console.WriteLine("Enter the Mark");
            int mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered Mark = " + mark);
            mark = mark / 10;
            switch (mark)
            {
                case 0: Console.WriteLine("Failed");
                    break;
                case 1: Console.WriteLine("E1");
                    break ;
                case 2:
                    Console.WriteLine("E1");
                    break;
                case 3:
                    Console.WriteLine("E1");
                    break;
                case 4:
                    Console.WriteLine("E1");
                    break;
                case 5:
                    Console.WriteLine("E1");
                    break;
                case 6:
                    Console.WriteLine("D1");
                    break;
                case 7:
                    Console.WriteLine("C1");
                    break;
                case 8:
                    Console.WriteLine("B1");
                    break;
                case 9:
                    Console.WriteLine("A1");
                    break;
                case 10:
                    Console.WriteLine("A1");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            */
            //**********************************************************************


            //SOLUTION - 5
            /*int i = 1, sum = 0;
            while (i <= 5)
            {
                sum=sum+i;
                i++;
            }
            Console.WriteLine(sum);
            */

            //***********************************************************************

            //SOLUTION - 6
            /*
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            foreach (int i in ints)
            {
                sum=sum+i;
            }
            Console.WriteLine(sum);
            */

            //***********************************************************************

            //SOLUTION - 7
            /*
            int[,] arr = new int[2, 2];
            arr[1, 0] = 6;
            Console.WriteLine(arr[1,0]);
            */

            //***********************************************************************

            //SOLUTION - 8
            //PART-2
            /*
            Program program = new Program();
            program.paramExample(21,345,345,2,756,8,3,32,54,657,476);
            */

            //***********************************************************************

            //SOLUTION - 9
            //PART-2
            /*
            int[] arr = { 34, 55, 78, 2, 46, 78, 9 };
            int[] arr2 = new int[arr.Length];

            int index1=Array.IndexOf(arr, 55);
            Console.WriteLine("Index of 55 in 1st array is = " + index1);

            Array.Sort(arr);
            Console.WriteLine("Element of 1st array after sorting is = " );
            printArray(arr);

            int index=Array.IndexOf(arr2, 55);
            Console.WriteLine("Index of 55 in 1st array is = " + index1);

            Array.Copy(arr, arr2, arr.Length);
            Console.WriteLine("Element of 2nd array is = ");
            printArray(arr);

            Array.Reverse(arr);
            Console.WriteLine("1st array in reverse order is = ");
            printArray(arr);
            printArray(arr2);
            */


            //***********************************************************************

            //SOLUTION - 10
            /*
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i, j = 0, k = 0, n;
            Console.Write("\n\nSeparate odd and even integers in separate arrays:\n");
            Console.Write("------------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.Write("\nThe Even elements are : \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("\nThe Odd elements are :\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");
            */

            //*******************************************************************

            //SOLUTION - 11
            /*
            string fruit = "Apple";
            switch (fruit)
            {
                case "Banana":
                    Console.WriteLine(fruit + " is selected");
                    break;
                case "Mango":
                    Console.WriteLine("");
                    break;
                case "Apple":
                    goto case "Banana";
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }

            */

            //*******************************************************************

            //SOLUTION - 12
            //PART - 2
            /*
            Program program = new Program();
            int i = 10;
            int val = program.manipulateParam(ref i);
            Console.WriteLine("Main Method Value = " + val);

            */

            //*******************************************************************

            //SOLUTION - 13
            //PART - 2
            /*
            Program program = new Program();
            int i;
            program.manipulateParam(out i);
            Console.WriteLine("Main Method Value = " + i);

            */

            //*******************************************************************

            //SOLUTION - 14
            //PART - 2















        }
        //***********************************************************************
        //***********************************************************************
        //***********************************************************************
        //***********************************************************************
        //***********************************************************************
        //***********************************************************************
        //***********************************************************************
        //***********************************************************************
        //***********************************************************************
        //***********************************************************************
        //***********************************************************************
        //***********************************************************************


        //SOLUTION - 8
        //PART-1
        /*
        public void paramExample(params int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum=sum+arr[i];

            }
            Console.WriteLine("SUM = " + sum);
            Console.WriteLine(arr.Length);
        }
        */

        //***********************************************************************

        //SOLUTION - 9
        //PART-1
        /*
        static void printArray(int[] arr)
        {
            foreach (Object o in arr)
            {
                Console.WriteLine(o + " ");
            }
        }

        */

        //*******************************************************************

        //SOLUTION - 12
        //PART - 1

        /*
        public void manipulateParam(ref int a){
        a = a*a;
        Console.WriteLine("Function Value = " + a);
        }


        */

        //*******************************************************************

        //SOLUTION - 13
        //PART - 1
        /*
        public void manipulateParam(out int val)
        {
            val = 50;
            val*=val;
            Console.WriteLine("Function Value = " + val);
        }
        */

        //*******************************************************************

        //SOLUTION - 14
        //PART - 1













    }

