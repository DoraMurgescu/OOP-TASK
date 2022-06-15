using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    static class Filter
    {
        public static Article[] ByAuthor(Article[] articles, Author author)
        {
            return Array.FindAll(articles, article => article.Author.Contains(author));
        }
        public static Article[] ByDate(Article[] articles, DateTime startDate, DateTime endDate)
        {
            return Array.FindAll(articles, article => article.Publication.CompareTo(startDate) >= 0 && article.Publication.CompareTo(endDate) <= 0);
        }
        public static Article[] Weekend(Article[] articles)
        {
            return Array.FindAll(articles, article => article.Publication.DayOfWeek == DayOfWeek.Saturday && article.Publication.DayOfWeek == DayOfWeek.Sunday);
        }
        public static Article[] Positive(Article[] articles)
        {
            return Array.FindAll(articles, article => article.Likes >= article.Dislikes);
        }
        public static Article[] Negative(Article[] articles)
        {
            return Array.FindAll(articles, article => article.Likes <= article.Dislikes);
        }
    }
}
