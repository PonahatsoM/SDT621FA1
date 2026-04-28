using System;

namespace StudentMarksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Student Marks Calculator ===\n");

            // Prompt for student name
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            // Array to store marks
            double[] marks = new double[3];
            double totalMarks = 0;

            // Loop to get 3 subject marks
            for (int i = 0; i < 3; i++)
            {
                double mark;
                bool validInput = false;

                // Validate numeric input
                do
                {
                    Console.Write($"Enter mark for subject {i + 1}: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out mark))
                    {
                        marks[i] = mark;
                        totalMarks += mark;
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                    }
                } while (!validInput);
            }

            // Calculate average
            double average = totalMarks / 3;

            // Determine pass/fail
            string result = average >= 50 ? "PASS" : "FAIL";

            // Display results
            Console.WriteLine("\n=== Results ===");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Average Marks: {average:F2}");
            Console.WriteLine($"Result: {result}");
        }
    }
}
