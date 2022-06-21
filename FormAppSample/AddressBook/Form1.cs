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

namespace AddressBook
{
    public partial class Form1 : Form
    {
        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1()
        {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            //氏名が未入力なら登録しない
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            Person newPerson = new Person
            {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
                Registration = dtp.Value,
            };
            listPerson.Add(newPerson);

            EnabledCheck();

            setCbCompany(cbCompany.Text);
        }

        //コンボボックスに会社名を登録する
        private void setCbCompany(string company)
        {

            if (!cbCompany.Items.Contains(company))
            {
                //登録されていなければ登録処理
                cbCompany.Items.Add(company);
            }
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup()
        {
            var listGroup = new List<Person.GroupType>();

            if (cbFamily.Checked)
            {
                listGroup.Add(Person.GroupType.家族);
            }

            if (cbFriend.Checked)
            {
                listGroup.Add(Person.GroupType.友人);
            }

            if (cbWork.Checked)
            {
                listGroup.Add(Person.GroupType.仕事);
            }

            if (cbOther.Checked)
            {
                listGroup.Add(Person.GroupType.その他);
            }

            return listGroup;
        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e)
        {
            if (dgvPersons.CurrentRow == null) return;

            var getIndex = dgvPersons.CurrentRow.Index;

            tbName.Text = listPerson[getIndex].Name;
            tbMailAddress.Text = listPerson[getIndex].MailAddress;
            tbAddress.Text = listPerson[getIndex].Address;
            cbCompany.Text = listPerson[getIndex].Company;
            pbPicture.Image = listPerson[getIndex].Picture;
            dtp.Value = listPerson[getIndex].Registration.Year > 1900 ? listPerson[getIndex].Registration : DateTime.Today;

            groupCheckBoxAllClear();

            foreach (var group in listPerson[getIndex].listGroup)
            {
                switch (group)
                {
                    case Person.GroupType.家族:
                    cbFamily.Checked = true;
                    break;

                    case Person.GroupType.友人:
                    cbFriend.Checked = true;
                    break;

                    case Person.GroupType.仕事:
                    cbWork.Checked = true;
                    break;

                    case Person.GroupType.その他:
                    cbOther.Checked = true;
                    break;

                    default:
                    break;
                }
            }
        }

        private void groupCheckBoxAllClear()
        {
            cbFamily.Checked = false;
            cbFriend.Checked = false;
            cbWork.Checked = false;
            cbOther.Checked = false;

            //又は
            //cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e)
        {

            if (dgvPersons.CurrentRow == null) return;
            var getIndex = dgvPersons.CurrentRow.Index;

            listPerson[getIndex].Name = tbName.Text;
            listPerson[getIndex].MailAddress = tbMailAddress.Text;
            listPerson[getIndex].Address = tbAddress.Text;
            listPerson[getIndex].Company = cbCompany.Text;
            listPerson[getIndex].Picture = pbPicture.Image;
            listPerson[getIndex].listGroup = GetCheckBoxGroup();
            listPerson[getIndex].Registration = dtp.Value;
            dgvPersons.Refresh();//データグリッドビュー更新
        }

        private void btDeleat_Click(object sender, EventArgs e)
        {
            if (dgvPersons.CurrentRow == null) return;
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);

            EnabledCheck();

        }

        //更新・削除ボタンのマスクを行う（マスク判定含む）
        private void EnabledCheck()
        {
            btUpdate.Enabled = btDeleat.Enabled = listPerson.Count() > 0 ? true : false;

            /*　↑どっちでも良き
            if (listPerson.Count() > 0)
            {
                //マスク解除
                btDeleat.Enabled = true;
                btUpdate.Enabled = true;
            } else
            {
                //マスク設定
                btDeleat.Enabled = false;
                btUpdate.Enabled = false;
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnabledCheck();
        }


        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create))
                    {
                        bf.Serialize(fs, listPerson);
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK)
            {
                cbCompany.Items.Clear();
                try
                {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        //逆シリアル化して読み込む
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;
                    }                       
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                foreach (var item in listPerson.Select(p=>p.Company))
                {
                    setCbCompany(item);//存在する会社を登録
                }
            }
            EnabledCheck();
        }


        private void btPictureClear_Click(object sender, EventArgs e) { pbPicture.Image = null; }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}