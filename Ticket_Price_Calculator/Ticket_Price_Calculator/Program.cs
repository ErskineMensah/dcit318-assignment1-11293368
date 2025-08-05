using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Price_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ticket Price Calculator!");
            Console.WriteLine("---------------------------------------");

            bool restart = true;

            while (restart)
            {
                int age = -1;

                // Loop until valid age is entered
                while (true)
                {
                    Console.Write("Please enter your age: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out age) && age > 0 && age < 130)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid age (Example, 25, 8, 7 or 60).");
                    }
                }

                // Determine ticket price
                double price = (age <= 12 || age >= 65) ? 7.0 : 10.0;
                Console.WriteLine($"Your ticket price is: GHC{price}");

                // Ask if the user wants to calculate a new ticket price again
                Console.Write("\nWould you like to calculate another ticket price? (Y/N): ");
                string choice = Console.ReadLine().Trim().ToLower();

                if (choice != "y" && choice != "yes")
                {
                    restart = false;
                    Console.WriteLine("\nThank you for using the Ticket Price Calculator!");
                }

                Console.WriteLine(); 
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
