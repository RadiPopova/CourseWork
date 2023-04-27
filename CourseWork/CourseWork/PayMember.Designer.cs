namespace CourseWork
{
    partial class frmPayPeriod
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
            this.btnPay = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPayDays = new System.Windows.Forms.Label();
            this.lblPayFrom = new System.Windows.Forms.Label();
            this.lbl_Child_Parent = new System.Windows.Forms.Label();
            this.cbbPayParr = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(102, 329);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(189, 54);
            this.btnPay.TabIndex = 33;
            this.btnPay.Text = "Записване";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 32;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // lblPayDays
            // 
            this.lblPayDays.AutoSize = true;
            this.lblPayDays.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lblPayDays.Location = new System.Drawing.Point(12, 157);
            this.lblPayDays.Name = "lblPayDays";
            this.lblPayDays.Size = new System.Drawing.Size(48, 26);
            this.lblPayDays.TabIndex = 30;
            this.lblPayDays.Text = "Дни";
            // 
            // lblPayFrom
            // 
            this.lblPayFrom.AutoSize = true;
            this.lblPayFrom.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lblPayFrom.Location = new System.Drawing.Point(12, 95);
            this.lblPayFrom.Name = "lblPayFrom";
            this.lblPayFrom.Size = new System.Drawing.Size(34, 26);
            this.lblPayFrom.TabIndex = 29;
            this.lblPayFrom.Text = "От";
            // 
            // lbl_Child_Parent
            // 
            this.lbl_Child_Parent.AutoSize = true;
            this.lbl_Child_Parent.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.lbl_Child_Parent.Location = new System.Drawing.Point(12, 28);
            this.lbl_Child_Parent.Name = "lbl_Child_Parent";
            this.lbl_Child_Parent.Size = new System.Drawing.Size(88, 26);
            this.lbl_Child_Parent.TabIndex = 28;
            this.lbl_Child_Parent.Text = "Родител";
            // 
            // cbbPayParr
            // 
            this.cbbPayParr.FormattingEnabled = true;
            this.cbbPayParr.Location = new System.Drawing.Point(169, 28);
            this.cbbPayParr.Name = "cbbPayParr";
            this.cbbPayParr.Size = new System.Drawing.Size(191, 24);
            this.cbbPayParr.TabIndex = 27;
            // 
            // frmPayPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblPayDays);
            this.Controls.Add(this.lblPayFrom);
            this.Controls.Add(this.lbl_Child_Parent);
            this.Controls.Add(this.cbbPayParr);
            this.Name = "frmPayPeriod";
            this.Text = "Плащане";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPayDays;
        private System.Windows.Forms.Label lblPayFrom;
        private System.Windows.Forms.Label lbl_Child_Parent;
        private System.Windows.Forms.ComboBox cbbPayParr;
    }
}