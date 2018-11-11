using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHBC_Lab_10
{
    class Program : Circle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            WillContinue();

        }

        public static void UserPrompt()
        {

            int radiusInput;
            Console.Write("Enter a radius: ");
            while (!int.TryParse(Console.ReadLine(), out radiusInput))
            {
                Console.WriteLine("That was an invalid input. ");
                Console.Write("Enter a radius: ");
                continue;
            }

            Circle circle = new Circle
            {
                Radius = radiusInput
            };

            Console.WriteLine("Circumference: " + circle.CalculateFormattedCircumference());
            Console.WriteLine("Area: " + circle.CalculateFormattedArea());
            Console.ReadLine();

        }

        public static void WillContinue()
        {
            UserPrompt();
            int counter = 2;

            while (true)
            {

                Console.Write("Continue? (y/n): ");
                var willContinue = Console.ReadLine();

                if (willContinue.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    UserPrompt();
                    counter++;
                    counter++;

                }
                else if (willContinue.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"You created {counter} Circle object(s), goodbye!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Write("Y or N not selected, please try again ");
                    Console.ReadLine();

                    continue;

                }
            }
        }
    }
}
