using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01__Q06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();

            int marks;
            while(true)
            {
                Console.WriteLine("Enter your Marks: ");
                marks = int.Parse(Console.ReadLine());

                if (marks < 0 && marks > 100)
                {
                    Console.WriteLine("Invalid Marks");
                }
                else
                {
                    break;
                }
            }

            char grade = FindGrade(marks);

            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Grade: {grade}");

            Console.ReadLine();
        }

        static char FindGrade(int mark)
        {
            char grade;

            if (mark <= 100 && mark >= 75)
            {
                grade = 'A';
            }
            else if (mark <= 74 && mark >= 60)
            {
                grade = 'B';
            }
            else if (mark <= 59 && mark >= 50)
            {
                grade = 'C';
            }
            else if (mark <= 49 && mark >= 40)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            return grade;
        }
    }
}
