namespace Store
{
    partial class ConnectionSettings
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
            this.IPLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortText = new System.Windows.Forms.TextBox();
            this.IPText = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IPLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.IPLabel.Location = new System.Drawing.Point(12, 51);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(184, 30);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "IP подключения";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PortLabel.Location = new System.Drawing.Point(12, 117);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(65, 30);
            this.PortLabel.TabIndex = 1;
            this.PortLabel.Text = "Порт";
            // 
            // PortText
            // 
            this.PortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortText.Location = new System.Drawing.Point(214, 126);
            this.PortText.Multiline = true;
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(161, 21);
            this.PortText.TabIndex = 3;
            // 
            // IPText
            // 
            this.IPText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IPText.Location = new System.Drawing.Point(214, 60);
            this.IPText.Multiline = true;
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(161, 21);
            this.IPText.TabIndex = 4;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.Window;
            this.OKButton.FlatAppearance.BorderSize = 0;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.OKButton.Location = new System.Drawing.Point(127, 153);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(93, 53);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ConnectionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(407, 218);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.IPText);
            this.Controls.Add(this.PortText);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.IPLabel);
            this.Name = "ConnectionSettings";
            this.ShowIcon = false;
            this.Text = "Параметры подключения";
            this.Load += new System.EventHandler(this.ConnectionSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortText;
        private System.Windows.Forms.TextBox IPText;
        private System.Windows.Forms.Button OKButton;
    }
}