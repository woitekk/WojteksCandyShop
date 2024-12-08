using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojteksCandyShop
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public int wage;
        public int hourlyRate;
        const int minimalWorkedHoursUnit = 1;

        public DateTime birthDay;

        public void PerformWork()
        {
            PerformWork(minimalWorkedHoursUnit);
        }
        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s).");
        }
        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) worked.");
            if(resetHours)
                numberOfHoursWorked = 0;

            return wage;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t{email}" +
                $"\nBirthday: \t{birthDay.ToShortDateString()}");
        }
    }
}
