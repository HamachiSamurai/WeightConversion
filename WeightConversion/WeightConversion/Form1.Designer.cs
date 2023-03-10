namespace WeightConversion
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
            this.conversionButton = new System.Windows.Forms.Button();
            this.kgTextBox = new System.Windows.Forms.TextBox();
            this.lbTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // conversionButton
            // 
            this.conversionButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.conversionButton.Location = new System.Drawing.Point(92, 288);
            this.conversionButton.Name = "conversionButton";
            this.conversionButton.Size = new System.Drawing.Size(206, 67);
            this.conversionButton.TabIndex = 0;
            this.conversionButton.Text = "マッスルマジック\r\n(重量変換)";
            this.conversionButton.UseVisualStyleBackColor = true;
            this.conversionButton.Click += new System.EventHandler(this.ConversionButtonClicked);
            // 
            // kgTextBox
            // 
            this.kgTextBox.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kgTextBox.Location = new System.Drawing.Point(92, 104);
            this.kgTextBox.Multiline = true;
            this.kgTextBox.Name = "kgTextBox";
            this.kgTextBox.Size = new System.Drawing.Size(319, 64);
            this.kgTextBox.TabIndex = 1;
            this.kgTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTextBox
            // 
            this.lbTextBox.Enabled = false;
            this.lbTextBox.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTextBox.Location = new System.Drawing.Point(92, 197);
            this.lbTextBox.Multiline = true;
            this.lbTextBox.Name = "lbTextBox";
            this.lbTextBox.Size = new System.Drawing.Size(319, 69);
            this.lbTextBox.TabIndex = 2;
            this.lbTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "kg";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(22, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 61);
            this.label2.TabIndex = 4;
            this.label2.Text = "lb";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 61);
            this.label3.TabIndex = 5;
            this.label3.Text = "脳筋御用達重量変換機";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(317, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "リセット";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ResetButtonClicked);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(454, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 321);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTextBox);
            this.Controls.Add(this.kgTextBox);
            this.Controls.Add(this.conversionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conversionButton;
        private System.Windows.Forms.TextBox kgTextBox;
        private System.Windows.Forms.TextBox lbTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

