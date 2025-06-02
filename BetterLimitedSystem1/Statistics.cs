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
    public partial class Statistics : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataTable dt;
        public Statistics()
        {
            InitializeComponent();
            con.Connect();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                
                updateProductStats("select p.Item_ID,p.Item_Name,sum(oi.Order_Qty) as Sold_Quantity,p.Price,sum(oi.Price) as ProductEarn from product as p left join ordereditems as oi on p.Item_ID = oi.Item_ID left join salesorder as so on oi.Order_ID = so.Order_ID group by p.Item_ID");
                con.cn.Close();

                con.cn.Open();
                updateChart("select p.Item_ID,p.Item_Name,sum(oi.Order_Qty) as Sold_Quantity,p.Price,sum(oi.Price) as ProductEarn from product as p left join ordereditems as oi on p.Item_ID = oi.Item_ID left join salesorder as so on oi.Order_ID = so.Order_ID group by p.Item_ID");
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updateProductStats(string SqlStr)
        {
            dt = new DataTable();
            da = new MySqlDataAdapter(SqlStr, con.cn);
            dt.Clear();
            da.Fill(dt);
            ProductStats.DataSource = dt;
        }

        public void updateChart(string SqlStr) {
            dt = new DataTable();
            da = new MySqlDataAdapter(SqlStr, con.cn);
            dt.Clear();
            da.Fill(dt);
            chart.DataSource = dt;
            chart.Series["Product"].XValueMember = "Item_ID";
            chart.Series["Product"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart.Series["Product"].YValueMembers = "ProductEarn";
            chart.Series["Product"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMonth.Text == "All Months")
                {
                    con.cn.Open();
                    updateProductStats("select p.Item_ID,p.Item_Name,sum(oi.Order_Qty) as Sold_Quantity,p.Price,sum(oi.Price) as ProductEarn from product as p left join ordereditems as oi on p.Item_ID = oi.Item_ID left join salesorder as so on oi.Order_ID = so.Order_ID where so.Order_Date like '" + cbYear.Text + "%' group by p.Item_ID;");
                    con.cn.Close();

                    con.cn.Open();
                    updateChart("select p.Item_ID,p.Item_Name,sum(oi.Order_Qty) as Sold_Quantity,p.Price,sum(oi.Price) as ProductEarn from product as p left join ordereditems as oi on p.Item_ID = oi.Item_ID left join salesorder as so on oi.Order_ID = so.Order_ID where so.Order_Date like '" + cbYear.Text + "%' group by p.Item_ID;");
                    con.cn.Close();
                }   
                else
                {
                    con.cn.Open();
                    updateProductStats("select p.Item_ID,p.Item_Name,sum(oi.Order_Qty) as Sold_Quantity,p.Price,sum(oi.Price) as ProductEarn from product as p left join ordereditems as oi on p.Item_ID = oi.Item_ID left join salesorder as so on oi.Order_ID = so.Order_ID where so.Order_Date like '%" + cbYear.Text + "-" + cbMonth.Text + "%' group by p.Item_ID;");
                    con.cn.Close();

                    con.cn.Open();
                    updateChart("select p.Item_ID,p.Item_Name,sum(oi.Order_Qty) as Sold_Quantity,p.Price,sum(oi.Price) as ProductEarn from product as p left join ordereditems as oi on p.Item_ID = oi.Item_ID left join salesorder as so on oi.Order_ID = so.Order_ID where so.Order_Date like '%" + cbYear.Text + "-" + cbMonth.Text + "%' group by p.Item_ID;");
                    con.cn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SalesMenu sm = new SalesMenu();
            this.Hide();
            sm.Show();
        }
    }
}
