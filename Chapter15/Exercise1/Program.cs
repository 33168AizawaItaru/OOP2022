using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2()
        {
            var books = Library.Books.Where(b=>b.Price == Library.Books.Max(x=>x.Price));

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_3()
        {
            var books = Library.Books.GroupBy(b=>b.PublishedYear).OrderBy(b=>b.Key);
            foreach (var g in books)
            {
                Console.WriteLine($"{g.Key}年 {g.Count()}");               
            }
        }

        private static void Exercise1_4()
        {
            var books = Library.Books.OrderByDescending(b => b.PublishedYear).ThenByDescending(x => x.Price);
            foreach (var book in books)
            {
                Console.WriteLine($"{book.PublishedYear} {book.Price} {book.Title}");
            }
        }

        private static void Exercise1_5()
        {
            var books = Library.Books.Join(Library.Categories, book => book.CategoryId,
                                                               category => category.Id,
                                                               (book, category) => new
                                                               {
                                                                   Title = book.Title,
                                                                   Category = category.Name,
                                                               })
                                     .Select(b => b.Category)
                                     .Distinct().OrderBy(b => b);

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_6()
        {
            var books = Library.Books.Join(Library.Categories, book => book.CategoryId,
                                                               category => category.Id,
                                                               (book, category) => new
                                                               {
                                                                   Title = book.Title,
                                                                   Category = category.Name,
                                                               })
                                     .GroupBy(b=>b.Category).OrderBy(b=>b.Key);
            foreach (var g in books)
            {
                Console.WriteLine($"#{g.Key}");
                foreach (var book in g)
                {
                    Console.WriteLine($"　{book.Title}");
                }
            }
        }

        private static void Exercise1_7()
        {
            var books = Library.Books.Join(Library.Categories, book => book.CategoryId,
                                                               category => category.Id,
                                                               (book, category) => new
                                                               {
                                                                   Title = book.Title,
                                                                   Category = category.Name,
                                                                   PublishedYear = book.PublishedYear,
                                                               })
                                     .Where(b=>b.Category == "Development")
                                     .GroupBy(b => b.PublishedYear).OrderBy(b => b.Key);
            foreach (var g in books)
            {
                Console.WriteLine($"#{g.Key}");
                foreach (var book in g)
                {
                    Console.WriteLine($"　{book.Title}");
                }
            }
        }

        private static void Exercise1_8()
        {
            var books = Library.Categories.GroupJoin(Library.Books, c => c.Id,
                                                                    b => b.CategoryId,
                                                                    (c, b) => new
                                                                    {
                                                                        Category = c.Name,
                                                                        Count = b.Count()
                                                                    })
                                          .Where(b=>b.Count >= 4);
            foreach (var book in books)
            {
                Console.WriteLine($"カテゴリ：{book.Category}");
            }
        }                                           
    }
}
