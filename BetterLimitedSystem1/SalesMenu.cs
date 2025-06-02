using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BetterLimitedSystem1
{
    public partial class SalesMenu : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataTable dt;
        public SalesMenu()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnStaffList_Click(object sender, System.EventArgs e)
        {
            StaffList sl = new StaffList();
            this.Hide();
            sl.ShowDialog();
        }

        private void btnSalesOrder_Click(object sender, System.EventArgs e)
        {
            SalesOrder so = new SalesOrder();
            this.Hide();
            so.ShowDialog();
        }

        private void Logout_Click(object sender, System.EventArgs e)
        {
            con.cn.Close();
            LoginUser.StaffID = "";
            LoginUser.Name = "";
            LoginUser.dept = "";
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
        }

        private void SalesMenu_Load(object sender, System.EventArgs e)
        {
            String Content = "";
            if (LoginUser.dept == "Inventory" || LoginUser.dept == "Sales" || LoginUser.dept == "CEO")
            {
                try
                {
                    con.cn.Open();
                    command = new MySqlCommand("select Item_ID, StockQuantity,ReOrderLevel from productstock", con.cn);
                    dr = command.ExecuteReader();
                    dt = new DataTable();
                    da = new MySqlDataAdapter();
                    dt.Load(dr);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Product p = new Product();
                        string Item_ID = dt.Rows[i]["Item_ID"].ToString();
                        int StockQuantity = Convert.ToInt32(dt.Rows[i]["StockQuantity"].ToString());
                        int ReOrderLevel = Convert.ToInt32(dt.Rows[i]["ReOrderLevel"].ToString());
                        if (StockQuantity < ReOrderLevel)
                        {
                            //MessageBox.Show(Item_ID + " is low level product, please send purchase request!", "Low Level Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Content += Item_ID + " is low level, please send purchase request!\n\n";
                        }
                    }
                    dr.Close();
                    con.cn.Close();
                    if (Content == "")
                    {
                        RTB_Alert.Text = "All product is enough\n\n";
                        RTB_Alert.ForeColor = Color.Black;
                    }
                    else
                    {
                        Content = "Product Alert:\n" + Content;
                        RTB_Alert.Text = Content;
                        RTB_Alert.ForeColor = Color.Red;
                        Content = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.cn.Close();
                }
            }
            if (LoginUser.dept == "CEO" || LoginUser.dept == "IT")
            {
                btnStaffList.Visible = true;
                staffListToolStripMenuItem.Visible = true;
            }
            else
            {
                btnStaffList.Visible = false;
                staffListToolStripMenuItem.Visible = false;
            }
            if (LoginUser.dept == "Purchase" || LoginUser.dept == "CEO")
            {
                btnInventory.Visible = true;
                btnSalesOrder.Visible = true;
                btnPurchaseList.Visible = true;
                purchaseOrderListToolStripMenuItem.Visible = true;
            }
            else 
            {
                btnPurchaseList.Visible = false;
                purchaseOrderListToolStripMenuItem.Visible = false;
            }
            try 
            {
                con.cn.Open();
                command = new MySqlCommand("select Content,MemoDate from memo",con.cn);
                dr = command.ExecuteReader();
                dt = new DataTable();
                da = new MySqlDataAdapter();
                dt.Load(dr);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Content += i+1 + ". " + dt.Rows[i]["Content"].ToString() + "\nUpdate Time: " + dt.Rows[i]["MemoDate"].ToString() + "\n";
                }
                dr.Close();
                con.cn.Close();
                RTB_Memo.Text += "Memo:\n\n" + Content + "\n";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
            lb_Date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lb_Time.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void btnInventory_Click(object sender, System.EventArgs e)
        {
            Inventory I = new Inventory();
            this.Hide();
            I.ShowDialog();
            
        }

        private void btnDeliveryInstallation_Click(object sender, System.EventArgs e)
        {
            DeliveryandInstallationManagement DIM = new DeliveryandInstallationManagement();
            this.Hide();
            DIM.ShowDialog();
        }


        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void TodayTimer_Tick(object sender, EventArgs e)
        {
            lb_Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_Memo_Click(object sender, EventArgs e)
        {
            CreateMemo CM = new CreateMemo();
            this.Hide();
            CM.Show();
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

        private void purchaseOrderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrderList POL = new PurchaseOrderList();
            this.Hide();
            POL.Show();
        }

        private void btnPurchaseList_Click(object sender, EventArgs e)
        {
            PurchaseOrderList POL = new PurchaseOrderList();
            this.Hide();
            POL.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Statistics stats = new Statistics();
            this.Hide();
            stats.Show();
        }
    }
}
