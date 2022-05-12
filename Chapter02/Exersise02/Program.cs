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
            if (args.Length >= 1 && args[0] == "-tom")
            {
                //フィートからメートルへの対応表を出力
                PrintInchToMeterList(1, 10);
            }
            else if (args.Length >= 1 && args[0] == "-toi")
            {
                //メートルからフィートへの対応表を出力
                PrintMaterToInchList(1, 10);
            }
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

        //メートルからフィートへの対応表
        private static void PrintMaterToInchList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} in", meter, inch);
            }
        }
    }
}
