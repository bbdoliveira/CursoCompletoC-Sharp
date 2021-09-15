using System;
using System.Globalization;

namespace ExercicioFix_Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n): ");
            char deposito = char.Parse(Console.ReadLine());

            if (deposito == 's')
            {
                Console.Write("Entre o de depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine());
                Console.Write("Seu saldo inicial é: " + depInicial.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                double saldoInicial = 0;
                Console.Write("Seu saldo incial é: " + saldoInicial.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
