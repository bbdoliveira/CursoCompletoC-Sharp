using System;

namespace Curse
{
    class Program
    {
        static void Main(string[] args)
        {
            //M = Linha
            //N = Coluna
            int m, n;

            Console.WriteLine("Digite a quantidade de linhas e colunas!");
            Console.WriteLine();
            Console.Write("Quantas linhas? ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------|");
            Console.Write("Quantas colunas? ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int lin = 0; lin < m; lin++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int col = 0; col < n; col++)
                {
                    mat[lin, col] = int.Parse(values[col]);
                }
            }
            Console.Write("Digite um numero que pertence a matriz: ");
            int x = int.Parse(Console.ReadLine());
            int count = 0;
            for (int lin = 0; lin < m; lin++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (mat[lin, col] == x)//Verifica se o X esta na linha.
                    {
                        Console.WriteLine("Position " + lin + "," + col + ":");
                        if (lin == 0)
                        {
                            col -= 1;
                            Console.WriteLine("Left: " + mat[lin, col]);
                            col += 2;
                            Console.WriteLine("Right: " + mat[lin, col]);
                            col -= 1;
                            lin += 1;
                            Console.WriteLine("Down: " + mat[lin, col]);
                        }
                        else if (lin > 0)
                        {
                            if (lin == m)
                            {
                                col -= 1;
                                Console.WriteLine("Left: " + mat[lin, col]);
                                col += 1;
                                lin -= 1;
                                Console.WriteLine("Up: " + mat[lin, col]);
                                if (col != n)
                                {
                                    Console.WriteLine("Right: " + mat[lin, col]);
                                }
                            }
                            else
                            {
                                col -= 1;
                                Console.WriteLine("Left: " + mat[lin, col]);
                                col += 1;
                                lin -= 1;
                                Console.WriteLine("Up: " + mat[lin, col]);
                                col += 1;
                                if (col != n)
                                {
                                    Console.WriteLine("Right: " + mat[lin, col]);
                                }
                                col -= 1;
                                lin += 2;
                                Console.WriteLine("Down: " + mat[lin, col]);
                            } 
                        }
                        //else
                        //{
                        //    //    j -= 1;
                        //    //    Console.WriteLine("Left: " + mat[i, j]);
                        //    //    j += 1;
                        //    //    i -= 1;
                        //    //    Console.WriteLine("Up: " + mat[i, j]);
                        //    //    j -= 1;
                        //    //    i += 1;
                        //    //    Console.WriteLine("Down: " + mat[i, j]);
                        //    col -= 1;
                        //    Console.WriteLine("Left: " + mat[lin, col]);
                        //    col += 1;
                        //    lin -= 1;
                        //    Console.WriteLine("Up: " + mat[lin, col]);
                        //    col += 1;
                        //    if (col != n)
                        //    {
                        //        Console.WriteLine("Right: " + mat[lin, col]);
                        //    }
                        //    col -= 1;
                        //    lin += 2;
                        //    Console.WriteLine("Down: " + mat[lin, col]);
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
