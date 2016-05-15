namespace lamport
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.createBtn = new System.Windows.Forms.Button();
            this.nOftext = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.DataGridView();
            this.discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.enterTime,
            this.serviceTime});
            this.DGV.Location = new System.Drawing.Point(58, 61);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(390, 150);
            this.DGV.TabIndex = 1;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(221, 12);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // nOftext
            // 
            this.nOftext.Location = new System.Drawing.Point(79, 12);
            this.nOftext.Name = "nOftext";
            this.nOftext.Size = new System.Drawing.Size(136, 22);
            this.nOftext.TabIndex = 3;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(221, 231);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // log
            // 
            this.log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.log.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.discription});
            this.log.Location = new System.Drawing.Point(58, 260);
            this.log.Name = "log";
            this.log.RowTemplate.Height = 24;
            this.log.Size = new System.Drawing.Size(390, 322);
            this.log.TabIndex = 5;
            // 
            // discription
            // 
            this.discription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discription.HeaderText = "discription";
            this.discription.Name = "discription";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 68;
            // 
            // enterTime
            // 
            this.enterTime.HeaderText = "enterTime";
            this.enterTime.Name = "enterTime";
            // 
            // serviceTime
            // 
            this.serviceTime.HeaderText = "serviceTime";
            this.serviceTime.Name = "serviceTime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 607);
            this.Controls.Add(this.log);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.nOftext);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.DGV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button createBtn;
        public System.Windows.Forms.TextBox nOftext;
        private System.Windows.Forms.Button startBtn;
        public System.Windows.Forms.DataGridView log;
        private System.Windows.Forms.DataGridViewTextBoxColumn discription;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTime;

    }
}

