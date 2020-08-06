using System;
namespace Exercise50plus
{
    public class Rectangle : Shape
    {
        public Rectangle(double length, double height)
        {
            base.Length = length;
            base.Height = height;
        }

        public override double CalculateArea()
        {
            return base.CalculateArea();
        }
    }
}
