using System;

namespace RecursiveFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(n));
        }
        static long Factoriel(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            long currNum = n * Factoriel(n - 1);
            return currNum;
        }
    }
}
