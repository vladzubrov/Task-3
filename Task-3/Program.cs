using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            string[,] a = new string[5, 2];
            int i = 0;
            int j = 0;
            a[i, j++] = "Том";
            a[i++, j--] = "1-2-3/123@ya.ru";

            a[i, j++] = "Джим";
            a[i++, j--] = "4-5-6/456@ya.ru";

            a[i, j++] = "Сэм";
            a[i++, j--] = "7-8-9/789@ya.ru";

            a[i, j++] = "Боб";
            a[i++, j--] = "11-22/1122@ya.ru";

            a[i, j++] = "Джоб";
            a[i, j] = "33-44/3344@ya.ru";

            Console.WriteLine("Введите имя");
            string Name = Console.ReadLine();
            for (int g=0; g< a.GetLength(0); g++) { if (Name == a[g, 0]) { Console.WriteLine($"{a[g, 1]}"); } }
            Console.ReadLine();


        }
    }
}
