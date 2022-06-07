
namespace Sample0607
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
            this.tbRamdom = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRamdom
            // 
            this.tbRamdom.BackColor = System.Drawing.SystemColors.Window;
            this.tbRamdom.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbRamdom.Location = new System.Drawing.Point(404, 394);
            this.tbRamdom.Name = "tbRamdom";
            this.tbRamdom.Size = new System.Drawing.Size(374, 117);
            this.tbRamdom.TabIndex = 0;
            this.tbRamdom.Text = "乱数取得";
            this.tbRamdom.UseVisualStyleBackColor = false;
            this.tbRamdom.Click += new System.EventHandler(this.tbRamdom_Click);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("ＭＳ 明朝", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number.Location = new System.Drawing.Point(91, 416);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(211, 74);
            this.number.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ 明朝", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(69, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "最大値";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ 明朝", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(69, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 67);
            this.label2.TabIndex = 2;
            this.label2.Text = "最小値";
            // 
            // numMin
            // 
            this.numMin.Font = new System.Drawing.Font("ＭＳ 明朝", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numMin.Location = new System.Drawing.Point(404, 56);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(336, 74);
            this.numMin.TabIndex = 1;
            // 
            // numMax
            // 
            this.numMax.Font = new System.Drawing.Font("ＭＳ 明朝", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numMax.Location = new System.Drawing.Point(404, 183);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(336, 74);
            this.numMax.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(823, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.number);
            this.Controls.Add(this.tbRamdom);
            this.Name = "Form1";
            this.Text = "乱数アプリ";
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbRamdom;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numMax;
    }
}

