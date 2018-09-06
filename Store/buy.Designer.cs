namespace inventory
{
    partial class buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buy));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buypronamecomb = new System.Windows.Forms.ComboBox();
            this.buyqttxt = new System.Windows.Forms.TextBox();
            this.buyprtxt = new System.Windows.Forms.TextBox();
            this.buysubbt = new System.Windows.Forms.Button();
            this.buypnmtxt = new System.Windows.Forms.TextBox();
            this.buydatetxt = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblpname = new System.Windows.Forms.Label();
            this.buyexitbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price:";
            // 
            // buypronamecomb
            // 
            this.buypronamecomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buypronamecomb.FormattingEnabled = true;
            this.buypronamecomb.Location = new System.Drawing.Point(210, 50);
            this.buypronamecomb.Name = "buypronamecomb";
            this.buypronamecomb.Size = new System.Drawing.Size(191, 32);
            this.buypronamecomb.TabIndex = 1;
            // 
            // buyqttxt
            // 
            this.buyqttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyqttxt.Location = new System.Drawing.Point(210, 125);
            this.buyqttxt.Name = "buyqttxt";
            this.buyqttxt.Size = new System.Drawing.Size(130, 29);
            this.buyqttxt.TabIndex = 2;
            // 
            // buyprtxt
            // 
            this.buyprtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyprtxt.Location = new System.Drawing.Point(210, 200);
            this.buyprtxt.Name = "buyprtxt";
            this.buyprtxt.Size = new System.Drawing.Size(130, 29);
            this.buyprtxt.TabIndex = 3;
            // 
            // buysubbt
            // 
            this.buysubbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buysubbt.Location = new System.Drawing.Point(180, 420);
            this.buysubbt.Name = "buysubbt";
            this.buysubbt.Size = new System.Drawing.Size(174, 35);
            this.buysubbt.TabIndex = 6;
            this.buysubbt.Text = "Submit";
            this.buysubbt.UseVisualStyleBackColor = true;
            this.buysubbt.Click += new System.EventHandler(this.buysubbt_Click);
            // 
            // buypnmtxt
            // 
            this.buypnmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buypnmtxt.Location = new System.Drawing.Point(210, 350);
            this.buypnmtxt.Name = "buypnmtxt";
            this.buypnmtxt.Size = new System.Drawing.Size(225, 29);
            this.buypnmtxt.TabIndex = 5;
            this.buypnmtxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // buydatetxt
            // 
            this.buydatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buydatetxt.Location = new System.Drawing.Point(210, 275);
            this.buydatetxt.Name = "buydatetxt";
            this.buydatetxt.Size = new System.Drawing.Size(130, 29);
            this.buydatetxt.TabIndex = 4;
            this.buydatetxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(60, 275);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(53, 24);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "Date:";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.Location = new System.Drawing.Point(60, 350);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(112, 24);
            this.lblpname.TabIndex = 0;
            this.lblpname.Text = "Party Name:";
            this.lblpname.Click += new System.EventHandler(this.lblpname_Click);
            // 
            // buyexitbt
            // 
            this.buyexitbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyexitbt.Location = new System.Drawing.Point(530, 420);
            this.buyexitbt.Name = "buyexitbt";
            this.buyexitbt.Size = new System.Drawing.Size(60, 35);
            this.buyexitbt.TabIndex = 7;
            this.buyexitbt.Text = "Exit";
            this.buyexitbt.UseVisualStyleBackColor = true;
            this.buyexitbt.Click += new System.EventHandler(this.buyexitbt_Click);
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(604, 468);
            this.Controls.Add(this.buyexitbt);
            this.Controls.Add(this.buypnmtxt);
            this.Controls.Add(this.buydatetxt);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblpname);
            this.Controls.Add(this.buysubbt);
            this.Controls.Add(this.buyprtxt);
            this.Controls.Add(this.buyqttxt);
            this.Controls.Add(this.buypronamecomb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "buy";
            this.Text = "Buy Inventory";
            this.Load += new System.EventHandler(this.buy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox buypronamecomb;
        private System.Windows.Forms.TextBox buyqttxt;
        private System.Windows.Forms.TextBox buyprtxt;
        private System.Windows.Forms.Button buysubbt;
        private System.Windows.Forms.TextBox buypnmtxt;
        private System.Windows.Forms.TextBox buydatetxt;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.Button buyexitbt;
    }
}