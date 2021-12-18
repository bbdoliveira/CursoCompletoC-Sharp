using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Type a number: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Type a number: ");
                int n2 = int.Parse(Console.ReadLine());

                int div = n1 / n2;

                Console.Write("Result: " + div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is now allowed!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error! " + e.Message);
            }
        }
    }
}
