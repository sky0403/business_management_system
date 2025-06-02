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
    public partial class ProductDetail : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataTable dt;
        public ProductDetail()
        {
            InitializeComponent();
            con.Connect();
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            BindData1();
            try
            {
                con.cn.Open();
                command = new MySqlCommand("select * from product where Item_ID = '" + txtItemID.Text + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txtItemName.Text = dr["Item_Name"].ToString();
                    txtPrice.Text = dr["Price"].ToString();
                    txtDesc.Text = dr["Description"].ToString();
                    string supplierid = dr["SupplierID"].ToString();
                    string necc = dr["Neccessary"].ToString();
                    if (Convert.ToInt32(necc) == 1)
                    {
                        cbNeccessary.Checked = true;
                    }
                    else
                    {
                        cbNeccessary.Checked = false;
                    }
                    string ava = dr["Avalibility"].ToString();
                    if (Convert.ToInt32(ava) == 1)
                    {
                        cbAvalibility.Checked = true;
                    }
                    else
                    {
                        cbAvalibility.Checked = false;
                    }
                    dr.Close();
                    command = new MySqlCommand("select SupplierName from supplier where SupplierID = '" + supplierid + "'", con.cn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        cbSupplier.Text = dr[0].ToString();
                        dr.Close();
                    }
                }

                command = new MySqlCommand("select * from productstock where Item_ID = '" + txtItemID.Text + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txtStock.Text = dr["StockQuantity"].ToString();
                    numReOrder.Text = dr["ReOrderLevel"].ToString();
                    txtReserve.Text = dr["Reservation"].ToString();
                    dr.Close();
                }


                con.cn.Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory I = new Inventory();
                DialogResult result;
                result = MessageBox.Show(this, "Are you sure you want to update this Product information?", "Update Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    con.cn.Open();
                    command = new MySqlCommand("update product set Item_Name = @itemname, Price = @price,Neccessary = @necc,Avalibility = @ava, Description = @desc where Item_ID = '" + txtItemID.Text + "'", con.cn);
                    command.Parameters.AddWithValue("itemname", txtItemName.Text);
                    command.Parameters.AddWithValue("price", txtPrice.Text);
                    command.Parameters.AddWithValue("desc", txtDesc.Text);
                    if (cbNeccessary.Checked == true)
                    {
                        command.Parameters.AddWithValue("necc", 1);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("necc", 0);
                    }
                    if (Convert.ToInt32(txtStock.Text) > 0 && cbAvalibility.Checked == true)
                    {
                        command.Parameters.AddWithValue("ava", 1);
                    }
                    else 
                    {
                        command.Parameters.AddWithValue("ava", 0);
                    }
                    command.ExecuteNonQuery();
                    command = new MySqlCommand("update productstock set ReOrderLevel = @reorderlevel where Item_ID = '" + txtItemID.Text + "'",con.cn);
                    command.Parameters.AddWithValue("reorderlevel", numReOrder.Text);
                    command.ExecuteNonQuery();
                    con.cn.Close();
                    this.Hide();
                    I.ShowDialog();


                }
                else
                {
                    con.cn.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Inventory I = new Inventory();
            this.Hide();
            I.ShowDialog();

        }

        public void BindData1()
        {
            con.cn.Open();
            string strCmd = "select SupplierName from supplier";
            command = new MySqlCommand(strCmd, con.cn);
            da = new MySqlDataAdapter(strCmd, con.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            command.ExecuteNonQuery();
            con.cn.Close();

            cbSupplier.DisplayMember = "SupplierName";
            cbSupplier.ValueMember = "SupplierName";
            cbSupplier.DataSource = ds.Tables[0];

            cbSupplier.Enabled = true;

        }

        private void btnInward_Click(object sender, EventArgs e)
        {
            
            int Inward = 0;
            int reser = 0;
            int newreser = 0;
            int qty = 0;
            int newqty = 0;
            string inwardsid = "";
            string newinwardsid = "";
            DialogResult result;
            if (numInwards.Value != 0) {
                result = MessageBox.Show(this, "Are you sure you want to inward goods?", "Update Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        command = new MySqlCommand("SELECT InwardsID FROM inwardsrecord WHERE InwardsID=(SELECT max(InwardsID) FROM inwardsrecord)", con.cn);
                        con.cn.Open();
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            inwardsid = dr[0].ToString();
                            newinwardsid = "IW" + String.Format("{00:000000}", Convert.ToInt32(inwardsid.TrimStart("IW".ToCharArray())) + 1);
                        }
                        else
                        {
                            newinwardsid = "IW" + String.Format("{00:000000}", 1);
                        }
                        con.cn.Close();
                        DateTime date = DateTime.Now;
                        string current = date.ToString("yyyy-MM-dd");
                        con.cn.Open();
                        command = new MySqlCommand("insert into inwardsrecord values(@inwardsid,@itemid,@qty,@inwardsdate)", con.cn);
                        command.Parameters.AddWithValue("inwardsid", newinwardsid);
                        command.Parameters.AddWithValue("itemid", txtItemID.Text);
                        command.Parameters.AddWithValue("qty", numInwards.Value);
                        command.Parameters.AddWithValue("inwardsdate", current);
                        command.ExecuteNonQuery();
                        con.cn.Close();

                        con.cn.Open();
                        command = new MySqlCommand("select * from productstock where Item_ID = '" + txtItemID.Text + "'", con.cn);
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            qty = Convert.ToInt32(dr["StockQuantity"].ToString());
                            reser = Convert.ToInt32(dr["Reservation"].ToString());
                            dr.Close();
                        }
                        con.cn.Close();
                        Inward = Convert.ToInt32(numInwards.Value);
                        if (reser > 0)
                        {
                            newreser = reser - Inward;
                            if (newreser < 0)
                            {
                                newqty = newreser * -1;
                                con.cn.Open();
                                command = new MySqlCommand("update productstock set Reservation = '0', StockQuantity = '" + newqty.ToString() + "' where Item_ID = '" + txtItemID.Text + "'", con.cn);
                                command.ExecuteNonQuery();
                                command = new MySqlCommand("update product set Avalibility = '1' where Item_ID = '" + txtItemID.Text + "'", con.cn);
                                command.ExecuteNonQuery();
                                con.cn.Close();

                            }
                            else
                            {
                                con.cn.Open();
                                command = new MySqlCommand("update productstock set Reservation = '" + newreser.ToString() + "' where Item_ID = '" + txtItemID.Text + "'", con.cn);
                                command.ExecuteNonQuery();
                                command = new MySqlCommand("update product set Avalibility = '0' where Item_ID = '" + txtItemID.Text + "'", con.cn);
                                command.ExecuteNonQuery();
                                con.cn.Close();
                            }
                        }
                        else
                        {
                            newqty = qty + Inward;
                            con.cn.Open();
                            command = new MySqlCommand("update productstock set StockQuantity = '" + newqty.ToString() + "'where Item_ID = '" + txtItemID.Text + "'", con.cn);
                            command.ExecuteNonQuery();
                            command = new MySqlCommand("update product set Avalibility = '1' where Item_ID = '" + txtItemID.Text + "'", con.cn);
                            command.ExecuteNonQuery();
                            con.cn.Close();
                        }


                        con.cn.Open();
                        command = new MySqlCommand("select * from productstock where Item_ID = '" + txtItemID.Text + "'", con.cn);
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            txtStock.Text = dr["StockQuantity"].ToString();
                            txtReserve.Text = dr["Reservation"].ToString();
                            dr.Close();

                            if (Convert.ToInt32(txtStock.Text) > 0)
                            {
                                cbAvalibility.Checked = true;
                            }
                            else 
                            {
                                cbAvalibility.Checked = false;
                            }
                        }
                        con.cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.cn.Close();
                    }
                }
            }
            else 
            {
                MessageBox.Show("Inwards number should not be 0");
            }
        }
    }
}
