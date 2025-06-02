using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace BetterLimitedSystem1
{
    public partial class Home : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataTable dt;

        int loginerrorcount = 0;

        

        public Home()
        {
            InitializeComponent();
            con.Connect();
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != string.Empty && txtStaffID.Text != string.Empty)
                {
                    if (loginerrorcount <= 5)
                    {
                        con.cn.Open();
                        command = new MySqlCommand("select * from account where StaffID='" + txtStaffID.Text + "' and Password='" + txtPassword.Text + "'", con.cn);
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            if (Convert.ToInt32(dr["Lock"].ToString()) == 0)
                            {
                                LoginUser.StaffID = dr["StaffID"].ToString();
                                LoginUser.Name = dr["Name"].ToString();
                                LoginUser.dept = dr["Department"].ToString();
                                MessageBox.Show("Login success");
                                dr.Close();
                                con.cn.Close();
                                if (LoginUser.dept == "Delivery Work Man" || LoginUser.dept == "Installation Work Man")
                                {
                                    WorkManMenu wm = new WorkManMenu();
                                    this.Hide();
                                    wm.Show();
                                }
                                else
                                {
                                    this.Hide();
                                    SalesMenu s = new SalesMenu();
                                    s.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your account has been locked, please contact your system manager");
                                con.cn.Close();
                            }
                        }
                        else
                        {
                            dr.Close();
                            con.cn.Close();
                            MessageBox.Show("No Account available with this StaffID and Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            loginerrorcount++;
                            txtPassword.Text = "";
                        }
                    }
                    else 
                    {
                        MessageBox.Show("You have enter wrong account 5 times, Your account locked, please contact your system manager");
                        con.cn.Open();
                        command = new MySqlCommand("update account set `Lock` = 1 where StaffID = '" + txtStaffID.Text + "'", con.cn);
                        command.ExecuteNonQuery();
                        con.cn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword CP = new ChangePassword();
            this.Hide();
            CP.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            loginerrorcount = 0;
        }
    }
}
