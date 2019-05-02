using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ввести трехзначное число");
            int primaryValue = Convert.ToInt32(Console.ReadLine());

            if (primaryValue >= 100 && primaryValue <= 999)
            {
                int reminder = primaryValue % 100;
                int firstNumber = (primaryValue - reminder) / 100;
                Console.WriteLine("Первая цифра числа {0} равна {1}",primaryValue, firstNumber);
                   
            }
            else
            {
                Console.WriteLine("Вы ввели неверное число");
            }
            
        }
    }
}
