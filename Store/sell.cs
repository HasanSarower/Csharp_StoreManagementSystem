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
    public partial class sell : Form
    {
        
        public sell()
        {
           
            InitializeComponent();
        }
        
      

  

        private void sell_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void sellexitbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sellexitbt_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fill()
        {
            string Error = "";
            DBProductMaster masObj = new DBProductMaster();
            DataTable table = masObj.getAllproduct(ref Error);

            sellpronmcmb.DataSource = table;
            sellpronmcmb.DisplayMember = "ProductName";
            sellpronmcmb.ValueMember = "ProductID";
        }

        private void sellsubbt_Click(object sender, EventArgs e)
        {
            int productID=Convert.ToInt32(sellpronmcmb.SelectedValue);
            string Error = "";
            DBProductMaster masObj = new DBProductMaster();
            double sellCount = masObj.getSellCount(productID, ref Error);
            double purcheCount = masObj.getPurchaseCount(productID, ref Error);
            double qun = Convert.ToInt64(sellqttxt.Text);
            if (qun > (purcheCount - sellCount))
            {
                MessageBox.Show("Invalid");
                return;
            }
            masObj.addSellEntry(Convert.ToInt32(sellpronmcmb.SelectedValue), Convert.ToInt64(sellqttxt.Text), Convert.ToInt64(sellprtxt.Text), sellpnmtxt.Text, selldatetxt.Text, ref Error);

            if (Error != "")
            {
                MessageBox.Show(Error);
            }
            else
            {
                //sellpronmcmb = "";
                //sellqttxt = "";
                //sellprtxt = "";
                //selldatetxt.Text = "";
                //sellpnmtxt = "";
                
            }
        }
        
    }
}