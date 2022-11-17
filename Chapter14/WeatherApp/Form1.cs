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
        List<string> colorInfo = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        public class PrefectureInfo
        {
            public string PrefectureName { get; set; }
        }

        private void GetInfo()
        {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            string dString;
            Class1[] json;
            
            switch (PrefectureList.SelectedItem)
            {
                case "宗谷地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/011000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "平均最低気温: "+json[1].tempAverage.areas[0].min+"　平均最高気温: "+ json[1].tempAverage.areas[0].max;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "平均最低降水量: " + json[1].precipAverage.areas[0].min + "　平均最高降水量: " + json[1].precipAverage.areas[0].max;
                break;

                case "上川・留萌地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/012000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "網走・北見・紋別地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/013000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "十勝地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/014030.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "釧路・根室地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/014100.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "胆振・日高地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/015000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "石狩・空知・後志地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/016000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "渡島・檜山地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/017000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "青森県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/020000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "岩手県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/030000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "宮城県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/040000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "秋田県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/050000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "山形県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/060000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "福島県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/070000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "茨城県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/080000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "栃木県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/090000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "群馬県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/100000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "埼玉県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/110000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "千葉県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/120000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "東京都":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/130000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "神奈川県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/140000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "山梨県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/190000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "長野県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/200000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "岐阜県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/210000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "静岡県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/220000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "愛知県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/230000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "三重県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/240000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "新潟県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/150000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "富山県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/160000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "石川県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/170000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "福井県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/180000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "滋賀県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/250000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "京都府":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/260000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "大阪府":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/270000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "兵庫県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/280000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "奈良県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/290000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "和歌山県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/300000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "鳥取県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/310000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "島根県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/320000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "岡山県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/330000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "広島県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/340000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "徳島県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/360000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "香川県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/370000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "愛媛県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/380000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "高知県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/390000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "山口県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/350000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "福岡県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/400000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "佐賀県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/410000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "長崎県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/420000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "熊本県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/430000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "大分県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/440000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "宮崎県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/450000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "奄美地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/460040.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "鹿児島県":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/460100.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "沖縄本島地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/471000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "大東島地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/472000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "宮古島地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/473000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;

                case "八重山地方":
                dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/474000.json");
                json = JsonConvert.DeserializeObject<Class1[]>(dString);
                WeatherInfo.Text += json[0].publishingOffice;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].reportDatetime;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += json[0].timeSeries[0].areas[0].area.name;
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明日の天気: " + json[0].timeSeries[0].areas[0].weathers[1];
                WeatherInfo.Text += Environment.NewLine;
                WeatherInfo.Text += "明後日の天気: " + json[0].timeSeries[0].areas[0].weathers[2];
                break;
            }
        }

        private void hokkaido_Click(object sender, EventArgs e)
        {
            PrefectureList.Items.Clear();
            string[] prefs = {"宗谷地方","上川・留萌地方","網走・北見・紋別地方",
                              "十勝地方","釧路・根室地方",
                              "胆振・日高地方","石狩・空知・後志地方",
                              "渡島・檜山地方",};
            PrefectureList.Items.AddRange(prefs);
        }

        private void tohoku_Click(object sender, EventArgs e)
        {
            PrefectureList.Items.Clear();
            string[] prefs = {"青森県","岩手県","宮城県",
                              "秋田県","山形県","福島県",};
            PrefectureList.Items.AddRange(prefs);
        }

        private void kantokosinetu_Click(object sender, EventArgs e)
        {
            PrefectureList.Items.Clear();
            string[] prefs = {"茨城県","栃木県", "群馬県",
                              "埼玉県","千葉県", "東京都",
                              "神奈川県","山梨県","長野県",};
            PrefectureList.Items.AddRange(prefs);
        }

        private void tokai_Click(object sender, EventArgs e)
        {
            PrefectureList.Items.Clear();
            string[] prefs = { "岐阜県", "静岡県", "愛知県", "三重県", };
            PrefectureList.Items.AddRange(prefs);
        }

        private void hokuriku_Click(object sender, EventArgs e)
        {
            PrefectureList.Items.Clear();
            string[] prefs = { "新潟県", "富山県", "石川県", "福井県", };
            PrefectureList.Items.AddRange(prefs);
        }

        private void kinki_Click(object sender, EventArgs e)
        {
            PrefectureList.Items.Clear();
            string[] prefs = { "滋賀県","京都府","大阪府",
                               "兵庫県","奈良県","和歌山県",};
            PrefectureList.Items.AddRange(prefs);
        }

        private void tyugoku_Click(object sender, EventArgs e)
        {
            PrefectureList.Items.Clear();
            string[] prefs = { "鳥取県", "島根県", "岡山県", "広島県", };
            PrefectureList.Items.AddRange(prefs);
        }

        private void sikoku_Click(object sender, EventArgs e)
        {
            PrefectureList.Items.Clear();
            string[] prefs = { "徳島県", "香川県", "愛媛県", "高知県", };
            PrefectureList.Items.AddRange(prefs);
        }

        private void kyusyu_Click(object sender, EventArgs e)
        {
            PrefectureList.Items.Clear();
            string[] prefs = {"山口県", "福岡県", "佐賀県", "長崎県", "熊本県	",
                              "大分県", "宮崎県", "奄美地方", "鹿児島県",};
            PrefectureList.Items.AddRange(prefs);
        }

        private void okinawa_Click(object sender, EventArgs e)
        {
            PrefectureList.Items.Clear();
            string[] prefs = { "沖縄本島地方", "大東島地方", "宮古島地方", "八重山地方", };
            PrefectureList.Items.AddRange(prefs);
        }

        private void PrefectureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeatherInfo.Clear();
            GetInfo();
        }
    }
}