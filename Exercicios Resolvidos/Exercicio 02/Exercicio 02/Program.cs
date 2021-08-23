using System;
using System.Globalization;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun01 = new Funcionario();
            Funcionario fun02 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            fun01.NOME = Console.ReadLine();
            Console.Write("Salário: ");
            fun01.SALARIO = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            fun02.NOME = Console.ReadLine();
            Console.Write("Salário: ");
            fun02.SALARIO = double.Parse(Console.ReadLine());

            double media;
            media = (fun01.SALARIO + fun02.SALARIO) / 2;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
