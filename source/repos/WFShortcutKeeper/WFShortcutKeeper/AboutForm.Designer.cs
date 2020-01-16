namespace WFShortcutKeeper
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.HeadingPanel = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.DevelopLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LinkedInPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinkedInPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadingPanel
            // 
            this.HeadingPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeadingPanel.Controls.Add(this.ExitLabel);
            this.HeadingPanel.Controls.Add(this.HeadingLabel);
            this.HeadingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadingPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadingPanel.Name = "HeadingPanel";
            this.HeadingPanel.Size = new System.Drawing.Size(517, 60);
            this.HeadingPanel.TabIndex = 0;
            this.HeadingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseDown);
            this.HeadingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseMove);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Location = new System.Drawing.Point(491, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(14, 13);
            this.ExitLabel.TabIndex = 1;
            this.ExitLabel.Text = "Х";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadingLabel.Location = new System.Drawing.Point(196, 19);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(125, 25);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Інформація";
            this.HeadingLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseDown);
            this.HeadingLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseMove);
            // 
            // DevelopLabel
            // 
            this.DevelopLabel.AutoSize = true;
            this.DevelopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DevelopLabel.Location = new System.Drawing.Point(86, 120);
            this.DevelopLabel.Name = "DevelopLabel";
            this.DevelopLabel.Size = new System.Drawing.Size(349, 24);
            this.DevelopLabel.TabIndex = 1;
            this.DevelopLabel.Text = "Developed by: Trambovetskyi Oleksandr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "State University of Telecommunications student";
            // 
            // LinkedInPicBox
            // 
            this.LinkedInPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkedInPicBox.Image = ((System.Drawing.Image)(resources.GetObject("LinkedInPicBox.Image")));
            this.LinkedInPicBox.Location = new System.Drawing.Point(137, 218);
            this.LinkedInPicBox.Name = "LinkedInPicBox";
            this.LinkedInPicBox.Size = new System.Drawing.Size(36, 35);
            this.LinkedInPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LinkedInPicBox.TabIndex = 3;
            this.LinkedInPicBox.TabStop = false;
            this.LinkedInPicBox.Click += new System.EventHandler(this.LinkedInPicBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 286);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LinkedInPicBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DevelopLabel);
            this.Controls.Add(this.HeadingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.HeadingPanel.ResumeLayout(false);
            this.HeadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinkedInPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeadingPanel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label DevelopLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox LinkedInPicBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}