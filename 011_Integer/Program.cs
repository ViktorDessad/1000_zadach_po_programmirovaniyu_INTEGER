using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Integer
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

                int sum = firsNumber + secondNumber + thirdNumber;
                int mul = firsNumber * secondNumber * thirdNumber;
                Console.WriteLine("Сумма = {0}, а произведение {1}", sum, mul);
            }
            else
            {
                Console.WriteLine("Вы ввели неверное число");
            }
     
        }
    }
}
