namespace WindowsFormsApp2
{
    partial class StoreNew
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uxMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxUrlTextBox = new System.Windows.Forms.TextBox();
            this.uxUsernameTextBox = new System.Windows.Forms.TextBox();
            this.uxPasswordTextBox = new System.Windows.Forms.TextBox();
            this.uxStore = new System.Windows.Forms.Button();
            this.uxOpen = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.uxMenuStrip.Size = new System.Drawing.Size(60, 26);
            this.uxMenuStrip.Text = "Menu";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // uxUrlTextBox
            // 
            this.uxUrlTextBox.Location = new System.Drawing.Point(126, 86);
            this.uxUrlTextBox.Name = "uxUrlTextBox";
            this.uxUrlTextBox.Size = new System.Drawing.Size(208, 22);
            this.uxUrlTextBox.TabIndex = 4;
            // 
            // uxUsernameTextBox
            // 
            this.uxUsernameTextBox.Location = new System.Drawing.Point(126, 133);
            this.uxUsernameTextBox.Name = "uxUsernameTextBox";
            this.uxUsernameTextBox.Size = new System.Drawing.Size(208, 22);
            this.uxUsernameTextBox.TabIndex = 5;
            // 
            // uxPasswordTextBox
            // 
            this.uxPasswordTextBox.Location = new System.Drawing.Point(126, 180);
            this.uxPasswordTextBox.Name = "uxPasswordTextBox";
            this.uxPasswordTextBox.Size = new System.Drawing.Size(208, 22);
            this.uxPasswordTextBox.TabIndex = 6;
            // 
            // uxStore
            // 
            this.uxStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStore.Location = new System.Drawing.Point(12, 214);
            this.uxStore.Name = "uxStore";
            this.uxStore.Size = new System.Drawing.Size(357, 60);
            this.uxStore.TabIndex = 7;
            this.uxStore.Text = "Store";
            this.uxStore.UseVisualStyleBackColor = true;
            this.uxStore.Click += new System.EventHandler(this.uxStore_Click);
            // 
            // StoreNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(381, 286);
            this.Controls.Add(this.uxStore);
            this.Controls.Add(this.uxPasswordTextBox);
            this.Controls.Add(this.uxUsernameTextBox);
            this.Controls.Add(this.uxUrlTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StoreNew";
            this.Text = "StoreNew";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxUrlTextBox;
        private System.Windows.Forms.TextBox uxUsernameTextBox;
        private System.Windows.Forms.TextBox uxPasswordTextBox;
        private System.Windows.Forms.Button uxStore;
        private System.Windows.Forms.OpenFileDialog uxOpen;
    }
}