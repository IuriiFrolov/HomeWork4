using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Homework3
{
    class Program
    {// Домажнее задание к лабараторной №4 Задача №1
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N > 0 ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Квадраты всех цеых чисел от 1 до {0}:", n);
            for (int i = 1, j=1, sq=(2*j-1); (i <= (2*n-1))&&(j<=n); i+=2,j++)
            {
                sq = sq + (j+j-1);

                Console.WriteLine("{0}", (sq+i+1) );
            }
            Console.ReadKey();
            
            
            /* int n= 9;

             for (int i = 1, j = 1 ; (i < (2n-1)) && (j<=n); i+=2, j++);
             {

             }*/
        }
    }
}
