using System;

public class TicketPriceCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your age: ");

        // Read user input and convert to integer
        int age = int.Parse(Console.ReadLine());

        double ticketPrice;

        if (age >= 65 || age <= 12)
        {
            ticketPrice = 7.0; // Discounted price
        }
        else
        {
            ticketPrice = 10.0; // Regular price
        }

        Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
    }
}