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
    public partial class OrdereditemDetail : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        DataTable dt;
        MySqlDataAdapter da;
        public OrdereditemDetail()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                con.cn.Open();
                command = new MySqlCommand("update cart set Qty = '" + txtQty.Text + "', Price = '" + txtPrice.Text + "' where Item_ID = '" + txtItemID.Text + "'", con.cn);
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

        private void OrdereditemDetail_Load(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text != String.Empty) 
            {
            con.cn.Open();
            command = new MySqlCommand("select Price from product where Item_ID = '" + txtItemID.Text + "'", con.cn);
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                txtPrice.Text = (Double.Parse(txtQty.Text) * Double.Parse(dr[0].ToString())).ToString();
                dr.Close();
            }

            con.cn.Close();
            }
        }
    }
}
