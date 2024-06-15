using System;

namespace Assignment1
{
    public class TicketPriceCalculator
    {
        public static void CalculateTicketPrice()
        {
            Console.WriteLine("Enter your age:");
            string? input = Console.ReadLine(); 
            if (input != null)
            {
                if (int.TryParse(input, out int age))
                {
                    if (age >= 65 || age <= 12)
                    {
                        Console.WriteLine("The ticket price is: GHC7");
                    }
                    else
                    {
                        Console.WriteLine("The ticket price is: GHC10");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numerical age.");
                }
            }
            else
            {
                Console.WriteLine("No input received. Please enter a numerical age.");
            }
        }
    }
}

