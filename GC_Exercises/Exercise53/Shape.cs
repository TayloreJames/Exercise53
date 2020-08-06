using System;
namespace Exercise53
{
    public abstract class Shape
    {
        private int _sides;
        public int Sides
        {
            get
            {
                return _sides;
            }
            set
            {
                while (true) 
                {
                    if (value > 0)
                    {
                        _sides = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Enter new value: ");
                        value = int.Parse(Console.ReadLine());
                    }
                } 
            }
        }

        public int Dimensions { get; set; }
        public int Vertices { get; set; }
        public int Faces { get; set; }
        public int Edges { get; set; }

        public Shape(int sides)
        {
            Sides = sides;
            DecideShape();
        }


        public abstract double CalculateArea();
        
        public abstract double CalculatePerimeter();

        public void DecideShape()
        {
            if (Sides == 0)
            {
                Console.WriteLine("Enter radius: ");
                var circle = new Circle(double.Parse(Console.ReadLine()));
            }
            else if(Sides == 1)
            {
                Console.WriteLine("Congrats you have a line....");
            }
            else if (Sides == 2)
            {
                Console.WriteLine("OooooOooh 2 lines.....");
            }
            else if (Sides == 3)
            {
                Console.WriteLine("Enter in side 1: ");
                var side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter in side 2: ");
                var side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter in side 3: ");
                var side3 = double.Parse(Console.ReadLine());
                var triangle = new Triangle(side1,side2,side3);
            }
            else if(Sides == 4)
            {
                while (true)
                {
                    Console.WriteLine("Are sides equal length? (y/n)");
                    if (Console.ReadLine() == "y")
                    {
                        Console.WriteLine("Please enter the length of the side: ");
                        var square = new Square(double.Parse(Console.ReadLine()));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Squares are great. Why not choose a square?");
                    }
                }


            }
            else
            {
                Console.WriteLine("We haven't gotten that far. Give us a break....");
            }
            

        }


    }
}
