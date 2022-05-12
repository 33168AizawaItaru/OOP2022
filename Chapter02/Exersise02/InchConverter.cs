using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class InchConverter
    {
        private const double ratio = 0.0254;//定数ratioを定義
        //public static readonly double ratio = 0.3048; ←外部からもアクセスさせたい場合

        //インチからメートルを求める(静的メソッド)
        public static double ToMeter(double inch)
        {
            return inch * ratio;
        }
        //メートルからフィートを求める(静的メソッド)
        public static double FromMeter(int meter)
        {
            return meter / ratio;
        }
    }
}
