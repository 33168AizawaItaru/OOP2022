﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            Person newPerson = new Person
            {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup()
            };
            listPerson.Add(newPerson);

            Check();
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
            tbCompany.Text = listPerson[getIndex].Company;
            pbPicture.Image = listPerson[getIndex].Picture;

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
            listPerson[getIndex].Company = tbCompany.Text;
            listPerson[getIndex].Picture = pbPicture.Image;
            listPerson[getIndex].listGroup = GetCheckBoxGroup();
            dgvPersons.Refresh();//データグリッドビュー更新
            
        }

        private void btDeleat_Click(object sender, EventArgs e)
        {
            if (dgvPersons.CurrentRow == null) return;
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);

            if (listPerson.Count == 0)
            {
                btDeleat.Enabled = false;
                btUpdate.Enabled = false;
            }
        }

        private void Check()
        {
            if (listPerson.Count >= 1)
            {
                if (listPerson == null)
                {
                    btDeleat.Enabled = false;
                    btUpdate.Enabled = false;
                } else
                {
                    btDeleat.Enabled = true;
                    btUpdate.Enabled = true;
                }
            } else
            {
                btDeleat.Enabled = false;
                btUpdate.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btDeleat.Enabled = false;//削除ボタンをマスク
            btUpdate.Enabled = false;//更新ボタン
        }

        private void btPictureClear_Click(object sender, EventArgs e){pbPicture.Image = null;}

        private void textBox3_TextChanged(object sender, EventArgs e){}
        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e){}


    }
}
