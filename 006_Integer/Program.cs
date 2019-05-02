using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое двузначное число");
            int integer = Convert.ToInt32(Console.ReadLine());

            if (integer >= 10 && integer <= 99)
            {
                int firstNumber = integer % 10;
                int secondNumber = (integer - firstNumber) / 10;
                Console.WriteLine("Первая цифра числа {0}, равна {1}, а вторая {2}.", 
                    integer, secondNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("Число должно быть больше или равно 10 и меньше 99");
            }
        }
    }
}
