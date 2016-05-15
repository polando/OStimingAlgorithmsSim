namespace scheduling
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
            this.procTable = new System.Windows.Forms.DataGridView();
            this.nameDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enteringTimeDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTimeDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logBox = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            this.addProcessBtn = new System.Windows.Forms.Button();
            this.addProcessBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tatLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wtLbl = new System.Windows.Forms.Label();
            this.FCFCBtn = new System.Windows.Forms.RadioButton();
            this.SJFBtn = new System.Windows.Forms.RadioButton();
            this.HRNBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SRTBtn = new System.Windows.Forms.RadioButton();
            this.RRBtn = new System.Windows.Forms.RadioButton();
            this.TStxt = new System.Windows.Forms.TextBox();
            this.TSlbl = new System.Windows.Forms.Label();
            this.timeSliceBTn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.procTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // procTable
            // 
            this.procTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDV,
            this.enteringTimeDV,
            this.serviceTimeDV});
            this.procTable.Location = new System.Drawing.Point(39, 135);
            this.procTable.Name = "procTable";
            this.procTable.RowTemplate.Height = 24;
            this.procTable.Size = new System.Drawing.Size(409, 235);
            this.procTable.TabIndex = 0;
            // 
            // nameDV
            // 
            this.nameDV.HeaderText = "name";
            this.nameDV.Name = "nameDV";
            // 
            // enteringTimeDV
            // 
            this.enteringTimeDV.HeaderText = "enteringTime";
            this.enteringTimeDV.Name = "enteringTimeDV";
            // 
            // serviceTimeDV
            // 
            this.serviceTimeDV.HeaderText = "serviceTime";
            this.serviceTimeDV.Name = "serviceTimeDV";
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.ItemHeight = 16;
            this.logBox.Location = new System.Drawing.Point(48, 376);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(400, 164);
            this.logBox.TabIndex = 1;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(350, 594);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(98, 42);
            this.start.TabIndex = 2;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // addProcessBtn
            // 
            this.addProcessBtn.Location = new System.Drawing.Point(164, 23);
            this.addProcessBtn.Name = "addProcessBtn";
            this.addProcessBtn.Size = new System.Drawing.Size(75, 23);
            this.addProcessBtn.TabIndex = 3;
            this.addProcessBtn.Text = "add";
            this.addProcessBtn.UseVisualStyleBackColor = true;
            this.addProcessBtn.Click += new System.EventHandler(this.addProcessBtn_Click);
            // 
            // addProcessBox
            // 
            this.addProcessBox.Location = new System.Drawing.Point(39, 24);
            this.addProcessBox.Name = "addProcessBox";
            this.addProcessBox.Size = new System.Drawing.Size(119, 22);
            this.addProcessBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "turnAroundTime :";
            // 
            // tatLbl
            // 
            this.tatLbl.AutoSize = true;
            this.tatLbl.Location = new System.Drawing.Point(373, 23);
            this.tatLbl.Name = "tatLbl";
            this.tatLbl.Size = new System.Drawing.Size(20, 17);
            this.tatLbl.TabIndex = 6;
            this.tatLbl.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "waitingTime :";
            // 
            // wtLbl
            // 
            this.wtLbl.AutoSize = true;
            this.wtLbl.Location = new System.Drawing.Point(382, 54);
            this.wtLbl.Name = "wtLbl";
            this.wtLbl.Size = new System.Drawing.Size(20, 17);
            this.wtLbl.TabIndex = 8;
            this.wtLbl.Text = "...";
            // 
            // FCFCBtn
            // 
            this.FCFCBtn.AutoSize = true;
            this.FCFCBtn.Location = new System.Drawing.Point(9, 21);
            this.FCFCBtn.Name = "FCFCBtn";
            this.FCFCBtn.Size = new System.Drawing.Size(63, 21);
            this.FCFCBtn.TabIndex = 9;
            this.FCFCBtn.TabStop = true;
            this.FCFCBtn.Text = "FCFS";
            this.FCFCBtn.UseVisualStyleBackColor = true;
            this.FCFCBtn.CheckedChanged += new System.EventHandler(this.FCFCBtn_CheckedChanged);
            // 
            // SJFBtn
            // 
            this.SJFBtn.AutoSize = true;
            this.SJFBtn.Location = new System.Drawing.Point(9, 48);
            this.SJFBtn.Name = "SJFBtn";
            this.SJFBtn.Size = new System.Drawing.Size(53, 21);
            this.SJFBtn.TabIndex = 10;
            this.SJFBtn.TabStop = true;
            this.SJFBtn.Text = "SJF";
            this.SJFBtn.UseVisualStyleBackColor = true;
            this.SJFBtn.CheckedChanged += new System.EventHandler(this.SJFBtn_CheckedChanged);
            // 
            // HRNBtn
            // 
            this.HRNBtn.AutoSize = true;
            this.HRNBtn.Location = new System.Drawing.Point(9, 75);
            this.HRNBtn.Name = "HRNBtn";
            this.HRNBtn.Size = new System.Drawing.Size(59, 21);
            this.HRNBtn.TabIndex = 11;
            this.HRNBtn.TabStop = true;
            this.HRNBtn.Text = "HRN";
            this.HRNBtn.UseVisualStyleBackColor = true;
            this.HRNBtn.CheckedChanged += new System.EventHandler(this.HRNBtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeSliceBTn);
            this.groupBox1.Controls.Add(this.TSlbl);
            this.groupBox1.Controls.Add(this.TStxt);
            this.groupBox1.Controls.Add(this.SRTBtn);
            this.groupBox1.Controls.Add(this.RRBtn);
            this.groupBox1.Controls.Add(this.FCFCBtn);
            this.groupBox1.Controls.Add(this.HRNBtn);
            this.groupBox1.Controls.Add(this.SJFBtn);
            this.groupBox1.Location = new System.Drawing.Point(39, 546);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 154);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithms";
            // 
            // SRTBtn
            // 
            this.SRTBtn.AutoSize = true;
            this.SRTBtn.Location = new System.Drawing.Point(9, 102);
            this.SRTBtn.Name = "SRTBtn";
            this.SRTBtn.Size = new System.Drawing.Size(57, 21);
            this.SRTBtn.TabIndex = 13;
            this.SRTBtn.TabStop = true;
            this.SRTBtn.Text = "SRT";
            this.SRTBtn.UseVisualStyleBackColor = true;
            this.SRTBtn.CheckedChanged += new System.EventHandler(this.SRTBtn_CheckedChanged);
            // 
            // RRBtn
            // 
            this.RRBtn.AutoSize = true;
            this.RRBtn.Location = new System.Drawing.Point(9, 127);
            this.RRBtn.Name = "RRBtn";
            this.RRBtn.Size = new System.Drawing.Size(108, 21);
            this.RRBtn.TabIndex = 12;
            this.RRBtn.TabStop = true;
            this.RRBtn.Text = "RoundRobin";
            this.RRBtn.UseVisualStyleBackColor = true;
            this.RRBtn.CheckedChanged += new System.EventHandler(this.RRBtn_CheckedChanged);
            // 
            // TStxt
            // 
            this.TStxt.Location = new System.Drawing.Point(168, 127);
            this.TStxt.Name = "TStxt";
            this.TStxt.Size = new System.Drawing.Size(43, 22);
            this.TStxt.TabIndex = 14;
            // 
            // TSlbl
            // 
            this.TSlbl.AutoSize = true;
            this.TSlbl.Location = new System.Drawing.Point(165, 106);
            this.TSlbl.Name = "TSlbl";
            this.TSlbl.Size = new System.Drawing.Size(77, 17);
            this.TSlbl.TabIndex = 15;
            this.TSlbl.Text = "TimeSlice :";
            // 
            // timeSliceBTn
            // 
            this.timeSliceBTn.Enabled = false;
            this.timeSliceBTn.Location = new System.Drawing.Point(221, 125);
            this.timeSliceBTn.Name = "timeSliceBTn";
            this.timeSliceBTn.Size = new System.Drawing.Size(39, 23);
            this.timeSliceBTn.TabIndex = 16;
            this.timeSliceBTn.Text = "set";
            this.timeSliceBTn.UseVisualStyleBackColor = true;
            this.timeSliceBTn.Click += new System.EventHandler(this.timeSliceBTn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 712);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wtLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tatLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProcessBox);
            this.Controls.Add(this.addProcessBtn);
            this.Controls.Add(this.start);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.procTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.procTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView procTable;
        public System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn enteringTimeDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTimeDV;
        public System.Windows.Forms.Button start;
        private System.Windows.Forms.Button addProcessBtn;
        private System.Windows.Forms.TextBox addProcessBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label tatLbl;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label wtLbl;
        private System.Windows.Forms.RadioButton FCFCBtn;
        private System.Windows.Forms.RadioButton SJFBtn;
        private System.Windows.Forms.RadioButton HRNBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RRBtn;
        private System.Windows.Forms.RadioButton SRTBtn;
        private System.Windows.Forms.Button timeSliceBTn;
        private System.Windows.Forms.Label TSlbl;
        private System.Windows.Forms.TextBox TStxt;
    }
}

