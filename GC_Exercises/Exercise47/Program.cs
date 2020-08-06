using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise47
{
    class Program
    {
        private static bool UserContinueSelection { get; set; } = true;


        static void Main(string[] args)
        {
            var stringList = new List<string>() { "Jason" };
            stringList.Add("Cory");
            stringList.RemoveAt(2);
            var cory = stringList.ElementAt(2);
            var result = stringList.Last(entry => entry.Contains("Jason"));

            stringList.Where(entry => entry.Contains("Jason"));


            while(UserContinueSelection == true)
            {
                var userInput = Console.ReadLine();
                stringList.Add(userInput);

               
            }
        }
    }
}
