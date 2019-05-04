using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня этого года от 1-365");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число от 1-7");
            int number = Convert.ToInt32(Console.ReadLine());


            dayNumber = ((dayNumber + number - 2) % 7) + 1;
            Console.WriteLine(dayNumber);

        }
    }
}
