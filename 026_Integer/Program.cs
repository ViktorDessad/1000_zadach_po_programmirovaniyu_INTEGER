using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня этого года от 1 до 365");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            if (dayNumber >= 1 && dayNumber <=365)
            {
                dayNumber %= 7;
                switch (dayNumber)
                {
                    case 0:
                        Console.WriteLine("0-Воскресенье");
                        break;
                    case 1:
                        Console.WriteLine("1-Понедельник");
                        break;
                    case 2:
                        Console.WriteLine("2-Вторник");
                        break;
                    case 3:
                        Console.WriteLine("3-Среда");
                        break;
                    case 4:
                        Console.WriteLine("4-Четверг");
                        break;
                    case 5:
                        Console.WriteLine("5-Пятница");
                        break;
                    case 6:
                        Console.WriteLine("6-Суббота");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не верный номер для этого года");
            }

                   
            

        }
    }
}
