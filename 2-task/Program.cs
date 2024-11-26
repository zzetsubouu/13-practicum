using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_task
{
    /// <summary>
    /// Задача 2. Найти минимальную величину их трех целых переменных a, b, c 
    /// с использованием вспомогательных методов (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            Output(FindMinValue(FindMinValue(a, b), c));
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
