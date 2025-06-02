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
    public partial class DeliveryDetail : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        public DeliveryDetail()
        {
            InitializeComponent();
            con.Connect();
        }

        private void DeliveryDetail_Load(object sender, EventArgs e)
        {
            BindData1();
            dtpDeliveryDate.MinDate = DateTime.Now;
            try
            {
                string workmanid = "";
                con.cn.Open();
                command = new MySqlCommand("select c.Customer_Name,c.Phone_Number as Customer_Phone, d.Address,d.Delivery_Date,d.Delivery_Session,d.Status,d.Delivery_workman from delivery as d left join salesorder as so on d.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where d.Order_ID = '" + txtOrderID.Text + "'",con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txtAddress.Text = dr["Address"].ToString();
                    txtCustomerName.Text = dr["Customer_Name"].ToString();
                    txtCustomerMobile.Text = dr["Customer_Phone"].ToString();
                    
                    workmanid = dr["Delivery_workman"].ToString();
                    string session = dr["Delivery_Session"].ToString();
                    switch (session) 
                    {
                        case "Morning (09:00am - 12:00nn)":
                            rbMorning.Checked = true;
                            break;
                        case "Afternoon (1:00pm – 5:00pm)":
                            rbAfternoon.Checked = true;
                            break;
                        case "Evening(6:00pm – 10:00pm)":
                            rbEvening.Checked = true;
                            break;
                    }
                    DateTime date = DateTime.Parse(dr["Delivery_Date"].ToString());
                    if (dr["Status"].ToString() == "Processing")
                    {
                        txtStatus.Text = dr["Status"].ToString();
                        dtpDeliveryDate.Text = date.ToString("yyyy-MM-dd");
                    }
                    else if (dr["Status"].ToString() == "Finish")
                    {
                        txtAddress.ReadOnly = true;
                        txtDate.Visible = true;
                        txtDate.Text = date.ToString("yyyy-MM-dd");
                    }
                    else 
                    {
                        txtStatus.Text = dr["Status"].ToString();
                        dtpDeliveryDate.Text = date.ToString("yyyy-MM-dd");
                        txtDate.Visible = false;
                    }
                }
                con.cn.Close();

                con.cn.Open();
                command = new MySqlCommand("select Name from account where StaffID = '" + workmanid + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read()) 
                {
                    cbDeliveryWorkMan.Text = dr[0].ToString();
                    if (txtStatus.Text == "Finish") {
                        txtWorkMan.Text = dr[0].ToString();
                        cbDeliveryWorkMan.Visible = false;
                        txtWorkMan.Visible = true;
                    }
                    dr.Close();
                }
                con.cn.Close();


                con.cn.Open();
                command = new MySqlCommand("select count(Delivery_Session) from delivery where Delivery_Date = '" + dtpDeliveryDate.Text + "'",con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    int count = Convert.ToInt32(dr[0].ToString());
                    dr.Close();
                    if (count >= 15)
                    {
                        gpDeliverySession.Visible = false;
                    }
                    else
                    {
                        gpDeliverySession.Visible = true;
                    }
                }

                command = new MySqlCommand("select count(*) from delivery where Delivery_Date = '" + dtpDeliveryDate.Text + "' and Delivery_Session = 'Morning (09:00am - 12:00nn)'",con.cn);
                dr = command.ExecuteReader();
                if (dr.Read()) 
                {
                    int sessioncount = Convert.ToInt32(dr[0].ToString());
                    dr.Close();
                    if (sessioncount >= 5)
                    {
                        rbMorning.ForeColor = Color.Gray;
                        rbMorning.Enabled = false;
                    }
                    else 
                    {
                        rbMorning.ForeColor = Color.Black;
                        rbMorning.Enabled = true;
                    }
                }

                command = new MySqlCommand("select count(*) from delivery where Delivery_Date = '" + dtpDeliveryDate.Text + "' and Delivery_Session = 'Afternoon (1:00pm – 5:00pm)'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    int sessioncount = Convert.ToInt32(dr[0].ToString());
                    dr.Close();
                    if (sessioncount >= 5)
                    {
                        rbAfternoon.ForeColor = Color.Gray;
                        rbAfternoon.Enabled = false;
                    }
                    else
                    {
                        rbAfternoon.ForeColor = Color.Black;
                        rbAfternoon.Enabled = true;
                    }
                }

                command = new MySqlCommand("select count(*) from delivery where Delivery_Date = '" + dtpDeliveryDate.Text + "' and Delivery_Session = 'Evening(6:00pm – 10:00pm)'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    int sessioncount = Convert.ToInt32(dr[0].ToString());
                    dr.Close();
                    if (sessioncount >= 5)
                    {
                        rbEvening.ForeColor = Color.Gray;
                        rbEvening.Enabled = false;
                    }
                    else
                    {
                        rbEvening.ForeColor = Color.Black;
                        rbEvening.Enabled = true;
                    }
                }
                con.cn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string session = "";
            if (rbMorning.Checked == true || rbAfternoon.Checked == true || rbEvening.Checked == true)
            {
                if (cbDeliveryWorkMan.Text != string.Empty) {
                    try
                    {
                        con.cn.Open();
                        command = new MySqlCommand("update delivery set Address = @address, Delivery_Date = @deliverydate, Delivery_Session = @deliverysession, Status = 'Processing', Delivery_workman = @workman where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                        command.Parameters.AddWithValue("deliverydate", dtpDeliveryDate.Text);
                        command.Parameters.AddWithValue("address", txtAddress.Text);
                        if (rbMorning.Checked == true)
                        {
                            session = "Morning (09:00am - 12:00nn)";
                        }
                        else if (rbAfternoon.Checked == true)
                        {
                            session = "Afternoon (1:00pm – 5:00pm)";
                        }
                        else if (rbEvening.Checked == true)
                        {
                            session = "Evening(6:00pm – 10:00pm)";
                        }
                        command.Parameters.AddWithValue("deliverysession", session);
                        command.Parameters.AddWithValue("workman", cbDeliveryWorkMan.SelectedValue);
                        command.ExecuteNonQuery();
                        con.cn.Close();


                        DeliveryandInstallationManagement di = new DeliveryandInstallationManagement();
                        this.Hide();
                        di.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.cn.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("Please select the Work Man");
                }
            }
            else 
            {
                MessageBox.Show("Please select the Session Time");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DeliveryandInstallationManagement DI = new DeliveryandInstallationManagement();
            this.Hide();
            DI.ShowDialog();
        }
        public void BindData1()
        {
            con.cn.Open();
            string strCmd = "select * from account where Department = 'Delivery Work Man' order by StaffID";
            command = new MySqlCommand(strCmd, con.cn);
            da = new MySqlDataAdapter(strCmd, con.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            command.ExecuteNonQuery();
            con.cn.Close();

            cbDeliveryWorkMan.DisplayMember = "Name";
            cbDeliveryWorkMan.ValueMember = "StaffID";
            cbDeliveryWorkMan.DataSource = ds.Tables[0];

            cbDeliveryWorkMan.Enabled = true;

        }
        private void cbDeliveryWorkMan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
