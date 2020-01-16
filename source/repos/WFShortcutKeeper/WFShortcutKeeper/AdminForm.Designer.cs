namespace WFShortcutKeeper
{
    partial class AdminForm
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
            this.HeadingPanel = new System.Windows.Forms.Panel();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.AdminDataGrid = new System.Windows.Forms.DataGridView();
            this.AdmDeleteBtn = new System.Windows.Forms.Button();
            this.HeadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadingPanel
            // 
            this.HeadingPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeadingPanel.Controls.Add(this.HeadingLabel);
            this.HeadingPanel.Controls.Add(this.ExitLabel);
            this.HeadingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadingPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadingPanel.Name = "HeadingPanel";
            this.HeadingPanel.Size = new System.Drawing.Size(800, 67);
            this.HeadingPanel.TabIndex = 0;
            this.HeadingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseDown);
            this.HeadingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseMove);
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadingLabel.Location = new System.Drawing.Point(306, 24);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(218, 24);
            this.HeadingLabel.TabIndex = 1;
            this.HeadingLabel.Text = "Панель адміністратора";
            this.HeadingLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseDown);
            this.HeadingLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseMove);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLabel.Location = new System.Drawing.Point(774, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(15, 13);
            this.ExitLabel.TabIndex = 0;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // AdminDataGrid
            // 
            this.AdminDataGrid.AllowUserToAddRows = false;
            this.AdminDataGrid.AllowUserToDeleteRows = false;
            this.AdminDataGrid.AllowUserToResizeColumns = false;
            this.AdminDataGrid.AllowUserToResizeRows = false;
            this.AdminDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdminDataGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AdminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminDataGrid.Location = new System.Drawing.Point(12, 73);
            this.AdminDataGrid.Name = "AdminDataGrid";
            this.AdminDataGrid.ReadOnly = true;
            this.AdminDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.AdminDataGrid.ShowEditingIcon = false;
            this.AdminDataGrid.Size = new System.Drawing.Size(776, 286);
            this.AdminDataGrid.TabIndex = 1;
            // 
            // AdmDeleteBtn
            // 
            this.AdmDeleteBtn.Location = new System.Drawing.Point(324, 366);
            this.AdmDeleteBtn.Name = "AdmDeleteBtn";
            this.AdmDeleteBtn.Size = new System.Drawing.Size(149, 44);
            this.AdmDeleteBtn.TabIndex = 2;
            this.AdmDeleteBtn.Text = "Видалити";
            this.AdmDeleteBtn.UseVisualStyleBackColor = true;
            this.AdmDeleteBtn.Click += new System.EventHandler(this.AdmDeleteBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.AdmDeleteBtn);
            this.Controls.Add(this.AdminDataGrid);
            this.Controls.Add(this.HeadingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.HeadingPanel.ResumeLayout(false);
            this.HeadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeadingPanel;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.DataGridView AdminDataGrid;
        private System.Windows.Forms.Button AdmDeleteBtn;
    }
}