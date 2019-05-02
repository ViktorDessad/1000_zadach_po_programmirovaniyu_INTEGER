using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое двузначное число");
            int integer = Convert.ToInt32(Console.ReadLine());

            if (integer >= 10 && integer <= 99)
            {
                int secondNumber = integer % 10;
                int firstNumber = (integer - secondNumber) / 10;

                int sum = secondNumber + firstNumber;
                int mul = secondNumber * firstNumber;

                Console.WriteLine("Первая цифра числа {0}, равна {1}, а вторая {2}.",
                    integer, firstNumber, secondNumber);
                Console.WriteLine("Сумма {0} + {1} = {2}, произведение {0} * {1} = {3}",
                    secondNumber, firstNumber, sum, mul);
            }
            else
            {
                Console.WriteLine("Число должно быть больше или равно 10 и меньше 99");
            }
        }
    }
}
