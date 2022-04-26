﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{//フィートとメートルの単位変換クラス
    public class FeetConverter
    {
        private const double ratio = 0.3048;//定数ratioを定義
        //public static readonly double ratio = 0.3048; ←外部からもアクセスさせたい場合

        //メートルからフィートを求める(静的メソッド)
        public static double FromMeter(int meter) 
        {
            return meter / ratio;
        }

        //フィートからメートルを求める(静的メソッド)
        public static double ToMeter(int feet)
        {
            return feet * ratio;
        }
    }
}
