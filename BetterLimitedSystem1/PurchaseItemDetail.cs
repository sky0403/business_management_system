using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BetterLimitedSystem1
{
    public partial class PurchaseItemDetail : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;

        public PurchaseItemDetail()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                double totalprice = double.Parse(txtPrice.Text) * double.Parse(txtQty.Text);
                con.cn.Open();
                command = new MySqlCommand("update purchaseitem set Quantity = '" + txtQty.Text + "', Total_Price = '" + totalprice.ToString() + "' where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text  + "' and Item_ID = '" + txtItemID.Text + "'", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
