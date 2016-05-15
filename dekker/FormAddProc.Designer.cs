namespace DekkerProject
{
    partial class FormAddProc
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
            this.addProcBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.procName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enteringTimeField = new System.Windows.Forms.TextBox();
            this.procDV = new System.Windows.Forms.DataGridView();
            this.resourceObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeNeededCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.procDV)).BeginInit();
            this.SuspendLayout();
            // 
            // addProcBtn
            // 
            this.addProcBtn.Location = new System.Drawing.Point(27, 250);
            this.addProcBtn.Name = "addProcBtn";
            this.addProcBtn.Size = new System.Drawing.Size(75, 23);
            this.addProcBtn.TabIndex = 0;
            this.addProcBtn.Text = "Add";
            this.addProcBtn.UseVisualStyleBackColor = true;
            this.addProcBtn.Click += new System.EventHandler(this.addProcBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // procName
            // 
            this.procName.Location = new System.Drawing.Point(127, 24);
            this.procName.Name = "procName";
            this.procName.Size = new System.Drawing.Size(100, 20);
            this.procName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entering Time";
            // 
            // enteringTimeField
            // 
            this.enteringTimeField.Location = new System.Drawing.Point(127, 51);
            this.enteringTimeField.Name = "enteringTimeField";
            this.enteringTimeField.Size = new System.Drawing.Size(100, 20);
            this.enteringTimeField.TabIndex = 4;
            // 
            // procDV
            // 
            this.procDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resourceObj,
            this.processCol,
            this.TimeNeededCol});
            this.procDV.Location = new System.Drawing.Point(27, 86);
            this.procDV.Name = "procDV";
            this.procDV.Size = new System.Drawing.Size(238, 144);
            this.procDV.TabIndex = 5;
            // 
            // resourceObj
            // 
            this.resourceObj.HeaderText = "resourceObj";
            this.resourceObj.Name = "resourceObj";
            this.resourceObj.Visible = false;
            // 
            // processCol
            // 
            this.processCol.HeaderText = "resource";
            this.processCol.Name = "processCol";
            this.processCol.ReadOnly = true;
            // 
            // TimeNeededCol
            // 
            this.TimeNeededCol.HeaderText = "Time Needed";
            this.TimeNeededCol.Name = "TimeNeededCol";
            // 
            // upBtn
            // 
            this.upBtn.Location = new System.Drawing.Point(271, 120);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(47, 23);
            this.upBtn.TabIndex = 6;
            this.upBtn.Text = "up";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.Location = new System.Drawing.Point(271, 149);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(47, 23);
            this.downBtn.TabIndex = 7;
            this.downBtn.Text = "down";
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(108, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time needed values in all rows must be filled";
            // 
            // FormAddProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.procDV);
            this.Controls.Add(this.enteringTimeField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.procName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProcBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAddProc";
            this.Text = "AddProcess";
            ((System.ComponentModel.ISupportInitialize)(this.procDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProcBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox procName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enteringTimeField;
        private System.Windows.Forms.DataGridView procDV;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourceObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn processCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeNeededCol;
        private System.Windows.Forms.Label label3;
    }
}