namespace WFShortcutKeeper
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.closeLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.Label();
            this.HeadingPanel = new System.Windows.Forms.Panel();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.LoadingPic = new System.Windows.Forms.PictureBox();
            this.HeadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPic)).BeginInit();
            this.SuspendLayout();
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.Location = new System.Drawing.Point(508, 9);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(21, 20);
            this.closeLabel.TabIndex = 0;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(168, 366);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(191, 38);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Авторизуватися";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.Location = new System.Drawing.Point(165, 419);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(210, 13);
            this.registerLabel.TabIndex = 2;
            this.registerLabel.Text = "Немає аккаунту? Зареєструйтесь";
            this.registerLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // HeadingPanel
            // 
            this.HeadingPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeadingPanel.Controls.Add(this.LogoPicBox);
            this.HeadingPanel.Controls.Add(this.closeLabel);
            this.HeadingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadingPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadingPanel.Name = "HeadingPanel";
            this.HeadingPanel.Size = new System.Drawing.Size(541, 125);
            this.HeadingPanel.TabIndex = 3;
            this.HeadingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseDown);
            this.HeadingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseMove);
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicBox.Image")));
            this.LogoPicBox.Location = new System.Drawing.Point(215, 12);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(105, 91);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicBox.TabIndex = 1;
            this.LogoPicBox.TabStop = false;
            this.LogoPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseDown);
            this.LogoPicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseMove);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logLabel.Location = new System.Drawing.Point(165, 183);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(34, 13);
            this.logLabel.TabIndex = 6;
            this.logLabel.Text = "Логін";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(165, 254);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(45, 13);
            this.passLabel.TabIndex = 7;
            this.passLabel.Text = "Пароль";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(168, 208);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(191, 20);
            this.loginBox.TabIndex = 10;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(168, 279);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(191, 20);
            this.passBox.TabIndex = 11;
            // 
            // LoadingPic
            // 
            this.LoadingPic.Image = ((System.Drawing.Image)(resources.GetObject("LoadingPic.Image")));
            this.LoadingPic.Location = new System.Drawing.Point(230, 305);
            this.LoadingPic.Name = "LoadingPic";
            this.LoadingPic.Size = new System.Drawing.Size(61, 55);
            this.LoadingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LoadingPic.TabIndex = 12;
            this.LoadingPic.TabStop = false;
            this.LoadingPic.Visible = false;
            // 
            // LoginForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.LoadingPic);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.HeadingPanel);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.HeadingPanel.ResumeLayout(false);
            this.HeadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Panel HeadingPanel;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.PictureBox LoadingPic;
    }
}

