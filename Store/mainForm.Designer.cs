namespace inventory
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainmenu = new System.Windows.Forms.ToolStrip();
            this.Logintsb = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addtsb = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selltsb = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.buytsb = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.logouttsb = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.exittsb = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mainmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Logintsb,
            this.toolStripSeparator1,
            this.addtsb,
            this.toolStripSeparator3,
            this.selltsb,
            this.toolStripSeparator4,
            this.buytsb,
            this.toolStripSeparator5,
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator6,
            this.logouttsb,
            this.toolStripSeparator7,
            this.exittsb});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(604, 25);
            this.mainmenu.TabIndex = 1;
            this.mainmenu.Text = "toolStrip1";
            // 
            // Logintsb
            // 
            this.Logintsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Logintsb.Image = ((System.Drawing.Image)(resources.GetObject("Logintsb.Image")));
            this.Logintsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Logintsb.Name = "Logintsb";
            this.Logintsb.Size = new System.Drawing.Size(52, 22);
            this.Logintsb.Text = "Login";
            this.Logintsb.Click += new System.EventHandler(this.Logintsb_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // addtsb
            // 
            this.addtsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addtsb.Enabled = false;
            this.addtsb.Image = ((System.Drawing.Image)(resources.GetObject("addtsb.Image")));
            this.addtsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addtsb.Name = "addtsb";
            this.addtsb.Size = new System.Drawing.Size(40, 22);
            this.addtsb.Text = "Add";
            this.addtsb.Click += new System.EventHandler(this.addtsb_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // selltsb
            // 
            this.selltsb.AccessibleName = "";
            this.selltsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selltsb.Enabled = false;
            this.selltsb.Image = ((System.Drawing.Image)(resources.GetObject("selltsb.Image")));
            this.selltsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selltsb.Name = "selltsb";
            this.selltsb.Size = new System.Drawing.Size(39, 22);
            this.selltsb.Text = "Sell";
            this.selltsb.Click += new System.EventHandler(this.sellstb_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // buytsb
            // 
            this.buytsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buytsb.Enabled = false;
            this.buytsb.Image = ((System.Drawing.Image)(resources.GetObject("buytsb.Image")));
            this.buytsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buytsb.Name = "buytsb";
            this.buytsb.Size = new System.Drawing.Size(39, 22);
            this.buytsb.Text = "Buy";
            this.buytsb.Click += new System.EventHandler(this.buystb_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.sellToolStripMenuItem});
            this.toolStripDropDownButton1.Enabled = false;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(59, 22);
            this.toolStripDropDownButton1.Text = "Show";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.purchaseToolStripMenuItem.Text = "Buy";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.sellToolStripMenuItem.Text = "Sell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(74, 22);
            this.toolStripButton1.Text = "BarCode";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton2.Text = "PushMsg";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // logouttsb
            // 
            this.logouttsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logouttsb.Enabled = false;
            this.logouttsb.Image = ((System.Drawing.Image)(resources.GetObject("logouttsb.Image")));
            this.logouttsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logouttsb.Name = "logouttsb";
            this.logouttsb.Size = new System.Drawing.Size(62, 22);
            this.logouttsb.Text = "Logout";
            this.logouttsb.Click += new System.EventHandler(this.logouttsb_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // exittsb
            // 
            this.exittsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exittsb.Image = ((System.Drawing.Image)(resources.GetObject("exittsb.Image")));
            this.exittsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exittsb.Name = "exittsb";
            this.exittsb.Size = new System.Drawing.Size(38, 22);
            this.exittsb.Text = "Exit";
            this.exittsb.Click += new System.EventHandler(this.exitstb_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(604, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 468);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainmenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "MyStore";
            this.Load += new System.EventHandler(this.mdi_Load);
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip mainmenu;
        public System.Windows.Forms.ToolStripButton addtsb;
        public System.Windows.Forms.ToolStripButton selltsb;
        public System.Windows.Forms.ToolStripButton buytsb;
        public System.Windows.Forms.ToolStripButton exittsb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        public System.Windows.Forms.ToolStripButton logouttsb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton Logintsb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}