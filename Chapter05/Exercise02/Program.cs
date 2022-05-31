using System;
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
            var intStr = Console.ReadLine();
            
            if (int.TryParse(intStr,out var strInt))
            {
                Console.WriteLine("{0:N}",strInt);
            } else
            {
                Console.WriteLine("できない...");
            }
        }
    }
}
