using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_task
{
    /// <summary>
    /// Задача 5. Определить статический метод int Meters (int k, int m), который принимает два целых аргумента (километры k, метры m)
    /// и возвращает количество метров. Используя этот метод, вычислить количество метров для расстояния:

    /// а) 3 км 40 м;
    /// б) 12 км 540 м.
    /// </summary>
    internal class Program
    {
        //а) 3 км 40 м;



        //static void Main(string[] args)
        //{
        //    int kilometers = 3;
        //    int meters = 40;

        //    Output(Meters(kilometers, meters));
        //    Console.ReadKey();
        //}
        //static void Output(int result)
        //{
        //    Console.WriteLine($"Расстояние = {result} м");
        //}
        //static int Meters(int km, int m)
        //{
        //    int totalMeters = km * 1000 + m;
        //    return totalMeters;
        //}








        //б) 12 км 540 м.




        static void Main(string[] args)
        {
            int kilometers = 12;
            int meters = 540;

            Output(Meters(kilometers, meters));
            Console.ReadKey();
        }
        static void Output(int result)
        {
            Console.WriteLine($"Расстояние = {result} м");
        }
        static int Meters(int km, int m)
        {
            int totalMeters = km * 1000 + m;
            return totalMeters;
        }






        //гибкая программа 



        //static void Main(string[] args)
        //{
        //    int kilometers = Input("Сколько км: ");
        //    int meters = Input("СКолько метров: ");

        //    Output(Meters(kilometers, meters));
        //    Console.ReadKey();
        //}
        //static int Input(string msg)
        //{
        //    Console.Write(msg);
        //    return int.Parse(Console.ReadLine());

        //}
        //static void Output(int result)
        //{
        //    Console.WriteLine($"Расстояние = {result} м");
        //}
        //static int Meters(int km, int m)
        //{
        //    int totalMeters = km * 1000 + m;
        //    return totalMeters;
        //}
    }
}
