using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3While2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do из лекции
            double sum = 1000;
            double sum2 = sum * 2;
            double p = 4;
            int yars = 18;
            while (yars <= 0)
            {
                sum += sum * 4 / 100;
                yars--;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
