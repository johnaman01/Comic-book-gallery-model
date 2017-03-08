using ComicBookGalleryModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ComicBookGalleryModel_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                //I did it!!!
                var series = new Series()
                {
                    Title = "The Amazing SpiderMan"
                };

                context.ComicBooks.Add(new ComicBook()
                {
                    Series = series,
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today
                });

                context.ComicBooks.Add(new ComicBook()
                {
                    Series = series,
                    IssueNumber = 2,
                    PublishedOn = DateTime.Today
                });

                context.SaveChanges();

                var comicBooks = context.ComicBooks
                    .Include(cb => cb.Series)
                    .ToList();
                foreach (var comicBook in comicBooks)
                {
                    Console.WriteLine(comicBook.DisplayText);
                }
                Console.ReadLine();
            }
        }
    }
}
