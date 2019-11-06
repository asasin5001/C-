using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main()
        {
            string exp = null;
            int n = 0;

            Console.WriteLine("Введите размер массива:");
            do
            {
                exp = Console.ReadLine();
                if (int.TryParse(exp, out n) && n > 0)
                {   
                    exp = null;
                }
                else
                {
                    Console.WriteLine("Ошибка!!!");
                }

            } while (exp != null);

            double[] a = new double [n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите a[{0}]", i);
                do
                {
                    exp = Console.ReadLine();
                    if (double.TryParse(exp, out a[i]))
                    {
                        exp = null;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!!!");
                    }

                } while (exp != null);
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();

            int num = 0;
            if(a[0] < a[1])
            {
                num++;
            }
            if (a[n-1] < a[n-2])
            {
                num++;
            }

            for (int i = 1; i < n - 1; i++)
            {
                if (a[i - 1] > a[i] && a[i] < a[i + 1])
                {
                    num++;
                }
            }

            if (num > 0)
            {
                Console.WriteLine("В массиве {0} локальних мин.", num);
            }
            else
            {
                Console.WriteLine("Таких нет.(л.мин.)");
            }

            num = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (a[i - 1] < a[i] && a[i] > a[i + 1])
                {
                    num++;
                }
            }

            if (num > 0)
            {
                Console.WriteLine("В массиве {0} локальних макс.", num);
            }
            else
            {
                Console.WriteLine("Таких нет.(л.макс.)");
            }


            Console.ReadKey();
        }
    }
}
