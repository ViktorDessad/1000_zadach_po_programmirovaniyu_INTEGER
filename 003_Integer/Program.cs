using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение размер файла в байтах");
            int inByte = Convert.ToInt32(Console.ReadLine());

            double inKiloByte = inByte / 1024.0;
            Console.WriteLine("В {0} байтах будет {1:#.##} килобайтов", inByte, inKiloByte);
        }
    }
}
