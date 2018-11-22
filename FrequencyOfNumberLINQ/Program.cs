using System;
using System.Collections.Generic;
using System.Linq;

namespace FrequencyOfNumberLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = new List<int> { 2, 8, 1, 2, 9, 2, 5, 6, 7, 3, 7, 6, 8, 5, 4, 8, 9, 2, 3, 7 };

            Console.WriteLine("Program displays the number and the frequency of numbers in a given list of numbers");

            var number = from digit in digits
                         group digit by digit into y
                         select y;

            var lambdaNumber = digits.GroupBy(x => x);
            Console.WriteLine("First check by LINQ query");
            foreach (var listNo in number)
            {
                Console.WriteLine("The number {0} appears {1} times", listNo.Key, listNo.Count());
            }
            Console.WriteLine("Additional check by LINQ method");
            foreach (var listNo in lambdaNumber)
            {
                Console.WriteLine("The number {0} appears {1} times", listNo.Key, listNo.Count());
            }

            Console.ReadKey();
        }
    }
}
