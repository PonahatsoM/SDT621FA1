using System;
using System.Collections.Generic;
using System.Text;

namespace EmfuleniMunicipalityApp
{
    internal class ServiceRequest
    {
        public Resident Resident { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }   // 1–5
        public int SeverityLevel { get; set; }   // 1–10
        public int EstimatedResolutionHours { get; set; }

        public double UrgencyScore { get; set; }

        public override string ToString()
        {
            return $"Request: {RequestType}, Priority: {PriorityLevel}, Severity: {SeverityLevel}, " +
                   $"Resolution: {EstimatedResolutionHours}h, Urgency Score: {UrgencyScore:F2}";
        }
    }
}
