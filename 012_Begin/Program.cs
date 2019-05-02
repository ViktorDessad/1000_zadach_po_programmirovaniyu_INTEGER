using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести трехзначное число");
            int primaryValue = Convert.ToInt32(Console.ReadLine());

            if (primaryValue >= 100 && primaryValue <= 999)
            {
                                                                         // 345
                int reminder = primaryValue % 100;                       // 345 % 100 = 45
                int firsNumber = primaryValue % 10;                      // 345 % 10 = 5  
                int secondNumber = (reminder - firsNumber) / 10;         // (45 - 5)/10 = 4 
                int thirdNumber = (primaryValue - reminder) / 100;       // (345 - 45)/100 = 3

                firsNumber *= 100;                                       // 500
                secondNumber *= 10;                                      // 40
                thirdNumber *= 1;                                        // 3

                int newValue = firsNumber + secondNumber + thirdNumber;
                Console.WriteLine("Старое число {0} новое число справа на лево {1}", primaryValue, newValue);
            }
            else
            {
                Console.WriteLine("Вы ввели неверное число");
            }
        }
    }
}
