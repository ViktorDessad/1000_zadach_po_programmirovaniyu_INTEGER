using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение длины в см");
            int centi = Convert.ToInt32(Console.ReadLine());

            double metr = centi / 100.0;
            Console.WriteLine("В {0} см будет {1} метров", centi, metr);
        }
    }
}
