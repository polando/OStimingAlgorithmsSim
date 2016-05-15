namespace DekkerProject
{
    partial class FormMain
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
            this.resourceCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dvResource = new System.Windows.Forms.DataGridView();
            this.resourceDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveRes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inf = new System.Windows.Forms.Label();
            this.addProcessBtn = new System.Windows.Forms.Button();
            this.processDGV = new System.Windows.Forms.DataGridView();
            this.processNameInDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runBtn = new System.Windows.Forms.Button();
            this.runDGV = new System.Windows.Forms.DataGridView();
            this.Discriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvResource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resourceCreate
            // 
            this.resourceCreate.Location = new System.Drawing.Point(232, 29);
            this.resourceCreate.Name = "resourceCreate";
            this.resourceCreate.Size = new System.Drawing.Size(70, 31);
            this.resourceCreate.TabIndex = 0;
            this.resourceCreate.Text = "create";
            this.resourceCreate.UseVisualStyleBackColor = true;
            this.resourceCreate.Click += new System.EventHandler(this.resourceCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "number of resources";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(149, 34);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 23);
            this.numericUpDown1.TabIndex = 4;
            // 
            // dvResource
            // 
            this.dvResource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvResource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resourceDV,
            this.amountDV});
            this.dvResource.Location = new System.Drawing.Point(32, 63);
            this.dvResource.Name = "dvResource";
            this.dvResource.Size = new System.Drawing.Size(314, 141);
            this.dvResource.TabIndex = 6;
            // 
            // resourceDV
            // 
            this.resourceDV.HeaderText = "resource";
            this.resourceDV.Name = "resourceDV";
            this.resourceDV.ReadOnly = true;
            // 
            // amountDV
            // 
            this.amountDV.HeaderText = "amount";
            this.amountDV.Name = "amountDV";
            // 
            // saveRes
            // 
            this.saveRes.Enabled = false;
            this.saveRes.Location = new System.Drawing.Point(149, 227);
            this.saveRes.Name = "saveRes";
            this.saveRes.Size = new System.Drawing.Size(75, 29);
            this.saveRes.TabIndex = 7;
            this.saveRes.Text = "save";
            this.saveRes.UseVisualStyleBackColor = true;
            this.saveRes.Click += new System.EventHandler(this.saveRes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inf);
            this.groupBox1.Controls.Add(this.dvResource);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.saveRes);
            this.groupBox1.Controls.Add(this.resourceCreate);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 268);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resources";
            // 
            // inf
            // 
            this.inf.AutoSize = true;
            this.inf.Enabled = false;
            this.inf.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.inf.Location = new System.Drawing.Point(39, 207);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(307, 17);
            this.inf.TabIndex = 8;
            this.inf.Text = "Enter amount for Each resource then click save";
            // 
            // addProcessBtn
            // 
            this.addProcessBtn.Enabled = false;
            this.addProcessBtn.Location = new System.Drawing.Point(124, 225);
            this.addProcessBtn.Name = "addProcessBtn";
            this.addProcessBtn.Size = new System.Drawing.Size(75, 31);
            this.addProcessBtn.TabIndex = 9;
            this.addProcessBtn.Text = "Add Process";
            this.addProcessBtn.UseVisualStyleBackColor = true;
            this.addProcessBtn.Click += new System.EventHandler(this.addProcessBtn_Click);
            // 
            // processDGV
            // 
            this.processDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processNameInDGV,
            this.timeDGV});
            this.processDGV.Location = new System.Drawing.Point(28, 63);
            this.processDGV.Name = "processDGV";
            this.processDGV.Size = new System.Drawing.Size(268, 141);
            this.processDGV.TabIndex = 10;
            // 
            // processNameInDGV
            // 
            this.processNameInDGV.HeaderText = "process";
            this.processNameInDGV.Name = "processNameInDGV";
            this.processNameInDGV.ReadOnly = true;
            // 
            // timeDGV
            // 
            this.timeDGV.HeaderText = "Total Time";
            this.timeDGV.Name = "timeDGV";
            this.timeDGV.ReadOnly = true;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(42, 22);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(75, 32);
            this.runBtn.TabIndex = 11;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // runDGV
            // 
            this.runDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.runDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Discriptions});
            this.runDGV.Location = new System.Drawing.Point(42, 61);
            this.runDGV.Name = "runDGV";
            this.runDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.runDGV.Size = new System.Drawing.Size(658, 225);
            this.runDGV.TabIndex = 12;
            // 
            // Discriptions
            // 
            this.Discriptions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discriptions.HeaderText = "Discriptions";
            this.Discriptions.Name = "Discriptions";
            this.Discriptions.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.processDGV);
            this.groupBox2.Controls.Add(this.addProcessBtn);
            this.groupBox2.Location = new System.Drawing.Point(407, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 262);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.runDGV);
            this.groupBox3.Controls.Add(this.runBtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(720, 297);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Running";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 28);
            this.menuStrip1.TabIndex = 15;
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 592);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "process Manager";
            this.Activated += new System.EventHandler(this.fillgrid);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvResource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resourceCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dvResource;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDV;
        private System.Windows.Forms.Button saveRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addProcessBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processNameInDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDGV;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discriptions;
        public System.Windows.Forms.DataGridView runDGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView processDGV;
        private System.Windows.Forms.Label inf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

