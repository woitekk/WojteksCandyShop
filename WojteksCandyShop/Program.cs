
using System.Text;
using WojteksCandyShop.Accounting;
using WojteksCandyShop.HR;

//int a = 42;
//int aCopy = a;
//Console.WriteLine($"Value of 'a' is {a} and value of 'aCopy is {aCopy}.");

//aCopy = 100;
//Console.WriteLine($"Value of 'a' is {a} and value of 'aCopy is {aCopy}.");



Console.WriteLine("Creating employee");
Console.WriteLine("-----------------\n");

Employee wojtek = new Employee("Wojtek", "Komowski", "test@test.pl", new DateTime(1982, 1, 7), 150, EmployeeType.Manager);

string wojtekAsJson = wojtek.ConvertToJson();
Console.WriteLine(wojtekAsJson);

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
StringBuilder builder = new StringBuilder();

builder.Append("Last name: ");
builder.AppendLine(wojtek.lastName);
builder.Append("First name: ");
builder.AppendLine(wojtek.firstName);
string employeeInfo = builder.ToString();
Console.WriteLine(employeeInfo);

StringBuilder builder2 = new StringBuilder();

for(int i = 0; i < 15; i++)
{
    builder2.Append(i);
    builder2.Append(", ");
}

string list = builder2.ToString();
Console.WriteLine(list);

//wojtek.DisplayEmployeeDetails();

//wojtek.PerformWork();
//wojtek.PerformWork();
//wojtek.PerformWork(6);
//wojtek.PerformWork();
//wojtek.PerformWork();

//double receivedWage = wojtek.ReceiveWage(true);

var gosia = new Employee("Gosia", "Mlodawska", "lufa@lufa.pl", new DateTime(1988, 6, 15), 120, EmployeeType.Research);
Employee basia = new("Basia", "Nowak", "mail@goo.com", new DateTime(1978, 7, 22), 180, EmployeeType.StoreManager);
Employee krzysztof = new("Krzysztof", "Nowakowski", "mail@ktiorego.niema", new DateTime(1982, 3, 29), 180, EmployeeType.Research);
Employee mieczyslaw = new("Mieczyslaw", "Nowawski", "mail45@ktiorego.niema", new DateTime(1987, 3, 29), null, EmployeeType.Sales);
Employee kasia = new("Katarzyna", "Noski", "mail6543@ktiorego.niema", new DateTime(1992, 3, 15), null, EmployeeType.Sales);


//gosia.DisplayEmployeeDetails();
//basia.DisplayEmployeeDetails();

//basia.firstName = "Barbara";
//var newB = basia.firstName;

//Console.WriteLine($"Prawidłowe imię Basi to {newB}.");

//WorkTask task;
//task.description = "Ciastka owsiane";
//task.hours = 2;
//task.PerformWorkTask();

#region First Run Wojtek

wojtek.PerformWork();
wojtek.PerformWork(5);
wojtek.PerformWork();
wojtek.ReceiveWage();
wojtek.DisplayEmployeeDetails();

#endregion

//Arrays

// Integer arrays
int[] sampleArray1 = new int[5];

int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5, };

Console.WriteLine("Podaj liczbę pracowników do rejestracji.");
int lenght = int.Parse(Console.ReadLine());

int[] employeeIds = new int[lenght];

for (int i = 0; i < lenght; i++)
{
    Console.WriteLine($"Podaj id {i + 1} pracownika.");
    int id = int.Parse(Console.ReadLine());
    employeeIds[i] = id;
}

for (int i = 0; i < employeeIds.Length; i++)
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
}

Array.Sort(employeeIds);
Console.WriteLine("Po posortowaniu:");
for (int i = 0; i < employeeIds.Length; i++)
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
}


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