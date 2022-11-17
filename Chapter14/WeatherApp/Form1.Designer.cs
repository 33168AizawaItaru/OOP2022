
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
            this.picture = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // WeatherInfo
            // 
            this.WeatherInfo.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WeatherInfo.Location = new System.Drawing.Point(60, 521);
            this.WeatherInfo.Multiline = true;
            this.WeatherInfo.Name = "WeatherInfo";
            this.WeatherInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WeatherInfo.Size = new System.Drawing.Size(714, 139);
            this.WeatherInfo.TabIndex = 0;
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(60, 35);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(571, 471);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 3;
            this.picture.TabStop = false;
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
            this.PrefectureList.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrefectureList.FormattingEnabled = true;
            this.PrefectureList.ItemHeight = 16;
            this.PrefectureList.Location = new System.Drawing.Point(671, 310);
            this.PrefectureList.Name = "PrefectureList";
            this.PrefectureList.Size = new System.Drawing.Size(235, 196);
            this.PrefectureList.TabIndex = 5;
            this.PrefectureList.SelectedIndexChanged += new System.EventHandler(this.PrefectureList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 663);
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
            this.Controls.Add(this.picture);
            this.Controls.Add(this.WeatherInfo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WeatherInfo;
        private System.Windows.Forms.PictureBox picture;
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
    }
}

