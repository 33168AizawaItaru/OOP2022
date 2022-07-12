using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
            DataGridView.DataSource = listCarReport;
        }

        #region 終了ボタン
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region　画像

        private void ArticleAdd_Click(object sender, EventArgs e)
        {
            
        }



        private void PictureDeleat_Click(object sender, EventArgs e)
        {
            Picture.Image = null;
        }

        #endregion

        private void ArticleOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                carName.Items.Clear();
                try
                {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        DataGridView.DataSource = null;
                        DataGridView.DataSource = listCarReport;
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                foreach (var item in listCarReport.Select(p => p.CarName))
                {
                    setCbCompany(item);//存在する会社を登録
                }
            }
        }

        //コンボボックスに車名を登録する
        private void setCbCompany(string company)
        {

            if (!carName.Items.Contains(company))
            {
                //登録されていなければ登録処理
                cbCompany.Items.Add(company);
            }
        }

        private void PictureOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Picture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
