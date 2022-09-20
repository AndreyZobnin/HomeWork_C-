using System;
using System.Collections.Generic;
using System.Text;

namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.Write("Введите количество строк: ");
            int n = Convert.ToInt32(System.Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                int k = 1;
                for (int space = 0; space < n - j; space++) System.Console.Write("  ");

                for (int i = 0; i <= j; i++)
                {
                    System.Console.Write("   {0:D} ", k);
                    k = k * (j - i) / (i + 1);
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
        }

    }

}