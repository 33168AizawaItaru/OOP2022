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

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {}
        private void MakerGroupCheck(int getIndex) {}

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



        //コンボボックスに記録者を登録する
        private void setAuther()
        {
            if (!auther.Items.Contains(auther.Text))
            {
                //登録されていなければ登録処理
                auther.Items.Add(auther.Text);
            }
        }

        //コンボボックスに車名を登録する
        private void setcarname()
        {
            if (!carName.Items.Contains(carName.Text))
            {
                //登録されていなければ登録処理
                carName.Items.Add(carName.Text);
            }
        }

        //接続時、コンボボックスに追加
        private void ConnectCombBox()
        {
            //記録者
            if (!auther.Items.Contains(carReportDBDataGridView.SelectedRows[0]))
            {
                auther.Items.Add(carReportDBDataGridView.SelectedRows[0]);
            }

            //車名
            if (!auther.Items.Contains(carReportDBDataGridView.SelectedRows[0]))
            {
                auther.Items.Add(carReportDBDataGridView.SelectedRows[0]);
            }
        }

        private void radioBttonAllClear()
        {
            toyota.Checked = false;
            nissan.Checked = false;
            honda.Checked = false;
            subaru.Checked = false;
            foreignCar.Checked = false;
            other.Checked = false;
        }

        private void rbChecked()
        {
            toyota.Checked = nissan.Checked = honda.Checked = subaru.Checked = foreignCar.Checked = other.Checked = listCarReport.Count() > 0 ? true : false;
        }

        //エラー回避
        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void Exit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void Form1_Load(object sender, EventArgs e)
        { 
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
            {}
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
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dateTimePicker.Text;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = auther.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetCheckBoxMakerGroup();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = carName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = report.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = picture.Image;


            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202215DataSet);
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e){Application.Exit();}

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202215DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202215DataSet.CarReportDB);

            ConnectCombBox();
        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202215DataSet);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = infosys202215DataSet.CarReportDB.NewRow();

            newRow[1] = dateTimePicker.Value;
            newRow[2] = auther.Text;
            newRow[3] = GetCheckBoxMakerGroup();
            newRow[4] = carName.Text;
            newRow[5] = report.Text;
            newRow[6] = ImageToByteArray(picture.Image);

            //データセットへ新しいレコードを追加
            infosys202215DataSet.CarReportDB.Rows.Add(newRow);
            //データベース更新
            this.carReportDBTableAdapter.Update(this.infosys202215DataSet.CarReportDB);

            setAuther();
            setcarname();
        }

        private void PictureOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "画像ファイル(*.jpg; *.png; *.bmp)| *.jpg; *.png; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picture.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }


        private void PictureDeleat_Click(object sender, EventArgs e)
        {
            picture.Image = null;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            dateTimePicker.Text = null;
            auther.Text = null;
            radioBttonAllClear();
            carName.Text = null;
            report.Text = null;
            picture.Image = null;
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void RadioButtonCheked()
        {
            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value =="トヨタ")
            {
                toyota.Checked = true;
            }

            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "日産")
            {
                nissan.Checked = true;
            }

            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "ホンダ")
            {
                honda.Checked = true;
            }

            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "スバル")
            {
                subaru.Checked = true;
            }

            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "外車")
            {
                foreignCar.Checked = true;
            }

            if ((string)carReportDBDataGridView.CurrentRow.Cells[3].Value == "その他")
            {
                other.Checked = true;
            }
        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e)
        {
            radioBttonAllClear();

            dateTimePicker.Text = carReportDBDataGridView.CurrentRow.Cells[1].Value.ToString();
            auther.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
            RadioButtonCheked();
            carName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
            report.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();
            picture.Text = carReportDBDataGridView.CurrentRow.Cells[6].Value.ToString();



            if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull))

                picture.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
            else
                picture.Image = null;
        }

        private void btSerch_Click(object sender, EventArgs e)
        {
            carReportDBTableAdapter.FillByName(infosys202215DataSet.CarReportDB, tbSerch.Text);
        }
    }
}