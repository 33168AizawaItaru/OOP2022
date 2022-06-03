﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book> {
            new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
            new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
            new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
            new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
            new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
            new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
            new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
            Console.WriteLine("-----");

            Exercise2_8(books);
            Console.WriteLine("-----");
        }

        private static void Exercise2_1(List<Book> books)
        {
            var book = books.Where(s => s.Title == "ワンダフル・C#ライフ");
            foreach (var boo in book)
            {
                Console.WriteLine("{0},{1}", boo.Price, boo.Pages);
            }
        }

        private static void Exercise2_2(List<Book> books)
        {
            var book = books.Count(s => s.Title.Contains("C#"));
            Console.WriteLine(book);
        }

        private static void Exercise2_3(List<Book> books)
        {
            var book = books.Where(s => s.Title.Contains("C#")).Average(s => s.Pages);
            Console.WriteLine(book);
        }

        private static void Exercise2_4(List<Book> books)
        {
            var book = books.First(s => s.Price > 4000);
            Console.WriteLine(book.Title);
        }

        private static void Exercise2_5(List<Book> books)
        {
            var book = books.Where(s => s.Price < 4000).Max(s => s.Pages);
            Console.WriteLine(book);
        }

        private static void Exercise2_6(List<Book> books)
        {
            foreach (var book in books.Where(s => s.Pages > 400).OrderByDescending(s => s.Price))
            {
                Console.WriteLine("{0},{1}", book.Title, book.Price);
            }
        }

        private static void Exercise2_7(List<Book> books)
        {
            foreach (var book in books.Where(s => s.Title.Contains("C#") && s.Pages <= 400))
            {
                Console.WriteLine(book.Title);
            }
        }

        private static void Exercise2_8(List<Book> books)
        {
            /*int count = 1;

            foreach (var book in books)
            {
                Console.WriteLine(count + "冊目：{0}", book.Title);
                count++;
            }*/

            foreach (var book in books.Select((b,i) => new {i,b.Title}))
            {
                Console.WriteLine((book.i+1) + "冊目:" + book.Title) ;
            }
        }

        class Book
        {
            public string Title { get; set; }
            public int Price { get; set; }
            public int Pages { get; set; }
        }
    }
}
