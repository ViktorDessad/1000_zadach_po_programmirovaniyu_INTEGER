using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Integer
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

                int newFirstNumber = secondNumber * 10;
                int newValue = newFirstNumber + firstNumber;
                Console.WriteLine("Старое целое число {0} и новое число после перестановки цифр {1}", 
                    integer, newValue);
            }
            else
            {
                Console.WriteLine("Число должно быть больше или равно 10 и меньше 99");
            }
        }
    }
}
                

               
