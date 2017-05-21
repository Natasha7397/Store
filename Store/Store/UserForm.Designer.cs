﻿namespace Store
{
    partial class UserForm
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.YetPasswordLabel = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.YetPasswordText = new System.Windows.Forms.TextBox();
            this.CheckIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.InfoLabel.Location = new System.Drawing.Point(121, 51);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(198, 36);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Регистрация";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LoginLabel.Location = new System.Drawing.Point(37, 121);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(91, 31);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordLabel.Location = new System.Drawing.Point(37, 173);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(107, 31);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // YetPasswordLabel
            // 
            this.YetPasswordLabel.AutoSize = true;
            this.YetPasswordLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YetPasswordLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.YetPasswordLabel.Location = new System.Drawing.Point(37, 222);
            this.YetPasswordLabel.Name = "YetPasswordLabel";
            this.YetPasswordLabel.Size = new System.Drawing.Size(207, 31);
            this.YetPasswordLabel.TabIndex = 3;
            this.YetPasswordLabel.Text = "Пароль еще раз";
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginText.Location = new System.Drawing.Point(256, 121);
            this.LoginText.Multiline = true;
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(195, 31);
            this.LoginText.TabIndex = 4;
            this.LoginText.TextChanged += new System.EventHandler(this.LoginText_TextChanged);
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordText.Location = new System.Drawing.Point(256, 177);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(195, 31);
            this.PasswordText.TabIndex = 5;
            // 
            // YetPasswordText
            // 
            this.YetPasswordText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.YetPasswordText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YetPasswordText.Location = new System.Drawing.Point(256, 226);
            this.YetPasswordText.Multiline = true;
            this.YetPasswordText.Name = "YetPasswordText";
            this.YetPasswordText.PasswordChar = '*';
            this.YetPasswordText.Size = new System.Drawing.Size(195, 30);
            this.YetPasswordText.TabIndex = 6;
            // 
            // CheckIn
            // 
            this.CheckIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckIn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CheckIn.Location = new System.Drawing.Point(127, 283);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(215, 32);
            this.CheckIn.TabIndex = 7;
            this.CheckIn.Text = "Зарегистрироваться";
            this.CheckIn.UseVisualStyleBackColor = true;
            this.CheckIn.Click += new System.EventHandler(this.CheckIn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(471, 357);
            this.Controls.Add(this.CheckIn);
            this.Controls.Add(this.YetPasswordText);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.YetPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.InfoLabel);
            this.Name = "UserForm";
            this.Text = "Пользователь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label YetPasswordLabel;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox YetPasswordText;
        private System.Windows.Forms.Button CheckIn;
    }
}