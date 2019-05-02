using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество секунд");
            int seconds = Convert.ToInt32(Console.ReadLine());
            int minutes = seconds / 60;
            int minutesReminder = minutes % 60;
            Console.WriteLine("С начала последнего часа прошло {0} минут", minutesReminder);
        }
    }
}
