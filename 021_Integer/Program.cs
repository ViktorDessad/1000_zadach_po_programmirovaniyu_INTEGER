using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество секунд");
            int seconds = Convert.ToInt32(Console.ReadLine());

            seconds = seconds % 60;
            Console.WriteLine("С начала последней минуты прошло {0} секунд", seconds);
        }

            
    }
}
