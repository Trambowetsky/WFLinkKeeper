namespace WFShortcutKeeper
{
    partial class CutsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CutsForm));
            this.MainFormPanel = new System.Windows.Forms.Panel();
            this.AdmBtn = new System.Windows.Forms.Button();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.MainFormLabel = new System.Windows.Forms.Label();
            this.shortcutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wFShortDBDataSet = new WFShortcutKeeper.WFShortDBDataSet();
            this.shortcutsTableAdapter = new WFShortcutKeeper.WFShortDBDataSetTableAdapters.ShortcutsTableAdapter();
            this.AddBtn = new System.Windows.Forms.Button();
            this.wFShortDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shortcutsDataGrid = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.MainFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wFShortDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wFShortDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormPanel
            // 
            this.MainFormPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainFormPanel.Controls.Add(this.AdmBtn);
            this.MainFormPanel.Controls.Add(this.HelpLabel);
            this.MainFormPanel.Controls.Add(this.ExitLabel);
            this.MainFormPanel.Controls.Add(this.MainFormLabel);
            this.MainFormPanel.Location = new System.Drawing.Point(0, 0);
            this.MainFormPanel.Name = "MainFormPanel";
            this.MainFormPanel.Size = new System.Drawing.Size(801, 66);
            this.MainFormPanel.TabIndex = 0;
            this.MainFormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormPanel_MouseDown);
            this.MainFormPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormPanel_MouseMove);
            // 
            // AdmBtn
            // 
            this.AdmBtn.Location = new System.Drawing.Point(34, 14);
            this.AdmBtn.Name = "AdmBtn";
            this.AdmBtn.Size = new System.Drawing.Size(84, 23);
            this.AdmBtn.TabIndex = 3;
            this.AdmBtn.Text = "Адмін панель";
            this.AdmBtn.UseVisualStyleBackColor = true;
            this.AdmBtn.Visible = false;
            this.AdmBtn.Click += new System.EventHandler(this.AdmBtn_Click);
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpLabel.Location = new System.Drawing.Point(12, 17);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(16, 16);
            this.HelpLabel.TabIndex = 2;
            this.HelpLabel.Text = "?";
            this.HelpLabel.Click += new System.EventHandler(this.HelpLabel_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLabel.Location = new System.Drawing.Point(768, 9);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(20, 24);
            this.ExitLabel.TabIndex = 1;
            this.ExitLabel.Text = "х";
            this.ExitLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // MainFormLabel
            // 
            this.MainFormLabel.AutoSize = true;
            this.MainFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainFormLabel.Location = new System.Drawing.Point(325, 24);
            this.MainFormLabel.Name = "MainFormLabel";
            this.MainFormLabel.Size = new System.Drawing.Size(156, 25);
            this.MainFormLabel.TabIndex = 0;
            this.MainFormLabel.Text = "Головне меню";
            this.MainFormLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormPanel_MouseDown);
            this.MainFormLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormPanel_MouseMove);
            // 
            // shortcutsBindingSource
            // 
            this.shortcutsBindingSource.DataMember = "Shortcuts";
            this.shortcutsBindingSource.DataSource = this.wFShortDBDataSet;
            // 
            // wFShortDBDataSet
            // 
            this.wFShortDBDataSet.DataSetName = "WFShortDBDataSet";
            this.wFShortDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shortcutsTableAdapter
            // 
            this.shortcutsTableAdapter.ClearBeforeFill = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(55, 392);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(116, 37);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Додати";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // wFShortDBDataSetBindingSource
            // 
            this.wFShortDBDataSetBindingSource.DataSource = this.wFShortDBDataSet;
            this.wFShortDBDataSetBindingSource.Position = 0;
            // 
            // shortcutsDataGrid
            // 
            this.shortcutsDataGrid.AllowUserToAddRows = false;
            this.shortcutsDataGrid.AllowUserToDeleteRows = false;
            this.shortcutsDataGrid.AllowUserToResizeColumns = false;
            this.shortcutsDataGrid.AllowUserToResizeRows = false;
            this.shortcutsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shortcutsDataGrid.BackgroundColor = System.Drawing.Color.Honeydew;
            this.shortcutsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.shortcutsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.shortcutsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shortcutsDataGrid.Location = new System.Drawing.Point(12, 72);
            this.shortcutsDataGrid.Name = "shortcutsDataGrid";
            this.shortcutsDataGrid.ReadOnly = true;
            this.shortcutsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.shortcutsDataGrid.Size = new System.Drawing.Size(776, 305);
            this.shortcutsDataGrid.TabIndex = 4;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(330, 392);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(116, 37);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Видалити";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(623, 392);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(116, 37);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "Редагувати";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // CutsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 441);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.shortcutsDataGrid);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.MainFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CutsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CutsForm";
            this.Load += new System.EventHandler(this.CutsForm_Load);
            this.MainFormPanel.ResumeLayout(false);
            this.MainFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wFShortDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wFShortDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainFormPanel;
        private System.Windows.Forms.Label MainFormLabel;
        private System.Windows.Forms.Label ExitLabel;
        private WFShortDBDataSet wFShortDBDataSet;
        private System.Windows.Forms.BindingSource shortcutsBindingSource;
        private WFShortDBDataSetTableAdapters.ShortcutsTableAdapter shortcutsTableAdapter;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.BindingSource wFShortDBDataSetBindingSource;
        private System.Windows.Forms.DataGridView shortcutsDataGrid;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Button AdmBtn;
    }
}