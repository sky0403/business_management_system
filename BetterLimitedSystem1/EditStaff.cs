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
    public partial class EditStaff : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        public EditStaff()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtPhone.Text != string.Empty && txtPassword.Text != string.Empty && txtPassword.Text != string.Empty && txtConfirmPassword.Text != string.Empty)
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    try
                    {
                        DialogResult result = MessageBox.Show("Do you want to update " + txtStaffID.Text + " Data?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            con.cn.Open();
                            command = new MySqlCommand("update account set Password = @password, Name = @name, PhoneNum = @phone, Department = @department where StaffID = '" + txtStaffID.Text + "'", con.cn);
                            command.Parameters.AddWithValue("password", txtPassword.Text);
                            command.Parameters.AddWithValue("name", txtName.Text);
                            command.Parameters.AddWithValue("phone", txtPhone.Text);
                            command.Parameters.AddWithValue("department", cbDepartment.Text);
                            command.ExecuteNonQuery();
                            con.cn.Close();
                            MessageBox.Show("You have update " + txtStaffID.Text + " Data!");
                            StaffList SL = new StaffList();
                            this.Hide();
                            SL.Show();
                        }
                        else 
                        {
                            MessageBox.Show("Please confirm your information");
                            
                        }
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
                else 
                {
                    MessageBox.Show("Please confirm your password, confirm password and password should be same");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the field");
            }
        }

        private void EditStaff_Load(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && ch != 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StaffList SL = new StaffList();
            this.Hide();
            SL.Show();
        }
    }
}
