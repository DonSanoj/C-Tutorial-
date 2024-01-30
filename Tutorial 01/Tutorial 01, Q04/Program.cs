using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01__Q04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for Fibonacci: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Patern: ");
            for (int i = 0; i < num; i++)
            {
                Console.Write(FindFibonacci(i) + " ");
            }

            Console.ReadLine();
        }

        static int FindFibonacci(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            else
            {
                return FindFibonacci(x - 1) + FindFibonacci(x - 2);
            }
        }
    }
}
