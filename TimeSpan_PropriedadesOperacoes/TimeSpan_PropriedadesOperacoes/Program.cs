using System;

namespace TimeSpan_PropriedadesOperacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {//limites do TimeSpan:
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("\n====================\n");//diferenca entre Day e TotalDay
            TimeSpan teste = new TimeSpan(3, 4, 5);
            Console.WriteLine(teste);
            Console.WriteLine(teste.Days);//mostra a quantidade inteira de Day
            Console.WriteLine(teste.TotalDays);//mostra todo o tempo convertido para Day

            Console.WriteLine("\n====================\n");
            TimeSpan t10 = new TimeSpan(1, 30, 10);
            TimeSpan t20 = new TimeSpan(0, 10, 05);

            TimeSpan sum = t10.Add(t20);
            TimeSpan dif = t10.Subtract(t20);

            Console.WriteLine(sum);
            Console.WriteLine(dif);


            
            


        }
    }
}
