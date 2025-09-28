
using System;
using System.Text;
using WojteksCandyShop;
using WojteksCandyShop.Accounting;
using WojteksCandyShop.HR;

//Full Console program
List<Employee> employees = new List<Employee>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("**********************");
Console.WriteLine("Wojtek's Candy Shop Employee app");
Console.WriteLine("**********************");
Console.ForegroundColor = ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.CheckForExistingEmployeeFile();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {employees.Count} employee(s)\n\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("**********************");
    Console.WriteLine("Select an action.");
    Console.WriteLine("**********************");

    Console.WriteLine("1: Register employee");
    Console.WriteLine("2: View all employees");
    Console.WriteLine("3: Save data");
    Console.WriteLine("4: Load data");
    Console.WriteLine("9: Quit app");
    Console.WriteLine("Your selection: ");

    userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            Utilities.RegisterEmployee(employees);
            break;
        case "2":
            Utilities.ViewAllEmployees(employees);
            break;
        case "3":
            Utilities.SaveEmployee(employees);
            break;
        case "4":
            Utilities.LoadEmployee(employees);
            break;
        case "9": break;
        default:
            Console.WriteLine("Invalid selection. Try again.");
            break;
    }
} while (userSelection != "9");


//int a = 42;
//int aCopy = a;
//Console.WriteLine($"Value of 'a' is {a} and value of 'aCopy is {aCopy}.");

//aCopy = 100;
//Console.WriteLine($"Value of 'a' is {a} and value of 'aCopy is {aCopy}.");



//Console.WriteLine("Creating employee");
//Console.WriteLine("-----------------\n");

//IEmployee wojtek = new Employee("Wojtek", "Komowski", "test@test.pl", new DateTime(1982, 1, 7), 150, "Piotrkowska", "4a", "Lodz", "91-084");

//string wojtekAsJson = wojtek.ConvertToJson();
//Console.WriteLine(wojtekAsJson);

//var testEmployee = wojtek;
//testEmployee.firstName = "Bolek";

//wojtek.DisplayEmployeeDetails();
//testEmployee.DisplayEmployeeDetails();

//wojtek.PerformWork(25);

//int minimumBonus = 100;
//int receivedBonus = wojtek.CalculateBonus(minimumBonus);
//Console.WriteLine($"Minimalny bonus to {minimumBonus}, a {wojtek.firstName} otrzymał(a) bonus w wysokości {receivedBonus}.");

//int bonusTax;
//int receivedBonus = wojtek.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
//Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax}. {wojtek.firstName} received bonus is {receivedBonus}");

/* String builder */
//StringBuilder builder = new StringBuilder();

//builder.Append("Last name: ");
//builder.AppendLine(wojtek.LastName);
//builder.Append("First name: ");
//builder.AppendLine(wojtek.FirstName);
//string employeeInfo = builder.ToString();
//Console.WriteLine(employeeInfo);

//StringBuilder builder2 = new StringBuilder();

//for(int i = 0; i < 15; i++)
//{
//    builder2.Append(i);
//    builder2.Append(", ");
//}

//string list = builder2.ToString();
//Console.WriteLine(list);

//wojtek.DisplayEmployeeDetails();

//wojtek.PerformWork();
//wojtek.PerformWork();
//wojtek.PerformWork(6);
//wojtek.PerformWork();
//wojtek.PerformWork();

//double receivedWage = wojtek.ReceiveWage(true);

//IEmployee gosia = new StoreManager("Gosia", "Mlodawska", "lufa@lufa.pl", new DateTime(1988, 6, 15), 90);
//IEmployee basia = new Researcher("Basia", "Nowak", "mail@goo.com", new DateTime(1978, 7, 22), 120);
//IEmployee krzysztof = new Manager("Krzysztof", "Nowakowski", "mail@ktiorego.niema", new DateTime(1982, 3, 29), 180);
//IEmployee mieczyslaw = new Developer("Mieczyslaw", "Nowawski", "mail45@ktiorego.niema", new DateTime(1987, 3, 29), 150, "Website");
//IEmployee kasia = new Employee("Katarzyna", "Noski", "mail6543@ktiorego.niema", new DateTime(1992, 3, 15), null);
//IEmployee wladek = new JuniorResearcher("Władysław", "Noski", "mail65ff43@ktiorego.niema", new DateTime(1988, 6, 14), null); 

