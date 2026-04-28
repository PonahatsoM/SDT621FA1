using System;
using System.Collections.Generic;
using System.Text;

namespace EmfuleniMunicipalityApp
{
    internal class Resident
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string AccountNumber { get; set; }
        public double MonthlyUsage { get; set; }

        public override string ToString()
        {
            return $"Resident: {Name}, Address: {Address}, Account#: {AccountNumber}, Usage: {MonthlyUsage} kWh";
        }
    }
}
