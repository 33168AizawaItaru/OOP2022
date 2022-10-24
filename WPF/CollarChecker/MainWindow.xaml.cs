using System;
using System.Collections.Generic;
using System.Linq;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            getColor();
        }

        private void Slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            getColor();
        }

        private void Slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            getColor();
        }

        private void getColor()
        {
            var rCol = Slider1.Value;
            var gCol = Slider2.Value;
            var bCol = Slider3.Value;
            label.Background = new SolidColorBrush(Color.FromRgb((byte)rCol, (byte)gCol, (byte)bCol));
        }
    }
}