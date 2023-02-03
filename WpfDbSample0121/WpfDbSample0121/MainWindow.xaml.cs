using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfDbSample0121 {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        
        WpfDbSample0121.infosys202000DataSet infosys202000DataSet;
        WpfDbSample0121.infosys202000DataSetTableAdapters.CarReportTableAdapter infosys202000DataSetCarReportTableAdapter;
        System.Windows.Data.CollectionViewSource carReportViewSource;

        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            infosys202000DataSet = ((WpfDbSample0121.infosys202000DataSet)(this.FindResource("infosys202000DataSet")));
            // テーブル CarReport にデータを読み込みます。必要に応じてこのコードを変更できます。
            infosys202000DataSetCarReportTableAdapter = new WpfDbSample0121.infosys202000DataSetTableAdapters.CarReportTableAdapter();
            infosys202000DataSetCarReportTableAdapter.Fill(infosys202000DataSet.CarReport);
            carReportViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("carReportViewSource")));
            carReportViewSource.View.MoveCurrentToFirst();
        }
        //選択行の取り出し
        private void Button_Click(object sender, RoutedEventArgs e) {
            DataRowView drv = (DataRowView)carReportViewSource.View.CurrentItem;
            MakerTextBox.Text = drv.Row[3].ToString();


        }
        //更新ボタン
        private void Button_Click_1(object sender, RoutedEventArgs e) {
            //選択行の取り出し
            DataRowView drv = (DataRowView)carReportViewSource.View.CurrentItem;
            drv.Row[3] = MakerTextBox.Text;
            //データベース更新
            infosys202000DataSetCarReportTableAdapter.Update(infosys202000DataSet.CarReport);
        }
        //新規追加ボタン
        private void Button_Click_2(object sender, RoutedEventArgs e) {
            //新規レコードの追加
            DataRow newDrv = (DataRow)infosys202000DataSet.CarReport.NewRow();
            newDrv[1] = "2020-10-10";
            newDrv[2] = "●●●●";
            newDrv[4] = "石川ひろし";
            //データセットに新しいレコードを追加
            infosys202000DataSet.CarReport.Rows.Add(newDrv);
            //データベース更新
            infosys202000DataSetCarReportTableAdapter.Update(infosys202000DataSet.CarReport);
        }
        //LINQでの取得
        private void Button_Click_3(object sender, RoutedEventArgs e) {
            var carName = infosys202000DataSet.CarReport.Select(n => n.Name).ToArray();
        }

        //レコード削除
        private void Button_RecordDelete(object sender, RoutedEventArgs e)
        {
            //選択行の取り出し
            DataRowView drv = (DataRowView)carReportViewSource.View.CurrentItem;
            //選択されたレコードの削除
            drv.Delete();
            //データベース更新
            infosys202000DataSetCarReportTableAdapter.Update(infosys202000DataSet.CarReport);

        }
    }
}
