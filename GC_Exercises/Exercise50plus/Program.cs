using System;

namespace Exercise50plus
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle1 = new Triangle(3, 4, 5);
            Console.WriteLine(triangle1.CalculateArea());

            var circle1 = new Circle(3);
            Console.WriteLine(circle1.CalculateArea());
        }
    }
}
