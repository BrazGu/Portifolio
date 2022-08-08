using System;

namespace CondicaoTernaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sim ou não: ");
            string frase = Console.ReadLine();

            string resposta = (frase == "sim") ? "Escolheu sim" : "Escolheu não";

            Console.WriteLine(resposta);

            Console.WriteLine("\n================================\n");

            Console.Write("Informe o preço: ");
            double preco = double.Parse(Console.ReadLine());

            double desconto = (preco < 20.0) ? desconto = preco * 0.1 : preco * 0.05;

            Console.WriteLine("Desconto: " + desconto + "\n");
        }
    }
}
