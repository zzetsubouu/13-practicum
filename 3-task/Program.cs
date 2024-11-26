using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_task
{
    /// <summary>
    /// Задача 3. Найти s=min(a, b) + min(c, d), 
    /// используя вспомогательные функции (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            int d = Input("d=");

            Output(FindMinValue(a, b) + FindMinValue(c, d));
            Console.ReadKey();
        }
        static int Input(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());

        }
        static void Output(int result)
        {
            Console.WriteLine($"SumOfMin = {result}");
        }
        static int FindMinValue(int v1, int v2)
        {
            return v1 < v2 ? v1 : v2;
        }
    }
}
