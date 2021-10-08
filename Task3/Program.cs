using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {// Домажнее задание к лабараторной №4 Задача №3
            //Инициализация переменных
            Console.WriteLine("Введите положительное число А");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите положительное число B");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите положительное число C");
            double c = Convert.ToDouble(Console.ReadLine());
            //Решение
            int na = 0;
            while (a >= c)
            {
                a = a -= c;
                na++;
            }

            int nb = 0;
            while (b >= c)
            {
                b = b -= c;
                nb++;
            }

            int sum = na;
            while ((nb - 1) > 0)
            {
                sum = sum += na;
                nb--;
            }
            Console.WriteLine("Количество целых квадратов со стороной С, размещенных в прямоугольнике размером АхВ ={0}", sum);

            Console.ReadKey();
        }
    }
}
