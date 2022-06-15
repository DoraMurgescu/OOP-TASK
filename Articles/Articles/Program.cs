using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("Marin", "Sorescu", new DateTime(1977, 6, 10));
            Author a2 = new Author("Mihai", "Eminescu", new DateTime(1977, 6, 10));
            Author a3 = new Author { FirstName = "Adrian", LastName = "Ghilea", BirthDay = new DateTime(1950, 2, 3) };
            Author[] authors = { a1, a2 };
            Author[] auts = { a1 };
            Article art1 = new Article("How to learn OOP", authors, new DateTime(2000, 6, 9));
            Article art2 = new Article("How to learn POO", authors, new DateTime(2001, 5, 9));
            Article art3 = new Article("How to learn OOP", auts, new DateTime(2000, 7, 9));

            Article[] arts = { art1, art2, art3 };
            //arts = Filter.ByAuthor(arts, Bobby);

            //Sort.ByTotalArticles(authors);
            Sort.ByLikes(arts);

            foreach (Article article in arts)
                Console.WriteLine(article);

            // foreach(Author x in authors)
            //  Console.WriteLine(x);

            Aggregate.AuthorTotal(authors);
        }
    }
}
