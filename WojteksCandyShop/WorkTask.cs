using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojteksCandyShop
{
    internal struct WorkTask
    {
        public string description;
        public int hours;

        public void PerformWorkTask()
        {
            Console.WriteLine($"Zadanie '{description}' wykonane w czasie {hours} godzin(y).");
        }
    }
}