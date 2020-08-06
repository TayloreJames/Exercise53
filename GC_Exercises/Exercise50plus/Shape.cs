using System;
namespace Exercise50plus
{
    public class Shape
    {
        public double Length { get; set; }
        public double Height { get; set; }
       

        public virtual double CalculateArea()
        {
            return Length * Height;
        }

        //public virtual double CalculatePerimeter()
        //{
        //    return 2 * Length + 2 * Height;
        //}
    }
}
