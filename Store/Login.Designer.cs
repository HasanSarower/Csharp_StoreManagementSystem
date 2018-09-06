namespace inventory
{
    partial class Login
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
            this.logunmlbl = new System.Windows.Forms.Label();
            this.logpasslbl = new System.Windows.Forms.Label();
            this.logintxt = new System.Windows.Forms.TextBox();
            this.logpasstxt = new System.Windows.Forms.TextBox();
            this.loginbt = new System.Windows.Forms.Button();
            this.logexitbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logunmlbl
            // 
            this.logunmlbl.AutoSize = true;
            this.logunmlbl.Location = new System.Drawing.Point(71, 133);
            this.logunmlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.logunmlbl.Name = "logunmlbl";
            this.logunmlbl.Size = new System.Drawing.Size(110, 24);
            this.logunmlbl.TabIndex = 0;
            this.logunmlbl.Text = "User Name:";
            // 
            // logpasslbl
            // 
            this.logpasslbl.AutoSize = true;
            this.logpasslbl.Location = new System.Drawing.Point(71, 190);
            this.logpasslbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.logpasslbl.Name = "logpasslbl";
            this.logpasslbl.Size = new System.Drawing.Size(97, 24);
            this.logpasslbl.TabIndex = 1;
            this.logpasslbl.Text = "Password:";
            // 
            // logintxt
            // 
            this.logintxt.Location = new System.Drawing.Point(209, 130);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(217, 29);
            this.logintxt.TabIndex = 1;
            this.logintxt.TextChanged += new System.EventHandler(this.untxt_TextChanged);
            // 
            // logpasstxt
            // 
            this.logpasstxt.Location = new System.Drawing.Point(209, 190);
            this.logpasstxt.Name = "logpasstxt";
            this.logpasstxt.PasswordChar = '$';
            this.logpasstxt.Size = new System.Drawing.Size(217, 29);
            this.logpasstxt.TabIndex = 2;
            this.logpasstxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // loginbt
            // 
            this.loginbt.Location = new System.Drawing.Point(209, 268);
            this.loginbt.Name = "loginbt";
            this.loginbt.Size = new System.Drawing.Size(145, 33);
            this.loginbt.TabIndex = 3;
            this.loginbt.Text = "Login";
            this.loginbt.UseVisualStyleBackColor = true;
            this.loginbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // logexitbt
            // 
            this.logexitbt.Location = new System.Drawing.Point(530, 420);
            this.logexitbt.Name = "logexitbt";
            this.logexitbt.Size = new System.Drawing.Size(60, 35);
            this.logexitbt.TabIndex = 4;
            this.logexitbt.Text = "Exit";
            this.logexitbt.UseVisualStyleBackColor = true;
            this.logexitbt.Click += new System.EventHandler(this.exitbt_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(604, 468);
            this.Controls.Add(this.logexitbt);
            this.Controls.Add(this.loginbt);
            this.Controls.Add(this.logpasstxt);
            this.Controls.Add(this.logintxt);
            this.Controls.Add(this.logpasslbl);
            this.Controls.Add(this.logunmlbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logunmlbl;
        private System.Windows.Forms.Label logpasslbl;
        private System.Windows.Forms.TextBox logintxt;
        protected System.Windows.Forms.TextBox logpasstxt;
        private System.Windows.Forms.Button loginbt;
        private System.Windows.Forms.Button logexitbt;
    }
}

