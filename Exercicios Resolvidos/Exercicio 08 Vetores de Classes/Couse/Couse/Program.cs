using System;
using System.Globalization;

namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                //Váriaveis temporárias
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                vect[i] = new Product(name, price); //Utilizando o construtor da classe.
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Produto: " + vect[i].Name + ", Valor: " + vect[i].Price);
            }*/
        }
    }
}
