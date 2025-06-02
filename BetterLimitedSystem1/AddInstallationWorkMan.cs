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
    public partial class AddInstallationWorkMan : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        DataTable dt;
        MySqlDataAdapter da;
        public AddInstallationWorkMan()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                con.cn.Open();
                command = new MySqlCommand("insert into installationworkman values(@workmanid, @workmanname)",con.cn);
                command.Parameters.AddWithValue("workmanid", txtWorkManID.Text);
                command.Parameters.AddWithValue("workmanname", txtWorkManName.Text);
                command.ExecuteNonQuery();
                con.cn.Close();
                DeliveryandInstallationManagement DI = new DeliveryandInstallationManagement();
                con.cn.Open();
                updateInstallationWorkManView("select * from installationworkman");
                con.cn.Close();
                this.Hide();
                DI.Show();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void AddInstallationWorkMan_Load(object sender, EventArgs e)
        {
            command = new MySqlCommand("SELECT InstallationWorkManID FROM installationworkman WHERE InstallationWorkManID=(SELECT max(InstallationWorkManID) FROM installationworkman)", con.cn);
            con.cn.Open();
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                string workmanid = dr[0].ToString();
                string newworkmanid = "IWM" + String.Format("{000:000}", Convert.ToInt32(workmanid.TrimStart("IWM".ToCharArray())) + 1);
                txtWorkManID.Text = newworkmanid;
                dr.Close();
            }
            else
            {
                txtWorkManID.Text = "IWM" + String.Format("{000:000}", 1);
                dr.Close();
            }
            updateInstallationWorkManView("select * from installationworkman");
            con.cn.Close();
        }

        private void updateInstallationWorkManView(string SqlStr)
        {
            command = new MySqlCommand(SqlStr, con.cn);
            dr = command.ExecuteReader();
            dt = new DataTable();
            da = new MySqlDataAdapter();
            dt.Load(dr);
            InstallationWorkManView.DataSource = dt;
            dr.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DeliveryandInstallationManagement DI = new DeliveryandInstallationManagement();
            this.Hide();
            DI.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (InstallationWorkManView.SelectedRows.Count > 0)
            {
                int selectedIndex = InstallationWorkManView.SelectedRows[0].Index;

                string WorkManID = InstallationWorkManView[0, selectedIndex].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure delete the Work Man record of " + WorkManID + "?");

                if (result == DialogResult.Yes)
                {
                    con.cn.Open();
                    command = new MySqlCommand("delete from installationworkman where WorkManID = '" + WorkManID + "'", con.cn);
                    command.ExecuteNonQuery();
                    con.cn.Close();

                }

                con.cn.Open();
                updateInstallationWorkManView("select * from deliveryworkman");
                con.cn.Close();

            }
        }
    }
}
