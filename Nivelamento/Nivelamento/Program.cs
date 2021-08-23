using System;
using System.Globalization;

namespace Nivelamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int codPeca, quantidadePeca, count = 0;
            double valorPeca, somaPreco = 0.0;



            while (count < 2)
            {
                string[] vet = Console.ReadLine().Split(' ');
                codPeca = int.Parse(vet[0]);
                quantidadePeca = int.Parse(vet[1]);
                valorPeca = double.Parse(vet[2]);
                somaPreco += valorPeca * quantidadePeca;
                count++;
            }

            Console.WriteLine("VALOR A PAGAR: R$ " + somaPreco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
