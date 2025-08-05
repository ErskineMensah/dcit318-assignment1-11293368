using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Type_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Triangle Type Identifier!");
            Console.WriteLine("----------------------------------------");

            bool restart = true;

            while (restart)
            {
                double sideA = GetValidSide("A");
                double sideB = GetValidSide("B");
                double sideC = GetValidSide("C");

                // Check if the sides form a valid triangle
                if (IsValidTriangle(sideA, sideB, sideC))
                {
                    // Determine the triangle type
                    if (sideA == sideB && sideB == sideC)
                        Console.WriteLine("The triangle is Equilateral.");
                    else if (sideA == sideB || sideA == sideC || sideB == sideC)
                        Console.WriteLine("The triangle is Isosceles.");
                    else
                        Console.WriteLine("The triangle is Scalene.");
                }
                else
                {
                    Console.WriteLine("The provided lenghts of sides A, B and C do not form a valid triangle; please enter new lengths for each side.");
                }

                // Logic to restart or exit
                Console.Write("\nWould you like to check another triangle? (Y/N): ");
                string choice = Console.ReadLine().Trim().ToLower();

                if (choice != "y" && choice != "yes")
                {
                    restart = false;
                    Console.WriteLine("\nThank you for using the Triangle Type Identifier!");
                }

                Console.WriteLine(); 
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static double GetValidSide(string label)
        {
            double side;
            while (true)
            {
                Console.Write($"Enter length of side {label}: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out side) && side > 0)
                {
                    return side;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }
        }

        //Below is the Triangle Inequality theorem to verify if the lengths of sides entered correspond to the triangle shape 
        static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
