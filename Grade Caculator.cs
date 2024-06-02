using System;

public class GradeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your numerical grade (0-100): ");

        // Read user input and convert to integer
        int grade = int.Parse(Console.ReadLine());

        // Validate input (optional)
        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
            return;
        }

        string letterGrade;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}");
    }
}