using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter the number of hours for the move:");
        // Read the user input and convert it to a double
        double hours = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the number of miles for the move:");
        // Read the user input and convert it to a double
        double miles = Convert.ToDouble(Console.ReadLine());

        // Calculate the total cost of the move using the MoveEstimator method
        double totalCost = MoveEstimator(hours, miles);

         // Display the total moving fee to the user
        Console.WriteLine($"The total moving fee is: ${totalCost:F2}");
    }
    // Method to estimate the moving cost based on hours and miles
    public static double MoveEstimator(double hours, double miles)
    {
        // Define the base rate, hourly rate, and mileage rate
        double baseRate = 200;
        double hourlyRate = 150;
        double mileageRate = 2;
        // Calculate the total cost using the formula
        double totalCost = baseRate + (hourlyRate * hours) + (mileageRate * miles);
        // Return the calculated total cost
        return totalCost;
    }
}
//2024/1/6_SenShoikot_Exercise 2.2