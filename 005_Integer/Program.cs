using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину отрезка A в см");
            int integer_A = Convert.ToInt32(Console.ReadLine());

            if (integer_A > 0)
            {
                Console.WriteLine("Введите введите длину отрезка B в см");
                int integer_B = Convert.ToInt32(Console.ReadLine());

                if (integer_B > 0 && integer_A > integer_B)
                {
                    int lineSum = integer_A / integer_B;
                    int reminder = integer_A % integer_B;
                    Console.WriteLine("На отрезке А размещено {0} целых отрезка В длиной {1} см, " +
                        "а остаток равен {2} см ", lineSum, integer_B, reminder);
                }
                else
                {
                    Console.WriteLine("Должны выполнятся условия В > 0 и А > B ");
                }
            }
            else
            {
                Console.WriteLine("Должно выполнятся условие А > 0");
            }
        }
    }
}
