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
            int i ;
            int j ;
            int[,] a = new int[5, 5];
            int f = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    a[i, j] = f;
                    f = f + 1;
                    System.Console.Write(String.Format("{0:00} ", a[i, j]));
                    
                };
             System.Console.WriteLine();
            };
            System.Console.WriteLine();
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (i == j)
                    { System.Console.Write(String.Format("{0:00} ", a[i, j])); }
                    else
                    { System.Console.Write(String.Format("{0:00} ", 0)); }

                };
                System.Console.WriteLine();
            };
            Console.ReadLine();
        }
    }
}
