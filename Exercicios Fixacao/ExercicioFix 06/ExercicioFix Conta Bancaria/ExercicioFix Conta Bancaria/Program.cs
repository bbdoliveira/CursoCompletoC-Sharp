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

            ContaBancaria conta = new ContaBancaria(numero, nome, deposito);

            if (deposito == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double quantia = double.Parse(Console.ReadLine());
                Console.WriteLine("Conta " + conta.Numero + " Titular: " + conta.Titular + " Saldo: $ " + conta.Deposito(quantia).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Conta " + conta.Numero + " Titular: " + conta.Titular + " Saldo: $ " + conta.Deposito(0.00));
            }

            Console.Write("Entre um valor para saque:");
            double saque = double.Parse(Console.ReadLine());

            conta.Saque(saque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine("Conta " + conta.Numero + " Titular: " + conta.Titular + " Saldo: $ " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
