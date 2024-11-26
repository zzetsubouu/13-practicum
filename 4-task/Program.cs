using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_task
{
    /// <summary>
    /// Задача 4. Определить статический метод int Seconds (int h, int m, int s), который принимает три целых аргумента 
    /// (часы h, минуты m и секунды s) и возвращает количество секунд,
    /// прошедших с начала дня. Используя этот метод, вычислить количество секунд, прошедших с начала дня при:

    /// а) 0 ч 40 мин 20 с;
    /// б) 3 ч 10 мин 50 с;
    ///
    /// </summary>
    internal class Program
    {
        //а) 0 ч 40 мин 20 с



        //static void Main(string[] args)
        //{
        //    int hours = 0;
        //    int mins = 40;
        //    int seconds = 20;

        //    Output(Seconds(hours, mins, seconds));
        //    Console.ReadKey();
        //}
        //static void Output(int result)
        //{
        //    Console.WriteLine($"Секунд с начала дня = {result}с");
        //}
        //static int Seconds(int hours, int mins, int seconds)
        //{
        //    int totalSeconds = hours * 3600 + mins * 60 + seconds;
        //    return totalSeconds;
        //}






        //б) 3 ч 10 мин 50 с.


        static void Main(string[] args)
        {
            int hours = 3;
            int mins = 10;
            int seconds = 50;

            Output(Seconds(hours, mins, seconds));
            Console.ReadKey();
        }
        static void Output(int result)
        {
            Console.WriteLine($"Секунд с начала дня = {result}с");
        }
        static int Seconds(int hours, int mins, int seconds)
        {
            int totalSeconds = hours * 3600 + mins * 60 + seconds;
            return totalSeconds;
        }







        //гибкая программа



        //static void Main(string[] args)
        //{
        //    int hours = Input("Сколько часов: ");
        //    int mins = Input("СКолько минут: ");
        //    int seconds = Input("Сколько секунд: ");

        //    Output(Seconds(hours, mins, seconds));
        //    Console.ReadKey();
        //}
        //static int Input(string msg)
        //{
        //    return int.Parse(Console.ReadLine());

        //}
        //static void Output(int result)
        //{
        //    Console.WriteLine($"Секунд с начала дня = {result}с");
        //}
        //static int Seconds(int hours, int mins, int seconds)
        //{
        //    int totalSeconds = hours * 3600 + mins * 60 + seconds;
        //    return totalSeconds;
        //}
    }
}
