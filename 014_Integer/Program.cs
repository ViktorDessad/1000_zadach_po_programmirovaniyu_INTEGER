using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int primaryValue = Convert.ToInt32(Console.ReadLine());

            if (primaryValue >= 100 && primaryValue < 999)
            {
                // Разбиваем число 345 на простые цифры 
                int firstReminder = primaryValue % 10;                                          // 5
                int secondReminder = (primaryValue % 100 - firstReminder) / 10;                 // 4
                int thirdReminder = (primaryValue - firstReminder - secondReminder * 10) / 100; // 3          

                int firstNumber = secondReminder;                                               // 4
                int secondNumber = firstReminder * 100;                                         // 500
                int thirdNumber = thirdReminder * 10;                                           // 30

                int sum = firstNumber + secondNumber + thirdNumber;

                Console.WriteLine("Новое число = {0}", sum);
            }
            else
            {
                Console.WriteLine("Вы ввели неправильное число");
            }

        }
    }
}
