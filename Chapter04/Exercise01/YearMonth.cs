using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class YearMonth
    {
        //年プロパティ
        public int Year { get; private set; }

        //月プロパティ
        public int Month { get; private set; }

        //コンストラクタ
        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }

        public bool Is21Century
        {
            get
            {
                return 2001 <= Year  && Year <= 2100;
            }

            
        }
    }
}
