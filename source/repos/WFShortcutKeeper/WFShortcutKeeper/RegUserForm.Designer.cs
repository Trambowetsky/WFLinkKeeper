namespace WFShortcutKeeper
{
    partial class RegUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegUserForm));
            this.RegExitLabel = new System.Windows.Forms.Label();
            this.HeadingPanel = new System.Windows.Forms.Panel();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.loginRegBox = new System.Windows.Forms.TextBox();
            this.passRegBox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.LoadingPicBox = new System.Windows.Forms.PictureBox();
            this.HeadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RegExitLabel
            // 
            this.RegExitLabel.AutoSize = true;
            this.RegExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegExitLabel.Location = new System.Drawing.Point(290, 9);
            this.RegExitLabel.Name = "RegExitLabel";
            this.RegExitLabel.Size = new System.Drawing.Size(18, 17);
            this.RegExitLabel.TabIndex = 0;
            this.RegExitLabel.Text = "X";
            this.RegExitLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RegExitLabel.Click += new System.EventHandler(this.RegExitLabel_Click);
            // 
            // HeadingPanel
            // 
            this.HeadingPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeadingPanel.Controls.Add(this.HeadingLabel);
            this.HeadingPanel.Controls.Add(this.RegExitLabel);
            this.HeadingPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadingPanel.Name = "HeadingPanel";
            this.HeadingPanel.Size = new System.Drawing.Size(319, 100);
            this.HeadingPanel.TabIndex = 1;
            this.HeadingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseDown);
            this.HeadingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseMove);
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadingLabel.Location = new System.Drawing.Point(22, 39);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(274, 31);
            this.HeadingLabel.TabIndex = 2;
            this.HeadingLabel.Text = "Реєстрація аккаунту";
            this.HeadingLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseDown);
            this.HeadingLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseMove);
            // 
            // loginRegBox
            // 
            this.loginRegBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.loginRegBox.Location = new System.Drawing.Point(60, 141);
            this.loginRegBox.Multiline = true;
            this.loginRegBox.Name = "loginRegBox";
            this.loginRegBox.Size = new System.Drawing.Size(186, 35);
            this.loginRegBox.TabIndex = 1;
            this.loginRegBox.Text = "Логін";
            this.loginRegBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passRegBox
            // 
            this.passRegBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passRegBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.passRegBox.Location = new System.Drawing.Point(60, 215);
            this.passRegBox.Multiline = true;
            this.passRegBox.Name = "passRegBox";
            this.passRegBox.Size = new System.Drawing.Size(186, 35);
            this.passRegBox.TabIndex = 2;
            this.passRegBox.Text = "Пароль";
            this.passRegBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.regButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.Location = new System.Drawing.Point(91, 331);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(129, 42);
            this.regButton.TabIndex = 3;
            this.regButton.Text = "Зареєструвати";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // LoadingPicBox
            // 
            this.LoadingPicBox.Image = ((System.Drawing.Image)(resources.GetObject("LoadingPicBox.Image")));
            this.LoadingPicBox.Location = new System.Drawing.Point(105, 266);
            this.LoadingPicBox.Name = "LoadingPicBox";
            this.LoadingPicBox.Size = new System.Drawing.Size(100, 59);
            this.LoadingPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LoadingPicBox.TabIndex = 4;
            this.LoadingPicBox.TabStop = false;
            this.LoadingPicBox.Visible = false;
            // 
            // RegUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(320, 416);
            this.Controls.Add(this.LoadingPicBox);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.passRegBox);
            this.Controls.Add(this.loginRegBox);
            this.Controls.Add(this.HeadingPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegUserForm";
            this.HeadingPanel.ResumeLayout(false);
            this.HeadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegExitLabel;
        private System.Windows.Forms.Panel HeadingPanel;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.TextBox loginRegBox;
        private System.Windows.Forms.TextBox passRegBox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.PictureBox LoadingPicBox;
    }
}