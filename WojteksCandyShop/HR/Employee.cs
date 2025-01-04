using BethanysPieShopHRM.Logic;
using Newtonsoft.Json;

namespace WojteksCandyShop.HR
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;
        const int minimalWorkedHoursUnit = 1;

        private DateTime birthDay;

        private EmployeeType employeeType;

        public static double taxRate = 0.15;

        //Properites
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            private set
            {
                numberOfHoursWorked = value;
            }
        }
        public double Wage
        {
            get { return wage;}
            private set
            {
                wage = value;
            }
        }
        public double? HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (hourlyRate < 0) 
                { 
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }
        public DateTime BirthDay
        {
            get; set;
        }
        public EmployeeType EmployeeType
        {
            get; set;
        }
        // End setitng properties
        //Second constractor
        public Employee(string firstName, string lastName, string email, DateTime birthDay) 
            : this(firstName, lastName, email, birthDay, 0, EmployeeType.StoreManager)
        {

        }

        //Main constructor
        public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate, EmployeeType employeeType)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10;
            EmployeeType = employeeType;
        }

        public void PerformWork()
        {
            PerformWork(minimalWorkedHoursUnit);
        }
        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHours} hour(s).");
        }

        public int CalculateBonus(int bonus)
        {
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"Pracownik otrzymał bonus w wysokości {bonus}.");
            return bonus;
        }

        //public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        //{
        //    if (numberOfHoursWorked > 10)
        //        bonus *= 2;

        //    if (bonus >= 200)
        //    {
        //        bonusTax = bonus / 10;
        //        bonus -= bonusTax;
        //    }

        //    Console.WriteLine($"Pracownik otrzymał bonus w wysokości {bonus}, podatek od bonusu wynisół {bonusTax}.");
        //    return bonus;
        //} 
        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"Pracownik otrzymał bonus w wysokości {bonus}, podatek od bonusu wynisół {bonusTax}.");
            return bonus;
        }

        public double CalculateWage()
        {
            WageCalculations wageCalculations = new WageCalculations();
            double calculatedValue = wageCalculations.ComplexWageCalculation(Wage, taxRate, 3, 42);
            return calculatedValue;
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforTax = 0.0;

            if (EmployeeType == EmployeeType.Manager)
            {
                wageBeforTax = NumberOfHoursWorked * HourlyRate.Value * 1.25;
                Console.WriteLine($"An extra was added since {FirstName} is a manager.");
            }
            else
            {
                wageBeforTax = NumberOfHoursWorked * HourlyRate.Value;
            }

            double taxAmount = wageBeforTax * taxRate;
            wage = wageBeforTax - taxAmount;


            Console.WriteLine($"{firstName} {lastName} has received a wage of {Wage} for {NumberOfHoursWorked} hour(s) worked.");
            if (resetHours)
                NumberOfHoursWorked = 0;

            return Wage;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"First name: \t{FirstName}\nLast name: \t{LastName}\nEmail: \t\t{Email}" +
                $"\nBirthday: \t{BirthDay.ToShortDateString()}\nEmployee type: \t{EmployeeType}\nTax rate: \t{taxRate}.\n");
        }
    }
}
