using System;
using System.Text;
using System.Collections.Generic;

namespace Resolvido2_StringBuilder.Entities
{
    internal class Post
    {
        //===================ATRIBUTOS===============================
        public DateTime Date { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        //==========================================================




        //===========CONSTRUTORES===================================
        public Post ()
        {//Construtor padrão
        }
        public Post(DateTime date, string tittle, string content, int likes)
        {//Construtor com atributos
            Date = date;
            Tittle = tittle;
            Content = content;
            Likes = likes;
        }
        //==========================================================




        //============MÉTODOS=======================================
        public void AddComments(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComments(Comment comment)
        {
            Comments.Remove(comment);
        }
        //==========================================================




        //==================STRING BUILDER==========================
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Tittle);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
        //==========================================================
    }
}
