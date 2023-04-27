namespace CourseWork
{
    partial class Home
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
            this.AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.payFT = new System.Windows.Forms.ToolStripMenuItem();
            this.payMember = new System.Windows.Forms.ToolStripMenuItem();
            this.payFoodTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.addParKids = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNew,
            this.payFT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddNew
            // 
            this.AddNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addParKids});
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(92, 26);
            this.AddNew.Text = "Добавяне";
            // 
            // payFT
            // 
            this.payFT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payMember,
            this.payFoodTrans});
            this.payFT.Name = "payFT";
            this.payFT.Size = new System.Drawing.Size(87, 26);
            this.payFT.Text = "Плащане";
            // 
            // payMember
            // 
            this.payMember.Name = "payMember";
            this.payMember.Size = new System.Drawing.Size(215, 26);
            this.payMember.Text = "Период";
            this.payMember.Click += new System.EventHandler(this.payMember_Click);
            // 
            // payFoodTrans
            // 
            this.payFoodTrans.Name = "payFoodTrans";
            this.payFoodTrans.Size = new System.Drawing.Size(215, 26);
            this.payFoodTrans.Text = "Храна/Транспорт";
            this.payFoodTrans.Click += new System.EventHandler(this.payFoodTrans_Click);
            // 
            // addParKids
            // 
            this.addParKids.Name = "addParKids";
            this.addParKids.Size = new System.Drawing.Size(224, 26);
            this.addParKids.Text = "Добавяне";
            this.addParKids.Click += new System.EventHandler(this.addParKids_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddNew;
        private System.Windows.Forms.ToolStripMenuItem payFT;
        private System.Windows.Forms.ToolStripMenuItem payMember;
        private System.Windows.Forms.ToolStripMenuItem payFoodTrans;
        private System.Windows.Forms.ToolStripMenuItem addParKids;
    }
}

