
namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.auther = new System.Windows.Forms.ComboBox();
            this.toyota = new System.Windows.Forms.RadioButton();
            this.nissan = new System.Windows.Forms.RadioButton();
            this.honda = new System.Windows.Forms.RadioButton();
            this.subaru = new System.Windows.Forms.RadioButton();
            this.foreignCar = new System.Windows.Forms.RadioButton();
            this.other = new System.Windows.Forms.RadioButton();
            this.carName = new System.Windows.Forms.ComboBox();
            this.report = new System.Windows.Forms.TextBox();
            this.pictureOpen = new System.Windows.Forms.Button();
            this.pictureDeleat = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.color = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSelect = new System.Windows.Forms.ColorDialog();
            this.carReportDBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.carReportDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202215DataSet = new CarReportSystem.infosys202215DataSet();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSerch = new System.Windows.Forms.Button();
            this.tbSerch = new System.Windows.Forms.TextBox();
            this.carReportDBTableAdapter = new CarReportSystem.infosys202215DataSetTableAdapters.CarReportDBTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202215DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202215DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(111, 37);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker.TabIndex = 0;
            // 
            // auther
            // 
            this.auther.FormattingEnabled = true;
            this.auther.Location = new System.Drawing.Point(111, 79);
            this.auther.Name = "auther";
            this.auther.Size = new System.Drawing.Size(200, 20);
            this.auther.TabIndex = 1;
            // 
            // toyota
            // 
            this.toyota.AutoSize = true;
            this.toyota.Location = new System.Drawing.Point(111, 127);
            this.toyota.Name = "toyota";
            this.toyota.Size = new System.Drawing.Size(47, 16);
            this.toyota.TabIndex = 2;
            this.toyota.TabStop = true;
            this.toyota.Text = "トヨタ";
            this.toyota.UseVisualStyleBackColor = true;
            // 
            // nissan
            // 
            this.nissan.AutoSize = true;
            this.nissan.Location = new System.Drawing.Point(164, 127);
            this.nissan.Name = "nissan";
            this.nissan.Size = new System.Drawing.Size(47, 16);
            this.nissan.TabIndex = 3;
            this.nissan.TabStop = true;
            this.nissan.Text = "日産";
            this.nissan.UseVisualStyleBackColor = true;
            // 
            // honda
            // 
            this.honda.AutoSize = true;
            this.honda.Location = new System.Drawing.Point(217, 127);
            this.honda.Name = "honda";
            this.honda.Size = new System.Drawing.Size(51, 16);
            this.honda.TabIndex = 4;
            this.honda.TabStop = true;
            this.honda.Text = "ホンダ";
            this.honda.UseVisualStyleBackColor = true;
            // 
            // subaru
            // 
            this.subaru.AutoSize = true;
            this.subaru.Location = new System.Drawing.Point(274, 127);
            this.subaru.Name = "subaru";
            this.subaru.Size = new System.Drawing.Size(52, 16);
            this.subaru.TabIndex = 5;
            this.subaru.TabStop = true;
            this.subaru.Text = "スバル";
            this.subaru.UseVisualStyleBackColor = true;
            // 
            // foreignCar
            // 
            this.foreignCar.AutoSize = true;
            this.foreignCar.Location = new System.Drawing.Point(332, 127);
            this.foreignCar.Name = "foreignCar";
            this.foreignCar.Size = new System.Drawing.Size(47, 16);
            this.foreignCar.TabIndex = 6;
            this.foreignCar.TabStop = true;
            this.foreignCar.Text = "外車";
            this.foreignCar.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(385, 127);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(54, 16);
            this.other.TabIndex = 7;
            this.other.TabStop = true;
            this.other.Text = "その他";
            this.other.UseVisualStyleBackColor = true;
            // 
            // carName
            // 
            this.carName.FormattingEnabled = true;
            this.carName.Location = new System.Drawing.Point(111, 170);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(200, 20);
            this.carName.TabIndex = 8;
            // 
            // report
            // 
            this.report.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.report.Location = new System.Drawing.Point(111, 208);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(409, 131);
            this.report.TabIndex = 10;
            // 
            // pictureOpen
            // 
            this.pictureOpen.Location = new System.Drawing.Point(700, 37);
            this.pictureOpen.Name = "pictureOpen";
            this.pictureOpen.Size = new System.Drawing.Size(75, 23);
            this.pictureOpen.TabIndex = 13;
            this.pictureOpen.Text = "開く...";
            this.pictureOpen.UseVisualStyleBackColor = true;
            this.pictureOpen.Click += new System.EventHandler(this.PictureOpen_Click);
            // 
            // pictureDeleat
            // 
            this.pictureDeleat.Location = new System.Drawing.Point(781, 37);
            this.pictureDeleat.Name = "pictureDeleat";
            this.pictureDeleat.Size = new System.Drawing.Size(75, 23);
            this.pictureDeleat.TabIndex = 14;
            this.pictureDeleat.Text = "削除";
            this.pictureDeleat.UseVisualStyleBackColor = true;
            this.pictureDeleat.Click += new System.EventHandler(this.PictureDeleat_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("ＭＳ 明朝", 18F, System.Drawing.FontStyle.Bold);
            this.btUpdate.Location = new System.Drawing.Point(19, 506);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 34);
            this.btUpdate.TabIndex = 16;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("ＭＳ 明朝", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Clear.Location = new System.Drawing.Point(761, 378);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(95, 42);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "クリア";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picture.Location = new System.Drawing.Point(599, 79);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(257, 232);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 21;
            this.picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(43, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(42, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(56, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "車名：";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.Location = new System.Drawing.Point(43, 208);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 13);
            this.label.TabIndex = 22;
            this.label.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(28, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "記事一覧：";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(610, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "画像";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.color,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル(F)";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.開くToolStripMenuItem.Text = "接続";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.保存ToolStripMenuItem.Text = "更新";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // color
            // 
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(119, 22);
            this.color.Text = "色設定...";
            this.color.Click += new System.EventHandler(this.色設定ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // carReportDBDataGridView
            // 
            this.carReportDBDataGridView.AllowUserToAddRows = false;
            this.carReportDBDataGridView.AutoGenerateColumns = false;
            this.carReportDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carReportDBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.carReportDBDataGridView.DataSource = this.carReportDBBindingSource;
            this.carReportDBDataGridView.Location = new System.Drawing.Point(111, 442);
            this.carReportDBDataGridView.MultiSelect = false;
            this.carReportDBDataGridView.Name = "carReportDBDataGridView";
            this.carReportDBDataGridView.RowTemplate.Height = 21;
            this.carReportDBDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carReportDBDataGridView.Size = new System.Drawing.Size(745, 186);
            this.carReportDBDataGridView.TabIndex = 29;
            this.carReportDBDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.carReportDBDataGridView_DataError);
            this.carReportDBDataGridView.Click += new System.EventHandler(this.carReportDBDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CarName";
            this.dataGridViewTextBoxColumn5.HeaderText = "CarName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // carReportDBBindingSource
            // 
            this.carReportDBBindingSource.DataMember = "CarReportDB";
            this.carReportDBBindingSource.DataSource = this.infosys202215DataSet;
            // 
            // infosys202215DataSet
            // 
            this.infosys202215DataSet.DataSetName = "infosys202215DataSet";
            this.infosys202215DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("ＭＳ 明朝", 18F, System.Drawing.FontStyle.Bold);
            this.btAdd.Location = new System.Drawing.Point(19, 567);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 34);
            this.btAdd.TabIndex = 18;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSerch
            // 
            this.btSerch.Location = new System.Drawing.Point(119, 378);
            this.btSerch.Name = "btSerch";
            this.btSerch.Size = new System.Drawing.Size(75, 23);
            this.btSerch.TabIndex = 31;
            this.btSerch.Text = "名前検索";
            this.btSerch.UseVisualStyleBackColor = true;
            this.btSerch.Click += new System.EventHandler(this.btSerch_Click);
            // 
            // tbSerch
            // 
            this.tbSerch.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSerch.Location = new System.Drawing.Point(217, 374);
            this.tbSerch.Name = "tbSerch";
            this.tbSerch.Size = new System.Drawing.Size(182, 34);
            this.tbSerch.TabIndex = 30;
            // 
            // carReportDBTableAdapter
            // 
            this.carReportDBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportDBTableAdapter = this.carReportDBTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202215DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(874, 727);
            this.Controls.Add(this.btSerch);
            this.Controls.Add(this.tbSerch);
            this.Controls.Add(this.carReportDBDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.pictureDeleat);
            this.Controls.Add(this.pictureOpen);
            this.Controls.Add(this.report);
            this.Controls.Add(this.carName);
            this.Controls.Add(this.other);
            this.Controls.Add(this.foreignCar);
            this.Controls.Add(this.subaru);
            this.Controls.Add(this.honda);
            this.Controls.Add(this.nissan);
            this.Controls.Add(this.toyota);
            this.Controls.Add(this.auther);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202215DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox auther;
        private System.Windows.Forms.RadioButton toyota;
        private System.Windows.Forms.RadioButton nissan;
        private System.Windows.Forms.RadioButton honda;
        private System.Windows.Forms.RadioButton subaru;
        private System.Windows.Forms.RadioButton foreignCar;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.ComboBox carName;
        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.Button pictureOpen;
        private System.Windows.Forms.Button pictureDeleat;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem color;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorSelect;
        private infosys202215DataSet infosys202215DataSet;
        private System.Windows.Forms.BindingSource carReportDBBindingSource;
        private infosys202215DataSetTableAdapters.CarReportDBTableAdapter carReportDBTableAdapter;
        private infosys202215DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSerch;
        private System.Windows.Forms.TextBox tbSerch;
        private System.Windows.Forms.DataGridView carReportDBDataGridView;
    }
}

