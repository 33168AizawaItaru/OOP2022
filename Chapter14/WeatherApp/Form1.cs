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
        Image currentImage = Image.FromFile(@"C:\Users\infosys\Downloads\touka.jpg");
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

        private void Prefecture_SelectedIndexChanged(object sender, EventArgs e)
        {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            string dString;
            Rootobject json;

            switch (Prefecture.SelectedItem)
            {
                case "宗谷地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "上川・留萌地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/012000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "網走・北見・紋別地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/013000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "十勝地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014030.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "釧路・根室地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/014100.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "胆振・日高地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/015000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "石狩・空知・後志地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/016000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "渡島・檜山地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/017000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "青森県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "岩手県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "宮城県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "秋田県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "山形県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/060000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "福島県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/070000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "茨城県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "栃木県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "群馬県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/100000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "埼玉県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/110000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "千葉県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/120000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "東京都":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "神奈川県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/140000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "山梨県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/190000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "長野県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/200000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "岐阜県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "静岡県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/220000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "愛知県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/230000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "三重県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/240000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "新潟県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/150000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "富山県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "石川県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/170000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "福井県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/180000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "滋賀県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "京都府":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/260000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "大阪府":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/270000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "兵庫県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/280000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "奈良県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/290000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "和歌山県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/300000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "鳥取県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "島根県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/320000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "岡山県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/330000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "広島県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/340000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "徳島県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/360000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "香川県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/370000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "愛媛県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/380000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "高知県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/390000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "山口県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/350000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "福岡県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "佐賀県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/410000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "長崎県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/420000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "熊本県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/430000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "大分県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/440000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "宮崎県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/450000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "奄美地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460040.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "鹿児島県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/460100.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "沖縄本島地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "大東島地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/472000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "宮古島地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/473000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;

                case "八重山地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/474000.json");
                json = JsonConvert.DeserializeObject<Rootobject>(dString);
                tbWeatherInfo.Text = json.text;
                break;
            }
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            if (currentImage != null)
            {
                //　画像を0,0に描画する
                e.Graphics.DrawImage(currentImage, 0, 0, currentImage.Width, currentImage.Height);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}