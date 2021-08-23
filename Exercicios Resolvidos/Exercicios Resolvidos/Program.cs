using System;

namespace Exercicios_Resolvidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoa1, pessoa2, idade1, idade2;

            pessoa1 = new Pessoas();
            idade1 = new Pessoas();

            pessoa2 = new Pessoas();
            idade2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.NOME = Console.ReadLine();
            Console.Write("Idade: ");
            idade1.IDADE = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.NOME = Console.ReadLine();
            Console.Write("Idade: ");
            idade2.IDADE = int.Parse(Console.ReadLine());

            if (idade1.IDADE > idade2.IDADE)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.NOME);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.NOME);
            }
        }
    }
}
