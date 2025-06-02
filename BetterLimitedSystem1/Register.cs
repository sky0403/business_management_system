using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BetterLimitedSystem1
{
    public partial class Register : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        Home h = new Home();

        public Register()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != string.Empty && txtPassword.Text != string.Empty && txtStaffID.Text != string.Empty && txtName.Text != string.Empty)
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                        con.cn.Open();
                        command = new MySqlCommand("select * from account where StaffID='" + txtStaffID.Text + "'", con.cn);
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("StaffID Already registered ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.cn.Close();
                        }
                        else
                        {
                            dr.Close();
                            command = new MySqlCommand("insert into account values(@staffid,@password,@name,@phone,@depart,@lock)", con.cn);
                            command.Parameters.AddWithValue("staffid", txtStaffID.Text);
                            command.Parameters.AddWithValue("password", txtPassword.Text);
                            command.Parameters.AddWithValue("name", txtName.Text);
                            command.Parameters.AddWithValue("phone", txtPhone.Text);
                            command.Parameters.AddWithValue("depart", comboBox1.Text);
                            command.Parameters.AddWithValue("lock", 0);
                            command.ExecuteNonQuery();
                            con.cn.Close();
                            MessageBox.Show(txtStaffID.Text + " Account is created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            StaffList SL = new StaffList();
                            SL.Show();
                        }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            h.ShowDialog();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            try
            {
                command = new MySqlCommand("SELECT StaffID FROM account WHERE StaffID=(SELECT max(StaffID) FROM account)", con.cn);
                con.cn.Open();
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    string staffid = dr[0].ToString();
                    string newstaffid = "S" + String.Format("{0:000}", Convert.ToInt32(staffid.TrimStart('S')) + 1);
                    txtStaffID.Text = newstaffid;
                }
                else
                {
                    txtStaffID.Text = "S" + String.Format("{0:000}", 1);
                }
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && ch != 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
            }
        }
    }
}
