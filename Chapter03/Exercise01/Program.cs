﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public delegate bool Judgement(int value);

    class Program
    {

        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            Exercise1_1(numbers);
            Console.WriteLine("-------------------");

            Exercise1_2(numbers);
            Console.WriteLine("-------------------");

            Exercise1_3(numbers);
            Console.WriteLine("-------------------");

            Exercise1_4(numbers);
            Console.WriteLine("-------------------");
        }


        private static void Exercise1_1(List<int> numbers)
        {
            var exists = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            if (exists)
                Console.WriteLine("存在しています");
            else
                Console.WriteLine("存在していません");
        }

        private static void Exercise1_2(List<int> numbers)
        {
            numbers.ForEach(n => Console.WriteLine(n / 2.0));
        }

        private static void Exercise1_3(List<int> numbers)
        {
            var longChar = numbers.Where(s => s >= 50);
            foreach (var s in longChar = numbers.Where(s => s >= 50))
            {
                Console.WriteLine(s);
            }
        }

        private static void Exercise1_4(List<int> numbers)
        {
            //使うタイミングで処理される　---→　遅延実行
            var list = numbers.Select(s => s * 2).ToList();

            numbers[5] = 5000;
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
