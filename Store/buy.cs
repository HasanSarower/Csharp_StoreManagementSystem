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
    public partial class buy : Form
    {
        
        public buy()
        {
           
            InitializeComponent();
        }

        private void buy_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpname_Click(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void buyexitbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buysubbt_Click(object sender, EventArgs e)
        {
            string Error = "";
            DBProductMaster masObj = new DBProductMaster();
            masObj.addPurchaseEntry(Convert.ToInt32(buypronamecomb.SelectedValue), Convert.ToInt64(buyqttxt.Text), Convert.ToInt64(buyprtxt.Text), buypnmtxt.Text,buydatetxt.Text, ref Error);
   
            if (Error != "")
            {
                MessageBox.Show(Error);
            }
            else
            {
               
                buyqttxt.Text = "";
                buyprtxt.Text = "";
                buydatetxt.Text = "";
                buypnmtxt.Text = "";
               
            }
        }
        private void fill()
        {
            string Error = "";
            DBProductMaster masObj = new DBProductMaster();
            DataTable table = masObj.getAllproduct(ref Error);

            buypronamecomb.DataSource = table;
            buypronamecomb.DisplayMember = "ProductName";
            buypronamecomb.ValueMember = "ProductID";
        }
       

    }
}