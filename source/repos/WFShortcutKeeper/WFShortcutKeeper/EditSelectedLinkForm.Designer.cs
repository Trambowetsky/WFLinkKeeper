namespace WFShortcutKeeper
{
    partial class EditSelectedLinkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSelectedLinkForm));
            this.headingPanel = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.EditingNameLabel = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.RichTextBox();
            this.DescTextBox = new System.Windows.Forms.RichTextBox();
            this.EditSaveChangesBtn = new System.Windows.Forms.Button();
            this.urlLabel = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.headingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headingPanel
            // 
            this.headingPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.headingPanel.Controls.Add(this.ExitLabel);
            this.headingPanel.Controls.Add(this.EditingNameLabel);
            this.headingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headingPanel.Location = new System.Drawing.Point(0, 0);
            this.headingPanel.Name = "headingPanel";
            this.headingPanel.Size = new System.Drawing.Size(677, 54);
            this.headingPanel.TabIndex = 0;
            this.headingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseDown);
            this.headingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseMove);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Location = new System.Drawing.Point(651, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(14, 13);
            this.ExitLabel.TabIndex = 1;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // EditingNameLabel
            // 
            this.EditingNameLabel.AutoSize = true;
            this.EditingNameLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.EditingNameLabel.Location = new System.Drawing.Point(228, 18);
            this.EditingNameLabel.Name = "EditingNameLabel";
            this.EditingNameLabel.Size = new System.Drawing.Size(226, 23);
            this.EditingNameLabel.TabIndex = 0;
            this.EditingNameLabel.Text = "Редагування посилання";
            this.EditingNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseDown);
            this.EditingNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseMove);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UrlTextBox.Location = new System.Drawing.Point(29, 90);
            this.UrlTextBox.Multiline = false;
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.UrlTextBox.Size = new System.Drawing.Size(619, 33);
            this.UrlTextBox.TabIndex = 1;
            this.UrlTextBox.Text = "";
            // 
            // DescTextBox
            // 
            this.DescTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescTextBox.Location = new System.Drawing.Point(29, 166);
            this.DescTextBox.Multiline = false;
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.DescTextBox.Size = new System.Drawing.Size(619, 33);
            this.DescTextBox.TabIndex = 2;
            this.DescTextBox.Text = "";
            // 
            // EditSaveChangesBtn
            // 
            this.EditSaveChangesBtn.Location = new System.Drawing.Point(279, 216);
            this.EditSaveChangesBtn.Name = "EditSaveChangesBtn";
            this.EditSaveChangesBtn.Size = new System.Drawing.Size(115, 40);
            this.EditSaveChangesBtn.TabIndex = 3;
            this.EditSaveChangesBtn.Text = "Зберегти";
            this.EditSaveChangesBtn.UseVisualStyleBackColor = true;
            this.EditSaveChangesBtn.Click += new System.EventHandler(this.EditSaveChangesBtn_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.urlLabel.Location = new System.Drawing.Point(26, 69);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(85, 18);
            this.urlLabel.TabIndex = 4;
            this.urlLabel.Text = "Посилання";
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescLabel.Location = new System.Drawing.Point(26, 145);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(44, 18);
            this.DescLabel.TabIndex = 5;
            this.DescLabel.Text = "Опис";
            // 
            // EditSelectedLinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 268);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.EditSaveChangesBtn);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.headingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditSelectedLinkForm";
            this.Text = "EditSelectedLinkForm";
            this.Load += new System.EventHandler(this.EditSelectedLinkForm_Load);
            this.headingPanel.ResumeLayout(false);
            this.headingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headingPanel;
        private System.Windows.Forms.Label EditingNameLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.RichTextBox UrlTextBox;
        private System.Windows.Forms.RichTextBox DescTextBox;
        private System.Windows.Forms.Button EditSaveChangesBtn;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label DescLabel;
    }
}