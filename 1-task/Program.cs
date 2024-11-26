using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_task
{
    /// <summary>
    /// Задача 1. Найти минимальную величину из двух целых переменных a, b,
    /// используя вспомогательные методы (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary> 
    internal class Program
    {

        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");

            Output(FindMinValue(a, b));
            Console.ReadKey();
        }
        static int Input(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());

        }
        static void Output(int result)
        {
            Console.WriteLine($"Min = {result}");
        }
        static int FindMinValue(int v1, int v2)
        {
            return v1 < v2 ? v1 : v2;
        }

    }
}
