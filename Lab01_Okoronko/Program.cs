using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_A_циклы
{
    class Program
    {
        static long Fact(long value)
        {
            return (value == 0) ? 1 : value * Fact(value - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите верхную границу суммы: ");
            int k = Int32.Parse(Console.ReadLine());
            Console.Write("Введите перменную х: ");
            int x = Int32.Parse(Console.ReadLine());
            double s = 0;
            for (int n = 0; n <= k; n++)
            {
                s += Math.Pow(-1, n) * Math.Pow(x, (2 * n + 1)) / (Fact(n) * (2 * n + 1));


            }
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}