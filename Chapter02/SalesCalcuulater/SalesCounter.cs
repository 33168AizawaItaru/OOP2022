using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalcuulater
{
    public class SalesCounter
    {

        private IEnumerable<Sale> _sales;//csvファイルから読み込んだデータ

        //コンストラクタ
        public SalesCounter(String filePath)
        {
            _sales = ReadSales(filePath);
        }

        //店舗別売り上げを求める
        public IDictionary<string, int> GetPerStoreSales() 
        {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales)
            {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }

        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        public static IEnumerable<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Sale sale = new Sale
                {
                    
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}
