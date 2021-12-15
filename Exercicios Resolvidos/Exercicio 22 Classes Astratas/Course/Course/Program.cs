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
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.00, 0.01));
            list.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.00, 0.01));

            double sum = 0.0;
            foreach (Account account in list)
            {
                sum += account.Balance;
            }

            foreach (Account account in list)
            {
                account.Witchdraw(10.0);
            }

            foreach (Account account in list)
            {
                Console.WriteLine("Updated balance for account " 
                    + account.Number 
                    + ": " 
                    + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
