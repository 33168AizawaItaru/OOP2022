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
                Console.WriteLine($"出版年：{book.PublishedYear},カテゴリ：{book.CategoryId},価格：{book.Price},タイトル：{book.Title}");
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
            
        }

        private static void Exercise1_5()
        {

        }

        private static void Exercise1_6()
        {

        }

        private static void Exercise1_7()
        {

        }

        private static void Exercise1_8()
        {

        }
    }
}
