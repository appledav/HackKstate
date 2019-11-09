namespace WindowsFormsApp2
{
    partial class Retrieve
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
            this.uxRetrieveButton = new System.Windows.Forms.Button();
            this.uxUrl = new System.Windows.Forms.Label();
            this.uxURLText = new System.Windows.Forms.TextBox();
            this.uxResults = new System.Windows.Forms.TextBox();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uxMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxBack = new System.Windows.Forms.ToolStripMenuItem();
            this.uxExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxRetrieveButton
            // 
            this.uxRetrieveButton.Location = new System.Drawing.Point(12, 37);
            this.uxRetrieveButton.Name = "uxRetrieveButton";
            this.uxRetrieveButton.Size = new System.Drawing.Size(144, 53);
            this.uxRetrieveButton.TabIndex = 0;
            this.uxRetrieveButton.Text = "Retrieve";
            this.uxRetrieveButton.UseVisualStyleBackColor = true;
            this.uxRetrieveButton.Click += new System.EventHandler(this.uxRetrieveButton_Click);
            // 
            // uxUrl
            // 
            this.uxUrl.AutoSize = true;
            this.uxUrl.Location = new System.Drawing.Point(183, 55);
            this.uxUrl.Name = "uxUrl";
            this.uxUrl.Size = new System.Drawing.Size(40, 17);
            this.uxUrl.TabIndex = 1;
            this.uxUrl.Text = "URL:";
            // 
            // uxURLText
            // 
            this.uxURLText.AcceptsReturn = true;
            this.uxURLText.Location = new System.Drawing.Point(229, 52);
            this.uxURLText.Name = "uxURLText";
            this.uxURLText.Size = new System.Drawing.Size(191, 22);
            this.uxURLText.TabIndex = 2;
            // 
            // uxResults
            // 
            this.uxResults.Location = new System.Drawing.Point(12, 106);
            this.uxResults.Multiline = true;
            this.uxResults.Name = "uxResults";
            this.uxResults.Size = new System.Drawing.Size(408, 93);
            this.uxResults.TabIndex = 3;
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(432, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uxMenu
            // 
            this.uxMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxBack,
            this.uxExit});
            this.uxMenu.Name = "uxMenu";
            this.uxMenu.Size = new System.Drawing.Size(60, 24);
            this.uxMenu.Text = "Menu";
            // 
            // uxBack
            // 
            this.uxBack.Name = "uxBack";
            this.uxBack.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.uxBack.Size = new System.Drawing.Size(224, 26);
            this.uxBack.Text = "Back";
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // uxExit
            // 
            this.uxExit.Name = "uxExit";
            this.uxExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.uxExit.Size = new System.Drawing.Size(224, 26);
            this.uxExit.Text = "Exit";
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // Retrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(432, 211);
            this.Controls.Add(this.uxResults);
            this.Controls.Add(this.uxURLText);
            this.Controls.Add(this.uxUrl);
            this.Controls.Add(this.uxRetrieveButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Retrieve";
            this.Text = "Retrieve";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxRetrieveButton;
        private System.Windows.Forms.Label uxUrl;
        private System.Windows.Forms.TextBox uxURLText;
        private System.Windows.Forms.TextBox uxResults;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uxMenu;
        private System.Windows.Forms.ToolStripMenuItem uxBack;
        private System.Windows.Forms.ToolStripMenuItem uxExit;
    }
}