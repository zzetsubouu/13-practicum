using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_task
{
    /// <summary>
    /// Определить статический метод double Average (int m, int n), который вычисляет и возвращает
    /// среднее арифметическое всех целых от m до n включительно. 
    /// Используя этот метод, вычислить среднее арифметическое всех чисел:

    /// а) от 1 до 10;

    /// б) от 20 до 40;

    /// в) от a до b(a, b вводятся с клавиатуры).
    /// </summary>
    internal class Program
    {
        //а) от 1 до 10;

        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"Среднее арифметическое чисел от 1 до 10 = {Average(1,10)}");
        //    Console.ReadKey();
        //}
        //static int Input(string msg)
        //{
        //    Console.Write(msg);
        //    return int.Parse(Console.ReadLine());

        //}
        //static double Average(int n, int m)
        //{
        //    double average = 0;
        //    for (int i = n; i <= m; i++)
        //    {
        //        average += i;
        //    }
        //    return average / 2;
        //}







        //б) от 20 до 40;



        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"Среднее арифметическое чисел от 20 до 40 = {Average()}");
        //    Console.ReadKey();
        //}
        //static int Input(string msg)
        //{
        //    Console.Write(msg);
        //    return int.Parse(Console.ReadLine());

        //}
        //static double Average()
        //{
        //    double average = 0;
        //    for (int i = 20; i <= 40; i++)
        //    {
        //        average += i;
        //    }
        //    return average / 2;
        //}






        //в) от a до b(a, b вводятся с клавиатуры).



        static void Main(string[] args)
        {
            int a = Input("Введите число от которого считаем среднее арифм.=");
            int b = Input("Введите второе число=");
            Console.WriteLine($"Среднее арифметическое этих чисел = {Average(a, b)}");
            Console.ReadKey();
        }
        static int Input(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());

        }
        static double Average(int n, int m)
        {
            double average = 0;
            for (int i = n; i <= m; i++)
            {
                average += i;
            }
            return average / 2;
        }

    }
}
