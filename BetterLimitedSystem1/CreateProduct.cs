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
    public partial class CreateProduct : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;

        public CreateProduct()
        {
            InitializeComponent();
            con.Connect();
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            BindData1();
            cbNeccessary.Checked = true;
            try
            {
                command = new MySqlCommand("SELECT Item_ID FROM product WHERE Item_ID=(SELECT max(Item_ID) FROM product)", con.cn);
                con.cn.Open();
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    string itemid = dr[0].ToString();
                    string newitemid = "P" + String.Format("{0:000000}", Convert.ToInt32(itemid.TrimStart('P')) + 1);
                    txtItemID.Text = newitemid;
                }
                else
                {
                    txtItemID.Text = "P" + String.Format("{0:000000}", 1);
                }
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string supplierid;
                if (txtItemName.Text != string.Empty && txtPrice.Text != string.Empty )
                {
                    con.cn.Open();
                    command = new MySqlCommand("select SupplierID from Supplier where SupplierName ='" + cbSupplier.Text + "'", con.cn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        supplierid = dr[0].ToString();
                        dr.Close();
                        command = new MySqlCommand("insert into product values(@itemid,@itemname,@supplierid,@desc,@price,@necc,@ava)",con.cn);
                        command.Parameters.AddWithValue("itemid", txtItemID.Text);
                        command.Parameters.AddWithValue("itemname", txtItemName.Text);
                        command.Parameters.AddWithValue("supplierid", supplierid);
                        command.Parameters.AddWithValue("desc", txtDesc.Text);
                        command.Parameters.AddWithValue("price", txtPrice.Text);
                        if (cbNeccessary.Checked == true)
                        {
                            command.Parameters.AddWithValue("necc", 1);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("necc", 0);
                        }
                        if (numStock.Value > 0)
                        {
                            command.Parameters.AddWithValue("ava", 1);
                        }
                        else 
                        {
                            command.Parameters.AddWithValue("ava", 0);
                        }
                        command.ExecuteNonQuery();
                        command = new MySqlCommand("insert into productstock values(@itemid,@stockqty,@reservation,@reorderlevel)",con.cn);
                        command.Parameters.AddWithValue("itemid", txtItemID.Text);
                        command.Parameters.AddWithValue("stockqty", numStock.Text);
                        command.Parameters.AddWithValue("reorderlevel", numReOrder.Text);
                        command.Parameters.AddWithValue("reservation", 0);
                        command.ExecuteNonQuery();
                        con.cn.Close();
                    }
                    Inventory I = new Inventory();
                    this.Hide();
                    I.ShowDialog();
                }
                else 
                {
                    MessageBox.Show("Please fill in all field of product", "Not enough information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.cn.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }
        public void BindData1()
        {
            con.cn.Open();
            string strCmd = "select * from supplier";
            command = new MySqlCommand(strCmd, con.cn);
            da = new MySqlDataAdapter(strCmd, con.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            command.ExecuteNonQuery();
            con.cn.Close();

            cbSupplier.DisplayMember = "SupplierName";
            cbSupplier.ValueMember = "SupplierID";
            cbSupplier.DataSource = ds.Tables[0];

            cbSupplier.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Inventory I = new Inventory();
            this.Hide();
            I.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SalesMenu sm = new SalesMenu();
            this.Hide();
            sm.ShowDialog();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && ch != 8 && ch != 46) 
            {
                e.Handled = true;
                MessageBox.Show("Price should be number");
            }
        }
    }
}
