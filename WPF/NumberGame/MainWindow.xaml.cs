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

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        private int correctNum;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (int.Parse((string)button.Content) == correctNum)
            {
                infoDisp.Text = "正解";
            } else 
            {
                infoDisp.Text = int.Parse((string)button.Content) < correctNum ? "まだ小さい" : "まだ大きい";
                button.Background = Brushes.Aquamarine;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            infoDisp.Text = "スタート";
            correctNum = rand.Next(25) + 1;
        }
    }
}