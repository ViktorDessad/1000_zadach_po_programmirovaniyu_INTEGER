using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение массы в кг");
            int kilo = Convert.ToInt32(Console.ReadLine());

            double tonna = kilo / 1000.0;
            Console.WriteLine("В {0} кг будет {1} тонн", kilo, tonna);
        }
    }
}
