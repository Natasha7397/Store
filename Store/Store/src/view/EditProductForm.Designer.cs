namespace Store
{
    partial class EditProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductForm));
            this.InfoLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.productPriceText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.productSellPriceLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productIdText = new System.Windows.Forms.TextBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.webCamBox = new System.Windows.Forms.PictureBox();
            this.webcamButton = new System.Windows.Forms.Button();
            this.scanButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webCamBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(538, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(235, 29);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Информация о товаре";
            this.InfoLabel.Click += new System.EventHandler(this.InfoLabel_Click);
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(11, 42);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(230, 29);
            this.NameText.TabIndex = 1;
            // 
            // productPriceText
            // 
            this.productPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPriceText.Location = new System.Drawing.Point(11, 104);
            this.productPriceText.Multiline = true;
            this.productPriceText.Name = "productPriceText";
            this.productPriceText.Size = new System.Drawing.Size(230, 29);
            this.productPriceText.TabIndex = 2;
            this.productPriceText.TextChanged += new System.EventHandler(this.productPriceText_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(55, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(154, 27);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Наименование:";
            // 
            // productSellPriceLabel
            // 
            this.productSellPriceLabel.AutoSize = true;
            this.productSellPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.productSellPriceLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productSellPriceLabel.Location = new System.Drawing.Point(55, 74);
            this.productSellPriceLabel.Name = "productSellPriceLabel";
            this.productSellPriceLabel.Size = new System.Drawing.Size(149, 27);
            this.productSellPriceLabel.TabIndex = 10;
            this.productSellPriceLabel.Text = "Цена продажи:";
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.Window;
            this.OKButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(60, 211);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(99, 29);
            this.OKButton.TabIndex = 17;
            this.OKButton.Text = "Ок";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.productIdText);
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Controls.Add(this.productIdLabel);
            this.panel1.Controls.Add(this.productPriceText);
            this.panel1.Controls.Add(this.productSellPriceLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.NameText);
            this.panel1.Location = new System.Drawing.Point(531, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 255);
            this.panel1.TabIndex = 18;
            // 
            // productIdText
            // 
            this.productIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productIdText.Location = new System.Drawing.Point(11, 166);
            this.productIdText.Multiline = true;
            this.productIdText.Name = "productIdText";
            this.productIdText.Size = new System.Drawing.Size(230, 29);
            this.productIdText.TabIndex = 12;
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.productIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productIdLabel.Location = new System.Drawing.Point(55, 136);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(78, 27);
            this.productIdLabel.TabIndex = 11;
            this.productIdLabel.Text = "Номер:";
            // 
            // webCamBox
            // 
            this.webCamBox.Location = new System.Drawing.Point(12, 12);
            this.webCamBox.Name = "webCamBox";
            this.webCamBox.Size = new System.Drawing.Size(513, 370);
            this.webCamBox.TabIndex = 19;
            this.webCamBox.TabStop = false;
            // 
            // webcamButton
            // 
            this.webcamButton.BackColor = System.Drawing.SystemColors.Window;
            this.webcamButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.webcamButton.Location = new System.Drawing.Point(531, 317);
            this.webcamButton.Name = "webcamButton";
            this.webcamButton.Size = new System.Drawing.Size(260, 29);
            this.webcamButton.TabIndex = 20;
            this.webcamButton.Text = "Начать сканирование";
            this.webcamButton.UseVisualStyleBackColor = false;
            this.webcamButton.Click += new System.EventHandler(this.webcamButton_Click);
            // 
            // scanButton
            // 
            this.scanButton.BackColor = System.Drawing.SystemColors.Window;
            this.scanButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scanButton.Location = new System.Drawing.Point(531, 353);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(260, 29);
            this.scanButton.TabIndex = 21;
            this.scanButton.Text = "Определить штрих код";
            this.scanButton.UseVisualStyleBackColor = false;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 394);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.webcamButton);
            this.Controls.Add(this.webCamBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoLabel);
            this.Name = "EditProductForm";
            this.ShowIcon = false;
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webCamBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox productPriceText;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label productSellPriceLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.TextBox productIdText;
        private System.Windows.Forms.PictureBox webCamBox;
        private System.Windows.Forms.Button webcamButton;
        private System.Windows.Forms.Button scanButton;
    }
}