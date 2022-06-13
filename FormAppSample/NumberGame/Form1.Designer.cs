
namespace NumberGame
{
    partial class form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inRandom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ 明朝", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(320, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "の中から数字を当ててね(*。*)=b";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(246, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 107);
            this.button1.TabIndex = 1;
            this.button1.Text = "入力";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ 明朝", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(683, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "がんば";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inRandom
            // 
            this.inRandom.Font = new System.Drawing.Font("ＭＳ 明朝", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inRandom.Location = new System.Drawing.Point(155, 252);
            this.inRandom.Name = "inRandom";
            this.inRandom.Size = new System.Drawing.Size(329, 74);
            this.inRandom.TabIndex = 3;
            this.inRandom.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ 明朝", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(35, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "1から";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // maxValue
            // 
            this.maxValue.Font = new System.Drawing.Font("ＭＳ 明朝", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxValue.Location = new System.Drawing.Point(158, 77);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(143, 74);
            this.maxValue.TabIndex = 3;
            this.maxValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxValue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(961, 570);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.inRandom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inRandom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxValue;
    }
}

