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
    public partial class ShowBuy : Form
    {
        public ShowBuy()
        {
            InitializeComponent();
        }

        private void ShowBuy_Load(object sender, EventArgs e)
        {
            string Error = "";
            DBProductMaster obj = new DBProductMaster();
            DataTable table=obj.getAllPurchaseData(ref Error);
            if (Error != "")
            {
                MessageBox.Show(Error);
            }
            else
            {
                dataGridView1.DataSource = table;
            }
        }
    }
}
