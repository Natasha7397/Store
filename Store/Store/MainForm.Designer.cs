﻿namespace Store
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurveyorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналитикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналитеческийОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.товарнаяНакладнаяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьНаПочтуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счетНаОплатуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьНаПочтуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.документыToolStripMenuItem,
            this.аналитикаToolStripMenuItem,
            this.документыToolStripMenuItem1});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(784, 31);
            this.MenuMain.TabIndex = 0;
            this.MenuMain.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПользователяToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.главнаяToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.главнаяToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.главнаяToolStripMenuItem.Text = "Главная";
            this.главнаяToolStripMenuItem.Click += new System.EventHandler(this.главнаяToolStripMenuItem_Click);
            // 
            // добавитьПользователяToolStripMenuItem
            // 
            this.добавитьПользователяToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.добавитьПользователяToolStripMenuItem.Name = "добавитьПользователяToolStripMenuItem";
            this.добавитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.добавитьПользователяToolStripMenuItem.Text = "Добавить пользователя";
            this.добавитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.добавитьПользователяToolStripMenuItem_Click);
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(269, 28);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductToolStripMenuItem,
            this.PurveyorToolStripMenuItem,
            this.ClientToolStripMenuItem});
            this.документыToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.документыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.документыToolStripMenuItem.Text = "Учет";
            this.документыToolStripMenuItem.Click += new System.EventHandler(this.документыToolStripMenuItem_Click);
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.ProductToolStripMenuItem.Text = "Товары";
            this.ProductToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // PurveyorToolStripMenuItem
            // 
            this.PurveyorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PurveyorToolStripMenuItem.Name = "PurveyorToolStripMenuItem";
            this.PurveyorToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.PurveyorToolStripMenuItem.Text = "Поставщики";
            this.PurveyorToolStripMenuItem.Click += new System.EventHandler(this.PurveyorToolStripMenuItem_Click);
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.ClientToolStripMenuItem.Text = "Клиенты";
            this.ClientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // аналитикаToolStripMenuItem
            // 
            this.аналитикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аналитеческийОтчетToolStripMenuItem,
            this.графикToolStripMenuItem});
            this.аналитикаToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.аналитикаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.аналитикаToolStripMenuItem.Name = "аналитикаToolStripMenuItem";
            this.аналитикаToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.аналитикаToolStripMenuItem.Text = "Аналитика";
            // 
            // аналитеческийОтчетToolStripMenuItem
            // 
            this.аналитеческийОтчетToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.аналитеческийОтчетToolStripMenuItem.Name = "аналитеческийОтчетToolStripMenuItem";
            this.аналитеческийОтчетToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
            this.аналитеческийОтчетToolStripMenuItem.Text = "Аналитеческий отчет";
            // 
            // графикToolStripMenuItem
            // 
            this.графикToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            this.графикToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
            this.графикToolStripMenuItem.Text = "График";
            this.графикToolStripMenuItem.Click += new System.EventHandler(this.графикToolStripMenuItem_Click);
            // 
            // документыToolStripMenuItem1
            // 
            this.документыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарнаяНакладнаяToolStripMenuItem1,
            this.счетНаОплатуToolStripMenuItem1});
            this.документыToolStripMenuItem1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.документыToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.документыToolStripMenuItem1.Name = "документыToolStripMenuItem1";
            this.документыToolStripMenuItem1.Size = new System.Drawing.Size(114, 27);
            this.документыToolStripMenuItem1.Text = "Документы";
            // 
            // товарнаяНакладнаяToolStripMenuItem1
            // 
            this.товарнаяНакладнаяToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сформироватьToolStripMenuItem,
            this.отправитьНаПочтуToolStripMenuItem});
            this.товарнаяНакладнаяToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.товарнаяНакладнаяToolStripMenuItem1.Name = "товарнаяНакладнаяToolStripMenuItem1";
            this.товарнаяНакладнаяToolStripMenuItem1.Size = new System.Drawing.Size(238, 28);
            this.товарнаяНакладнаяToolStripMenuItem1.Text = "Товарная накладная";
            // 
            // сформироватьToolStripMenuItem
            // 
            this.сформироватьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.сформироватьToolStripMenuItem.Name = "сформироватьToolStripMenuItem";
            this.сформироватьToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.сформироватьToolStripMenuItem.Text = "Сформировать";
            this.сформироватьToolStripMenuItem.Click += new System.EventHandler(this.сформироватьToolStripMenuItem_Click);
            // 
            // отправитьНаПочтуToolStripMenuItem
            // 
            this.отправитьНаПочтуToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.отправитьНаПочтуToolStripMenuItem.Name = "отправитьНаПочтуToolStripMenuItem";
            this.отправитьНаПочтуToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.отправитьНаПочтуToolStripMenuItem.Text = "Отправить на почту";
            this.отправитьНаПочтуToolStripMenuItem.Click += new System.EventHandler(this.отправитьНаПочтуToolStripMenuItem_Click);
            // 
            // счетНаОплатуToolStripMenuItem1
            // 
            this.счетНаОплатуToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сформироватьToolStripMenuItem1,
            this.отправитьНаПочтуToolStripMenuItem1});
            this.счетНаОплатуToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.счетНаОплатуToolStripMenuItem1.Name = "счетНаОплатуToolStripMenuItem1";
            this.счетНаОплатуToolStripMenuItem1.Size = new System.Drawing.Size(238, 28);
            this.счетНаОплатуToolStripMenuItem1.Text = "Счет на оплату";
            // 
            // сформироватьToolStripMenuItem1
            // 
            this.сформироватьToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.сформироватьToolStripMenuItem1.Name = "сформироватьToolStripMenuItem1";
            this.сформироватьToolStripMenuItem1.Size = new System.Drawing.Size(251, 28);
            this.сформироватьToolStripMenuItem1.Text = "Сформировать";
            this.сформироватьToolStripMenuItem1.Click += new System.EventHandler(this.сформироватьToolStripMenuItem1_Click);
            // 
            // отправитьНаПочтуToolStripMenuItem1
            // 
            this.отправитьНаПочтуToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.отправитьНаПочтуToolStripMenuItem1.Name = "отправитьНаПочтуToolStripMenuItem1";
            this.отправитьНаПочтуToolStripMenuItem1.Size = new System.Drawing.Size(251, 28);
            this.отправитьНаПочтуToolStripMenuItem1.Text = "Отправить на почту";
            this.отправитьНаПочтуToolStripMenuItem1.Click += new System.EventHandler(this.отправитьНаПочтуToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 533);
            this.Controls.Add(this.MenuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuMain;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurveyorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналитикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналитеческийОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem товарнаяНакладнаяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem счетНаОплатуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитьНаПочтуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem отправитьНаПочтуToolStripMenuItem1;
    }
}