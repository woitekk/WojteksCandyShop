
using WojteksCandyShop;

//int a = 42;
//int aCopy = a;
//Console.WriteLine($"Value of 'a' is {a} and value of 'aCopy is {aCopy}.");

//aCopy = 100;
//Console.WriteLine($"Value of 'a' is {a} and value of 'aCopy is {aCopy}.");



Console.WriteLine("Creating employee");
Console.WriteLine("-----------------\n");

Employee wojtek = new Employee("Wojtek", "Komowski", "test@test.pl", new DateTime(1982, 1, 7), 150);

var testEmployee = wojtek;
testEmployee.firstName = "Bolek";

wojtek.DisplayEmployeeDetails();
testEmployee.DisplayEmployeeDetails();

//wojtek.DisplayEmployeeDetails();

//wojtek.PerformWork();
//wojtek.PerformWork();
//wojtek.PerformWork(6);
//wojtek.PerformWork();
//wojtek.PerformWork();

//double receivedWage = wojtek.ReceiveWage(true);

//var gosia = new Employee("Gosia", "Mlodawska", "lufa@lufa.pl", new DateTime(1988, 6, 15), 120);
//Employee basia = new("Basia", "Nowak", "mail@goo.com", new DateTime(1978, 7, 22), 180);

//gosia.DisplayEmployeeDetails();
//basia.DisplayEmployeeDetails();

//basia.firstName = "Barbara";
//var newB = basia.firstName;

//Console.WriteLine($"Prawidłowe imię Basi to {newB}.");
