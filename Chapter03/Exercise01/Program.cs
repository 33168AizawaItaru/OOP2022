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
            var numbers = new List<int> { 12,87,94,14,53,20,40,35,76,91,31,17,48};
            
            Exercise1_1(numbers);
            Console.WriteLine();

            Exercise1_2(numbers);
            Console.WriteLine();

        }

        private static void Exercise1_1(List<int> numbers)
        {
            var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            if (exists)
                Console.WriteLine("存在しています");
            else
                Console.WriteLine("存在していません");
        }

        private static void Exercise1_2(List<int> numbers)
        {
            
        }
    }
}
