using System;

namespace FuncoesDaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcd EFGHIJ ABC abc DEFG ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim(); //apaga os espaços antes e depois do string

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            

            Console.WriteLine("- Original: " + original +  "-");

            Console.WriteLine("- ToUpper: " + s1 + "-");

            Console.WriteLine("- ToLower: " + s2 + "-");
            
            Console.WriteLine("- Trim: " + s3 + "-");

            Console.WriteLine("- IndexOf('bc'): " + n1);
            
            Console.WriteLine("- LastIndexOf('bc'): " + n2);
            
            Console.WriteLine("- Substring(3): " + s4);

            Console.WriteLine("- Substring(3,5): " + s5);

            Console.WriteLine("- Replace('a', 'x '): " + s6);

            Console.WriteLine("- IsNullOrEmpty: " + b1);

            Console.WriteLine("- IsNullOrWhiteSpace: " + b2);


            




            
        }
    }
}
