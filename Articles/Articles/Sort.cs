using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    static class Sort
    {
        public static void ByPublication(Article[] articles)
        {
            //Array.Sort(article, PublicationSortHelper);
            Array.Sort(articles, (x, y) => x.Publication.CompareTo(y.Publication));
        }
        private static int LikesSortHelper(Article firstArticle, Article secondArticle)
        {
            if (firstArticle.Likes > secondArticle.Likes)
                return 1;
            if (firstArticle.Likes < secondArticle.Likes)
                return -1;
            else
                return 0;
        }
        public static void ByLikes(Article[] articles)
        {
            //Array.Sort(article, LikesSortHelper);
            Array.Sort(articles, (x, y) => x.Likes - y.Likes);

        }
        private static int DislikesSortHelper(Article firstArticle, Article secondArticle)
        {
            if (firstArticle.Dislikes > secondArticle.Likes)
                return 1;
            if (firstArticle.Dislikes < secondArticle.Dislikes)
                return -1;
            else
                return 0;
        }
        public static void ByDislikes(Article[] article)
        {
            Array.Sort(article, (x, y) => x.Dislikes - y.Dislikes);
        }

        private static int RatioSortHelper(Article firstArticle, Article secondArticle)
        {
            int firstRatio = firstArticle.Likes - firstArticle.Dislikes;
            int secondRatio = secondArticle.Likes - secondArticle.Dislikes;

            if (firstRatio > secondRatio)
                return 1;
            if (firstRatio < secondRatio)
                return -1;
            else
                return 0;
        }
        public static void ByRatio(Article[] article)
        {
            Array.Sort(article, RatioSortHelper);
        }
        private static int TotalArticlesSortHelper(Author firstAuthor, Author secondAuthor)
        {
            if (firstAuthor.TotalArticles > secondAuthor.TotalArticles)
                return -1;
            if (firstAuthor.TotalArticles < secondAuthor.TotalArticles)
                return 1;
            else
                return 0;
        }
        public static void ByTotalArticles(Author[] authors)
        {
            Array.Sort(authors, TotalArticlesSortHelper);
        }
    }
}
