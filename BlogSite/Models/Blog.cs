using System;

namespace BlogSite.Models
{
    public class Blog
    {
        public string title;
        public DateTime datePublished = new DateTime();
        public string body;
        public Blog(string title, string body)
        {
            this.title = title;
            this.datePublished = DateTime.Now;
            this.body = body;
        }
    }
}