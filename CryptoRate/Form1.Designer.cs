namespace CryptoRate
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.binanceData = new System.Windows.Forms.Label();
            this.bybitData = new System.Windows.Forms.Label();
            this.kucoinData = new System.Windows.Forms.Label();
            this.bitgetData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bybit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kucoin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bitget:";
            // 
            // binanceData
            // 
            this.binanceData.AutoSize = true;
            this.binanceData.Location = new System.Drawing.Point(68, 70);
            this.binanceData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.binanceData.Name = "binanceData";
            this.binanceData.Size = new System.Drawing.Size(64, 13);
            this.binanceData.TabIndex = 8;
            this.binanceData.Text = "нет данных";
            // 
            // bybitData
            // 
            this.bybitData.AutoSize = true;
            this.bybitData.Location = new System.Drawing.Point(64, 100);
            this.bybitData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bybitData.Name = "bybitData";
            this.bybitData.Size = new System.Drawing.Size(64, 13);
            this.bybitData.TabIndex = 9;
            this.bybitData.Text = "нет данных";
            // 
            // kucoinData
            // 
            this.kucoinData.AutoSize = true;
            this.kucoinData.Location = new System.Drawing.Point(64, 128);
            this.kucoinData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kucoinData.Name = "kucoinData";
            this.kucoinData.Size = new System.Drawing.Size(64, 13);
            this.kucoinData.TabIndex = 10;
            this.kucoinData.Text = "нет данных";
            // 
            // bitgetData
            // 
            this.bitgetData.AutoSize = true;
            this.bitgetData.Location = new System.Drawing.Point(64, 159);
            this.bitgetData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bitgetData.Name = "bitgetData";
            this.bitgetData.Size = new System.Drawing.Size(64, 13);
            this.bitgetData.TabIndex = 11;
            this.bitgetData.Text = "нет данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(78, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "BTCUSDT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bitgetData);
            this.Controls.Add(this.kucoinData);
            this.Controls.Add(this.bybitData);
            this.Controls.Add(this.binanceData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "CryptoRate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label binanceData;
        private System.Windows.Forms.Label bybitData;
        private System.Windows.Forms.Label kucoinData;
        private System.Windows.Forms.Label bitgetData;
        private System.Windows.Forms.Label label2;
    }
}

