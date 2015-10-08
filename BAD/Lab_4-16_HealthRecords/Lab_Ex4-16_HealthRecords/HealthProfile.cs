using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Ex4_16_HealthRecords
{
    class HealthProfile
    {
        private string firstName;
        private string lastName;
        private string gender;
        private int dayOfBirth;
        private int monthOfBirth;
        private int yearOfBirth;
        private double height;
        private double weight;

        public HealthProfile(string firstName, string lastName, string gender,
            int dayOfBirth, int monthOfBirth, int yearOfBirth, double height, double weight)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DayOfBirth = dayOfBirth;
            MonthOfBirth = monthOfBirth;
            YearOfBirth = yearOfBirth;
            Height = height; // meters
            Weight = weight; // kilograms
        }

        public int getAge()
        {
            int age;

            DateTime today = DateTime.Today;
            age = today.Year - YearOfBirth;
            if (today.Month < MonthOfBirth || (today.Month == MonthOfBirth && today.Day < DayOfBirth)) age--;
            return age;
        }

        public int calculateMaxHeartRate()
        {
            return 220 - getAge();
        }

        public double calculateMinTargetHeartRate()
        {
            return calculateMaxHeartRate() * 0.5;
        }

        public double calculateMaxTargetHeartRate()
        {
            return calculateMaxHeartRate() * 0.85; 
        }

        public double calculateIBM()
        {

            Console.WriteLine(Weight);
            Console.WriteLine(Height);

            return Weight / (Height * Height);
        }

        public String getSummary()
        {
            String summary = "First name: " + FirstName 
            + "\nLast name: " + LastName
            + "\nDate of Birth: " + DayOfBirth + "/" + MonthOfBirth + "/" + YearOfBirth
            + "\nAge: " + getAge()
            + "\nHeight: " + Height
            + "\nWeight: " + Weight
            + "\nMax Heart Rate: " + calculateMaxHeartRate()
            + "\nHeart Rate Range: " + calculateMinTargetHeartRate() + " - " + calculateMaxTargetHeartRate()
            + "\nIMB: " + calculateIBM();
            return summary;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int DayOfBirth
        {
            get { return dayOfBirth; }
            set { dayOfBirth = value; }
        }

        public int MonthOfBirth
        {
            get { return monthOfBirth; }
            set { monthOfBirth = value; }
        }

        public int YearOfBirth
        {
            get { return yearOfBirth; }
            set { yearOfBirth = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }



    }
}
