using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    public class FeetConveter
    //フィートとメートルの単位変換クラス
    {
        
        //フィートからメートルを求める(静的メソッド)
        public static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }

        //メートルからフィートを求める(静的メソッド)
        public static double MeterToFeet(int meter) 
        {
            return meter / 0.3048;
        }
    }
}
