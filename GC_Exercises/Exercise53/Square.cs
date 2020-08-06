using System;
namespace Exercise53
{
    public class Square:Shape
    {
        public double SideLength { get; set; }

       
        public Square(double side)
        {
            SideLength = side;

        }

        public override double CalculateArea()
        {
            return SideLength * SideLength;
        }

        public override double CalculatePerimeter()
        {
            return 4 * SideLength;
        }
    }
}
