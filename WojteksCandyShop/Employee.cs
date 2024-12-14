using Newtonsoft.Json;

namespace WojteksCandyShop
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;
        const int minimalWorkedHoursUnit = 1;

        public DateTime birthDay;

        public EmployeeType employeeType;

        //Second constractor
        public Employee(string first, string last, string mail, DateTime bD) : this(first, last, mail, bD, 0, EmployeeType.StoreManager) 
        { 

        }

        //Main constructor
        public Employee(string first, string last, string mail, DateTime bD, double rate, EmployeeType empType)
        {
            firstName = first;
            lastName = last;
            email = mail;
            birthDay = bD;
            hourlyRate = rate;
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

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        public double ReceiveWage(bool resetHours = true)
        {
            if(employeeType == EmployeeType.Manager)
            {
                wage = numberOfHoursWorked * hourlyRate * 1.5;
                Console.WriteLine($"An extra was added since {firstName} is a manager.");
            }
            else
            {
                wage = numberOfHoursWorked * hourlyRate;
            }
          
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) worked.");
            if(resetHours)
                numberOfHoursWorked = 0;

            return wage;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"First name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}" +
                $"\nBirthday: \t{birthDay.ToShortDateString()}\n");
        }
    }
}
