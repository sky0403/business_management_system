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
    public partial class PurchaseOrderList : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataTable dt;
        public PurchaseOrderList()
        {
            InitializeComponent();
            con.Connect();
        }

        private void PurchaseOrderList_Load(object sender, EventArgs e)
        {
            try
            {
                PurchaseOrderView.ReadOnly = true;
                con.cn.Open();
                UpdateOrderView("select * from purchaseorder order by PurchaseOrder_ID");
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
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesOrder so = new SalesOrder();
            this.Hide();
            so.Show();
        }

        public void UpdateOrderView(string SqlStr)
        {
            dt = new DataTable();
            da = new MySqlDataAdapter(SqlStr, con.cn);
            dt.Clear();
            da.Fill(dt);
            PurchaseOrderView.DataSource = dt;

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            this.Hide();
            i.Show();
        }

        private void deliveryAndInstallationManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryandInstallationManagement DI = new DeliveryandInstallationManagement();
            this.Hide();
            DI.Show();
        }

        private void purchaseOrderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrderList POL = new PurchaseOrderList();
            this.Hide();
            POL.Show();
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffList sl = new StaffList();
            this.Hide();
            sl.Show();
        }

        private void createMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMemo CM = new CreateMemo();
            this.Hide();
            CM.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (comboBoxSearchBy.Text) 
            {
                case "Purchase Order ID":
                    con.cn.Open();
                    UpdateOrderView("select * from purchaseorder where Purchase_ID = '" + txtSearch.Text + "' order by PurchaseOrder_ID");
                    con.cn.Close();
                    break;
                case "Supplier ID":
                    con.cn.Open();
                    UpdateOrderView("select * from purchaseorder where SupplierID = '" + txtSearch.Text + "' order by PurchaseOrder_ID");
                    con.cn.Close();
                    break;
                case "Status":
                    con.cn.Open();
                    UpdateOrderView("select * from purchaseorder where Status like '%" + txtSearch.Text + "%' order by PurchaseOrder_ID");
                    con.cn.Close();
                    break;

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            con.cn.Open();
            UpdateOrderView("select * from purchaseorder order by PurchaseOrder_ID");
            con.cn.Close();
        }

        private void PurchaseOrderView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LoginUser.dept == "CEO" || LoginUser.dept == "Purchase")
            {
                PurchaseOrderDetail POD = new PurchaseOrderDetail();
                POD.txtPurchaseOrderID.Text = this.PurchaseOrderView.CurrentRow.Cells[0].Value.ToString();
                this.Hide();
                POD.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Only CEO and Purchase department staff can access purchase order details", "No Permission",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SalesMenu sm = new SalesMenu();
            this.Hide();
            sm.Show();
        }
    }
}
