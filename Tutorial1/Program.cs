using System;

namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            int loanAmount;
            // Loop until valid loan amount is provided
            while (!TryGetValidIntegerInput("Enter the loan amount:", out loanAmount) || loanAmount <= 0)
            {
                // Display error message for invalid input
                Console.WriteLine("Please enter a valid positive integer value.");
            }

            int interestRate;
            // Loop until valid interest rate is provided
            while (!TryGetValidIntegerInput("Enter the interest rate (%):", out interestRate) || interestRate <= 0)
            {
                // Display error message for invalid input
                Console.WriteLine("Please enter a valid positive integer value.");
            }

            int loanDuration;
            // Loop until valid loan duration is provided
            while (!TryGetValidIntegerInput("Enter the loan duration (months):", out loanDuration) || loanDuration <= 0)
            {
                // Display error message for invalid input
                Console.WriteLine("Please enter a valid positive integer value.");
            }

            // Calculate interest amount and total amount
            int intAmount = ((loanAmount * interestRate) / 100) * loanDuration;
            int totalAmount = intAmount + loanAmount;

            // Display results
            Console.WriteLine($"Interest amount for {loanDuration} months: {intAmount}");
            Console.WriteLine($"Total amount to be paid after {loanDuration} months: {totalAmount}");
        }

        static bool TryGetValidIntegerInput(string prompt, out int result)
        {
            result = 0;
            // Display prompt for input
            Console.WriteLine(prompt);
            // Read input from console
            string input = Console.ReadLine();
            // Check if input is empty
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            // Try to parse input to integer
            if (!int.TryParse(input, out result) || result < 0)
            {
                return false;
            }
            // Return true if input is valid
            return true;
        }
    }
}
