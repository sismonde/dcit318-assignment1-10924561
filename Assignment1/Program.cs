using System;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            // Call static methods from each class to execute functionality
            GradeCalculator.CalculateGrade();
            TicketPriceCalculator.CalculateTicketPrice();
            TriangleTypeIdentifier.IdentifyTriangleType();
        }
    }
}
