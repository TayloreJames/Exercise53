using System;

namespace Exercise37
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOne = new int[5];
            var sum = 0;

            for(int i=0; i<arrayOne.Length; i++)
            {
                Console.WriteLine("Please enter a number: ");
                arrayOne[i] = int.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.WriteLine("Please enter a number:");
                arrayOne[i] = int.Parse(Console.ReadLine());
                sum += arrayOne[i];
            }

            Console.WriteLine($"{arrayOne[0]} + {arrayOne[1]} + {arrayOne[2]} + {arrayOne[3]} + {arrayOne[4]} = {sum}");


        }

        
    }
}
