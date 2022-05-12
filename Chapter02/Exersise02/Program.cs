using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersise02
{
    class Program
    {
        static void Main(string[] args)
        {
            //インチからメートルへの対応表を出力
            PrintInchToMeterList(1, 10);
        }

        //インチからメートルへの対応表
        private static void PrintInchToMeterList(int start, int stop)
        {
            for (int inch = start; inch <= stop; inch++)
            {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0} in = {1:0.0000} m", inch, meter);
            }
        }
    }
}
