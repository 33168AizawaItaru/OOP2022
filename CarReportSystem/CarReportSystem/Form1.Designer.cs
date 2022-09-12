
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Button();
            this.pictureOpen = new System.Windows.Forms.Button();
            this.pictureDeleat = new System.Windows.Forms.Button();
            this.articleSave = new System.Windows.Forms.Button();
            this.articleOpen = new System.Windows.Forms.Button();
            this.articleAdd = new System.Windows.Forms.Button();
            this.articleRevision = new System.Windows.Forms.Button();
            this.articleDeleat = new System.Windows.Forms.Button();
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
            this.infosys202215DataSet = new CarReportSystem.infosys202215DataSet();
            this.carReportDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carReportDBTableAdapter = new CarReportSystem.infosys202215DataSetTableAdapters.CarReportDBTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202215DataSetTableAdapters.TableAdapterManager();
            this.carReportDBBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.carReportDBBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.carReportDBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202215DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingNavigator)).BeginInit();
            this.carReportDBBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(111, 53);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker.TabIndex = 0;
            // 
            // auther
            // 
            this.auther.FormattingEnabled = true;
            this.auther.Location = new System.Drawing.Point(111, 95);
            this.auther.Name = "auther";
            this.auther.Size = new System.Drawing.Size(200, 20);
            this.auther.TabIndex = 1;
            // 
            // toyota
            // 
            this.toyota.AutoSize = true;
            this.toyota.Location = new System.Drawing.Point(111, 143);
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
            this.nissan.Location = new System.Drawing.Point(164, 143);
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
            this.honda.Location = new System.Drawing.Point(217, 143);
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
            this.subaru.Location = new System.Drawing.Point(274, 143);
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
            this.foreignCar.Location = new System.Drawing.Point(332, 143);
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
            this.other.Location = new System.Drawing.Point(385, 143);
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
            this.carName.Location = new System.Drawing.Point(111, 186);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(200, 20);
            this.carName.TabIndex = 8;
            // 
            // report
            // 
            this.report.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.report.Location = new System.Drawing.Point(111, 224);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(409, 131);
            this.report.TabIndex = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(111, 361);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(661, 61);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(778, 389);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(98, 31);
            this.exit.TabIndex = 12;
            this.exit.Text = "終了";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureOpen
            // 
            this.pictureOpen.Location = new System.Drawing.Point(680, 53);
            this.pictureOpen.Name = "pictureOpen";
            this.pictureOpen.Size = new System.Drawing.Size(75, 23);
            this.pictureOpen.TabIndex = 13;
            this.pictureOpen.Text = "開く...";
            this.pictureOpen.UseVisualStyleBackColor = true;
            this.pictureOpen.Click += new System.EventHandler(this.PictureOpen_Click);
            // 
            // pictureDeleat
            // 
            this.pictureDeleat.Location = new System.Drawing.Point(761, 53);
            this.pictureDeleat.Name = "pictureDeleat";
            this.pictureDeleat.Size = new System.Drawing.Size(75, 23);
            this.pictureDeleat.TabIndex = 14;
            this.pictureDeleat.Text = "削除";
            this.pictureDeleat.UseVisualStyleBackColor = true;
            this.pictureDeleat.Click += new System.EventHandler(this.PictureDeleat_Click);
            // 
            // articleSave
            // 
            this.articleSave.Location = new System.Drawing.Point(21, 428);
            this.articleSave.Name = "articleSave";
            this.articleSave.Size = new System.Drawing.Size(75, 34);
            this.articleSave.TabIndex = 16;
            this.articleSave.Text = "保存";
            this.articleSave.UseVisualStyleBackColor = true;
            this.articleSave.Click += new System.EventHandler(this.articleSave_Click);
            // 
            // articleOpen
            // 
            this.articleOpen.Location = new System.Drawing.Point(21, 389);
            this.articleOpen.Name = "articleOpen";
            this.articleOpen.Size = new System.Drawing.Size(75, 33);
            this.articleOpen.TabIndex = 17;
            this.articleOpen.Text = "開く...";
            this.articleOpen.UseVisualStyleBackColor = true;
            this.articleOpen.Click += new System.EventHandler(this.ArticleOpen_Click);
            // 
            // articleAdd
            // 
            this.articleAdd.Location = new System.Drawing.Point(568, 332);
            this.articleAdd.Name = "articleAdd";
            this.articleAdd.Size = new System.Drawing.Size(75, 23);
            this.articleAdd.TabIndex = 18;
            this.articleAdd.Text = "追加";
            this.articleAdd.UseVisualStyleBackColor = true;
            this.articleAdd.Click += new System.EventHandler(this.ArticleAdd_Click);
            // 
            // articleRevision
            // 
            this.articleRevision.Location = new System.Drawing.Point(669, 332);
            this.articleRevision.Name = "articleRevision";
            this.articleRevision.Size = new System.Drawing.Size(75, 23);
            this.articleRevision.TabIndex = 19;
            this.articleRevision.Text = "修正";
            this.articleRevision.UseVisualStyleBackColor = true;
            this.articleRevision.Click += new System.EventHandler(this.articleRevision_Click);
            // 
            // articleDeleat
            // 
            this.articleDeleat.Location = new System.Drawing.Point(773, 332);
            this.articleDeleat.Name = "articleDeleat";
            this.articleDeleat.Size = new System.Drawing.Size(75, 23);
            this.articleDeleat.TabIndex = 20;
            this.articleDeleat.Text = "削除";
            this.articleDeleat.UseVisualStyleBackColor = true;
            this.articleDeleat.Click += new System.EventHandler(this.articleDeleat_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picture.Location = new System.Drawing.Point(579, 94);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(257, 232);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 21;
            this.picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(43, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(42, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(56, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "車名：";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.Location = new System.Drawing.Point(43, 224);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 13);
            this.label.TabIndex = 22;
            this.label.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(30, 361);
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
            this.label5.Location = new System.Drawing.Point(576, 57);
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
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
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
            this.開くToolStripMenuItem.Text = "開く...";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.保存ToolStripMenuItem.Text = "保存...";
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
            // infosys202215DataSet
            // 
            this.infosys202215DataSet.DataSetName = "infosys202215DataSet";
            this.infosys202215DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReportDBBindingSource
            // 
            this.carReportDBBindingSource.DataMember = "CarReportDB";
            this.carReportDBBindingSource.DataSource = this.infosys202215DataSet;
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
            // carReportDBBindingNavigator
            // 
            this.carReportDBBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carReportDBBindingNavigator.BindingSource = this.carReportDBBindingSource;
            this.carReportDBBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carReportDBBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carReportDBBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carReportDBBindingNavigatorSaveItem});
            this.carReportDBBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.carReportDBBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carReportDBBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carReportDBBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carReportDBBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carReportDBBindingNavigator.Name = "carReportDBBindingNavigator";
            this.carReportDBBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carReportDBBindingNavigator.Size = new System.Drawing.Size(891, 25);
            this.carReportDBBindingNavigator.TabIndex = 24;
            this.carReportDBBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 15);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // carReportDBBindingNavigatorSaveItem
            // 
            this.carReportDBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carReportDBBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carReportDBBindingNavigatorSaveItem.Image")));
            this.carReportDBBindingNavigatorSaveItem.Name = "carReportDBBindingNavigatorSaveItem";
            this.carReportDBBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.carReportDBBindingNavigatorSaveItem.Text = "データの保存";
            this.carReportDBBindingNavigatorSaveItem.Click += new System.EventHandler(this.carReportDBBindingNavigatorSaveItem_Click);
            // 
            // carReportDBDataGridView
            // 
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
            this.carReportDBDataGridView.Name = "carReportDBDataGridView";
            this.carReportDBDataGridView.RowTemplate.Height = 21;
            this.carReportDBDataGridView.Size = new System.Drawing.Size(745, 186);
            this.carReportDBDataGridView.TabIndex = 29;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(891, 727);
            this.Controls.Add(this.carReportDBDataGridView);
            this.Controls.Add(this.carReportDBBindingNavigator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.articleDeleat);
            this.Controls.Add(this.articleRevision);
            this.Controls.Add(this.articleAdd);
            this.Controls.Add(this.articleOpen);
            this.Controls.Add(this.articleSave);
            this.Controls.Add(this.pictureDeleat);
            this.Controls.Add(this.pictureOpen);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202215DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingNavigator)).EndInit();
            this.carReportDBBindingNavigator.ResumeLayout(false);
            this.carReportDBBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button pictureOpen;
        private System.Windows.Forms.Button pictureDeleat;
        private System.Windows.Forms.Button articleSave;
        private System.Windows.Forms.Button articleOpen;
        private System.Windows.Forms.Button articleAdd;
        private System.Windows.Forms.Button articleRevision;
        private System.Windows.Forms.Button articleDeleat;
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
        private System.Windows.Forms.BindingNavigator carReportDBBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carReportDBBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView carReportDBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}

