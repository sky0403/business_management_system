using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimitedSystem1
{
    public partial class InwardsRecord : Form
    {
        myDBConnection con = new myDBConnection();
        DataTable dt;
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        public InwardsRecord()
        {
            InitializeComponent();
            con.Connect();
        }

        private void InwardsRecord_Load(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                UpdateInwardsView("select ir.Item_ID,p.Item_Name,ir.Quantity,ir.InwardsDate from inwardsrecord as ir left join product as p on ir.Item_ID = p.Item_ID");
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateInwardsView(string SqlStr)
        {
            dt = new DataTable();
            da = new MySqlDataAdapter(SqlStr, con.cn);
            dt.Clear();
            da.Fill(dt);
            InwardsView.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                switch (comboBoxSearchBy.Text) 
                {
                    case "All":
                        UpdateInwardsView("select ir.Item_ID,p.Item_Name,ir.Quantity,ir.InwardsDate from inwardsrecord as ir left join product as p on ir.Item_ID = p.Item_ID");
                        break;
                    case "Product ID":
                        UpdateInwardsView("select ir.Item_ID,p.Item_Name,ir.Quantity,ir.InwardsDate from inwardsrecord as ir left join product as p on ir.Item_ID = p.Item_ID where ir.Item_ID = '" + cbSearch.SelectedValue + "'");
                        break;
                    case "Product Name":
                        UpdateInwardsView("select ir.Item_ID,p.Item_Name,ir.Quantity,ir.InwardsDate from inwardsrecord as ir left join product as p on ir.Item_ID = p.Item_ID where p.Item_Name like '%" + cbSearch.SelectedValue + "%'");
                        break;
                }
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                UpdateInwardsView("select ir.Item_ID,p.Item_Name,ir.Quantity,ir.InwardsDate from inwardsrecord as ir left join product as p on ir.Item_ID = p.Item_ID");
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                UpdateInwardsView("select ir.Item_ID,p.Item_Name,ir.Quantity,ir.InwardsDate from inwardsrecord as ir left join product as p on ir.Item_ID = p.Item_ID where ir.InwardsDate  between '" + dtpFromDate.Text + "' and '" + dtpToDate.Text + "'");
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            this.Hide();
            i.Show();
        }

        public void BindData1() 
        {
            con.cn.Open();
            string strCmd = "select * from product order by Item_ID";
            command = new MySqlCommand(strCmd, con.cn);
            da = new MySqlDataAdapter(strCmd, con.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            command.ExecuteNonQuery();
            con.cn.Close();

            cbSearch.DisplayMember = "Item_ID";
            cbSearch.ValueMember = "Item_ID";
            cbSearch.DataSource = ds.Tables[0];

            cbSearch.Enabled = true;
            cbSearch.ForeColor = Color.Black;
        }

        public void BindData2() 
        {
            con.cn.Open();
            string strCmd = "select * from product order by Item_ID";
            command = new MySqlCommand(strCmd, con.cn);
            da = new MySqlDataAdapter(strCmd, con.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            command.ExecuteNonQuery();
            con.cn.Close();

            cbSearch.DisplayMember = "Item_Name";
            cbSearch.ValueMember = "Item_ID";
            cbSearch.DataSource = ds.Tables[0];

            cbSearch.Enabled = true;
            cbSearch.ForeColor = Color.Black;
        }


        private void comboBoxSearchBy_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxSearchBy.SelectedItem)
            {
                case "All":
                    cbSearch.ForeColor = Color.Gray;
                    cbSearch.Enabled = false;
                    break;
                case "Product ID":
                    BindData1();
                    break;
                case "Product Name":
                    BindData2();
                    break;
            }
        }
    }
}
