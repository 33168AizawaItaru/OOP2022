using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15
{
    class Program
    {
        static void Main(string[] args)
        {
            var years = new List<int>();
            var books = Library.Books.Where(b=>years.Contains(b.PublishedYear));

            Console.WriteLine("出力したい西暦を入力");
            var input = int.Parse(Console.ReadLine());

            while (!(input == -1))
            {
                years.Add(input);
                input = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("昇順：1 or 降順：2");
            var line = int.Parse(Console.ReadLine());

            if (line == 1)//昇順
            {
                foreach (var year in books.OrderBy(b=>b.PublishedYear))
                {Console.WriteLine(year);}
            }else if(line == 2)//降順
            {
                foreach (var year in books.OrderByDescending(b => b.PublishedYear))
                {Console.WriteLine(year);}
            }
            Console.WriteLine();

            var selected = Library.Books.Where(b => years.Contains(b.PublishedYear))
                                        .Join(Library.Categories, book => book.CategoryId,
                                                                 category => category.Id,
                                                                 (book, category) => new
                                                                 {
                                                                     Title = book.Title,
                                                                     Category = category.Name,
                                                                     PublishedYear = book.PublishedYear,
                                                                     Price = book.Price
                                                                 }
                                        );

            foreach (var book in selected.OrderByDescending(b => b.PublishedYear).ThenBy(x => x.Category))
            {
                
                Console.WriteLine("タイトル：{0},　出版年：{1},　カテゴリ：{2},　価格：{3}", book.Title, book.PublishedYear, book.Category,book.Price);

            }
            Console.WriteLine("金額の合計：{0}",selected.Sum(b=>b.Price));
        }
    }
}