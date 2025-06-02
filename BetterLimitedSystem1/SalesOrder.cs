using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System;

namespace BetterLimitedSystem1
{
    public partial class SalesOrder : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt;

        public SalesOrder()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            SalesMenu sm = new SalesMenu();
            this.Hide();
            sm.ShowDialog();
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            CreateSalesOrder cso = new CreateSalesOrder();
            this.Hide();
            cso.ShowDialog();
        }

        private void SalesOrder_Load(object sender, System.EventArgs e)
        {
            try
            {
                if (LoginUser.dept == "Sales" || LoginUser.dept == "CEO")
                {
                    btnCreate.Visible = true;
                }
                else 
                {
                    btnCreate.Visible = false;
                }
                SalesOrderView.ReadOnly = true;
                con.cn.Open();
                UpdateOrderView("select * from salesorder order by Order_ID");
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
            if (LoginUser.dept == "CEO" || LoginUser.dept == "IT")
            {
                staffListToolStripMenuItem.Visible = true;
            }
            else
            {
                staffListToolStripMenuItem.Visible = false;
            }

            if (LoginUser.dept == "CEO" || LoginUser.dept == "Purchase")
            {
                purchaseOrderListToolStripMenuItem.Visible = true;
            }
            else 
            {
                purchaseOrderListToolStripMenuItem.Visible = false;
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != String.Empty)
                {
                    con.cn.Open();
                    if (comboBoxSearchBy.Text == "Order ID")
                    {
                        UpdateOrderView("Select * from salesorder where Order_ID = '" + txtSearch.Text + "'");
                        con.cn.Close();
                    }
                    else if (comboBoxSearchBy.Text == "Customer Email")
                    {
                        UpdateOrderView("Select * from salesorder where Customer_Email like '%" + txtSearch.Text + "%'");
                        con.cn.Close();
                    }
                }
                else {
                    MessageBox.Show("You need to enter the key word to search!", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
                    con.cn.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SalesOrderView.ReadOnly = true;
            con.cn.Open();
            UpdateOrderView("select * from salesorder order by Order_ID");
            con.cn.Close();
        }

        private void SalesOrderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void UpdateOrderView(string SqlStr) 
        {
            dt = new DataTable();
            da = new MySqlDataAdapter(SqlStr,con.cn);
            dt.Clear();
            da.Fill(dt);
            SalesOrderView.DataSource = dt;

        }
        private void SalesOrderView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Order_Detail OD = new Order_Detail();
            OD.txtOrderID.Text = this.SalesOrderView.CurrentRow.Cells[0].Value.ToString();
            this.Hide();
            OD.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                UpdateOrderView("select * from salesorder where Order_Date between '" + dtpFromDate.Text + "' and '" + dtpToDate.Text + "'");
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void deliveryAndInstallationManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryandInstallationManagement DI = new DeliveryandInstallationManagement();
            this.Hide();
            DI.Show();
        }
        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesOrder so = new SalesOrder();
            this.Hide();
            so.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            this.Hide();
            i.Show();
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffList sl = new StaffList();
            this.Hide();
            sl.Show();

        }

        private void createMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMemo cm = new CreateMemo();
            this.Hide();
            cm.Show();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void MenumenuItem_Click(object sender, EventArgs e)
        {
            SalesMenu sm = new SalesMenu();
            this.Hide();
            sm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {

        }

        private void purchaseOrderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrderList pol = new PurchaseOrderList();
            this.Hide();
            pol.Show();
        }
    }
}
