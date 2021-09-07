using System;
using System.Globalization;

namespace ExercicioFix_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double qteDolares = double.Parse(Console.ReadLine());

            double valorPago = ConversorDeMoeda.Moeda(qteDolares, dolar);

            Console.WriteLine("Calor a ser pago em reais = " + valorPago.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
