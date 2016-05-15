namespace mainProject
{
    partial class Form1
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
            this.lamportBtn = new System.Windows.Forms.Button();
            this.schedualBtn = new System.Windows.Forms.Button();
            this.dekkerBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lamportBtn
            // 
            this.lamportBtn.Location = new System.Drawing.Point(106, 157);
            this.lamportBtn.Name = "lamportBtn";
            this.lamportBtn.Size = new System.Drawing.Size(83, 23);
            this.lamportBtn.TabIndex = 0;
            this.lamportBtn.Text = "lamport";
            this.lamportBtn.UseVisualStyleBackColor = true;
            this.lamportBtn.Click += new System.EventHandler(this.lamportBtn_Click);
            // 
            // schedualBtn
            // 
            this.schedualBtn.Location = new System.Drawing.Point(106, 119);
            this.schedualBtn.Name = "schedualBtn";
            this.schedualBtn.Size = new System.Drawing.Size(83, 23);
            this.schedualBtn.TabIndex = 1;
            this.schedualBtn.Text = "scheduler";
            this.schedualBtn.UseVisualStyleBackColor = true;
            this.schedualBtn.Click += new System.EventHandler(this.schedualBtn_Click);
            // 
            // dekkerBtn
            // 
            this.dekkerBtn.Location = new System.Drawing.Point(106, 81);
            this.dekkerBtn.Name = "dekkerBtn";
            this.dekkerBtn.Size = new System.Drawing.Size(83, 23);
            this.dekkerBtn.TabIndex = 2;
            this.dekkerBtn.Text = "dekker";
            this.dekkerBtn.UseVisualStyleBackColor = true;
            this.dekkerBtn.Click += new System.EventHandler(this.dekkerBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.dekkerBtn);
            this.Controls.Add(this.schedualBtn);
            this.Controls.Add(this.lamportBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lamportBtn;
        private System.Windows.Forms.Button schedualBtn;
        private System.Windows.Forms.Button dekkerBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

