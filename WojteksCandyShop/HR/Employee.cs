using BethanysPieShopHRM.Logic;
using Newtonsoft.Json;

namespace WojteksCandyShop.HR
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double? hourlyRate;
        const int minimalWorkedHoursUnit = 1;

        public DateTime birthDay;

        public EmployeeType employeeType;

        public static double taxRate = 0.15;

        //Second constractor
        public Employee(string first, string last, string mail, DateTime bD) : this(first, last, mail, bD, 0, EmployeeType.StoreManager)
        {

        }

        //Main constructor
        public Employee(string first, string last, string mail, DateTime bD, double? rate, EmployeeType empType)
        {
            firstName = first;
            lastName = last;
            email = mail;
            birthDay = bD;
            hourlyRate = rate ?? 10;
            employeeType = empType;
        }

        public void PerformWork()
        {
            PerformWork(minimalWorkedHoursUnit);
        }
        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s).");
        }

        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWorked > 10)
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
            if (numberOfHoursWorked > 10)
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
            double calculatedValue = wageCalculations.ComplexWageCalculation(wage, taxRate, 3, 42);
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

            if (employeeType == EmployeeType.Manager)
            {
                wageBeforTax = numberOfHoursWorked * hourlyRate.Value * 1.25;
                Console.WriteLine($"An extra was added since {firstName} is a manager.");
            }
            else
            {
                wageBeforTax = numberOfHoursWorked * hourlyRate.Value;
            }

            double taxAmount = wageBeforTax * taxRate;
            wage = wageBeforTax - taxAmount;


            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) worked.");
            if (resetHours)
                numberOfHoursWorked = 0;

            return wage;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"First name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}" +
                $"\nBirthday: \t{birthDay.ToShortDateString()}\nTax rate: \t{taxRate}.\n");
        }
    }
}
