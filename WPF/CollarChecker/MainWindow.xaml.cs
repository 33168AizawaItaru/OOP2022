using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollarChecker
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        MyColor mycolor = new MyColor();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            getColor();
        }

        private void getColor()
        {
            label.Background = new SolidColorBrush(Color.FromRgb((byte)Slider1.Value, (byte)Slider2.Value, (byte)Slider3.Value));
        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList()
        {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        /// <summary>
        /// 色と色名を保持するクラス
        /// </summary>
        public class MyColor
        {
            public Color Color { get; set; }
            public string Name { get; set; }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;

            label.Background = new SolidColorBrush(color);

            Slider1.Value = color.R;
            Slider2.Value = color.G;
            Slider3.Value = color.B;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            getColor();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var saveColors = "R：" + rText.Text + "　G：" + gText.Text + "　B：" + bText.Text;

            var colorName = ((IEnumerable<MyColor>)DataContext)
                                .Where(c => c.Color.R == mycolor.Color.R &&
                                          c.Color.G == mycolor.Color.G &&
                                          c.Color.B == mycolor.Color.B).FirstOrDefault();

            //colorInfo.Items.Insert(0,colorName?.Name ?? "R：" + rText.Text + "　G：" + gText.Text + "　B：" + bText.Text);
            
            if (colorName != null)
            {
                colorInfo.Items.Add(colorName.Name);
            } else
            {
                colorInfo.Items.Add(saveColors);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            colorInfo.Items.Clear();
        }

        private void colorInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var colors = colorInfo.SelectedItem;
            string[] color = colors.ToString().Split('　');

            rText.Text = color[0].Substring(2);
            gText.Text = color[1].Substring(2);
            bText.Text = color[2].Substring(2);
        }
    }
}