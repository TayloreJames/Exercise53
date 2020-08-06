using System;
namespace Exercise50plus
{
    public class Triangle : Shape
    {
        public double SideLength1 { get; set; }
        public double SideLength2 { get; set; }
        public double SideLength3 { get; set; }


        public Triangle(double length1, double length2, double length3)
        {
            SideLength1 = length1;
            SideLength2 = length2;
            SideLength3 = length3;
        }

        public override double CalculateArea()
        {
            var semiPerimeter = (SideLength1 + SideLength2 + SideLength3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideLength1) * (semiPerimeter - SideLength2) * (semiPerimeter - SideLength3));
        }

        //public override double CalculatePerimeter()
        //{
        //    return base.CalculatePerimeter();
        //}

    }
}
