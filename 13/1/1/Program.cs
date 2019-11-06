using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string relo = null;
            int r = 0;
            int n = 0;

            Console.WriteLine("Введите радиус: ");
            do
            {
                relo = Console.ReadLine();
                if (int.TryParse(relo, out r))
                {
                    if (r > 0)
                    {
                        relo = null;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка!!!!");
                }

            } while (relo != null);

            Console.WriteLine("Введите количество углов: ");
            do
            {
                relo = Console.ReadLine();
                if (int.TryParse(relo, out n))
                {
                    if (n > 0)
                    {
                        relo = null;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка!!!!");
                }

            } while (relo != null);

            double pi = 3.14;
            double p = 0;

            p = 2 * r * n * Math.Atan(pi / n);

            Console.WriteLine("Периметр: {0}", p);

            Console.ReadKey();
           
        }
    }
}
