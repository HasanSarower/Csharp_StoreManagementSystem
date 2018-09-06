using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace inventory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a="USER";
            string b="pswrd";
            if (logintxt.Text==a && logpasstxt.Text == b)
            {        
               // logintxt.Text = "";
               // logpasstxt.Text = "";
                
                mainForm m1 = (mainForm)this.Parent.TopLevelControl;
                m1.Logintsb.Enabled = false;
               // m1.showtsb.Enabled = true;
                m1.selltsb.Enabled = true;
                m1.buytsb.Enabled = true;
                m1.addtsb.Enabled = true;
                m1.exittsb.Enabled = false;
                
                m1.logouttsb.Enabled = true;
                m1.toolStripDropDownButton1.Enabled = true;
               
                   
                this.Close();

                MessageBox.Show("Hello! WELCOME to My Store ! :)"); 
                
            }
            else
            {
                logintxt.Text = "";
                logpasstxt.Text = "";

                MessageBox.Show("Invalid User Name And Password");          
                  
            }
            
           
        }
        

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void untxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            this.Close();
           
           
        }
    }
}