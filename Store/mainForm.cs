using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace inventory
{
    public partial class mainForm : Form
    {
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void mdi_Load(object sender, EventArgs e)
        {

        }

        private void logintsb_Click(object sender, EventArgs e)
        {
           
                Login l = new Login();
                l.MdiParent = this;
                l.Show();
            
        }

        
        
        private void addtsb_Click(object sender, EventArgs e)
        {
            
                add ad = new add();
                ad.MdiParent = this;
                ad.Show();
            
        }

        public void sellstb_Click(object sender, EventArgs e)
        {
            
                sell se = new sell();
                se.MdiParent = this;
                se.Show();
                
           
        }

        private void buystb_Click(object sender, EventArgs e)
        {
            
                buy by = new buy();
                by.MdiParent = this;
                by.Show();
            
        }

        private void showalltsb_Click(object sender, EventArgs e)
        {
            
        }

        private void exitstb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void logouttsb_Click(object sender, EventArgs e)
        {
            
            logouttsb.Enabled = false;
            exittsb.Enabled = true;
            Logintsb.Enabled = true;
            addtsb.Enabled = false;
            selltsb.Enabled = false;
            buytsb.Enabled = false;
            toolStripDropDownButton1.Enabled = false;
           

            add ad = new add();
            ad.MdiParent = this;
            ad.Close();

            sell se = new sell();
            se.MdiParent = this;
            se.Close();

            buy by = new buy();
            by.MdiParent = this;
            by.Close();

        }

        private void Logintsb_Click_1(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.MdiParent = this;
            l1.Show();

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBuy buy = new ShowBuy();
            buy.MdiParent = this;
            buy.Show();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSell buy = new ShowSell();
            buy.MdiParent = this;
            buy.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}