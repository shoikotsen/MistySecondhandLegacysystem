using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter the number of hours for the move:");
        double hours = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the number of miles for the move:");
        double miles = Convert.ToDouble(Console.ReadLine());

        // Calculate the total cost
        double totalCost = MoveEstimator(hours, miles);

        // Display the result
        Console.WriteLine($"The total moving fee is: ${totalCost:F2}");
    }

    public static double MoveEstimator(double hours, double miles)
    {
        double baseRate = 200;
        double hourlyRate = 150;
        double mileageRate = 2;

        double totalCost = baseRate + (hourlyRate * hours) + (mileageRate * miles);
        return totalCost;
    }
}
//2024/1/6_SenShoikot_Exercise 2.2