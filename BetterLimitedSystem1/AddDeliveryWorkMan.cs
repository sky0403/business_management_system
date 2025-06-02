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
    public partial class AddDeliveryWorkMan : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        DataTable dt;
        MySqlDataAdapter da;
        public AddDeliveryWorkMan()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("insert into deliveryworkman values(@workmanid, @workmanname)", con.cn);
                command.Parameters.AddWithValue("workmanid", txtWorkManID.Text);
                command.Parameters.AddWithValue("workmanname", txtWorkManName.Text);
                command.ExecuteNonQuery();
                con.cn.Close();
                DeliveryandInstallationManagement DI = new DeliveryandInstallationManagement();
                this.Hide();
                DI.Show();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DeliveryandInstallationManagement DI = new DeliveryandInstallationManagement();
            this.Hide();
            DI.Show();
        }

        private void txtWorkManName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDeliveryWorkMan_Load(object sender, EventArgs e)
        {
            command = new MySqlCommand("SELECT WorkManID FROM deliveryworkman WHERE WorkManID=(SELECT max(WorkManID) FROM deliveryworkman)", con.cn);
            con.cn.Open();
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                string workmanid = dr[0].ToString();
                string newworkmanid = "WM" + String.Format("{00:000}", Convert.ToInt32(workmanid.TrimStart("WM".ToCharArray())) + 1);
                txtWorkManID.Text = newworkmanid;
                dr.Close();
            }
            else
            {
                txtWorkManID.Text = "WM" + String.Format("{00:000}", 1);
                dr.Close();
            }

            updateDeliveryWorkManView("select * from deliveryworkman");

            con.cn.Close();

            
        }

        private void updateDeliveryWorkManView(string SqlStr)
        {
            command = new MySqlCommand(SqlStr, con.cn);
            dr = command.ExecuteReader();
            dt = new DataTable();
            da = new MySqlDataAdapter();
            dt.Load(dr);
            DeliveryWorkManView.DataSource = dt;
            dr.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (DeliveryWorkManView.SelectedRows.Count > 0)
            {
                int selectedIndex = DeliveryWorkManView.SelectedRows[0].Index;

                string WorkManID = DeliveryWorkManView[0, selectedIndex].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure delete the Work Man record of " + WorkManID + "?");

                if (result == DialogResult.Yes)
                {
                    con.cn.Open();
                    command = new MySqlCommand("delete from deliveryworkman where WorkManID = '" + WorkManID + "'",con.cn);
                    command.ExecuteNonQuery();
                    con.cn.Close();

                }

                con.cn.Open();
                updateDeliveryWorkManView("select * from deliveryworkman");
                con.cn.Close();

            }
        }
    }
}
