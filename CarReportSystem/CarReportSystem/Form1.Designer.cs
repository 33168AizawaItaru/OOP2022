
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Recorder = new System.Windows.Forms.ComboBox();
            this.Toyota = new System.Windows.Forms.RadioButton();
            this.Nissan = new System.Windows.Forms.RadioButton();
            this.Honda = new System.Windows.Forms.RadioButton();
            this.Subaru = new System.Windows.Forms.RadioButton();
            this.ForeignCar = new System.Windows.Forms.RadioButton();
            this.Other = new System.Windows.Forms.RadioButton();
            this.carName = new System.Windows.Forms.ComboBox();
            this.Report = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.PictureOpen = new System.Windows.Forms.Button();
            this.PictureDeleat = new System.Windows.Forms.Button();
            this.ArticleSave = new System.Windows.Forms.Button();
            this.ArticleOpen = new System.Windows.Forms.Button();
            this.ArticleAdd = new System.Windows.Forms.Button();
            this.ArticleRevision = new System.Windows.Forms.Button();
            this.ArticleDeleat = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(111, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker.TabIndex = 0;
            // 
            // Recorder
            // 
            this.Recorder.FormattingEnabled = true;
            this.Recorder.Location = new System.Drawing.Point(111, 54);
            this.Recorder.Name = "Recorder";
            this.Recorder.Size = new System.Drawing.Size(200, 20);
            this.Recorder.TabIndex = 1;
            // 
            // Toyota
            // 
            this.Toyota.AutoSize = true;
            this.Toyota.Location = new System.Drawing.Point(111, 102);
            this.Toyota.Name = "Toyota";
            this.Toyota.Size = new System.Drawing.Size(47, 16);
            this.Toyota.TabIndex = 2;
            this.Toyota.TabStop = true;
            this.Toyota.Text = "トヨタ";
            this.Toyota.UseVisualStyleBackColor = true;
            // 
            // Nissan
            // 
            this.Nissan.AutoSize = true;
            this.Nissan.Location = new System.Drawing.Point(164, 102);
            this.Nissan.Name = "Nissan";
            this.Nissan.Size = new System.Drawing.Size(47, 16);
            this.Nissan.TabIndex = 3;
            this.Nissan.TabStop = true;
            this.Nissan.Text = "日産";
            this.Nissan.UseVisualStyleBackColor = true;
            // 
            // Honda
            // 
            this.Honda.AutoSize = true;
            this.Honda.Location = new System.Drawing.Point(217, 102);
            this.Honda.Name = "Honda";
            this.Honda.Size = new System.Drawing.Size(51, 16);
            this.Honda.TabIndex = 4;
            this.Honda.TabStop = true;
            this.Honda.Text = "ホンダ";
            this.Honda.UseVisualStyleBackColor = true;
            // 
            // Subaru
            // 
            this.Subaru.AutoSize = true;
            this.Subaru.Location = new System.Drawing.Point(274, 102);
            this.Subaru.Name = "Subaru";
            this.Subaru.Size = new System.Drawing.Size(52, 16);
            this.Subaru.TabIndex = 5;
            this.Subaru.TabStop = true;
            this.Subaru.Text = "スバル";
            this.Subaru.UseVisualStyleBackColor = true;
            // 
            // ForeignCar
            // 
            this.ForeignCar.AutoSize = true;
            this.ForeignCar.Location = new System.Drawing.Point(332, 102);
            this.ForeignCar.Name = "ForeignCar";
            this.ForeignCar.Size = new System.Drawing.Size(47, 16);
            this.ForeignCar.TabIndex = 6;
            this.ForeignCar.TabStop = true;
            this.ForeignCar.Text = "外車";
            this.ForeignCar.UseVisualStyleBackColor = true;
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.Location = new System.Drawing.Point(385, 102);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(54, 16);
            this.Other.TabIndex = 7;
            this.Other.TabStop = true;
            this.Other.Text = "その他";
            this.Other.UseVisualStyleBackColor = true;
            // 
            // carName
            // 
            this.carName.FormattingEnabled = true;
            this.carName.Location = new System.Drawing.Point(111, 145);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(200, 20);
            this.carName.TabIndex = 8;
            // 
            // Report
            // 
            this.Report.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Report.Location = new System.Drawing.Point(111, 183);
            this.Report.Multiline = true;
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(409, 131);
            this.Report.TabIndex = 10;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(111, 320);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 21;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(760, 176);
            this.DataGridView.TabIndex = 11;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(761, 512);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(110, 31);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "終了";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PictureOpen
            // 
            this.PictureOpen.Location = new System.Drawing.Point(680, 12);
            this.PictureOpen.Name = "PictureOpen";
            this.PictureOpen.Size = new System.Drawing.Size(75, 23);
            this.PictureOpen.TabIndex = 13;
            this.PictureOpen.Text = "開く...";
            this.PictureOpen.UseVisualStyleBackColor = true;
            this.PictureOpen.Click += new System.EventHandler(this.PictureOpen_Click);
            // 
            // PictureDeleat
            // 
            this.PictureDeleat.Location = new System.Drawing.Point(761, 12);
            this.PictureDeleat.Name = "PictureDeleat";
            this.PictureDeleat.Size = new System.Drawing.Size(75, 23);
            this.PictureDeleat.TabIndex = 14;
            this.PictureDeleat.Text = "削除";
            this.PictureDeleat.UseVisualStyleBackColor = true;
            this.PictureDeleat.Click += new System.EventHandler(this.PictureDeleat_Click);
            // 
            // ArticleSave
            // 
            this.ArticleSave.Location = new System.Drawing.Point(21, 387);
            this.ArticleSave.Name = "ArticleSave";
            this.ArticleSave.Size = new System.Drawing.Size(75, 34);
            this.ArticleSave.TabIndex = 16;
            this.ArticleSave.Text = "保存";
            this.ArticleSave.UseVisualStyleBackColor = true;
            // 
            // ArticleOpen
            // 
            this.ArticleOpen.Location = new System.Drawing.Point(21, 348);
            this.ArticleOpen.Name = "ArticleOpen";
            this.ArticleOpen.Size = new System.Drawing.Size(75, 33);
            this.ArticleOpen.TabIndex = 17;
            this.ArticleOpen.Text = "開く...";
            this.ArticleOpen.UseVisualStyleBackColor = true;
            this.ArticleOpen.Click += new System.EventHandler(this.ArticleOpen_Click);
            // 
            // ArticleAdd
            // 
            this.ArticleAdd.Location = new System.Drawing.Point(568, 291);
            this.ArticleAdd.Name = "ArticleAdd";
            this.ArticleAdd.Size = new System.Drawing.Size(75, 23);
            this.ArticleAdd.TabIndex = 18;
            this.ArticleAdd.Text = "追加";
            this.ArticleAdd.UseVisualStyleBackColor = true;
            this.ArticleAdd.Click += new System.EventHandler(this.ArticleAdd_Click);
            // 
            // ArticleRevision
            // 
            this.ArticleRevision.Location = new System.Drawing.Point(669, 291);
            this.ArticleRevision.Name = "ArticleRevision";
            this.ArticleRevision.Size = new System.Drawing.Size(75, 23);
            this.ArticleRevision.TabIndex = 19;
            this.ArticleRevision.Text = "修正";
            this.ArticleRevision.UseVisualStyleBackColor = true;
            // 
            // ArticleDeleat
            // 
            this.ArticleDeleat.Location = new System.Drawing.Point(773, 291);
            this.ArticleDeleat.Name = "ArticleDeleat";
            this.ArticleDeleat.Size = new System.Drawing.Size(75, 23);
            this.ArticleDeleat.TabIndex = 20;
            this.ArticleDeleat.Text = "削除";
            this.ArticleDeleat.UseVisualStyleBackColor = true;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.Control;
            this.Picture.Location = new System.Drawing.Point(579, 41);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(257, 232);
            this.Picture.TabIndex = 21;
            this.Picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(43, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(42, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(56, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "車名：";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.Location = new System.Drawing.Point(43, 183);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 13);
            this.label.TabIndex = 22;
            this.label.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(30, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "記事一覧：";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 555);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.ArticleDeleat);
            this.Controls.Add(this.ArticleRevision);
            this.Controls.Add(this.ArticleAdd);
            this.Controls.Add(this.ArticleOpen);
            this.Controls.Add(this.ArticleSave);
            this.Controls.Add(this.PictureDeleat);
            this.Controls.Add(this.PictureOpen);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.carName);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.ForeignCar);
            this.Controls.Add(this.Subaru);
            this.Controls.Add(this.Honda);
            this.Controls.Add(this.Nissan);
            this.Controls.Add(this.Toyota);
            this.Controls.Add(this.Recorder);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox Recorder;
        private System.Windows.Forms.RadioButton Toyota;
        private System.Windows.Forms.RadioButton Nissan;
        private System.Windows.Forms.RadioButton Honda;
        private System.Windows.Forms.RadioButton Subaru;
        private System.Windows.Forms.RadioButton ForeignCar;
        private System.Windows.Forms.RadioButton Other;
        private System.Windows.Forms.ComboBox carName;
        private System.Windows.Forms.TextBox Report;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button PictureOpen;
        private System.Windows.Forms.Button PictureDeleat;
        private System.Windows.Forms.Button ArticleSave;
        private System.Windows.Forms.Button ArticleOpen;
        private System.Windows.Forms.Button ArticleAdd;
        private System.Windows.Forms.Button ArticleRevision;
        private System.Windows.Forms.Button ArticleDeleat;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

