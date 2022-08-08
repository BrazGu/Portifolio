using System;
using System.Globalization;

namespace DateTime1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //alguns construtores para iniciarmos a função:
            Console.WriteLine("\n===================\n");
            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 03, 05, 00, 33, 05);

            DateTime d3 = DateTime.Now;
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;//horário do GNT GreenWitch

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);

            Console.WriteLine("\n===================\n");
            DateTime dd1 = DateTime.Parse("2000-08-15");
            DateTime dd2 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime dd3 = DateTime.Parse("15/08/2000");
            DateTime dd4 = DateTime.Parse("15/08/2000 13:58:06");

            Console.WriteLine(dd1);
            Console.WriteLine(dd2);
            Console.WriteLine(dd3);
            Console.WriteLine(dd4);

            Console.WriteLine("\n===================\n");


            DateTime ddd1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime ddd2 = DateTime.ParseExact("15/08/2000 13:43:24", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(ddd1);
            Console.WriteLine(ddd2);

            Console.WriteLine("\n===================\n");
        }
    }
}
