using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01
{
    class Program
    {
        public delegate bool judgement(int value);//デリゲートの宣言

        static void Main(string[] args)
        {
            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            var names = list.FindAll(s => s.Length <= 6);

            names.ForEach(s => Console.WriteLine(s));

            /*   ↑でも可
             *  foreach (var s in names)
             *  {
             *      Console.WriteLine(names);
             *  }
            */
        }
    }
}
