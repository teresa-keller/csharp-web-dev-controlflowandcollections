using System;
using System.Collections.Generic;
namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> exampleNumbers = new List<int>{ 1, 1, 2, 3, 5, 8, 6, 6, 5, 9 };
            static int sumOfEvens(List<int> exampleNumbers)
            {
                int totalEvens = 0;
                foreach (int number in exampleNumbers)
                {
                    if(number % 2 == 0)
                    {
                        totalEvens += number;
                    }
                }
                return totalEvens;
            }
            Console.WriteLine(sumOfEvens(exampleNumbers));
        }
    }
}
