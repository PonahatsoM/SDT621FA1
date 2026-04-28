using EmfuleniMunicipalityApp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmfuleniMunicipalityApp
{
    internal class UtilitiesManager
    {
        public List<ServiceRequest> Requests { get; set; } = new List<ServiceRequest>();
        public List<ServiceRequest> ProcessedRequests { get; set; } = new List<ServiceRequest>();

        // Calculate urgency score
        public void CalculateUrgency(ServiceRequest request)
        {
            // Simple formula: (Priority * Severity) / ResolutionHours
            request.UrgencyScore = (request.PriorityLevel * request.SeverityLevel) /
                                   (request.EstimatedResolutionHours > 0 ? request.EstimatedResolutionHours : 1);
        }

        // Generate report for a processed request
        public void GenerateReport(ServiceRequest request)
        {
            Console.WriteLine("\n=== Service Request Report ===");
            Console.WriteLine(request.Resident.ToString());
            Console.WriteLine(request.ToString());
            Console.WriteLine("==============================\n");
        }

        // Summary after all requests processed
        public void GenerateSummary()
        {
            Console.WriteLine("\n=== Summary of Processed Requests ===");
            foreach (var req in ProcessedRequests)
            {
                Console.WriteLine(req.ToString());
            }

            var highest = ProcessedRequests.OrderByDescending(r => r.UrgencyScore).FirstOrDefault();
            if (highest != null)
            {
                Console.WriteLine($"\nHighest Urgency Request: {highest.RequestType} for {highest.Resident.Name} " +
                                  $"with score {highest.UrgencyScore:F2}");
            }
        }
    }
}
