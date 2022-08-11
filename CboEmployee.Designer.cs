namespace ComboEmployeeApp
{
    partial class CboEmployee
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
            this.CboName = new System.Windows.Forms.ComboBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblHours = new System.Windows.Forms.Label();
            this.TxtHours = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.VsbHours = new System.Windows.Forms.VScrollBar();
            this.LblRate = new System.Windows.Forms.Label();
            this.LblGross = new System.Windows.Forms.Label();
            this.TxtGrossPay = new System.Windows.Forms.TextBox();
            this.CboRate = new System.Windows.Forms.ComboBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCompute = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CboName
            // 
            this.CboName.FormattingEnabled = true;
            this.CboName.Location = new System.Drawing.Point(168, 85);
            this.CboName.Name = "CboName";
            this.CboName.Size = new System.Drawing.Size(121, 24);
            this.CboName.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(168, 37);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(109, 16);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Employee Name";
            // 
            // LblHours
            // 
            this.LblHours.AutoSize = true;
            this.LblHours.Location = new System.Drawing.Point(168, 141);
            this.LblHours.Name = "LblHours";
            this.LblHours.Size = new System.Drawing.Size(43, 16);
            this.LblHours.TabIndex = 2;
            this.LblHours.Text = "Hours";
            // 
            // TxtHours
            // 
            this.TxtHours.Location = new System.Drawing.Point(233, 141);
            this.TxtHours.Name = "TxtHours";
            this.TxtHours.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtHours.Size = new System.Drawing.Size(100, 22);
            this.TxtHours.TabIndex = 3;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 100);
            this.vScrollBar1.TabIndex = 4;
            // 
            // VsbHours
            // 
            this.VsbHours.Location = new System.Drawing.Point(336, 85);
            this.VsbHours.Name = "VsbHours";
            this.VsbHours.Size = new System.Drawing.Size(18, 124);
            this.VsbHours.TabIndex = 5;
            this.VsbHours.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // LblRate
            // 
            this.LblRate.AutoSize = true;
            this.LblRate.Location = new System.Drawing.Point(168, 212);
            this.LblRate.Name = "LblRate";
            this.LblRate.Size = new System.Drawing.Size(36, 16);
            this.LblRate.TabIndex = 6;
            this.LblRate.Text = "Rate";
            // 
            // LblGross
            // 
            this.LblGross.AllowDrop = true;
            this.LblGross.AutoSize = true;
            this.LblGross.Location = new System.Drawing.Point(168, 310);
            this.LblGross.Name = "LblGross";
            this.LblGross.Size = new System.Drawing.Size(70, 16);
            this.LblGross.TabIndex = 8;
            this.LblGross.Tag = "";
            this.LblGross.Text = "Gross Pay";
            // 
            // TxtGrossPay
            // 
            this.TxtGrossPay.Location = new System.Drawing.Point(270, 310);
            this.TxtGrossPay.Name = "TxtGrossPay";
            this.TxtGrossPay.Size = new System.Drawing.Size(100, 22);
            this.TxtGrossPay.TabIndex = 9;
            // 
            // CboRate
            // 
            this.CboRate.FormattingEnabled = true;
            this.CboRate.Location = new System.Drawing.Point(233, 212);
            this.CboRate.Name = "CboRate";
            this.CboRate.Size = new System.Drawing.Size(121, 24);
            this.CboRate.TabIndex = 10;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(125, 415);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCompute
            // 
            this.BtnCompute.Location = new System.Drawing.Point(248, 414);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(106, 23);
            this.BtnCompute.TabIndex = 12;
            this.BtnCompute.Text = "Compute";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(386, 414);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CboEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 642);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCompute);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.CboRate);
            this.Controls.Add(this.TxtGrossPay);
            this.Controls.Add(this.LblGross);
            this.Controls.Add(this.LblRate);
            this.Controls.Add(this.VsbHours);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.TxtHours);
            this.Controls.Add(this.LblHours);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.CboName);
            this.Name = "CboEmployee";
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.CboEmployee_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblHours;
        private System.Windows.Forms.TextBox TxtHours;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar VsbHours;
        private System.Windows.Forms.Label LblRate;
        private System.Windows.Forms.Label LblGross;
        private System.Windows.Forms.TextBox TxtGrossPay;
        private System.Windows.Forms.ComboBox CboRate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.Button BtnExit;
    }
}

