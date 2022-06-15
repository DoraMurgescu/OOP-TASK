using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    static class Aggregate
    {
        public static void AuthorTotal(Author[] authors)
        {
            foreach (Author author in authors)
            {
                Console.WriteLine($"{author} \nTotal publications: {author.TotalArticles}");
            }
        }
        public static int ArticlesBetween(Article[] articles, DateTime startDate, DateTime endDate)
        {
            return Filter.ByDate(articles, startDate, endDate).Length;
        }
    }
}
