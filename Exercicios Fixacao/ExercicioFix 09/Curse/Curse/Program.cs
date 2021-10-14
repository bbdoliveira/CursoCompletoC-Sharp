using System;

namespace Curse
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;

            Console.WriteLine("Digite a quantidade de linhas e colunas!");
            Console.WriteLine();
            Console.Write("Quantas linhas? ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------|");
            Console.Write("Quantas colunas? ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.Write("Digite um numero que pertence a matriz: ");
            int x = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == x)
                    {
                        //Console.WriteLine("Position " + i + "," + j + ":");
                        //if (i == 0 && j == 0)
                        //{
                        //    Console.WriteLine("Right: " + mat[0,1]);
                        //}
                        //else if (true)
                        //{

                        //}
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("O número digitado aparece: " + count + ", vezes!");
        }
    }
}
