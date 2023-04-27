namespace CourseWork
{
    partial class frmPayFood
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
            this.gbxFood = new System.Windows.Forms.GroupBox();
            this.gbxTransport = new System.Windows.Forms.GroupBox();
            this.cbbPayKidsF = new System.Windows.Forms.ComboBox();
            this.lblKids = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.txtPayKidsF = new System.Windows.Forms.TextBox();
            this.txtPayKidsT = new System.Windows.Forms.TextBox();
            this.lbl2Number = new System.Windows.Forms.Label();
            this.lbl2Kids = new System.Windows.Forms.Label();
            this.cbbPayKidsT = new System.Windows.Forms.ComboBox();
            this.btnPayFood = new System.Windows.Forms.Button();
            this.btnPayTransport = new System.Windows.Forms.Button();
            this.gbxFood.SuspendLayout();
            this.gbxTransport.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFood
            // 
            this.gbxFood.Controls.Add(this.btnPayFood);
            this.gbxFood.Controls.Add(this.txtPayKidsF);
            this.gbxFood.Controls.Add(this.lblNumbers);
            this.gbxFood.Controls.Add(this.lblKids);
            this.gbxFood.Controls.Add(this.cbbPayKidsF);
            this.gbxFood.Location = new System.Drawing.Point(53, 67);
            this.gbxFood.Name = "gbxFood";
            this.gbxFood.Size = new System.Drawing.Size(279, 302);
            this.gbxFood.TabIndex = 0;
            this.gbxFood.TabStop = false;
            this.gbxFood.Text = "Храна";
            // 
            // gbxTransport
            // 
            this.gbxTransport.Controls.Add(this.btnPayTransport);
            this.gbxTransport.Controls.Add(this.txtPayKidsT);
            this.gbxTransport.Controls.Add(this.lbl2Number);
            this.gbxTransport.Controls.Add(this.lbl2Kids);
            this.gbxTransport.Controls.Add(this.cbbPayKidsT);
            this.gbxTransport.Location = new System.Drawing.Point(452, 67);
            this.gbxTransport.Name = "gbxTransport";
            this.gbxTransport.Size = new System.Drawing.Size(279, 302);
            this.gbxTransport.TabIndex = 1;
            this.gbxTransport.TabStop = false;
            this.gbxTransport.Text = "Транспорт";
            // 
            // cbbPayKidsF
            // 
            this.cbbPayKidsF.FormattingEnabled = true;
            this.cbbPayKidsF.Location = new System.Drawing.Point(122, 58);
            this.cbbPayKidsF.Name = "cbbPayKidsF";
            this.cbbPayKidsF.Size = new System.Drawing.Size(121, 24);
            this.cbbPayKidsF.TabIndex = 0;
            // 
            // lblKids
            // 
            this.lblKids.AutoSize = true;
            this.lblKids.Location = new System.Drawing.Point(37, 65);
            this.lblKids.Name = "lblKids";
            this.lblKids.Size = new System.Drawing.Size(39, 16);
            this.lblKids.TabIndex = 1;
            this.lblKids.Text = "Дете";
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Location = new System.Drawing.Point(40, 162);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(41, 16);
            this.lblNumbers.TabIndex = 2;
            this.lblNumbers.Text = "Пъти";
            // 
            // txtPayKidsF
            // 
            this.txtPayKidsF.Location = new System.Drawing.Point(142, 155);
            this.txtPayKidsF.Name = "txtPayKidsF";
            this.txtPayKidsF.Size = new System.Drawing.Size(100, 22);
            this.txtPayKidsF.TabIndex = 3;
            // 
            // txtPayKidsT
            // 
            this.txtPayKidsT.Location = new System.Drawing.Point(133, 155);
            this.txtPayKidsT.Name = "txtPayKidsT";
            this.txtPayKidsT.Size = new System.Drawing.Size(100, 22);
            this.txtPayKidsT.TabIndex = 7;
            // 
            // lbl2Number
            // 
            this.lbl2Number.AutoSize = true;
            this.lbl2Number.Location = new System.Drawing.Point(31, 162);
            this.lbl2Number.Name = "lbl2Number";
            this.lbl2Number.Size = new System.Drawing.Size(41, 16);
            this.lbl2Number.TabIndex = 6;
            this.lbl2Number.Text = "Пъти";
            // 
            // lbl2Kids
            // 
            this.lbl2Kids.AutoSize = true;
            this.lbl2Kids.Location = new System.Drawing.Point(28, 65);
            this.lbl2Kids.Name = "lbl2Kids";
            this.lbl2Kids.Size = new System.Drawing.Size(39, 16);
            this.lbl2Kids.TabIndex = 5;
            this.lbl2Kids.Text = "Дете";
            // 
            // cbbPayKidsT
            // 
            this.cbbPayKidsT.FormattingEnabled = true;
            this.cbbPayKidsT.Location = new System.Drawing.Point(113, 58);
            this.cbbPayKidsT.Name = "cbbPayKidsT";
            this.cbbPayKidsT.Size = new System.Drawing.Size(121, 24);
            this.cbbPayKidsT.TabIndex = 4;
            // 
            // btnPayFood
            // 
            this.btnPayFood.Location = new System.Drawing.Point(43, 226);
            this.btnPayFood.Name = "btnPayFood";
            this.btnPayFood.Size = new System.Drawing.Size(189, 54);
            this.btnPayFood.TabIndex = 34;
            this.btnPayFood.Text = "Записване";
            this.btnPayFood.UseVisualStyleBackColor = true;
            // 
            // btnPayTransport
            // 
            this.btnPayTransport.Location = new System.Drawing.Point(44, 226);
            this.btnPayTransport.Name = "btnPayTransport";
            this.btnPayTransport.Size = new System.Drawing.Size(189, 54);
            this.btnPayTransport.TabIndex = 34;
            this.btnPayTransport.Text = "Записване";
            this.btnPayTransport.UseVisualStyleBackColor = true;
            // 
            // frmPayFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxTransport);
            this.Controls.Add(this.gbxFood);
            this.Name = "frmPayFood";
            this.Text = "Плащане";
            this.gbxFood.ResumeLayout(false);
            this.gbxFood.PerformLayout();
            this.gbxTransport.ResumeLayout(false);
            this.gbxTransport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFood;
        private System.Windows.Forms.TextBox txtPayKidsF;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblKids;
        private System.Windows.Forms.ComboBox cbbPayKidsF;
        private System.Windows.Forms.GroupBox gbxTransport;
        private System.Windows.Forms.TextBox txtPayKidsT;
        private System.Windows.Forms.Label lbl2Number;
        private System.Windows.Forms.Label lbl2Kids;
        private System.Windows.Forms.ComboBox cbbPayKidsT;
        private System.Windows.Forms.Button btnPayFood;
        private System.Windows.Forms.Button btnPayTransport;
    }
}