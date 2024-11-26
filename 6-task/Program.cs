using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_task
{
    /// <summary>
    /// Задача 6. Определить статический метод void Numbers (int n), который выводит на экран четные числа от 2 до числа n. Используя этот метод, вывести на экран четные числа:
    ///
    ///а) от 2 до 20;
    ///
    ///б) от 2 до 50;
    ///
    ///в) от 2 до m(m вводится с клавиатуры).
    ///
    /// </summary>
    internal class Program
    {
        //а) от 2 до 20;

        //static void Main(string[] args)
        //{
        //    Numbers(20);
        //    Console.ReadKey();
        //}
        //static void Numbers(int n)
        //{
        //    for (int i = 2; i <= n; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}








        //б) от 2 до 50;



        //static void Main(string[] args)
        //{
        //    Numbers(50);
        //    Console.ReadKey();
        //}
        //static void Numbers(int n)
        //{
        //    for (int i = 2; i <= n; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}





        //в) от 2 до m(m вводится с клавиатуры).



        static void Main(string[] args)
        {
            int m = Input("m=");
            Numbers(m);
            Console.ReadKey();
        }
        static int Input(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());

        }
        static void Numbers(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
