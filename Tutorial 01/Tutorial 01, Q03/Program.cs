using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01__Q03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("ERROR: Try again");
            }
            else
            {
                int sum = CalculateSum(number);
                Console.WriteLine($"Sum = {sum}");
            }

            Console.ReadLine();
        }

        static int CalculateSum(int num)
        {
            return (num * (num + 1) / 2);
        }
    }
}
