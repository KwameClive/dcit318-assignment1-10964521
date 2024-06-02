using System;

public class TriangleTypeIdentifier
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of side 3: ");
        double side3 = double.Parse(Console.ReadLine());

        string triangleType;

        if (side1 == side2 && side2 == side3)
        {
            triangleType = "Equilateral";
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            triangleType = "Isosceles";
        }
        else
        {
            triangleType = "Scalene";
        }

        Console.WriteLine($"The triangle is: {triangleType}");
    }
}