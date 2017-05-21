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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.Hint2 = new System.Windows.Forms.ToolTip(this.components);
            this.RememberCheck = new System.Windows.Forms.CheckBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.AutoSize = true;
            this.AuthorizationLabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AuthorizationLabel.Location = new System.Drawing.Point(63, 35);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(239, 42);
            this.AuthorizationLabel.TabIndex = 0;
            this.AuthorizationLabel.Text = "Авторизация";
            this.AuthorizationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LoginLabel.Location = new System.Drawing.Point(26, 111);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(97, 32);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordLabel.Location = new System.Drawing.Point(26, 180);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(113, 32);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginText.Location = new System.Drawing.Point(155, 111);
            this.LoginText.Multiline = true;
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(192, 32);
            this.LoginText.TabIndex = 3;
            this.Hint.SetToolTip(this.LoginText, "Введите Ваш пароль");
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordText.Location = new System.Drawing.Point(155, 180);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(192, 32);
            this.PasswordText.TabIndex = 4;
            this.Hint2.SetToolTip(this.PasswordText, "Введите Ваш логин");
            // 
            // RememberCheck
            // 
            this.RememberCheck.AutoSize = true;
            this.RememberCheck.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RememberCheck.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RememberCheck.Location = new System.Drawing.Point(93, 245);
            this.RememberCheck.Name = "RememberCheck";
            this.RememberCheck.Size = new System.Drawing.Size(165, 25);
            this.RememberCheck.TabIndex = 5;
            this.RememberCheck.Text = "Запомнить  меня";
            this.RememberCheck.UseVisualStyleBackColor = true;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignIn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignIn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SignIn.Location = new System.Drawing.Point(125, 287);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(107, 37);
            this.SignIn.TabIndex = 6;
            this.SignIn.Text = "Вход";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(382, 384);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.RememberCheck);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.AuthorizationLabel);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
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
    }
}

