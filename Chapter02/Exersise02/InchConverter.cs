using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersise02
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
    }
}
