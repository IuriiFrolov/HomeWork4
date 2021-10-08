using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3While
{
    class Program
    {
        static void Main(string[] args)
        {// Домажнее задание к лабараторной №4 Задача №2
            int positive = 0;
            int negative = 0;
            Console.WriteLine("Введите последовотельность целых чисел, окончанием последовательности служит число 0");
            do
            {
                int x1 = Convert.ToInt32(Console.ReadLine());
                if (x1 == 0)
                { break; }
                else if (x1 > 0)
                { positive++; }
                else
                { negative++; }
            } while (true);
            if (positive > negative)
            {
                Console.WriteLine("Положительных ( {0} шт.) больше, чем отрицательных ( {1} шт.)", positive, negative);
            }
            else if (positive < negative)
            {
                Console.WriteLine("Положительных ( {0} шт.) меньше, чем отрицательных ( {1} шт.)", positive, negative);
            }
            else
            {
                Console.WriteLine(" Количество положительных ( {0} шт.) равно количеству отрицательных ( {1} шт.)", positive, negative);
            }
                     Console.ReadKey();
        }
    }
}
