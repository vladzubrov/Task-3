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
            Console.Write("Введите слово  ");
            string a = Console.ReadLine();
            string b="";
                        
            for (int i = a.Length; i>0; i--)
            {
                b = b + a[i-1]; 
            }
            Console.Write(b);
            Console.ReadLine();
        }
    }
}
