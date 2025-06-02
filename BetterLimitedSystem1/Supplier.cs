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
    public partial class Supplier : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataTable dt;
        public Supplier()
        {
            InitializeComponent();
            con.Connect();
        }


        private void Supplier_Load(object sender, EventArgs e)
        {
            command = new MySqlCommand("SELECT SupplierID FROM supplier WHERE SupplierID=(SELECT max(SupplierID) FROM supplier)", con.cn);
            con.cn.Open();
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                string supplierid = dr[0].ToString();
                string newsupplierid = "SP" + String.Format("{00:0000}", Convert.ToInt32(supplierid.TrimStart("SP".ToCharArray())) + 1);
                txtSupplierID.Text = newsupplierid;
                dr.Close();
            }
            else
            {
                txtSupplierID.Text = "SP" + String.Format("{00:0000}", 1);
                dr.Close();
            }
            con.cn.Close();

            try
            {
                con.cn.Open();
                updateSupplierView("select * from supplier");
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }

            btnUpdate.Visible = false;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("select * from supplier where SupplierName = '" + txtSupplierName.Text + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("You already have this supplier information!Please confirm your supplier Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.cn.Close();
                }
                else
                {
                    dr.Close();
                    command = new MySqlCommand("insert into supplier values(@supplierid,@suppliername,@desc)", con.cn);
                    command.Parameters.AddWithValue("@supplierid", txtSupplierID.Text);
                    command.Parameters.AddWithValue("@suppliername", txtSupplierName.Text);
                    command.Parameters.AddWithValue("@desc", txtDescription.Text);
                    command.ExecuteNonQuery();
                    updateSupplierView("select * from supplier");
                    con.cn.Close();

                    command = new MySqlCommand("SELECT SupplierID FROM supplier WHERE SupplierID=(SELECT max(SupplierID) FROM supplier)", con.cn);
                    con.cn.Open();
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        string supplierid = dr[0].ToString();
                        string newsupplierid = "SP" + String.Format("{00:0000}", Convert.ToInt32(supplierid.TrimStart("SP".ToCharArray())) + 1);
                        txtSupplierID.Text = newsupplierid;
                        dr.Close();
                    }
                    else
                    {
                        txtSupplierID.Text = "SP" + String.Format("{00:0000}", 1);
                        dr.Close();
                    }
                    con.cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }
        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text == "Description...")
            {
                txtDescription.Text = "";
                txtDescription.ForeColor = Color.Black;
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                txtDescription.Text = "Description...";
                txtDescription.ForeColor = Color.Gray;
            }
        }

        private void updateSupplierView(string SqlStr) 
        {
            command = new MySqlCommand(SqlStr, con.cn);
            dr = command.ExecuteReader();
            dt = new DataTable();
            da = new MySqlDataAdapter();
            dt.Load(dr);
            SupplierView.DataSource = dt;
            dr.Close();
        }

        private void SupplierView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SupplierView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SupplierView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSupplierID.Text = SupplierView.CurrentRow.Cells[0].Value.ToString();
            txtSupplierName.Text = SupplierView.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = SupplierView.CurrentRow.Cells[2].Value.ToString();
            btnUpdate.Visible = true;
            txtDescription.ForeColor = Color.Black;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("update supplier set SupplierName = @suppliername, Description = @desc where SupplierID = '" + txtSupplierID.Text + "'",con.cn);
                command.Parameters.AddWithValue("suppliername", txtSupplierName.Text);
                command.Parameters.AddWithValue("desc", txtDescription.Text);
                command.ExecuteNonQuery();
                con.cn.Close();
                MessageBox.Show("You have update the supplier " + txtSupplierID.Text +  " information","",MessageBoxButtons.OK);
                
                con.cn.Open();
                updateSupplierView("select * from supplier order by SupplierID");
                con.cn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            this.Hide();
            i.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("SELECT SupplierID FROM supplier WHERE SupplierID=(SELECT max(SupplierID) FROM supplier)", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    string supplierid = dr[0].ToString();
                    string newsupplierid = "SP" + String.Format("{00:0000}", Convert.ToInt32(supplierid.TrimStart("SP".ToCharArray())) + 1);
                    txtSupplierID.Text = newsupplierid;
                    dr.Close();
                }
                else
                {
                    txtSupplierID.Text = "SP" + String.Format("{00:0000}", 1);
                    dr.Close();
                }
                con.cn.Close();

                txtSupplierName.Text = "";
                txtDescription.Text = "Description...";
                txtDescription.ForeColor = Color.Gray;
                btnUpdate.Visible = false;
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message);}
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (SupplierView.SelectedRows.Count > 0)
            {
                int selectedIndex = SupplierView.SelectedRows[0].Index;

                string SupplierID = SupplierView[0, selectedIndex].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure delete the supplier record of " + SupplierID + "?","Delete Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) 
                {
                    try
                    {
                        con.cn.Open();
                        command = new MySqlCommand("delete from supplier where supplierID = '" + SupplierID + "'",con.cn);
                        command.ExecuteNonQuery();
                        updateSupplierView("select * from supplier");
                        con.cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.cn.Close();
                    }
                }
            }
        }
    }
}
