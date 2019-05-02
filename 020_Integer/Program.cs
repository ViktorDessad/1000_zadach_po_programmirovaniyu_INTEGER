using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество секунд");
            int seconds = Convert.ToInt32(Console.ReadLine());

            double minutes = seconds / 3600.0;
            Console.WriteLine("В {0} секундах {1} часов", seconds, minutes);
        }
    }
}
