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
    public partial class CreateMemo : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataTable dt;

        public CreateMemo()
        {
            InitializeComponent();
            con.Connect();
        }

        private void CreateMemo_Load(object sender, EventArgs e)
        {
            txtCreateBy.Text = LoginUser.StaffID;
            command = new MySqlCommand("SELECT MemoID FROM memo WHERE MemoID=(SELECT max(MemoID) FROM memo)", con.cn);
            con.cn.Open();
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                int memoid = Convert.ToInt32(dr[0].ToString()) + 1;
                txtMemoID.Text = memoid.ToString();
                dr.Close();
            }
            else
            {
                txtMemoID.Text = "1";
                dr.Close();
            }
            con.cn.Close();
            if (LoginUser.dept == "CEO" || LoginUser.dept == "IT")
            {
                staffListToolStripMenuItem.Visible = true;
            }
            else
            {
                staffListToolStripMenuItem.Visible = false;
            }

            try
            {
                con.cn.Open();
                command = new MySqlCommand("Select * from memo", con.cn);
                dr = command.ExecuteReader();
                dt = new DataTable();
                da = new MySqlDataAdapter();
                dt.Load(dr);
                MemoView.DataSource = dt;
                dr.Close();
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void txtContent_Enter(object sender, EventArgs e)
        {
            if (txtContent.Text == "Content....")
            {
                txtContent.Text = "";
                txtContent.ForeColor = Color.Black;
            }
        }

        private void txtContent_Leave(object sender, EventArgs e)
        {
            if (txtContent.Text == "")
            {
                txtContent.Text = "Content....";
                txtContent.ForeColor = Color.Gray;
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (txtContent.Text != string.Empty)
            {
                try
                {
                    con.cn.Open();
                    command = new MySqlCommand("insert into memo values(@memoid,@content,@staff,@Date)", con.cn);
                    command.Parameters.AddWithValue("memoid", txtMemoID.Text);
                    command.Parameters.AddWithValue("content", txtContent.Text);
                    command.Parameters.AddWithValue("staff", txtCreateBy.Text);
                    command.Parameters.AddWithValue("Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.ExecuteNonQuery();
                    con.cn.Close();
                    MessageBox.Show("Your Memo created!");
                    SalesMenu sm = new SalesMenu();
                    this.Hide();
                    sm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.cn.Close();
                }
            }
            else 
            {
                MessageBox.Show("Please enter your memo content!");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            SalesMenu s = new SalesMenu();
            this.Hide();
            s.Show();
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

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MemoView.SelectedRows.Count > 0)
                {
                    int selectedIndex = MemoView.SelectedRows[0].Index;

                    string memoID = MemoView[0, selectedIndex].Value.ToString();
                    con.cn.Open();
                    command = new MySqlCommand("delete from memo where MemoID = '" + memoID + "'", con.cn);
                    command.ExecuteNonQuery();
                    con.cn.Close();


                    con.cn.Open();
                    command = new MySqlCommand("select * from memo", con.cn);
                    dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    MemoView.DataSource = dt;
                    con.cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deleting Failed:" + ex.Message.ToString(), "Delete",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.cn.Close();
            }
        }

        private void MemoView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
