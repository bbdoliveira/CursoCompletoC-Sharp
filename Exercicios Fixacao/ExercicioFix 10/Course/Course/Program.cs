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
            
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(quantity, productPrice);
                double totalOrder = item.SubTotal(quantity, productPrice);
            }

            Client client = new Client(userName, userEmail, userBirthDay);

            Console.WriteLine(userName);
            Console.WriteLine(userEmail);
            Console.WriteLine(userBirthDay);
            Console.WriteLine(orderStatus);
            Console.WriteLine(n);
        }
    }
}
