namespace Problem_MethodOverriding
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Area rectangle = new Area();
            rectangle.calculateArea(10, 20);

            Area circle = new Area();
            circle.calculateArea(50);

            Area triangle = new Area();
            triangle.calculateArea(10, 52.2);

        }

    }

    public class Area
    {
        public void calculateArea(int l, int b)
        {
            int area = l * b;
            Console.WriteLine("Area of Rectangle = " + area);
        }

        public void calculateArea(int h, double b)
        {
            double area = 0.5 * (h * b);
            Console.WriteLine("Area of Triangle = " + area);
        }

        public void calculateArea(int r)
        {
            double PI = 3.14;
            double area = PI * Math.Pow(r,2);
            Console.WriteLine("Area of Circle = " + area);
        }

    }

}