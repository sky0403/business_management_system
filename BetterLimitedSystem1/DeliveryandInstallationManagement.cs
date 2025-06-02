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
    public partial class DeliveryandInstallationManagement : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataTable dt;
        public DeliveryandInstallationManagement()
        {
            InitializeComponent();
            con.Connect();
        }

        private void DeliveryandInstallationManagement_Load(object sender, EventArgs e)
        {
            try
            {
                DeliveryView.ReadOnly = true;
                InstallationView.ReadOnly = true;
                con.cn.Open();
                UpdateDeliveryView("select d.Deli_ID,d.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, d.Address,d.Delivery_Date,d.Delivery_Session,d.Status,d.Delivery_workman from delivery as d left join salesorder as so on d.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email");
                UpdateInstallationView("select i.Install_ID,i.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, i.Address,i.Installation_Date,i.Installation_Time,i.Status,i.Installation_workman from installation as i left join salesorder as so on i.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email");
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }

            if (LoginUser.dept == "CEO" || LoginUser.dept == "Inventory")
            {
                btnFinishDelivery.Visible = true;
                btnGenerateDailyDelivery.Visible = true;
            }
            else 
            {
                btnFinishDelivery.Visible = false;
                btnGenerateDailyDelivery.Visible = false;
            }

            if (LoginUser.dept == "CEO" || LoginUser.dept == "Technical Support")
            {
                btnFinishInstallation.Visible = true;
                btnGenerateDailyInstallation.Visible = true;
            }
            else
            {
                btnFinishInstallation.Visible = false;
                btnGenerateDailyInstallation.Visible = false;
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
            SalesMenu S = new SalesMenu();
            this.Hide();
            S.ShowDialog();
        }

        public void UpdateDeliveryView(string SqlStr)
        {
            dt = new DataTable();
            da = new MySqlDataAdapter(SqlStr, con.cn);
            dt.Clear();
            da.Fill(dt);
            DeliveryView.DataSource = dt;
        }
        public void UpdateInstallationView(string SqlStr)
        {
            dt = new DataTable();
            da = new MySqlDataAdapter(SqlStr, con.cn);
            dt.Clear();
            da.Fill(dt);
            InstallationView.DataSource = dt;
        }

        private void DeliveryView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LoginUser.dept == "Inventory" || LoginUser.dept =="Installation" || LoginUser.dept == "CEO")
            {
                DeliveryDetail DD = new DeliveryDetail();
                DD.txtOrderID.Text = this.DeliveryView.CurrentRow.Cells[1].Value.ToString();
                this.Hide();
                DD.ShowDialog();
            }
            else
            {
                MessageBox.Show("Only Inventory and Installation department staff can view the delivery Detail", "have not permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InstallationView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InstallationView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LoginUser.dept == "Inventory" || LoginUser.dept == "Installation" || LoginUser.dept == "CEO")
            {
                InstallationDetail ID = new InstallationDetail();
                ID.txtOrderID.Text = this.InstallationView.CurrentRow.Cells[1].Value.ToString();
                this.Hide();
                ID.ShowDialog();
            }
            else
            {
                MessageBox.Show("Only Inventory and Installation department staff can view the Installation Order Detail", "have not permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSearchDelivery_Click(object sender, EventArgs e)
        {
            if (txtSearchDelivery.Text != string.Empty)
            {
                try
                {
                    con.cn.Open();
                    switch (cbDeliverySearch.Text)
                    {
                        case "Order ID":
                            UpdateDeliveryView("select d.Deli_ID,d.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, d.Address,d.Delivery_Date,d.Delivery_Session,d.Status,d.Delivery_workman " +
                            "from delivery as d left join salesorder as so on d.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where d.Order_ID = '" + txtSearchDelivery.Text + "'");
                            con.cn.Close();
                            break;
                        case "Delivery ID":
                            UpdateDeliveryView("select d.Deli_ID,d.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, d.Address,d.Delivery_Date,d.Delivery_Session,d.Status,d.Delivery_workman " +
                            "from delivery as d left join salesorder as so on d.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where d.Deli_ID = '" + txtSearchDelivery.Text + "'");
                            con.cn.Close();
                            break;
                        case "Delivery Work Man":
                            UpdateDeliveryView("select d.Deli_ID,d.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, d.Address,d.Delivery_Date,d.Delivery_Session,d.Status,d.Delivery_workman " +
                            "from delivery as d left join salesorder as so on d.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where d.Delivery_workman like '%" + txtSearchDelivery.Text + "%'");
                            con.cn.Close();
                            break;
                        case "Status":
                            UpdateDeliveryView("select d.Deli_ID,d.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, d.Address,d.Delivery_Date,d.Delivery_Session,d.Status,d.Delivery_workman " +
                            "from delivery as d left join salesorder as so on d.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where d.Status like '%" + txtSearchDelivery.Text + "%'");
                            con.cn.Close();
                            break;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.cn.Close();
                }
            }
            else 
            {
                con.cn.Open();
                UpdateDeliveryView("select d.Deli_ID,d.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, d.Address,d.Delivery_Date,d.Delivery_Session,d.Status,d.Delivery_workman from delivery as d left join salesorder as so on d.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email");
                con.cn.Close();
            }
        }

        private void btnSearchInstallation_Click(object sender, EventArgs e)
        {
            if (txtSearchInstallation.Text != string.Empty)
            {
                try
                {
                    con.cn.Open();
                    switch (cbInstallationSearch.Text)
                    {
                        case "Order ID":
                            UpdateInstallationView("select i.Install_ID,i.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, i.Address,i.Installation_Date,i.Installation_Time,i.Status,i.Installation_workman" +
                                " from installation as i left join salesorder as so on i.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where i.Order_ID = '" + txtSearchInstallation.Text + "'") ;
                            con.cn.Close();
                            break;
                        case "Installation ID":
                            UpdateInstallationView("select i.Install_ID,i.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, i.Address,i.Installation_Date,i.Installation_Time,i.Status,i.Installation_workman" +
                                " from installation as i left join salesorder as so on i.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where i.Install_ID = '" + txtSearchInstallation.Text + "'"); 
                            con.cn.Close();
                            break;
                        case "Installation Work Man":
                            UpdateInstallationView("select i.Install_ID,i.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, i.Address,i.Installation_Date,i.Installation_Time,i.Status,i.Installation_workman" +
                                " from installation as i left join salesorder as so on i.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where i.Installation_Workman like '%" + txtSearchInstallation.Text + "%'"); 
                            con.cn.Close();
                            break;
                        case "Status":
                            UpdateInstallationView("select i.Install_ID,i.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, i.Address,i.Installation_Date,i.Installation_Time,i.Status,i.Installation_workman" +
                                " from installation as i left join salesorder as so on i.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where i.Status like '%" + txtSearchInstallation.Text + "%'"); 
                            con.cn.Close();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.cn.Close();
                }
            }
            else 
            {
                con.cn.Open();
                UpdateInstallationView("select i.Install_ID,i.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, i.Address,i.Installation_Date,i.Installation_Time,i.Status,i.Installation_workman from installation as i left join salesorder as so on i.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email");
                con.cn.Close();
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
        
        private void btnGenerateDailyDeveliery_Click(object sender, EventArgs e)
        {
            DailyDeliveryList DDL = new DailyDeliveryList();
            this.Hide();
            DDL.Show();
        }
        private void btnGenerateDailyInstallation_Click(object sender, EventArgs e)
        {
            DailyInstallationList DIL = new DailyInstallationList();
            this.Hide();
            DIL.Show();
        }

        private void MenumenuItem_Click(object sender, EventArgs e)
        {
            SalesMenu sm = new SalesMenu();
            this.Hide();
            sm.Show();
        }

        private void txtSearchDelivery_Enter(object sender, EventArgs e)
        {
            if (txtSearchDelivery.Text == "Search...") 
            {
                txtSearchDelivery.Text = "";
                txtSearchDelivery.ForeColor = Color.Black;
            }
        }

        private void txtSearchDelivery_Leave(object sender, EventArgs e)
        {
            if (txtSearchDelivery.Text == "")
            {
                txtSearchDelivery.Text = "Search...";
                txtSearchDelivery.ForeColor = Color.Gray;
            }
        }

        private void txtSearchInstallation_Enter(object sender, EventArgs e)
        {
            if (txtSearchInstallation.Text == "Search...")
            {
                txtSearchInstallation.Text = "";
                txtSearchInstallation.ForeColor = Color.Black;
            }
        }

        private void txtSearchInstallation_Leave(object sender, EventArgs e)
        {
            if (txtSearchInstallation.Text == "")
            {
                txtSearchInstallation.Text = "Search...";
                txtSearchInstallation.ForeColor = Color.Gray;
            }
        }

        private void btnFinishDelivery_Click(object sender, EventArgs e)
        {
            if (DeliveryView.SelectedRows.Count > 0) 
            {
                int selectedIndex = DeliveryView.SelectedRows[0].Index;

                string DeliID = DeliveryView[0, selectedIndex].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure " + DeliID + " Delivery is finished?", "Finish Delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) 
                {
                    try
                    {
                        con.cn.Open();
                        command = new MySqlCommand("update delivery set Status = 'Finish' where Deli_ID = '" + DeliID + "'", con.cn);
                        command.ExecuteNonQuery();
                        UpdateDeliveryView("select d.Deli_ID,d.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, d.Address,d.Delivery_Date,d.Delivery_Session,d.Status,d.Delivery_workman from delivery as d left join salesorder as so on d.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email");
                        con.cn.Close();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void btnFinishInstallation_Click(object sender, EventArgs e)
        {
            if (InstallationView.SelectedRows.Count > 0)
            {
                int selectedIndex = InstallationView.SelectedRows[0].Index;

                string InstallID = InstallationView[0, selectedIndex].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure " + InstallID + " installation is finished?", "Finish Installation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.cn.Open();
                        command = new MySqlCommand("update installation set Status = 'Finish' where Install_ID = '" + InstallID + "'", con.cn);
                        command.ExecuteNonQuery();
                        UpdateInstallationView("select i.Install_ID,i.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, i.Address,i.Installation_Date,i.Installation_Time,i.Status,i.Installation_workman from installation as i left join salesorder as so on i.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email");
                        con.cn.Close();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void btnRefreshDelivery_Click(object sender, EventArgs e)
        {
            con.cn.Open();
            UpdateDeliveryView("select d.Deli_ID,d.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, d.Address,d.Delivery_Date,d.Delivery_Session,d.Status,d.Delivery_workman from delivery as d left join salesorder as so on d.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email");
            con.cn.Close();
        }

        private void btnRefreshInstallation_Click(object sender, EventArgs e)
        {
            con.cn.Open();
            UpdateInstallationView("select i.Install_ID,i.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, i.Address,i.Installation_Date,i.Installation_Time,i.Status,i.Installation_workman from installation as i left join salesorder as so on i.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email");
            con.cn.Close();
        }

        private void btnAddDeliveryWorkMan_Click(object sender, EventArgs e)
        {
            AddDeliveryWorkMan adwm = new AddDeliveryWorkMan();
            this.Hide();
            adwm.Show();
        }

        private void btnAddInstallationWorkMan_Click(object sender, EventArgs e)
        {
            AddInstallationWorkMan aiwm = new AddInstallationWorkMan();
            this.Hide();
            aiwm.Show();
        }
    }
}
