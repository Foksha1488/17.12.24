using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_12
{
    internal class Program
    {/// <summary>
     /// Вывести в столбик 5 раз слово «Привет!» (циклы с условием)
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Привет!");
            }
            Console.ReadKey();
        }  

    }
    
}
