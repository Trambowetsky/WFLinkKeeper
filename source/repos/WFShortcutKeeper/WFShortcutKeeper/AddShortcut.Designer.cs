namespace WFShortcutKeeper
{
    partial class AddShortcut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddShortcut));
            this.AddFormPanel = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.AddFormLabel = new System.Windows.Forms.Label();
            this.linkbox = new System.Windows.Forms.TextBox();
            this.descbox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.AddFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFormPanel
            // 
            this.AddFormPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AddFormPanel.Controls.Add(this.ExitLabel);
            this.AddFormPanel.Controls.Add(this.AddFormLabel);
            this.AddFormPanel.Location = new System.Drawing.Point(0, 0);
            this.AddFormPanel.Name = "AddFormPanel";
            this.AddFormPanel.Size = new System.Drawing.Size(311, 58);
            this.AddFormPanel.TabIndex = 0;
            this.AddFormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddFormPanel_MouseDown);
            this.AddFormPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddFormPanel_MouseMove);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Location = new System.Drawing.Point(285, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(14, 13);
            this.ExitLabel.TabIndex = 6;
            this.ExitLabel.Text = "Х";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // AddFormLabel
            // 
            this.AddFormLabel.AutoSize = true;
            this.AddFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFormLabel.Location = new System.Drawing.Point(42, 21);
            this.AddFormLabel.Name = "AddFormLabel";
            this.AddFormLabel.Size = new System.Drawing.Size(236, 20);
            this.AddFormLabel.TabIndex = 0;
            this.AddFormLabel.Text = "Додавання нового посилання";
            this.AddFormLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddFormPanel_MouseDown);
            this.AddFormLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddFormPanel_MouseMove);
            // 
            // linkbox
            // 
            this.linkbox.Location = new System.Drawing.Point(12, 105);
            this.linkbox.Name = "linkbox";
            this.linkbox.Size = new System.Drawing.Size(287, 20);
            this.linkbox.TabIndex = 1;
            // 
            // descbox
            // 
            this.descbox.Location = new System.Drawing.Point(12, 198);
            this.descbox.Name = "descbox";
            this.descbox.Size = new System.Drawing.Size(287, 20);
            this.descbox.TabIndex = 2;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(12, 80);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(63, 13);
            this.urlLabel.TabIndex = 3;
            this.urlLabel.Text = "Посилання";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(12, 167);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(33, 13);
            this.descLabel.TabIndex = 4;
            this.descLabel.Text = "Опис";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(93, 260);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(121, 54);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Зберегти";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddShortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 348);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.descbox);
            this.Controls.Add(this.linkbox);
            this.Controls.Add(this.AddFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddShortcut";
            this.Text = "AddShortcut";
            this.AddFormPanel.ResumeLayout(false);
            this.AddFormPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AddFormPanel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label AddFormLabel;
        private System.Windows.Forms.TextBox linkbox;
        private System.Windows.Forms.TextBox descbox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Button SaveBtn;
    }
}