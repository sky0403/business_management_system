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
    public partial class InstallationOrder : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataTable dt;
        public InstallationOrder()
        {
            InitializeComponent();
            con.Connect();
        }

        private void InstallationOrder_Load(object sender, EventArgs e)
        {
            BindData1();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            WorkManMenu wm = new WorkManMenu();
            this.Hide();
            wm.Show();
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
        private void btnFinishInstallation_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you finished " + txtOrderID.Text + " Installation Order?", "Installation Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.cn.Open();
                    command = new MySqlCommand("update installation set Status = 'Finish' where Install_ID = '" + cbInstallationOrderID.SelectedValue + "'", con.cn);
                    command.ExecuteNonQuery();
                    command = new MySqlCommand("select * from installation where Install_ID = '" + cbInstallationOrderID.SelectedValue + "'", con.cn);
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
                MessageBox.Show("Please confirm you finished the " + txtOrderID.Text + " installation order");
            }
        }

        public void BindData1()
        {
            con.cn.Open();
            string strCmd = "select * from installation where Installation_Workman = '" + LoginUser.StaffID + "' and Status = 'Processing'";
            command = new MySqlCommand(strCmd, con.cn);
            da = new MySqlDataAdapter(strCmd, con.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            command.ExecuteNonQuery();
            con.cn.Close();

            cbInstallationOrderID.DisplayMember = "Install_ID";
            cbInstallationOrderID.ValueMember = "Install_ID";
            cbInstallationOrderID.DataSource = ds.Tables[0];

            cbInstallationOrderID.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("select * from installation where Install_ID = '" + cbInstallationOrderID.SelectedValue + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txtOrderID.Text = dr["Order_ID"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    DateTime date = DateTime.Parse(dr["Installation_Date"].ToString());
                    txtInstallationDate.Text = date.ToString("yyyy-MM-dd");
                    txtTime.Text = dr["Installation_Time"].ToString();
                    txtWorkMan.Text = dr["Installation_Workman"].ToString();
                    txtStatus.Text = dr["Status"].ToString();
                    
                }
                dr.Close();
                updateProductView("select Item_ID,Order_Qty from ordereditems where Order_ID = '" + txtOrderID.Text + "'");
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You dont have processing installation order");
            }
        }
    }
}
