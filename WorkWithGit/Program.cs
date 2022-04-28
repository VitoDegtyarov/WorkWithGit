using System;

namespace WorkWithGit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DateTime time = DateTime.ParseExact("04|2016|05", "MM|yyyy|dd", null);

            DateTime time = DateTime.ParseExact(Console.ReadLine(), "dd,mm,yyyy", null);
            Console.WriteLine($"The input day: {time.ToShortDateString()}");

            if (time.DayOfWeek == DayOfWeek.Sunday && time.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Its weekend!");
            }else
                Console.WriteLine("Work mthf");

            //if (DateTime.Now < time)
            //{
            //    Console.WriteLine("YEEEP");
            //}
            //TImeSpan??? ( bolshe pro vremya)
            //var test = DateTime.Now - time;
        }
    }
}
