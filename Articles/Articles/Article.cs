using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    class Article
    {
        public Article(string title, Author[] author, DateTime publication)
        {
            Title = title;
            Author = author;
            Publication = publication;
            LastUpdate = publication;
            Likes = 3;
            Dislikes = 0;

            foreach (Author aut in Author)
                aut.TotalArticles++;
        }
        public string Title { get; set; }
        public DateTime Publication { get; private set; }
        public DateTime LastUpdate { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public Author[] Author { get; set; }
        public string Authors
        {
            get
            {
                string toReturn = "";
                foreach (Author person in Author)
                    toReturn += $"{person.FullName}; ";
                return toReturn;
            }
        }
        public override string ToString()
        {
            string article = $"\"{Title}\" by {Authors}";
            article += "\n";
            article += $"Publication date: {Publication.Date}";
            article += "\n";
            article += $"Last time modified: {LastUpdate.Date}";
            article += "\n";
            article += $"Likes: {Likes}   Dislikes: {Dislikes}";
            article += "\n";
            return article;
        }

    }
}
