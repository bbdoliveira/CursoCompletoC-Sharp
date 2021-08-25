using System;
using System.Globalization;

namespace ExercicioFix_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + a.MediaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
