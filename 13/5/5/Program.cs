using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main()
        {
            string exp = null;
            int m = 0;

            Console.WriteLine("Введите количество рядков:");
            do
            {
                exp = Console.ReadLine();
                if (int.TryParse(exp, out m) && m > 0)
                {
                    exp = null;
                }
                else
                {
                    Console.WriteLine("Ошибка!!!");
                }
            } while (exp != null);

            double[,] a = new double[m, m];

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine("Введите a[{0}][{1}]:",i,j);
                    do
                    {
                        exp = Console.ReadLine();
                        if (double.TryParse(exp, out a[i,j]))
                        {
                            exp = null;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка!!!");
                        }
                    } while (exp != null);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", a[i,j]);
                }
                Console.WriteLine();
            }

            double sum = 0;

            for (int i = 0; i < m; i++)
            {
                    sum += a[i, i];
            }

            Console.WriteLine("Сумма главной диагонали: {0}", sum);
            sum = 0;

            for (int i = m-1; i >= 0; i--)
            {
                sum += a[m - 1 - i, i];
            }
            Console.WriteLine("Сумма побочной диагонали: {0}", sum);

            Console.ReadKey();
        }
    }
}
