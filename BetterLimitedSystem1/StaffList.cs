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
    public partial class StaffList : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataTable dt;
        public StaffList()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesMenu s = new SalesMenu();
            s.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.ShowDialog();
        }

        private void StaffList_Load(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                UpdateStaffView("select * from account order by StaffID");
                con.cn.Close();
                if (LoginUser.dept == "CEO")
                {
                    btnAdd.Visible = true;
                    btnDelete.Visible = true;
                    btnLock.Visible = true;
                }
                else
                {
                    btnAdd.Visible = false;
                    btnDelete.Visible= false;
                    btnLock.Visible = false;
                }
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
        private void UpdateStaffView(string sqlStr)
        {
            dt = new DataTable();
            da = new MySqlDataAdapter(sqlStr, con.cn);
            dt.Clear();
            da.Fill(dt);
            da.Dispose();
            StaffView.DataSource = dt;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (StaffView.SelectedRows.Count > 0)
            {
                int selectedIndex = StaffView.SelectedRows[0].Index;
                string StaffID = StaffView[0, selectedIndex].Value.ToString();
                DialogResult result = MessageBox.Show("Do you want to Delete " + StaffID + " Data?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.cn.Open();
                        command = new MySqlCommand("Delete from account where StaffID = '" + StaffID + "'", con.cn);
                        command.ExecuteNonQuery();
                        con.cn.Close();
                        MessageBox.Show("You have delete " + StaffID + " Staff Data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.cn.Open();
                        UpdateStaffView("select * from account order by StaffID");
                        con.cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }


        private void StaffView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStaff ES = new EditStaff();
            ES.txtStaffID.Text = this.StaffView.CurrentRow.Cells[0].Value.ToString();
            ES.txtName.Text = this.StaffView.CurrentRow.Cells[2].Value.ToString();
            ES.txtPhone.Text = this.StaffView.CurrentRow.Cells[3].Value.ToString();
            ES.cbDepartment.Text = this.StaffView.CurrentRow.Cells[4].Value.ToString();
            this.Hide();
            ES.ShowDialog();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (StaffView.SelectedRows.Count > 0)
            {
                int selectedIndex = StaffView.SelectedRows[0].Index;
                string StaffID = StaffView[0, selectedIndex].Value.ToString();
                DialogResult result = MessageBox.Show("Do you want to Lock " + StaffID + " account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.cn.Open();
                        command = new MySqlCommand("update account set `Lock` = '1' where StaffID = '" + StaffID + "'", con.cn);
                        command.ExecuteNonQuery();
                        con.cn.Close();
                        MessageBox.Show("You have Locked " + StaffID + " account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.cn.Open();
                        UpdateStaffView("select * from account order by StaffID");
                        con.cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void btnUnLock_Click(object sender, EventArgs e)
        {
            if (StaffView.SelectedRows.Count > 0)
            {
                int selectedIndex = StaffView.SelectedRows[0].Index;
                string StaffID = StaffView[0, selectedIndex].Value.ToString();
                DialogResult result = MessageBox.Show("Do you want to UnLock " + StaffID + " account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.cn.Open();
                        command = new MySqlCommand("update account set `Lock` = '0' where StaffID = '" + StaffID + "'", con.cn);
                        command.ExecuteNonQuery();
                        con.cn.Close();
                        MessageBox.Show("You have UnLocked " + StaffID + " account", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.cn.Open();
                        UpdateStaffView("select * from account order by StaffID");
                        con.cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
    }
}
