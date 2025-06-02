using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BetterLimitedSystem1
{
    public partial class Inventory : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataTable dt;
        public Inventory()
        {
            InitializeComponent();
            con.Connect();
        }

        private void Inventory_Load(object sender, System.EventArgs e)
        {
            if (LoginUser.dept == "Inventory" || LoginUser.dept == "CEO")
            {
                btnAddProduct.Visible = true;
                btn_SupplierList.Visible = true;
                btn_GoodsReturn.Visible = true;
                btnPurchase.Visible = true;
                btnInwardsRecord.Visible = true;
            }
            else 
            {
                btnPurchase.Visible = false;
                btnAddProduct.Visible = false;
                btn_SupplierList.Visible = false;
                btn_GoodsReturn.Visible = false;
                btnInwardsRecord.Visible = false;
            }
            try
            {
                con.cn.Open();
                command = new MySqlCommand("Select p.Item_ID as Item_ID, p.Item_Name as Item_Name, p.SupplierID as Supplier_ID, ps.StockQuantity as Stock_Qty,ps.Reservation as Reservation_Qty,ps.ReOrderLevel as ReOrder_level from product as p left join productstock as ps on p.Item_ID = ps.Item_ID", con.cn);
                dr = command.ExecuteReader();
                dt = new DataTable();
                da = new MySqlDataAdapter();
                dt.Load(dr);
                ProductView.DataSource = dt;
                dr.Close();
                con.cn.Close();

                con.cn.Open();
                command = new MySqlCommand("select Item_ID, StockQuantity,ReOrderLevel from productstock",con.cn);
                dr = command.ExecuteReader();
                dt = new DataTable();
                da = new MySqlDataAdapter();
                dt.Load(dr);
                for(int i = 0; i < dt.Rows.Count; i++) 
                {
                    Product p = new Product();
                    string Item_ID = dt.Rows[i]["Item_ID"].ToString();
                    int StockQuantity = Convert.ToInt32(dt.Rows[i]["StockQuantity"].ToString());
                    int ReOrderLevel = Convert.ToInt32(dt.Rows[i]["ReOrderLevel"].ToString());
                    if (StockQuantity < ReOrderLevel) 
                    {
                        MessageBox.Show(Item_ID + " is low level product, please send purchase request!", "Low Level Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            SalesMenu s = new SalesMenu();
            this.Hide();
            s.ShowDialog();
        }

        private void ProductView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LoginUser.dept == "Inventory" || LoginUser.dept == "CEO")
            {
                ProductDetail PD = new ProductDetail();
                PD.txtItemID.Text = this.ProductView.CurrentRow.Cells[0].Value.ToString();
                this.Hide();
                PD.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Only Inventory department staff can view the product detail", "have not permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e) 
        {
            try
            {
                if (LoginUser.dept == "Inventory" || LoginUser.dept == "Sales" || LoginUser.dept == "CEO" || LoginUser.dept == "Admin")
                {
                    CreateProduct CP = new CreateProduct();
                    this.Hide();
                    CP.ShowDialog();
                }
                else 
                {
                    MessageBox.Show("Only Inventory department staff can view the product detail", "have not permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            con.cn.Open();
            dt = new DataTable();
            da = new MySqlDataAdapter("Select p.Item_ID as Item_ID, p.Item_Name as Item_Name, p.SupplierID as Supplier_ID, ps.StockQuantity as Stock_Qty,ps.ReOrderLevel as ReOrder_level from product as p left join productstock as ps on p.Item_ID = ps.Item_ID", con.cn);
            dt.Clear();
            da.Fill(dt);
            ProductView.DataSource = dt;
            con.cn.Close();
        }

        private void btn_SupplierList_Click(object sender, EventArgs e)
        {
            Supplier Sup = new Supplier();
            this.Hide();
            Sup.Show();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Search...")
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != string.Empty)
                {
                    con.cn.Open();
                    switch (comboBoxSearchBy.Text) {
                        case "All":
                            UpdateOrderView("Select p.Item_ID as Item_ID, p.Item_Name as Item_Name, p.SupplierID as Supplier_ID, ps.StockQuantity as Stock_Qty,ps.Reservation as Reservation_Qty,ps.ReOrderLevel as ReOrder_level from product as p left join productstock as ps on p.Item_ID = ps.Item_ID");
                            con.cn.Close();
                            break;
                        case "Product ID":
                            UpdateOrderView("Select p.Item_ID as Item_ID, p.Item_Name as Item_Name, p.SupplierID as Supplier_ID, ps.StockQuantity as Stock_Qty,ps.Reservation as Reservation_Qty,ps.ReOrderLevel as ReOrder_level from product as p left join productstock as ps on p.Item_ID = ps.Item_ID where p.Item_ID = '" + txtSearch.Text + "'");
                            con.cn.Close();
                            break;
                        case "Product Name":
                            UpdateOrderView("Select p.Item_ID as Item_ID, p.Item_Name as Item_Name, p.SupplierID as Supplier_ID, ps.StockQuantity as Stock_Qty,ps.Reservation as Reservation_Qty,ps.ReOrderLevel as ReOrder_level from product as p left join productstock as ps on p.Item_ID = ps.Item_ID where p.Item_Name like '%" + txtSearch.Text + "%'");
                            con.cn.Close();
                            break;
                        case "Supplier":
                            UpdateOrderView("select p.Item_ID,p.Item_Name,p.SupplierID,p.Description,P.Price from product as p left join supplier as sp on p.SupplierID = sp.SupplierID where sp.SupplierName like  '%" + txtSearch.Text + "%' order by p.Item_ID");
                            con.cn.Close();
                            break;
                    }
                }
                else
                {
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
        public void UpdateOrderView(string SqlStr)
        {
            dt = new DataTable();
            da = new MySqlDataAdapter(SqlStr, con.cn);
            dt.Clear();
            da.Fill(dt);
            ProductView.DataSource = dt;
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

        private void ProductView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PurchaseOrder PO = new PurchaseOrder();
            this.Hide();
            PO.Show();
        }

        private void btn_GoodsReturn_Click(object sender, EventArgs e)
        {
            GoodsReturn GR = new GoodsReturn();
            this.Hide();
            GR.Show();
        }

        private void purchaseOrderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrderList POL = new PurchaseOrderList();
            this.Hide();
            POL.Show();
        }

        private void btnInwardsRecord_Click(object sender, EventArgs e)
        {
            InwardsRecord IR = new InwardsRecord();
            this.Hide();
            IR.Show();
        }
    }


}
