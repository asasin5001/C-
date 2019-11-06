using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main()
        {
            string relo = null;
            int nn = 0;
            int nk = 0;

            Console.WriteLine("Введите nn: ");
            do
            {
                relo = Console.ReadLine();

                if(int.TryParse(relo, out nn))
                {
                    if(nn >= 0)
                    {
                        relo = null;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка!!!");
                }
            } while (relo != null);

            Console.WriteLine("Введите nk: ");
            do
            {
                relo = Console.ReadLine();

                if (int.TryParse(relo, out nk))
                {
                    if (nk >= nn)
                    {
                        relo = null;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка!!!");
                }
            } while (relo != null);

            double p = 1;
            for(int k = nn; k < nk; k++)
            {
                p = p * ((Math.Pow(-1, k) * Math.Pow(k, 2) + Math.Pow(-1, Math.Pow(k, 2) + 1) * k) / (2 * Math.Pow(k, 3) + 3));
            }

            Console.WriteLine("P(a): {0}", p);

            Console.ReadKey();
        }
    }
}
