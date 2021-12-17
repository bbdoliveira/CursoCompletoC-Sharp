using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpend = double.Parse(Console.ReadLine());

                    list.Add(new NaturalPerson(name, annualIncome, healthExpend));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numEmployee = int.Parse(Console.ReadLine());

                    list.Add(new LegalPerson(name, annualIncome, numEmployee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            
            double sum = 0.0;

            foreach (Person person in list)
            {
                Console.WriteLine(person.Name + ": $ " + person.Tax().ToString("F2", CultureInfo.InvariantCulture));
                sum += person.Tax();
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
