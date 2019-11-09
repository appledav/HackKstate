namespace WindowsFormsApp2
{
    partial class uxMainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxStoreNew = new System.Windows.Forms.Button();
            this.uxRetrieve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the User Account Interface. What would you like to do?\r\n";
            // 
            // uxStoreNew
            // 
            this.uxStoreNew.Location = new System.Drawing.Point(29, 79);
            this.uxStoreNew.Name = "uxStoreNew";
            this.uxStoreNew.Size = new System.Drawing.Size(175, 52);
            this.uxStoreNew.TabIndex = 1;
            this.uxStoreNew.Text = "Store New";
            this.uxStoreNew.UseVisualStyleBackColor = true;
            this.uxStoreNew.Click += new System.EventHandler(this.uxStoreNew_Click);
            // 
            // uxRetrieve
            // 
            this.uxRetrieve.Location = new System.Drawing.Point(282, 79);
            this.uxRetrieve.Name = "uxRetrieve";
            this.uxRetrieve.Size = new System.Drawing.Size(175, 52);
            this.uxRetrieve.TabIndex = 2;
            this.uxRetrieve.Text = "Retrieve";
            this.uxRetrieve.UseVisualStyleBackColor = true;
            this.uxRetrieve.Click += new System.EventHandler(this.uxRetrieve_Click);
            // 
            // uxMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(492, 143);
            this.Controls.Add(this.uxRetrieve);
            this.Controls.Add(this.uxStoreNew);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "uxMainScreen";
            this.Text = "Home Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxStoreNew;
        private System.Windows.Forms.Button uxRetrieve;
    }
}

