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
    public partial class InstallationDetail : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        public InstallationDetail()
        {
            InitializeComponent();
            con.Connect();
        }

        private void InstallationDetail_Load(object sender, EventArgs e)
        {
            BindData1();
            try
            {
                string workmanid = "";
                con.cn.Open();
                command = new MySqlCommand("select c.Customer_Name,c.Phone_Number as Customer_Phone, " +
                    "d.Address,d.Delivery_Date,d.Delivery_Session,i.Status, i.Installation_Workman " +
                    "from delivery as d left join salesorder as so on d.Order_ID = so.Order_ID " +
                    "left join customer as c on c.Customer_Email = so.Customer_Email left join installation as i on" +
                    " i.Order_ID = so.Order_ID where i.Order_ID = '" + txtOrderID.Text + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    DateTime delivery = DateTime.Parse(dr["Delivery_Date"].ToString()); 
                    txtAddress.Text = dr["Address"].ToString();
                    txtCustomerName.Text = dr["Customer_Name"].ToString();
                    txtCustomerMobile.Text = dr["Customer_Phone"].ToString();
                    txtDeliveryDate.Text = delivery.ToString("yyyy-MM-dd");
                    workmanid = dr["Installation_workman"].ToString();
                    
                    txtDeliverySession.Text = dr["Delivery_Session"].ToString();
                    switch (txtDeliverySession.Text)
                    {
                        case "Monrning (09:00am - 12:00nn)":
                            dtpInstallationDate.Text = delivery.ToString();
                            dtpInstallationDate.MinDate = delivery;
                            dtpInstallationTime.Text = "14:00";
                            break;
                        case "Afternoon (1:00pm – 5:00pm)":
                            dtpInstallationDate.Text = delivery.ToString();
                            dtpInstallationDate.MinDate = delivery;
                            dtpInstallationTime.Text = "19:00";
                            break;
                        case "Evening(6:00pm – 10:00pm)":
                            dtpInstallationDate.Text = (delivery.AddDays(1)).ToString();
                            dtpInstallationDate.MinDate = delivery.AddDays(1);
                            dtpInstallationTime.Text = "10:00";
                            break;
                    }
                    txtStatus.Text = dr["Status"].ToString();
                    dr.Close();
                }
                con.cn.Close();

                con.cn.Open();
                command = new MySqlCommand("select Name from account where StaffID = '" + workmanid + "'",con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    cbInstallationWorkMan.Text = dr[0].ToString();
                    dr.Close();
                }
                con.cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != string.Empty)
            {
                if (cbInstallationWorkMan.Text != string.Empty)
                {
                    try
                    {
                        con.cn.Open();
                        command = new MySqlCommand("update installation set Address = @address,Installation_Date = @installationdate, Installation_Time = @installationtime, Status = 'Processing', installation_workman = @workman where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                        command.Parameters.AddWithValue("address", txtAddress.Text);
                        command.Parameters.AddWithValue("installationdate", dtpInstallationDate.Text);
                        command.Parameters.AddWithValue("installationtime", dtpInstallationTime.Text);
                        command.Parameters.AddWithValue("workman", cbInstallationWorkMan.SelectedValue);
                        command.ExecuteNonQuery();
                        con.cn.Close();
                        DeliveryandInstallationManagement DI = new DeliveryandInstallationManagement();
                        this.Hide();
                        DI.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.cn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please choose installation work man");
                }
            }
            else
            {
                MessageBox.Show("Please input address");
            }
        }

        public void BindData1()
        {
            con.cn.Open();
            string strCmd = "select * from account where Department = 'Installation Work Man' order by StaffID";
            command = new MySqlCommand(strCmd, con.cn);
            da = new MySqlDataAdapter(strCmd, con.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            command.ExecuteNonQuery();
            con.cn.Close();

            cbInstallationWorkMan.DisplayMember = "Name";
            cbInstallationWorkMan.ValueMember = "StaffID";
            cbInstallationWorkMan.DataSource = ds.Tables[0];

            cbInstallationWorkMan.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DeliveryandInstallationManagement DI = new DeliveryandInstallationManagement();
            this.Hide();
            DI.ShowDialog();
        }
    }
}
