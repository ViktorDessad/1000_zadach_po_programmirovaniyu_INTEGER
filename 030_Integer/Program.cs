using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер года 1001-9899");
            int yearNumber = Convert.ToInt32(Console.ReadLine());

            int centuryNumber = (yearNumber / 100) + 1;
            Console.WriteLine("На дворе сейчас {0} год или {1} столетие", yearNumber, centuryNumber);

        }
    }
}
