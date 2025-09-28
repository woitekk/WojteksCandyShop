using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WojteksCandyShop.HR;

namespace WojteksCandyShop
{
    internal class Utilities
    {
        private static string directory = @"C:\Users\admin\source\repos\WojteksCandyShop\WojteksCandyShop\Employees\";
        private static string fileName = "employees.txt";

        internal static void RegisterEmployee(List<Employee> employees)
        {
            Console.WriteLine("Creating an employee");

            Console.WriteLine("What type of employee do you want to register?");
            Console.WriteLine("1. Employee\n2. Manager\n3. Store manager\n4. Researcher\n5. Junior researcher");
            Console.Write("Your selection: ");
            string employeeType = Console.ReadLine();

            if (employeeType != "1" && employeeType != "2" && employeeType != "3"
                && employeeType != "4" && employeeType != "5")
            {
                Console.WriteLine("Invalid selection!");
                return;
            }

            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter the last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter the email: ");
            string email = Console.ReadLine();

            Console.Write("Enter the birth day: ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());//ex. 2/16/2008

            Console.Write("Enter the hourly rate: ");
            string hourlyRate = Console.ReadLine();
            double rate = double.Parse(hourlyRate);

            Employee employee = null;
            switch (employeeType)
            {
                case "1":
                    employee = new Employee(firstName, lastName, email, birthDay, rate);
                    break;
                case "2":
                    employee = new Manager(firstName, lastName, email, birthDay, rate);
                    break;
                case "3":
                    employee = new StoreManager(firstName, lastName, email, birthDay, rate);
                    break;
                case "4":
                    employee = new Researcher(firstName, lastName, email, birthDay, rate);
                    break;
                case "5":
                    employee = new JuniorResearcher(firstName, lastName, email, birthDay, rate);
                    break;
            }
            employees.Add(employee);
            Console.WriteLine("Employee created!\n\n");

        }

        internal static void CheckForExistingEmployeeFile() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string path = $"{directory}{fileName}";
            bool existingFileFound = File.Exists(path);

            if (existingFileFound)
            {
                Console.WriteLine("Existing file with employee data is found.");
            }
            else
            {
                //Create 
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Console.WriteLine("Directory is ready to save files.");
                }
            }
        }

        internal static void ViewAllEmployees(List<Employee> employees) 
        { 
            for(int i = 0;  i < employees.Count; i++)
            {
                employees[i].DisplayEmployeeDetails();
            }
        }

        internal static void LoadEmployee(List<Employee> employees)
        {
            string path = $"{directory}{fileName}";
            if (File.Exists(path))
            {
                employees.Clear();

                string[] employeesAsString = File.ReadAllLines(path);
                for (int i = 0; i < employeesAsString.Length; i++)
                {
                    string[] employeeDetails = employeesAsString[i].Split(';');
                    string firstName = employeeDetails[0].Substring(employeeDetails[0].IndexOf(':') + 2);
                    string lastName = employeeDetails[1].Substring(employeeDetails[1].IndexOf(':') + 2);
                    string email = employeeDetails[2].Substring(employeeDetails[2].IndexOf(':') + 2);
                    DateTime birthDay = DateTime.Parse(employeeDetails[3].Substring(employeeDetails[3].IndexOf(':') + 2));
                    double hourlyRate = double.Parse(employeeDetails[4].Substring(employeeDetails[4].IndexOf(':') + 2));
                    string employeeType = employeeDetails[5].Substring(employeeDetails[5].IndexOf(':') + 2);
                    Employee employee = null;
                    switch (employeeType)
                    {
                        case "Employee":
                            employee = new Employee(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                        case "Manager":
                            employee = new Manager(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                        case "Store manager":
                            employee = new StoreManager(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                        case "Researcher":
                            employee = new Researcher(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                        case "Junior researcher":
                            employee = new JuniorResearcher(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                    }
                    employees.Add(employee);
                }
            }
        }

        internal static void SaveEmployee(List<Employee> employees)
        {
            string path = $"{directory}{fileName}";
            StringBuilder sb = new StringBuilder();
            foreach (Employee employee in employees)
            {
                string employeeType = GetEmployeeType(employee);
                sb.Append($"First name: {employee.FirstName};");
                sb.Append($"Last name: {employee.LastName};");
                sb.Append($"Email: {employee.Email};");
                sb.Append($"Birth day: {employee.BirthDay.ToShortDateString()};");
                sb.Append($"Hourly rate: {employee.HourlyRate};");
                sb.Append($"Employee type: {employeeType};");
                sb.Append(Environment.NewLine);
            }
            File.WriteAllText(path, sb.ToString());
            Console.WriteLine($"Employee data saved to {path}.");
        }
        private static string GetEmployeeType(Employee employee)
        {
            if (employee is StoreManager)
                return "Store manager";
            else if (employee is Manager)
                return "Manager";
            else if (employee is JuniorResearcher)
                return "Junior researcher";
            else if (employee is Researcher)
                return "Researcher";
            else
                return "Employee";
        }
    }
}
