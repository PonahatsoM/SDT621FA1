using System;
using System.Collections.Generic;
using System.Linq;

namespace EmfuleniMunicipalityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UtilitiesManager manager = new UtilitiesManager();

            Console.Write("Enter number of residents: ");
            int numResidents = int.Parse(Console.ReadLine());
            List<Resident> residents = new List<Resident>();

            // Capture residents
            for (int i = 0; i < numResidents; i++)
            {
                Console.WriteLine($"\nResident {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Address: ");
                string address = Console.ReadLine();
                Console.Write("Account Number: ");
                string account = Console.ReadLine();
                Console.Write("Monthly Utility Usage (kWh): ");
                double usage = double.Parse(Console.ReadLine());

                residents.Add(new Resident { Name = name, Address = address, AccountNumber = account, MonthlyUsage = usage });
            }

            // Capture service requests
            Console.Write("\nEnter number of service requests: ");
            int numRequests = int.Parse(Console.ReadLine());

            for (int i = 0; i < numRequests; i++)
            {
                Console.WriteLine($"\nService Request {i + 1}:");

                // Safe resident selection
                int resIndex;
                while (true)
                {
                    Console.Write($"Select resident index (1 to {numResidents}): ");
                    if (int.TryParse(Console.ReadLine(), out resIndex))
                    {
                        resIndex -= 1; // adjust for 0-based index
                        if (resIndex >= 0 && resIndex < residents.Count)
                            break;
                    }
                    Console.WriteLine("Invalid resident index. Please try again.");
                }

                Console.Write("Request Type: ");
                string type = Console.ReadLine();

                int priority;
                while (true)
                {
                    Console.Write("Priority Level (1–5): ");
                    if (int.TryParse(Console.ReadLine(), out priority) && priority >= 1 && priority <= 5)
                        break;
                    Console.WriteLine("Invalid priority. Must be between 1 and 5.");
                }

                int severity;
                while (true)
                {
                    Console.Write("Severity Level (1–10): ");
                    if (int.TryParse(Console.ReadLine(), out severity) && severity >= 1 && severity <= 10)
                        break;
                    Console.WriteLine("Invalid severity. Must be between 1 and 10.");
                }

                int hours;
                while (true)
                {
                    Console.Write("Estimated Resolution Hours: ");
                    if (int.TryParse(Console.ReadLine(), out hours) && hours > 0)
                        break;
                    Console.WriteLine("Invalid hours. Must be greater than 0.");
                }

                ServiceRequest req = new ServiceRequest
                {
                    Resident = residents[resIndex],
                    RequestType = type,
                    PriorityLevel = priority,
                    SeverityLevel = severity,
                    EstimatedResolutionHours = hours
                };

                manager.CalculateUrgency(req);
                manager.Requests.Add(req);
            }

            // Display queue
            Console.WriteLine("\n=== Pending Service Requests ===");
            foreach (var req in manager.Requests)
            {
                Console.WriteLine(req.ToString());
            }

            // Process requests interactively
            while (manager.Requests.Count > 0)
            {
                Console.Write($"\nEnter request index to process (1 to {manager.Requests.Count}, or 0 to stop): ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 0) break;

                if (choice < 1 || choice > manager.Requests.Count)
                {
                    Console.WriteLine("Invalid request index. Try again.");
                    continue;
                }

                ServiceRequest selected = manager.Requests[choice - 1];
                manager.GenerateReport(selected);
                manager.ProcessedRequests.Add(selected);
                manager.Requests.RemoveAt(choice - 1);
            }

            // Summary
            manager.GenerateSummary();
        }
    }
}
