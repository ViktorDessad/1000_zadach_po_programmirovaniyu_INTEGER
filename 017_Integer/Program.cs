using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число больше 999");
            int value = Convert.ToInt32(Console.ReadLine());

            if (value > 999)
            {
                value = (value % 1000) / 100;
                Console.WriteLine("Это число {0}", value);
            }
            else
            {
                Console.WriteLine("Вы ввели число меньше 1000");
            }
        }
    }
}
