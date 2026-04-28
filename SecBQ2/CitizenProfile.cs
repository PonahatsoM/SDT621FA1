using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAffairsDigitalIdentityProcessor_
{
    internal class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; private set; }
        public string CitizenshipStatus { get; set; }

        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAge(idNumber);
        }

        private int CalculateAge(string idNumber)
        {
            if (idNumber.Length < 6) return 0;

            string birthDatePart = idNumber.Substring(0, 6); // YYMMDD
            int year = int.Parse(birthDatePart.Substring(0, 2));
            int month = int.Parse(birthDatePart.Substring(2, 2));
            int day = int.Parse(birthDatePart.Substring(4, 2));

            // Determine century
            int currentYear = DateTime.Now.Year % 100;
            int century = (year <= currentYear) ? 2000 : 1900;
            DateTime birthDate = new DateTime(century + year, month, day);

            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.Date < birthDate.AddYears(age)) age--;

            return age;
        }

        public string ValidateID()
        {
            if (string.IsNullOrEmpty(IDNumber) || IDNumber.Length != 13)
                return "Invalid ID: Must contain exactly 13 digits.";

            foreach (char c in IDNumber)
            {
                if (!char.IsDigit(c))
                    return "Invalid ID: Must contain only numeric digits.";
            }

            if (Age <= 0)
                return "Invalid ID: Birth date could not be determined.";

            return "ID is valid.";
        }

        public string GenerateProfileSummary()
        {
            return $"=== Citizen Profile ===\n" +
                   $"Name: {FullName}\n" +
                   $"ID Number: {IDNumber}\n" +
                   $"Age: {Age}\n" +
                   $"Citizenship: {CitizenshipStatus}\n" +
                   $"Validation: {ValidateID()}\n" +
                   $"Processed on: {DateTime.Now}\n";
        }
    }
}
