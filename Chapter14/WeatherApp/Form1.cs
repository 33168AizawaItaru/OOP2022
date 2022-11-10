﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addPrefecture();
        }

        private void addPrefecture()
        {
            string[] addPrefecture =
                            { "宗谷地方", "上川・留萌地方", "網走・北見・紋別地方", "十勝地方", "釧路・根室地方",
                              "胆振・日高地方", "石狩・空知・後志地方", "渡島・檜山地方", "青森県", "岩手県",
                              "宮城県", "秋田県", "山形県", "福島県", "茨城県",
                              "栃木県", "群馬県", "埼玉県", "千葉県", "東京都",
                              "神奈川県", "山梨県", "長野県", "岐阜県", "静岡県",
                              "愛知県", "三重県", "新潟県", "富山県", "石川県",
                              "福井県", "滋賀県", "京都府", "大阪府", "兵庫県",
                              "奈良県", "和歌山県", "鳥取県", "島根県", "岡山県",
                              "広島県", "徳島県", "香川県", "愛媛県", "高知県",
                              "山口県", "福岡県", "佐賀県", "長崎県", "熊本県	",
                              "大分県", "宮崎県", "奄美地方", "鹿児島県", "沖縄本島地方",
                              "大東島地方", "宮古島地方", "八重山地方",
                            };
            Prefecture.Items.AddRange(addPrefecture);
        }

        private void btWeatherGet_Click(object sender, EventArgs e)
        {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
        }

        private void Prefecture_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
