using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        Settings settings = Settings.getInstance();

        public Form1()
        {
            InitializeComponent();
            dataGridView.DataSource = listCarReport;
        }

        #region 終了ボタン
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region　メーカーグループのあれ
        private CarReport.MakerGroup GetCheckBoxMakerGroup()
        {
            if (toyota.Checked)
            {
                return CarReport.MakerGroup.トヨタ;
            }

            if (nissan.Checked)
            {
                return CarReport.MakerGroup.日産;
            }

            if (honda.Checked)
            {
                return CarReport.MakerGroup.ホンダ;
            }

            if (subaru.Checked)
            {
                return CarReport.MakerGroup.スバル;
            }

            if (foreignCar.Checked)
            {
                return CarReport.MakerGroup.外国車;
            }
            
            return CarReport.MakerGroup.その他;
        }
        #endregion

        #region 車名登録
        //コンボボックスに車名を登録する
        private void setCarName(string setcarname)
        {
            if (!carName.Items.Contains(setcarname))
            {
                //登録されていなければ登録処理
                carName.Items.Add(setcarname);
            }
        }
        #endregion

        #region 記録者登録
        //コンボボックスに車名を登録する
        private void setAuther(string setauther)
        {
            if (!auther.Items.Contains(setauther))
            {
                //登録されていなければ登録処理
                auther.Items.Add(setauther);
            }
        }
        #endregion

        #region 画像を開く
        private void PictureOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picture.Image = Image.FromFile(openFileDialog.FileName);
            }
            pictureDeleat.Enabled = true;
        }
        #endregion

        #region　画像削除
        private void PictureDeleat_Click(object sender, EventArgs e)
        {
            picture.Image = null;
        }
        #endregion

        #region データグリッドビューの中
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            var getIndex = dataGridView.CurrentRow.Index;

            dateTimePicker.Value = listCarReport[getIndex].Date;
            auther.Text = listCarReport[getIndex].Auther;
            carName.Text = listCarReport[getIndex].CarName;
            report.Text = listCarReport[getIndex].Report;
            picture.Image = listCarReport[getIndex].Picture;

            MakerGroupCheck(getIndex);
        }
        #endregion

        #region メーカーグループチェック
        private void MakerGroupCheck(int getIndex)
        {
            radioBttonAllClear();

            switch (listCarReport[getIndex].Maker)
            {
                case CarReport.MakerGroup.トヨタ:
                toyota.Checked = true;
                break;

                case CarReport.MakerGroup.日産:
                nissan.Checked = true;
                break;

                case CarReport.MakerGroup.ホンダ:
                honda.Checked = true;
                break;

                case CarReport.MakerGroup.スバル:
                subaru.Checked = true;
                break;

                case CarReport.MakerGroup.外国車:
                foreignCar.Checked = true;
                break;

                case CarReport.MakerGroup.その他:
                other.Checked = true;
                break;

                default:
                break;
            }

        }
        #endregion

        #region ラジオボタンクリア
        private void radioBttonAllClear()
        {
            toyota.Checked = false;
            nissan.Checked = false;
            honda.Checked = false;
            subaru.Checked = false;
            foreignCar.Checked = false;
            other.Checked = false;
        }
        #endregion

        #region 修正（更新）
        private void articleRevision_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            var getIndex = dataGridView.CurrentRow.Index;

            listCarReport[getIndex].Date = dateTimePicker.Value;
            listCarReport[getIndex].Auther = auther.Text;
            listCarReport[getIndex].Maker = GetCheckBoxMakerGroup();
            listCarReport[getIndex].CarName = carName.Text;
            listCarReport[getIndex].Report = report.Text;
            listCarReport[getIndex].Picture = picture.Image; 
            dataGridView.Refresh();//データグリッドビュー更新
        }
        #endregion

        #region 記事追加
        private void ArticleAdd_Click(object sender, EventArgs e)
        {

            CarReport newCarReport = new CarReport
            {
                Date = dateTimePicker.Value,
                Auther = auther.Text,
                Maker = GetCheckBoxMakerGroup(),
                CarName = carName.Text,
                Report = report.Text,
                Picture = picture.Image,
            };
            listCarReport.Add(newCarReport);

            EnabledCheck();

            setCarName(carName.Text);
            setAuther(auther.Text);
        }
        #endregion

        #region 記事削除
        private void articleDeleat_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            listCarReport.RemoveAt(dataGridView.CurrentRow.Index);

            EnabledCheck();
        }
        #endregion

        #region　記事開く
        private void ArticleOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                carName.Items.Clear();
                auther.Items.Clear();
                try
                {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = listCarReport;
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                foreach (var item in listCarReport.Select(p => p.CarName))
                {
                    setCarName(item);//存在する会社を登録
                }

                foreach (var item in listCarReport.Select(p => p.Auther))
                {
                    setAuther(item);//存在する会社を登録
                }

                EnabledCheck();
            }
        }
        #endregion

        #region 記事保存
        private void articleSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(saveFileDialog.FileName, FileMode.Create))
                    {
                        bf.Serialize(fs, listCarReport);
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region ラジオボタンのあれ
        private void rbChecked()
        {
            toyota.Checked = nissan.Checked = honda.Checked = subaru.Checked = foreignCar.Checked = other.Checked = listCarReport.Count() > 0 ? true : false;
        }
        #endregion

        #region マスク
        //更新・削除ボタンのマスクを行う（マスク判定含む）
        private void EnabledCheck()
        {
            articleRevision.Enabled = articleDeleat.Enabled = listCarReport.Count() > 0 ? true : false;
        }
        #endregion

        #region レポート閉じるやつ
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //シリアル化
            using (var writer = XmlWriter.Create("setting.xml"))
            {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202215DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202215DataSet.CarReportDB);
            EnabledCheck();

            try
            {
                //逆シリアル化
                using (var reader = XmlReader.Create("setting.xml"))
                {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            } catch(Exception)
            {

            }
        }


        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorSelect.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorSelect.Color;//背景変更
                settings.MainFormColor = colorSelect.Color.ToArgb();
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(saveFileDialog.FileName, FileMode.Create))
                    {
                        bf.Serialize(fs, listCarReport);
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                carName.Items.Clear();
                auther.Items.Clear();
                try
                {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = listCarReport;
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                foreach (var item in listCarReport.Select(p => p.CarName))
                {
                    setCarName(item);//存在する会社を登録
                }

                foreach (var item in listCarReport.Select(p => p.Auther))
                {
                    setAuther(item);//存在する会社を登録
                }

                EnabledCheck();
            }
        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202215DataSet);

        }
    }
}