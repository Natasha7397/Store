namespace Store
{
    partial class AuthorizationForm
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
            this.components = new System.ComponentModel.Container();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.Hint2 = new System.Windows.Forms.ToolTip(this.components);
            this.RememberCheck = new System.Windows.Forms.CheckBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.MenuAuthorization = new System.Windows.Forms.MenuStrip();
            this.параметрыПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAuthorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.AutoSize = true;
            this.AuthorizationLabel.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AuthorizationLabel.Location = new System.Drawing.Point(64, 60);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(254, 51);
            this.AuthorizationLabel.TabIndex = 0;
            this.AuthorizationLabel.Text = "Авторизация";
            this.AuthorizationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginLabel.Location = new System.Drawing.Point(26, 130);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(103, 40);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PasswordLabel.Location = new System.Drawing.Point(26, 193);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(125, 40);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.SystemColors.Window;
            this.LoginText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginText.Location = new System.Drawing.Point(155, 138);
            this.LoginText.Multiline = true;
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(192, 32);
            this.LoginText.TabIndex = 3;
            this.Hint.SetToolTip(this.LoginText, "Введите Ваш пароль");
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordText.Location = new System.Drawing.Point(157, 201);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(192, 32);
            this.PasswordText.TabIndex = 4;
            this.Hint2.SetToolTip(this.PasswordText, "Введите Ваш логин");
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // RememberCheck
            // 
            this.RememberCheck.AutoSize = true;
            this.RememberCheck.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RememberCheck.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RememberCheck.Location = new System.Drawing.Point(89, 254);
            this.RememberCheck.Name = "RememberCheck";
            this.RememberCheck.Size = new System.Drawing.Size(187, 30);
            this.RememberCheck.TabIndex = 5;
            this.RememberCheck.Text = "Запомнить  меня";
            this.RememberCheck.UseVisualStyleBackColor = true;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.SystemColors.Window;
            this.SignIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignIn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SignIn.Location = new System.Drawing.Point(113, 290);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(118, 51);
            this.SignIn.TabIndex = 6;
            this.SignIn.Text = "Вход";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // MenuAuthorization
            // 
            this.MenuAuthorization.BackColor = System.Drawing.SystemColors.Window;
            this.MenuAuthorization.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыПодключенияToolStripMenuItem});
            this.MenuAuthorization.Location = new System.Drawing.Point(0, 0);
            this.MenuAuthorization.Name = "MenuAuthorization";
            this.MenuAuthorization.Size = new System.Drawing.Size(382, 31);
            this.MenuAuthorization.TabIndex = 7;
            this.MenuAuthorization.Text = "menuStrip1";
            // 
            // параметрыПодключенияToolStripMenuItem
            // 
            this.параметрыПодключенияToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.параметрыПодключенияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.параметрыПодключенияToolStripMenuItem.Name = "параметрыПодключенияToolStripMenuItem";
            this.параметрыПодключенияToolStripMenuItem.Size = new System.Drawing.Size(227, 27);
            this.параметрыПодключенияToolStripMenuItem.Text = "Параметры подключения";
            this.параметрыПодключенияToolStripMenuItem.Click += new System.EventHandler(this.параметрыПодключенияToolStripMenuItem_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(382, 367);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.RememberCheck);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.AuthorizationLabel);
            this.Controls.Add(this.MenuAuthorization);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.MenuAuthorization;
            this.Name = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.MenuAuthorization.ResumeLayout(false);
            this.MenuAuthorization.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AuthorizationLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.ToolTip Hint2;
        private System.Windows.Forms.CheckBox RememberCheck;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.MenuStrip MenuAuthorization;
        private System.Windows.Forms.ToolStripMenuItem параметрыПодключенияToolStripMenuItem;
    }
}

