using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BetterLimitedSystem1
{
    public partial class ChangePassword : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;

        public ChangePassword()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOldPassword.Text != string.Empty && txtStaffID.Text != string.Empty && txtNewPassword.Text != string.Empty && txtConfirmPassword.Text != string.Empty && txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    if (txtNewPassword.Text == txtConfirmPassword.Text)
                    {
                        con.cn.Open();
                        command = new MySqlCommand("select * from account where StaffID = '" + txtStaffID.Text +"' and Password = '" + txtOldPassword.Text + "'", con.cn);
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            command = new MySqlCommand("update account set Password ='" + txtNewPassword.Text + "' where StaffID = '" + txtStaffID.Text + "'and Password = '" + txtOldPassword.Text + "'", con.cn);
                            command.ExecuteNonQuery();
                            con.cn.Close();
                            MessageBox.Show("Password changed", "OK", MessageBoxButtons.OK);
                            this.Hide();
                            Home home = new Home();
                            home.ShowDialog();
                        }
                        else {
                            con.cn.Close();
                            MessageBox.Show("Account or Password not correct, Please confirm your account information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtOldPassword.Text = "";
                            txtNewPassword.Text = "";
                            txtConfirmPassword.Text = "";
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("new password and confirm should be same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNewPassword.Text = "";
                        txtConfirmPassword.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
