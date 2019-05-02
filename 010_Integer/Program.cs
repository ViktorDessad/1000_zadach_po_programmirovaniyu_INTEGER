using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести трехзначное число");
            int primaryValue = Convert.ToInt32(Console.ReadLine());

            if (primaryValue >= 100 && primaryValue <= 999)
            {
                int firstReminder = primaryValue % 10;
                int secondReminder = primaryValue % 100;

                int secondNumber = (secondReminder - firstReminder) / 10;
                
                Console.WriteLine("Вторая цифра числа {0} равна {2}, а третья {1}", 
                    primaryValue, firstReminder, secondNumber);
            }
            else
            {
                Console.WriteLine("Вы ввели неверное число");
            }

        }
    }
}
