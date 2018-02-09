namespace Mozzie.Excelerator
{
    partial class ParentView
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
            this.parentViewMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.parentViewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // parentViewMenu
            // 
            this.parentViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.parentViewMenu.Location = new System.Drawing.Point(0, 0);
            this.parentViewMenu.Name = "parentViewMenu";
            this.parentViewMenu.Size = new System.Drawing.Size(592, 24);
            this.parentViewMenu.TabIndex = 0;
            this.parentViewMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSpreadsheetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSpreadsheetToolStripMenuItem
            // 
            this.openSpreadsheetToolStripMenuItem.Name = "openSpreadsheetToolStripMenuItem";
            this.openSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.openSpreadsheetToolStripMenuItem.Text = "Open Spreadsheet(s)";
            this.openSpreadsheetToolStripMenuItem.Click += new System.EventHandler(this.openSpreadsheetToolStripMenuItem_Click);
            // 
            // openFilesDialog
            // 
            this.openFilesDialog.Filter = "Excel Workbook|*.xlsx|Legacy Excel Worksheet|*.xls";
            this.openFilesDialog.Multiselect = true;
            // 
            // ParentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.parentViewMenu);
            this.MainMenuStrip = this.parentViewMenu;
            this.Name = "ParentView";
            this.Text = "The Mozzie Excelerator";
            this.parentViewMenu.ResumeLayout(false);
            this.parentViewMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip parentViewMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSpreadsheetToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFilesDialog;
    }
}

