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

            if (line == 1)
            {
                foreach (var year in books.OrderBy(b=>b.PublishedYear))
                {Console.WriteLine(year);}
            }else if(line == 2)
            {
                foreach (var year in books.OrderByDescending(b => b.PublishedYear))
                {Console.WriteLine(year);}
            }
            Console.WriteLine();

            var groups = Library.Books.Where(b => years.Contains(b.PublishedYear)).GroupBy(b=>b.PublishedYear).OrderBy(b=>b.Key);
            

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key}年");
                foreach (var book in group)
                {
                    var category = Library.Categories.Where(b => b.Id == book.CategoryId).First();
                    Console.WriteLine("　タイトル：{0},　価格：{1},　カテゴリ：{2}",book.Title,book.Price,category.Name);
                }
            }
        }
    }
}