//krzysztof.AttendManagementMeeting();
//wladek.ReasearchNewCandyTastes(2);
//wladek.ReasearchNewCandyTastes(5);

//gosia.DisplayEmployeeDetails();
//basia.DisplayEmployeeDetails();

//basia.firstName = "Barbara";
//var newB = basia.firstName;

//Console.WriteLine($"Prawidłowe imię Basi to {newB}.");

//WorkTask task;
//task.description = "Ciastka owsiane";
//task.hours = 2;
//task.PerformWorkTask();

//#region First Run Wojtek

//wojtek.PerformWork();
//wojtek.PerformWork(5);
//wojtek.PerformWork();
//wojtek.ReceiveWage();
//wojtek.DisplayEmployeeDetails();

//#endregion

//Arrays

// Integer arrays
//int[] sampleArray1 = new int[5];

//int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5, };

//Console.WriteLine("Podaj liczbę pracowników do rejestracji.");
//int lenght = int.Parse(Console.ReadLine());

//int[] employeeIds = new int[lenght];

//for (int i = 0; i < lenght; i++)
//{
//    Console.WriteLine($"Podaj id {i + 1} pracownika.");
//    int id = int.Parse(Console.ReadLine());
//    employeeIds[i] = id;
//}

//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}

//Array.Sort(employeeIds);
//Console.WriteLine("Po posortowaniu:");
//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}


//Array from methods
//Employee[] employess = new Employee[5];
//employess[0] = gosia; employess[1] = basia;  employess[2] = krzysztof; employess[3] =  mieczyslaw; employess[4] =  kasia;

//foreach(Employee e in employess)
//{
//    e.DisplayEmployeeDetails();
//    var numberOfHoursWorked = new Random().Next(30);
//    e.PerformWork(numberOfHoursWorked);
//    e.ReceiveWage();
//}

//Collections - List
//List<int> employeeIds = new List<int>();

//employeeIds.Add(53);
//employeeIds.Add(6453);
//employeeIds.Add(4);
//employeeIds.Add(45);
//employeeIds.Add(7545);
//employeeIds.Add(34);
////employeeIds.Add("string");
//int value = employeeIds.FirstOrDefault();

//if (value == 53)
//{
//    Console.WriteLine($"Employee ids has a {value} id.");
//}

//if (employeeIds.Contains(4))
//{
//    Console.WriteLine("Employee id contains number 4.");
//}
//else
//{
//    Console.WriteLine("There is no employee with id of 4.");
//}

//int currentAmountOfEmployees = employeeIds.Count;
//Console.WriteLine($"There are currently {currentAmountOfEmployees} employees at the firm.");

//var employeesArray = employeeIds.ToArray();

//employeeIds.Clear();
//int currentAmountOfEmployeesAfterRestructurization = employeeIds.Count;
//Console.WriteLine($"There are currently {currentAmountOfEmployeesAfterRestructurization} employees at the firm.");


//Console.WriteLine("Adding employees...");
//Console.WriteLine("-----------------\n");
//Console.WriteLine("How many employees IDs do you want to register?");
//int lenght = int.Parse(Console.ReadLine());

//for(int i = 0; i < lenght; i++)
//{
//    Console.WriteLine("Enter employee ID:");
//    int id = int.Parse(Console.ReadLine());
//    employeeIds.Add(id);
//}

//List<IEmployee> employees = new List<IEmployee>();
//employees.Add(wojtek);
//employees.Insert(0, kasia);
//employees.Add(mieczyslaw);
//employees.Add(basia);
//employees.Add(gosia);
//employees.Add(krzysztof);   
//employees.Add(wladek);

//foreach(Employee e in employees)
//{
//    e.DisplayEmployeeDetails();
//    e.GiveBonus();
//    e.GiveComplement();
//}

