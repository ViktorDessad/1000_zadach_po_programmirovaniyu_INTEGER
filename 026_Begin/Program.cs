using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня этого года от 1 до 365");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            dayNumber = (dayNumber %= 7) + 1;
            Console.WriteLine("Номер дня недели {0}", dayNumber);
        }
    }
}
