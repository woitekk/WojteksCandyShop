
using WojteksCandyShop;

Console.WriteLine("Creating employee");
Console.WriteLine("-----------------\n");

Employee wojtek = new Employee("Wojtek", "Komowski", "test@test.pl", new DateTime(1982, 1, 7), 150);

wojtek.DisplayEmployeeDetails();

wojtek.PerformWork();
wojtek.PerformWork();
wojtek.PerformWork(6);
wojtek.PerformWork();
wojtek.PerformWork();

wojtek.ReceiveWage(true);
