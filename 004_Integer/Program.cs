using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число A");
            int integer_A = Convert.ToInt32(Console.ReadLine());

            if (integer_A > 0)
            {
                Console.WriteLine("Введите целое положительное число B");
                int integer_B = Convert.ToInt32(Console.ReadLine());

                if (integer_B > 0 && integer_A > integer_B)
                {
                    int lineSum = integer_A / integer_B;
                    Console.WriteLine("На отрезке А размещено {0} целых отрезков В ", lineSum);
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
