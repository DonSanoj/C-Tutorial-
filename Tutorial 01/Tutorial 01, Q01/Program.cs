using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Q01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = 0;
            double width = 0;

            while(true)
            {
                Console.WriteLine("Enter the length:");
                string input = Console.ReadLine();

                try
                {
                    length = Convert.ToDouble(input);

                    if (length <= 0)
                    {
                        Console.WriteLine("Length must be a positive number. Please try againg.");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a numerical number");
                }
            }

            while(true)
            {
                Console.WriteLine("Enter the width:");
                string input = Console.ReadLine();

                try
                {
                    width = Convert.ToDouble(input);

                    if (width <= 0)
                    {
                        Console.WriteLine("Width must be a positive number. Please try againg.");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a numerical number");
                }
            }

            double area = CalculateArea(length, width);

            Console.WriteLine($"The area = {area}");

            Console.ReadLine();
        }

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }
    }
}
