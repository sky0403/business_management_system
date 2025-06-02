using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BetterLimitedSystem1
{
    public partial class WorkManMenu : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataTable dt;
        public WorkManMenu()
        {
            InitializeComponent();
            con.Connect();
        }

        private void WorkManMenu_Load(object sender, EventArgs e)
        {
            if (LoginUser.dept == "Delivery Work Man")
            {
                btnDelivery.Visible = true;
            }
            else
            {
                btnDelivery.Visible = false;
            }

            if (LoginUser.dept == "Installation Work Man")
            {
                btnInstallation.Visible = true;
            }
            else
            {
                btnInstallation.Visible = false;
            }
            string Content = "";
            try
            {
                if (LoginUser.dept == "Delivery Work Man")
                {
                    DateTime date = DateTime.Now;
                    string currentdate = date.ToString("yyyy-MM-dd");
                    con.cn.Open();
                    command = new MySqlCommand("select count(*) from delivery where Delivery_workman = '" + LoginUser.StaffID + "' and Status = 'Processing' and Delivery_Date = '" + currentdate + "'", con.cn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        string count = dr[0].ToString();
                        Content += "You have " + count + " Delivery Order Today.\n\n";
                        dr.Close();
                    }
                    command = new MySqlCommand("select * from delivery where Delivery_workman = '" + LoginUser.StaffID + "' and Status = 'Processing' and Delivery_Date = '" + currentdate + "'", con.cn);
                    dr = command.ExecuteReader();
                    dt = new DataTable();
                    da = new MySqlDataAdapter();
                    dt.Load(dr);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Product p = new Product();
                        string Deli_ID = dt.Rows[i]["Deli_ID"].ToString();
                        string OrderID = dt.Rows[i]["Order_ID"].ToString();
                        string address = dt.Rows[i]["Address"].ToString();
                        string session = dt.Rows[i]["Delivery_Session"].ToString();
                        Content += i+1 + ". " + OrderID + " delivery to " + address + "\nSession_Time is " + session;
                    }

                    RTB_Memo.Text += Content;

                    dr.Close();
                    con.cn.Close();
                }
                else
                {
                    DateTime date = DateTime.Now;
                    string currentdate = date.ToString("yyyy-MM-dd");
                    con.cn.Open();
                    command = new MySqlCommand("select count(*) from installation where Installation_Workman = '" + LoginUser.StaffID + "' and Status = 'Processing' and Installation_Date = '" + currentdate + "'", con.cn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        string count = dr[0].ToString();
                        Content += "You have " + count + " Installation Order Today.\n\n";
                        dr.Close();
                    }
                    command = new MySqlCommand("select * from installation where Installation_Workman = '" + LoginUser.StaffID + "' and Status = 'Processing' and Installation_Date = '" + currentdate + "'", con.cn);
                    dr = command.ExecuteReader();
                    dt = new DataTable();
                    da = new MySqlDataAdapter();
                    dt.Load(dr);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Product p = new Product();
                        string Deli_ID = dt.Rows[i]["Install"].ToString();
                        string OrderID = dt.Rows[i]["Order_ID"].ToString();
                        string address = dt.Rows[i]["Address"].ToString();
                        DateTime insta = DateTime.Parse(dt.Rows[i]["Installation_Time"].ToString());
                        string time = insta.ToString("HH:mm");
                        Content += i+1 + ". " + OrderID + " installation at " + address + " ,Time is " + time + ".";
                    }

                    RTB_Memo.Text += Content;

                    dr.Close();
                    con.cn.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            DeliveryOrder DO = new DeliveryOrder();
            this.Hide();
            DO.Show();
        }

        private void btnInstallation_Click(object sender, EventArgs e)
        {
            InstallationOrder IO = new InstallationOrder();
            this.Hide();
            IO.Show();
        }
    }
}
