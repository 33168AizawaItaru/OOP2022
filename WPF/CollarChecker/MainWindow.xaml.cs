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
        List<MyColor> colorList = new List<MyColor>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = GetColorList();
            EnabledCheck();
        }

        

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            getColor();
        }

        private void getColor()
        {
            var r = byte.Parse(rText.Text);
            var g = byte.Parse(gText.Text);
            var b = byte.Parse(bText.Text);
            Color color = Color.FromRgb(r,g,b);
            label.Background = new SolidColorBrush(color);
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
            Slider1.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.R;
            Slider2.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.G;
            Slider3.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.B;
            getColor();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            getColor();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var sColor = GetColorName(byte.Parse(rText.Text),byte.Parse(gText.Text),byte.Parse(bText.Text));

            saveList.Items.Insert(0, sColor.Name ?? "R:" + sColor.Color.R + "　G:" + sColor.Color.G + "　B:" + sColor.Color.B);
            colorList.Insert(0, sColor);
            Delete.IsEnabled = true;
        }

        private MyColor GetColorName(byte r, byte g, byte b)
        {
            return new MyColor
            {
                Color = Color.FromRgb(r, g, b),
                Name = ((IEnumerable<MyColor>)DataContext)
                                .Where(c => c.Color.R == r &&
                                            c.Color.G == g &&
                                            c.Color.B == b).Select(c => c.Name).FirstOrDefault()
            };
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (saveList.SelectedIndex == -1)return;

            colorList.RemoveAt(saveList.SelectedIndex);
            saveList.Items.RemoveAt(saveList.SelectedIndex);

            EnabledCheck();
        }

        private void colorInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (saveList.SelectedIndex != -1)
            {
                Slider1.Value = colorList[saveList.SelectedIndex].Color.R;
                Slider2.Value = colorList[saveList.SelectedIndex].Color.G;
                Slider3.Value = colorList[saveList.SelectedIndex].Color.B;
            }        
            getColor();
        }

        private void EnabledCheck()
        {
            if (saveList.Items.Count == 0)
            {
                Delete.IsEnabled = false;
            } else
            {
                Delete.IsEnabled = true;
            }
        }
    }
}