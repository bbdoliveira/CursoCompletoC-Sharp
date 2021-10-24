using System;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data");
            Console.Write("Name: ");
            string userName = Console.ReadLine();
            Console.Write("Email: ");
            string userEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime userBirthDay = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Console.Write("How mani items to this order? ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Product name: ");

            Console.WriteLine(userName);
            Console.WriteLine(userEmail);
            Console.WriteLine(userBirthDay);
            Console.WriteLine(orderStatus);
            Console.WriteLine(quantity);
        }
    }
}
