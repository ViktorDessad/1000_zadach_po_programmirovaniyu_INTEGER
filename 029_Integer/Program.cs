using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны A и В");
            int side_A = Convert.ToInt32(Console.ReadLine());
            int side_B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторон квадрата С");
            int side_C = Convert.ToInt32(Console.ReadLine());

            int figure_AB = side_A * side_B;
            double figure_C = Math.Pow(side_C, 2);

            double figureNumber = figure_AB / figure_C;
            double figureReminder = figure_AB % figure_C;

            Console.WriteLine("Количество кавадратов С на фигуре АВ {0:#}, площать остатка {1} см кв.",
                figureNumber, figureReminder);
        }
    }
}
