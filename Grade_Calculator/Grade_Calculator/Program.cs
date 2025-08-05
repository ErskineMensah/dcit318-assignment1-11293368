using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Calculator!");
            Console.WriteLine("--------------------------------");

            bool restart = true;

            while (restart)
            {
                double grade = -1;

                // Loop until valid input is received from user
                while (true)
                {
                    Console.Write("Enter your numerical grade from (0-100): ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out grade) && grade >= 0 && grade <= 100)
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    }
                }

                // Determine letter grade
                if (grade >= 90)
                    Console.WriteLine("Your letter grade is: A");
                else if (grade >= 80)
                    Console.WriteLine("Your letter grade is: B");
                else if (grade >= 70)
                    Console.WriteLine("Your letter grade is: C");
                else if (grade >= 60)
                    Console.WriteLine("Your letter grade is: D");
                else
                    Console.WriteLine("Your letter grade is: F");

                // Option to restart or exit the application
                Console.Write("\nWould you like to calculate another grade? (Y/N): ");
                string choice = Console.ReadLine().Trim().ToLower();

                if (choice != "y" && choice != "yes")
                {
                    restart = false;
                    Console.WriteLine("\nThank you for using the Grade Calculator Console Apps!!!");
                }

                Console.WriteLine(); 
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
