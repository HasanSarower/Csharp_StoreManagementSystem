using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using inventory.DBClass;

namespace inventory
{
    public partial class add : Form
    {
      
        
        public add()
        {
            
            InitializeComponent();
        }

       

        private void exitbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Load(object sender, EventArgs e)
        {

        }

        private void adaddbt_Click(object sender, EventArgs e)
        {
            
            string Error = "";
            DBProductMaster masObj = new DBProductMaster();
            masObj.addProduct(adprotxt.Text, ref Error);

            if (Error != "")
            {
                MessageBox.Show(Error);
            }
            else
            {
                adprotxt.Text = "";
            }
            
        }

        
    }
}