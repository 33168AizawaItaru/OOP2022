
namespace WeatherApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WeatherInfo = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.hokkaido = new System.Windows.Forms.Button();
            this.tohoku = new System.Windows.Forms.Button();
            this.kantokosinetu = new System.Windows.Forms.Button();
            this.tokai = new System.Windows.Forms.Button();
            this.hokuriku = new System.Windows.Forms.Button();
            this.kinki = new System.Windows.Forms.Button();
            this.sikoku = new System.Windows.Forms.Button();
            this.okinawa = new System.Windows.Forms.Button();
            this.kyusyu = new System.Windows.Forms.Button();
            this.tyugoku = new System.Windows.Forms.Button();
            this.PrefectureList = new System.Windows.Forms.ListBox();
            this.today = new System.Windows.Forms.PictureBox();
            this.tomorrow = new System.Windows.Forms.PictureBox();
            this.dayAfterTomorrow = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.today)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayAfterTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WeatherInfo
            // 
            this.WeatherInfo.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WeatherInfo.Location = new System.Drawing.Point(60, 521);
            this.WeatherInfo.Multiline = true;
            this.WeatherInfo.Name = "WeatherInfo";
            this.WeatherInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WeatherInfo.Size = new System.Drawing.Size(707, 139);
            this.WeatherInfo.TabIndex = 0;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(60, 35);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(571, 471);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 3;
            this.Picture.TabStop = false;
            // 
            // hokkaido
            // 
            this.hokkaido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hokkaido.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hokkaido.Location = new System.Drawing.Point(313, 69);
            this.hokkaido.Name = "hokkaido";
            this.hokkaido.Size = new System.Drawing.Size(103, 26);
            this.hokkaido.TabIndex = 4;
            this.hokkaido.Text = "北海道地方";
            this.hokkaido.UseVisualStyleBackColor = true;
            this.hokkaido.Click += new System.EventHandler(this.hokkaido_Click);
            // 
            // tohoku
            // 
            this.tohoku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tohoku.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tohoku.Location = new System.Drawing.Point(451, 256);
            this.tohoku.Name = "tohoku";
            this.tohoku.Size = new System.Drawing.Size(86, 26);
            this.tohoku.TabIndex = 4;
            this.tohoku.Text = "東北地方";
            this.tohoku.UseVisualStyleBackColor = true;
            this.tohoku.Click += new System.EventHandler(this.tohoku_Click);
            // 
            // kantokosinetu
            // 
            this.kantokosinetu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kantokosinetu.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kantokosinetu.Location = new System.Drawing.Point(429, 335);
            this.kantokosinetu.Name = "kantokosinetu";
            this.kantokosinetu.Size = new System.Drawing.Size(114, 27);
            this.kantokosinetu.TabIndex = 4;
            this.kantokosinetu.Text = "関東甲信地方";
            this.kantokosinetu.UseVisualStyleBackColor = true;
            this.kantokosinetu.Click += new System.EventHandler(this.kantokosinetu_Click);
            // 
            // tokai
            // 
            this.tokai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tokai.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tokai.Location = new System.Drawing.Point(313, 394);
            this.tokai.Name = "tokai";
            this.tokai.Size = new System.Drawing.Size(84, 26);
            this.tokai.TabIndex = 4;
            this.tokai.Text = "東海地方";
            this.tokai.UseVisualStyleBackColor = true;
            this.tokai.Click += new System.EventHandler(this.tokai_Click);
            // 
            // hokuriku
            // 
            this.hokuriku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hokuriku.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hokuriku.Location = new System.Drawing.Point(258, 251);
            this.hokuriku.Name = "hokuriku";
            this.hokuriku.Size = new System.Drawing.Size(86, 26);
            this.hokuriku.TabIndex = 4;
            this.hokuriku.Text = "北陸地方";
            this.hokuriku.UseVisualStyleBackColor = true;
            this.hokuriku.Click += new System.EventHandler(this.hokuriku_Click);
            // 
            // kinki
            // 
            this.kinki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kinki.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kinki.Location = new System.Drawing.Point(212, 293);
            this.kinki.Name = "kinki";
            this.kinki.Size = new System.Drawing.Size(82, 25);
            this.kinki.TabIndex = 4;
            this.kinki.Text = "近畿地方";
            this.kinki.UseVisualStyleBackColor = true;
            this.kinki.Click += new System.EventHandler(this.kinki_Click);
            // 
            // sikoku
            // 
            this.sikoku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sikoku.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sikoku.Location = new System.Drawing.Point(187, 438);
            this.sikoku.Name = "sikoku";
            this.sikoku.Size = new System.Drawing.Size(89, 24);
            this.sikoku.TabIndex = 4;
            this.sikoku.Text = "四国地方";
            this.sikoku.UseVisualStyleBackColor = true;
            this.sikoku.Click += new System.EventHandler(this.sikoku_Click);
            // 
            // okinawa
            // 
            this.okinawa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okinawa.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.okinawa.Location = new System.Drawing.Point(379, 458);
            this.okinawa.Name = "okinawa";
            this.okinawa.Size = new System.Drawing.Size(111, 28);
            this.okinawa.TabIndex = 4;
            this.okinawa.Text = "沖縄地方";
            this.okinawa.UseVisualStyleBackColor = true;
            this.okinawa.Click += new System.EventHandler(this.okinawa_Click);
            // 
            // kyusyu
            // 
            this.kyusyu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kyusyu.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kyusyu.Location = new System.Drawing.Point(26, 443);
            this.kyusyu.Name = "kyusyu";
            this.kyusyu.Size = new System.Drawing.Size(87, 25);
            this.kyusyu.TabIndex = 4;
            this.kyusyu.Text = "九州地方";
            this.kyusyu.UseVisualStyleBackColor = true;
            this.kyusyu.Click += new System.EventHandler(this.kyusyu_Click);
            // 
            // tyugoku
            // 
            this.tyugoku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tyugoku.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tyugoku.Location = new System.Drawing.Point(109, 321);
            this.tyugoku.Name = "tyugoku";
            this.tyugoku.Size = new System.Drawing.Size(86, 24);
            this.tyugoku.TabIndex = 4;
            this.tyugoku.Text = "中国地方";
            this.tyugoku.UseVisualStyleBackColor = true;
            this.tyugoku.Click += new System.EventHandler(this.tyugoku_Click);
            // 
            // PrefectureList
            // 
            this.PrefectureList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PrefectureList.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrefectureList.FormattingEnabled = true;
            this.PrefectureList.ItemHeight = 16;
            this.PrefectureList.Location = new System.Drawing.Point(669, 35);
            this.PrefectureList.Name = "PrefectureList";
            this.PrefectureList.Size = new System.Drawing.Size(235, 196);
            this.PrefectureList.TabIndex = 5;
            this.PrefectureList.SelectedIndexChanged += new System.EventHandler(this.PrefectureList_SelectedIndexChanged);
            // 
            // today
            // 
            this.today.BackColor = System.Drawing.Color.Transparent;
            this.today.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.today.Location = new System.Drawing.Point(550, 406);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(100, 100);
            this.today.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.today.TabIndex = 6;
            this.today.TabStop = false;
            // 
            // tomorrow
            // 
            this.tomorrow.BackColor = System.Drawing.Color.Transparent;
            this.tomorrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tomorrow.Location = new System.Drawing.Point(677, 406);
            this.tomorrow.Name = "tomorrow";
            this.tomorrow.Size = new System.Drawing.Size(100, 100);
            this.tomorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tomorrow.TabIndex = 6;
            this.tomorrow.TabStop = false;
            // 
            // dayAfterTomorrow
            // 
            this.dayAfterTomorrow.BackColor = System.Drawing.Color.Transparent;
            this.dayAfterTomorrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayAfterTomorrow.Location = new System.Drawing.Point(804, 406);
            this.dayAfterTomorrow.Name = "dayAfterTomorrow";
            this.dayAfterTomorrow.Size = new System.Drawing.Size(100, 100);
            this.dayAfterTomorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dayAfterTomorrow.TabIndex = 6;
            this.dayAfterTomorrow.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(550, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "今日";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(677, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "明日";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(804, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "明後日";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(773, 521);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayAfterTomorrow);
            this.Controls.Add(this.tomorrow);
            this.Controls.Add(this.today);
            this.Controls.Add(this.PrefectureList);
            this.Controls.Add(this.kyusyu);
            this.Controls.Add(this.okinawa);
            this.Controls.Add(this.sikoku);
            this.Controls.Add(this.tyugoku);
            this.Controls.Add(this.kinki);
            this.Controls.Add(this.hokuriku);
            this.Controls.Add(this.tokai);
            this.Controls.Add(this.kantokosinetu);
            this.Controls.Add(this.tohoku);
            this.Controls.Add(this.hokkaido);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.WeatherInfo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "三日間の天気予報";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.today)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayAfterTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WeatherInfo;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button hokkaido;
        private System.Windows.Forms.Button tohoku;
        private System.Windows.Forms.Button kantokosinetu;
        private System.Windows.Forms.Button tokai;
        private System.Windows.Forms.Button hokuriku;
        private System.Windows.Forms.Button kinki;
        private System.Windows.Forms.Button sikoku;
        private System.Windows.Forms.Button okinawa;
        private System.Windows.Forms.Button kyusyu;
        private System.Windows.Forms.Button tyugoku;
        private System.Windows.Forms.ListBox PrefectureList;
        private System.Windows.Forms.PictureBox today;
        private System.Windows.Forms.PictureBox tomorrow;
        private System.Windows.Forms.PictureBox dayAfterTomorrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

