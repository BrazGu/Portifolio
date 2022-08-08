using System;
using Resolvido2_StringBuilder.Entities;

namespace Resolvido2_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //==============FIRST POST==================================
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travelling to the New Zealand",
                "I'm going to visit this wonderfulcountry!",
                12
                );
            p1.AddComments(c1);
            p1.AddComments(c2);
            //==========================================================




            //===============SECOND POST================================
            Comment c3 = new Comment("Good Night!");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );
            p2.AddComments(c3);
            p2.AddComments(c4);
            //==========================================================




            //================USER SCREEN===============================
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            //==========================================================
        }
    }
}
