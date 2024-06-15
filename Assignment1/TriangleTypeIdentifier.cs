using System;

namespace Assignment1
{
    public class TriangleTypeIdentifier
    {
        public static void IdentifyTriangleType()
        {
            Console.WriteLine("Enter the length of the first side:");
            string? input1 = Console.ReadLine(); 
            if (input1 != null) 
            {
                if (double.TryParse(input1, out double side1))
                {
                    Console.WriteLine("Enter the length of the second side:");
                    string? input2 = Console.ReadLine(); 
                    if (input2 != null)
                    {
                        if (double.TryParse(input2, out double side2))
                        {
                            Console.WriteLine("Enter the length of the third side:");
                            string? input3 = Console.ReadLine(); 
                            if (input3 != null) 
                            {
                                if (double.TryParse(input3, out double side3))
                                {
                                    if (side1 == side2 && side2 == side3)
                                    {
                                        Console.WriteLine("The triangle is Equilateral.");
                                    }
                                    else if (side1 == side2 || side2 == side3 || side1 == side3)
                                    {
                                        Console.WriteLine("The triangle is Isosceles.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The triangle is Scalene.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No input received. Please enter the length of the third side.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a numerical value.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No input received. Please enter the length of the second side.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value.");
                }
            }
            else
            {
                Console.WriteLine("No input received. Please enter the length of the first side.");
            }
        }
    }
}

