using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojteksCandyShop.HR
{
    internal class Developer : Employee
    {
        private string currentProject;

        public string CurrentProject
        {
            get { return currentProject; }
            set
            {
                currentProject = value;
            }
        }
        public Developer(string firstName, string lastName, string email, DateTime birthDay, 
            double? hourlyRate, string currentProject) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }
        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine($"First name: \t{FirstName}\nLast name: \t{LastName}\nEmail: \t\t{Email}" +
                $"\nBirthday: \t{BirthDay.ToShortDateString()}\nCurrent project: \t{CurrentProject}\nTax rate: \t{taxRate}.\n");
        }
    }
}
