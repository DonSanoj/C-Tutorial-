using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Enter {i} number:");
                int number = int.Parse(Console.ReadLine());

                if (IsEven(number))
                {
                    Console.WriteLine($"{number} is even");
                }
                else
                {
                    Console.WriteLine($"{number} is odd");
                }
            }

            Console.ReadLine();
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}