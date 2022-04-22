using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom")
            {
                //フィートからメートルへの対応表を出力
                PrintFeetToMeterList(1,10);
            }
            else
            {
                //メートルからフィートへの対応表を出力
                PrintMaterToFeetList(1,10);
            }
        }

        //フィートからメートルへの対応表
        private static void PrintFeetToMeterList(int start, int stop)
        {
            FeetConveter fc = new FeetConveter();
            for (int feet = start; feet <= 10; feet++)
            {
                
                double meter = fc.FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        //メートルからフィートへの対応表
        private static void PrintMaterToFeetList(int start,int stop)
        {
            FeetConveter fc = new FeetConveter();
            for (int meter = 1; meter <= 10; meter++)
            {
                double feet = fc.MeterToFeet(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }

        
    }
}
