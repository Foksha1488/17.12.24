using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зад_3_17_12
{
    internal class Program
    {/// <summary>
     /// Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите целое число n ");
            int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            Console.Read();
        }
    }
}
    
