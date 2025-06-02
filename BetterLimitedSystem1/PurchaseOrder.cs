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
    public partial class PurchaseOrder : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataTable dt;
        public PurchaseOrder()
        {
            InitializeComponent();
            con.Connect();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            try
            {
                BindData1();
                ProductView.ReadOnly = true;
                txtHandler.Text = LoginUser.StaffID;
                command = new MySqlCommand("SELECT PurchaseOrder_ID FROM purchaseorder WHERE PurchaseOrder_ID=(SELECT max(PurchaseOrder_ID) FROM purchaseorder)", con.cn);
                con.cn.Open();
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    string orderid = dr[0].ToString();
                    string neworderid = "PO" + String.Format("{00:0000}", Convert.ToInt32(orderid.TrimStart("PO".ToCharArray())) + 1);
                    txtPurchaseOrderID.Text = neworderid;
                    dr.Close();
                }
                else
                {
                    txtPurchaseOrderID.Text = "PO" + String.Format("{00:0000}", 1);
                    dr.Close();
                }
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("delete from cart", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
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

            cbSupplierID.DisplayMember = "SupplierID";
            cbSupplierID.ValueMember = "SupplierID";
            cbSupplierID.DataSource = ds.Tables[0];

            cbSupplierID.Enabled = true;
        }

        private void cbSupplierID_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("select SupplierName from supplier where SupplierID = '" + cbSupplierID.SelectedValue + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    string suppliername = dr[0].ToString();
                    dr.Close();
                    txtSupplierName.Text = suppliername;

                }
                con.cn.Close();
                cbItemID.Text = "";
                BindData2();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        public void BindData2()
        {
            con.cn.Open();
            string strCmd = "select * from product as p left join productstock as ps on p.Item_ID = ps.Item_ID where p.SupplierID = '" + cbSupplierID.SelectedValue + "' and p.Neccessary = '1'";
            command = new MySqlCommand(strCmd, con.cn);
            da = new MySqlDataAdapter(strCmd, con.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            command.ExecuteNonQuery();
            con.cn.Close();

            cbItemID.DisplayMember = "Item_ID";
            cbItemID.ValueMember = "Item_ID";
            cbItemID.DataSource = ds.Tables[0];

            cbItemID.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have submitted purchase order request, Purchase Order ID is " + txtPurchaseOrderID.Text);
            Inventory i = new Inventory();
            this.Hide();
            i.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double total = 0;
            bool hvitem = false;
            string itemid;
            Product p;
            string newpurchaseitemid;
            try
            {
                p = new Product();
                if (cbItemID.SelectedValue.ToString() != string.Empty)
                {
                    con.cn.Open();
                    command = new MySqlCommand("select Item_ID from product where Item_ID='" + cbItemID.SelectedValue.ToString() + "'", con.cn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        command = new MySqlCommand("select Item_ID from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "' and Item_ID = '" + cbItemID.SelectedValue.ToString() + "'", con.cn);
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            hvitem = true;
                        }
                        else
                        {
                            hvitem = false;
                        }
                        dr.Close();
                        con.cn.Close();

                        if (numQty.Value != 0)
                        {
                            if (hvitem == false)
                            {
                                con.cn.Open();
                                command = new MySqlCommand("select * from purchaseorder where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'", con.cn);
                                dr = command.ExecuteReader();
                                if (dr.Read())
                                {
                                    dr.Close();
                                    con.cn.Close();
                                    command = new MySqlCommand("SELECT PurchaseItem_ID FROM purchaseitem WHERE PurchaseItem_ID=(SELECT max(PurchaseItem_ID) FROM purchaseitem)", con.cn);
                                    con.cn.Open();
                                    dr = command.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        string purchaseitemid = dr[0].ToString();
                                        newpurchaseitemid = "PI" + String.Format("{00:000000}", Convert.ToInt32(purchaseitemid.TrimStart("PI".ToCharArray())) + 1);
                                        dr.Close();
                                    }
                                    else
                                    {
                                        newpurchaseitemid = "PI" + String.Format("{00:000000}", 1);
                                        dr.Close();
                                    }
                                    con.cn.Close();
                                    con.cn.Open();
                                    command = new MySqlCommand("select * from product where Item_ID='" + cbItemID.SelectedValue.ToString() + "'", con.cn);
                                    dr = command.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        p.setItem_ID(dr["Item_ID"].ToString());
                                        p.setprice((Double)(dr["Price"]));
                                        dr.Close();
                                        command = new MySqlCommand("Insert into purchaseitem values(@Purchaseitemid,@purchaseorderid,@itemid,@qty,@price,@totalprice)", con.cn);
                                        command.Parameters.AddWithValue("Purchaseitemid", newpurchaseitemid);
                                        command.Parameters.AddWithValue("purchaseorderid", txtPurchaseOrderID.Text);
                                        command.Parameters.AddWithValue("itemid", p.Item_ID);
                                        command.Parameters.AddWithValue("qty", (int)(numQty.Value));
                                        command.Parameters.AddWithValue("price", p.price);
                                        double Price = p.price * (double)(numQty.Value);
                                        command.Parameters.AddWithValue("totalprice", Price);
                                        command.ExecuteNonQuery();
                                        itemid = cbItemID.SelectedValue.ToString();
                                        con.cn.Close();
                                        txtTotal.Text = Price.ToString();
                                        con.cn.Open();
                                        updateProductView("select Item_ID,Quantity,Price from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'");
                                        con.cn.Close();

                                        command = new MySqlCommand("select SUM(Total_Price) from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'", con.cn);
                                        con.cn.Open();
                                        dr = command.ExecuteReader();
                                        if (dr.Read())
                                        {
                                            total = double.Parse(dr[0].ToString());
                                            dr.Close();
                                        }
                                        con.cn.Close();
                                        txtTotal.Text = total.ToString();
                                    }
                                }
                                else
                                {
                                    dr.Close();
                                    con.cn.Close();
                                    command = new MySqlCommand("SELECT PurchaseItem_ID FROM purchaseitem WHERE PurchaseItem_ID=(SELECT max(PurchaseItem_ID) FROM purchaseitem)", con.cn);
                                    con.cn.Open();
                                    dr = command.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        string purchaseitemid = dr[0].ToString();
                                        newpurchaseitemid = "PI" + String.Format("{00:000000}", Convert.ToInt32(purchaseitemid.TrimStart("PI".ToCharArray())) + 1);
                                        dr.Close();
                                    }
                                    else
                                    {
                                        newpurchaseitemid = "PI" + String.Format("{00:000000}", 1);
                                        dr.Close();
                                    }
                                    con.cn.Close();
                                    con.cn.Open();
                                    command = new MySqlCommand("select * from product where Item_ID='" + cbItemID.SelectedValue.ToString() + "'", con.cn);
                                    dr = command.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        p.setItem_ID(dr["Item_ID"].ToString());
                                        p.setprice((Double)(dr["Price"]));

                                        dr.Close();
                                        command = new MySqlCommand("insert into purchaseorder values(@purchaseorderid,@supplierid,@Status)", con.cn);
                                        command.Parameters.AddWithValue("purchaseorderid", txtPurchaseOrderID.Text);
                                        command.Parameters.AddWithValue("supplierid", cbSupplierID.SelectedValue.ToString());
                                        command.Parameters.AddWithValue("Status", "Awaiting Approval");
                                        command.ExecuteNonQuery();
                                        command = new MySqlCommand("Insert into purchaseitem values(@Purchaseitemid,@purchaseorderid,@itemid,@qty,@price,@totalprice)", con.cn);
                                        command.Parameters.AddWithValue("Purchaseitemid", newpurchaseitemid);
                                        command.Parameters.AddWithValue("purchaseorderid", txtPurchaseOrderID.Text);
                                        command.Parameters.AddWithValue("itemid", p.Item_ID);
                                        command.Parameters.AddWithValue("qty", (int)(numQty.Value));
                                        command.Parameters.AddWithValue("price", p.price);
                                        double Price = p.price * (double)(numQty.Value);
                                        command.Parameters.AddWithValue("totalprice", Price);
                                        command.ExecuteNonQuery();
                                        itemid = cbItemID.SelectedValue.ToString();
                                        con.cn.Close();
                                        txtTotal.Text = Price.ToString();
                                        con.cn.Open();
                                        updateProductView("select Item_ID,Quantity,Price from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'");
                                        con.cn.Close();

                                        command = new MySqlCommand("select SUM(Total_Price) from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'", con.cn);
                                        con.cn.Open();
                                        dr = command.ExecuteReader();
                                        if (dr.Read())
                                        {
                                            total = double.Parse(dr[0].ToString());
                                            dr.Close();
                                        }
                                        con.cn.Close();
                                        txtTotal.Text = total.ToString();
                                    }
                                }

                                cbSupplierID.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Your list already have this item, please edit by click the item in cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                con.cn.Close();
                                cbItemID.Text = "";
                                numQty.Value = 0;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please enter valid qty of product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.cn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Item ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.cn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the Item ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }


        public void updateProductView(string SqlStr) 
        {
            dt = new DataTable();
            da = new MySqlDataAdapter(SqlStr, con.cn);
            dt.Clear();
            da.Fill(dt);
            ProductView.DataSource = dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("select * from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    command = new MySqlCommand("delete from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'", con.cn);
                    command.ExecuteNonQuery();
                    command = new MySqlCommand("delete from purchaseorder where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'", con.cn);
                    command.ExecuteNonQuery();
                }
                con.cn.Close();


                Inventory i = new Inventory();
                this.Hide();
                i.Show();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                if (ProductView.SelectedRows.Count > 0)
                {
                    int selectedIndex = ProductView.SelectedRows[0].Index;

                    string ItemID = ProductView[0, selectedIndex].Value.ToString();
                    con.cn.Open();
                    command = new MySqlCommand("delete from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "' and Item_ID = '" + ItemID + "'", con.cn);
                    command.ExecuteNonQuery();
                    con.cn.Close();

                    command = new MySqlCommand("select sum(Total_Price) from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'", con.cn);
                    con.cn.Open();
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        if (dr[0].ToString() == "")
                        {
                            total = 0;
                        }
                        else 
                        {
                            total = double.Parse(dr[0].ToString());
                        }
                        dr.Close();
                    }
                    txtTotal.Text = total.ToString();
                    con.cn.Close();


                    con.cn.Open();
                    updateProductView("select Item_ID,Quantity,Price from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'");
                    con.cn.Close();
                }
                else
                {
                    MessageBox.Show("Please select the product to delete.", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deleting Failed:" + ex.Message.ToString(), "Delete",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.cn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            double total = 0;
            con.cn.Open();
            updateProductView("select Item_ID,Quantity,Price from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'");
            con.cn.Close();

            command = new MySqlCommand("select sum(Total_Price) from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'", con.cn);
            con.cn.Open();
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "")
                {
                    total = 0;
                }
                else 
                {
                    total = double.Parse(dr[0].ToString());
                }
                dr.Close();
            }
            con.cn.Close();

            txtTotal.Text = total.ToString();
        }

        private void ProductView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PurchaseItemDetail PID = new PurchaseItemDetail();
            PID.txtPurchaseOrderID.Text = txtPurchaseOrderID.Text;
            PID.txtItemID.Text = this.ProductView.CurrentRow.Cells[0].Value.ToString();
            PID.txtQty.Text = this.ProductView.CurrentRow.Cells[1].Value.ToString();
            PID.txtPrice.Text = this.ProductView.CurrentRow.Cells[2].Value.ToString();
            PID.ShowDialog();
        }
    }
}
