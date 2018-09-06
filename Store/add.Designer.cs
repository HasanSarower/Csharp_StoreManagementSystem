namespace inventory
{
    partial class add
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
            this.adpronamelbl = new System.Windows.Forms.Label();
            this.adprotxt = new System.Windows.Forms.TextBox();
            this.addbt = new System.Windows.Forms.Button();
            this.adexitbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adpronamelbl
            // 
            this.adpronamelbl.AutoSize = true;
            this.adpronamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adpronamelbl.Location = new System.Drawing.Point(60, 50);
            this.adpronamelbl.Name = "adpronamelbl";
            this.adpronamelbl.Size = new System.Drawing.Size(136, 24);
            this.adpronamelbl.TabIndex = 1;
            this.adpronamelbl.Text = "Product Name:";
            // 
            // adprotxt
            // 
            this.adprotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adprotxt.Location = new System.Drawing.Point(210, 50);
            this.adprotxt.Name = "adprotxt";
            this.adprotxt.Size = new System.Drawing.Size(122, 29);
            this.adprotxt.TabIndex = 1;
            // 
            // addbt
            // 
            this.addbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbt.Location = new System.Drawing.Point(210, 177);
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(122, 35);
            this.addbt.TabIndex = 2;
            this.addbt.Text = "Add";
            this.addbt.UseVisualStyleBackColor = true;
            this.addbt.Click += new System.EventHandler(this.adaddbt_Click);
            // 
            // adexitbt
            // 
            this.adexitbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adexitbt.Location = new System.Drawing.Point(530, 420);
            this.adexitbt.Name = "adexitbt";
            this.adexitbt.Size = new System.Drawing.Size(60, 35);
            this.adexitbt.TabIndex = 3;
            this.adexitbt.Text = "Exit";
            this.adexitbt.UseVisualStyleBackColor = true;
            this.adexitbt.Click += new System.EventHandler(this.exitbt_Click);
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 468);
            this.Controls.Add(this.adexitbt);
            this.Controls.Add(this.addbt);
            this.Controls.Add(this.adprotxt);
            this.Controls.Add(this.adpronamelbl);
            this.Name = "add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add New Inventory";
            this.Load += new System.EventHandler(this.add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adpronamelbl;
        private System.Windows.Forms.TextBox adprotxt;
        private System.Windows.Forms.Button addbt;
        private System.Windows.Forms.Button adexitbt;
    }
}