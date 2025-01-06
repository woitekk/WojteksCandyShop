using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojteksCandyShop.HR
{
    internal class Researcher : Employee
    {
        public Researcher(string firstName, string lastName, string email, DateTime birthDay, 
            double? hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }

        private int numOfCandiesInvented = 0;
        public int NumOfCandiesInvented
        {
            get; set;
        }
        public void ReasearchNewCandyTastes(int reasearchHours)
        {
            NumberOfHoursWorked += reasearchHours;

            if(new Random().Next(100) > 50)
            {
                NumOfCandiesInvented++;
                Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new candy taste. " +
                    $"Total number of candies invented: {NumOfCandiesInvented}.");
            }
            else
            {
                Console.WriteLine($"Researcher {FirstName} {LastName} is working still on a new candy taste.");
            }
        }
    }
}
