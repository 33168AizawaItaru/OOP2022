using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers)
        {
            var numMax = numbers.Max();
            Console.WriteLine(numMax);
        }

        private static void Exercise1_2(int[] numbers)
        {

            foreach(var last2 in numbers.Skip(numbers.Length - 2))
            {
                Console.WriteLine(last2);
            }
        }

        private static void Exercise1_3(int[] numbers)
        {

            foreach (var str in numbers.Select(s=>s.ToString()))
            {
                Console.WriteLine(str);
            }

        }

        private static void Exercise1_4(int[] numbers)
        {
            foreach (var asc3 in numbers.OrderBy(o => o).Take(3))
            {
                Console.WriteLine(asc3);
            }
        }

        private static void Exercise1_5(int[] numbers)
        {
            var dist = numbers.Distinct().Count(c=>c>10);
            Console.WriteLine(dist);
        }
    }
}
