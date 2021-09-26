using System;
using System.Collections.Generic;
using System.Text;
using Exercicio2.Entities;

namespace Exercicio2.Entities
{
    class Post
    {
        public DateTime Momment { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime momment, string tittle, string content, int likes)
        {
            Momment = momment;
            Tittle = tittle;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Tittle);
            sb.Append(Likes);
            sb.Append("Likes - ");
            sb.AppendLine(Momment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
