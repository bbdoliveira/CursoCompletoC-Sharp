using System.Globalization;
using Course.Entities;

Console.WriteLine("Enter rental data");
Console.Write("Car model:");
string model = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy hh:mm): "); //Na linha abaixo passando o formato da data e hora.
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

Console.Write("Enter price per hour: ");
double priceHour = double.Parse(Console.ReadLine());
Console.Write("Enter price per day: ");
double priceDay = double.Parse(Console.ReadLine());
