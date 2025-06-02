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
    public partial class DeliveryOrder : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataTable dt;
        public DeliveryOrder()
        {
            InitializeComponent();
            con.Connect();
        }

        private void DeliveryOrder_Load(object sender, EventArgs e)
        {
            BindData1();
        }

        private void updateProductView(string SqlStr)
        {
            command = new MySqlCommand(SqlStr, con.cn);
            dr = command.ExecuteReader();
            dt = new DataTable();
            da = new MySqlDataAdapter();
            dt.Load(dr);
            ProductView.DataSource = dt;
            dr.Close();
        }
        public void BindData1()
        {
            con.cn.Open();
            string strCmd = "select * from delivery where Delivery_workman = '" + LoginUser.StaffID + "' and Status = 'Processing'";
            command = new MySqlCommand(strCmd, con.cn);
            da = new MySqlDataAdapter(strCmd, con.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            command.ExecuteNonQuery();
            con.cn.Close();

            cbDeliveryOrderID.DisplayMember = "Deli_ID";
            cbDeliveryOrderID.ValueMember = "Deli_ID";
            cbDeliveryOrderID.DataSource = ds.Tables[0];

            cbDeliveryOrderID.Enabled = true;
        }

        private void cbDeliveryOrderID_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFinishDelivery_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you finished " + txtOrderID.Text + " Delivery Order?", "Delivery Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try 
                {
                    con.cn.Open();
                    command = new MySqlCommand("update delivery set Status = 'Finish' where Deli_ID = '" + cbDeliveryOrderID.SelectedValue + "'",con.cn);
                    command.ExecuteNonQuery();
                    command = new MySqlCommand("select * from delivery where Deli_ID = '" + cbDeliveryOrderID.SelectedValue + "'", con.cn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        txtStatus.Text = dr["Status"].ToString();
                        dr.Close();
                    }
                    con.cn.Close();
                    BindData1();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Please confirm you finished the " + txtOrderID.Text + " delivery order");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("select * from delivery where Deli_ID = '" + cbDeliveryOrderID.SelectedValue + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txtOrderID.Text = dr["Order_ID"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    DateTime date = DateTime.Parse(dr["Delivery_Date"].ToString());
                    txtDeliveryDate.Text = date.ToString("yyyy-MM-dd");
                    txtSession.Text = dr["Delivery_Session"].ToString();
                    txtWorkMan.Text = dr["Delivery_workman"].ToString();
                    txtStatus.Text = dr["Status"].ToString();
                    dr.Close();
                }
                updateProductView("select Item_ID,Order_Qty from ordereditems where Order_ID = '" + txtOrderID.Text + "'");
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You dont have processing delivery order");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            WorkManMenu WM = new WorkManMenu();
            this.Hide();
            WM.Show();
        }
    }
}
