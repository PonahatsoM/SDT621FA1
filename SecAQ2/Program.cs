using System;

namespace SimpleATMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Simple ATM ===\n");

            // Initial balance
            double balance = 5000.00; // starting balance
            Console.WriteLine($"Your current balance is: {balance:C}\n");

            // Prompt user for withdrawal amount
            Console.Write("Enter amount to withdraw: ");
            string input = Console.ReadLine();
            double withdrawalAmount;

            // Validate numeric input
            if (double.TryParse(input, out withdrawalAmount))
            {
                if (withdrawalAmount <= 0)
                {
                    Console.WriteLine("Invalid amount. Withdrawal must be greater than zero.");
                }
                else if (withdrawalAmount > balance)
                {
                    Console.WriteLine("Insufficient funds. Transaction declined.");
                }
                else
                {
                    // Perform withdrawal
                    balance -= withdrawalAmount;

                    // Display transaction results
                    Console.WriteLine("\n=== Transaction Successful ===");
                    Console.WriteLine($"Amount Withdrawn: {withdrawalAmount:C}");
                    Console.WriteLine($"Updated Balance: {balance:C}");
                    Console.WriteLine($"Transaction Time: {DateTime.Now}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }

            Console.WriteLine("\nThank you for using Simple ATM!");
        }
    }
}

