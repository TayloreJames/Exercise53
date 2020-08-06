using System;

namespace Exercise34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[] { 16, 32, 64, 128, 256 };




            HalfArray(arrayOne);
            

            DoubleArray(arrayOne);
        }

        public static void HalfArray(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = inputArray[i] / 2;
                Console.WriteLine(inputArray[i]);
            }
        }

        public static void DoubleArray(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = inputArray[i] * 2;
                Console.WriteLine(inputArray[i]);
            }
        }
    }
}
