using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main()
        {
            List<object> t = new List<object>(); 
            string exp = null;
            byte b = 0;
            int i = 0;
            double d = 0;
            char c;

            Console.WriteLine("Добавление элементов. Чтобы закончить введите exit.");
            Console.WriteLine("Чтобы ввести double вводите через ','.");
            do
            {
                exp = Console.ReadLine();
                if(exp.Trim() == "exit")
                {
                    Console.WriteLine("Конец.");
                    exp = null;
                }
                else if (byte.TryParse(exp, out b))
                    t.Add(b);
                else if (int.TryParse(exp, out i))
                    t.Add(i);
                else if (double.TryParse(exp, out d))
                    t.Add(d);
                else if (char.TryParse(exp, out c))
                    t.Add(c);
                else
                    t.Add(exp);
            } while (exp != null);

            int[] ar = new int[5];
            foreach(object random in t)
            {
                if (random.GetType() == typeof(byte))
                    ar[0]++;
                else if (random.GetType() == typeof(int))
                    ar[1]++;
                else if (random.GetType() == typeof(double))
                    ar[2]++;
                else if (random.GetType() == typeof(char))
                    ar[3]++;
                else
                    ar[4]++;
            }
            Console.WriteLine("Количество типов byte, int, double, char, string:");
            Console.WriteLine("С типом byte: {0}", ar[0]);
            Console.WriteLine("С типом int: {0}", ar[1]);
            Console.WriteLine("С типом double: {0}", ar[2]);
            Console.WriteLine("С типом char: {0}", ar[3]);
            Console.WriteLine("С типом string: {0}", ar[4]);

            Console.ReadKey();
        }
    }
}
