using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main()
        {
            string relo = null;
            int a = 0;

            Console.WriteLine("Введите число:");
            do
            {
                relo = Console.ReadLine();
                if (int.TryParse(relo, out a))
                {
                    if(a > 99 && a < 1000)
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

            int[] num = new int[3];
            for(int i = 2; i >= 0; i--)
            {
                num[i] = a % 10;
                a /= 10;
            }
            
            if(num[0] < num[1] && num[1] < num[2])
            {
                Console.WriteLine("Истина");
            }
            else
            {
                Console.WriteLine("Ложь");
            }

            Console.ReadKey();
        }
    }
}
