using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using MySql.Data.MySqlClient;

namespace BetterLimitedSystem1
{
    public partial class DailyDeliveryList : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlDataReader dr;
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt;
        public DailyDeliveryList()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DeliveryandInstallationManagement DI = new DeliveryandInstallationManagement();
            this.Hide();
            DI.Show();
        }

        private void DailyDeliveryList_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                con.cn.Open();
                command = new MySqlCommand("select d.Deli_ID as Delivery_ID,d.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, d.Address,d.Delivery_Date,d.Delivery_Session,d.Status,d.Delivery_workman from delivery as d left join salesorder as so on d.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where Delivery_Date = '" + dtpDate.Text + "'", con.cn);
                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                dt.Clear();
                da.Fill(dt);
                DeliveryView.DataSource = dt;
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("select d.Deli_ID as Delivery_ID,d.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, d.Address,d.Delivery_Date,d.Delivery_Session,d.Status,d.Delivery_workman from delivery as d left join salesorder as so on d.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where Delivery_Date = '" + dtpDate.Text + "'", con.cn);
                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                dt.Clear();
                da.Fill(dt);
                DeliveryView.DataSource = dt;
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to export the PDF?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    String DeliveryName = dtpDate.Text + " Delivery List";


                    string fileName = $"{Directory.GetCurrentDirectory()}\\..\\..\\..\\Daily Delivery List\\{DeliveryName}.pdf";

                    Document pdfDelivery = new Document(PageSize.A4_LANDSCAPE, 0f, 0f, 0f, 0f);

                    PdfWriter.GetInstance(pdfDelivery, new FileStream(fileName, FileMode.Create));
                    pdfDelivery.Open();

                    Paragraph pd = new Paragraph("Better Limited");
                    pd.Alignment = 1;
                    pdfDelivery.Add(pd);

                    Paragraph pd1 = new Paragraph(DeliveryName);
                    pd1.Alignment = 1;
                    pdfDelivery.Add(pd1);

                    PdfPTable pTable = new PdfPTable(DeliveryView.Columns.Count);


                    for (int i = 0; i < DeliveryView.Columns.Count; i++)
                    {

                        pTable.AddCell(new Phrase(DeliveryView.Columns[i].HeaderText));
                    }
                    pTable.HeaderRows = 1;
                    for (int i = 0; i < DeliveryView.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < DeliveryView.Columns.Count; j++)
                        {
                            if (DeliveryView[j, i].Value != null)
                                pTable.AddCell(new Phrase(DeliveryView[j, i].Value.ToString()));
                        }
                    }
                    
                    pTable.SpacingBefore = 30;
                    pTable.SpacingAfter = 30;
                    pdfDelivery.Add(pTable);


                    DateTime date = new DateTime();
                    date = DateTime.Now;

                    pdfDelivery.Close();
                    MessageBox.Show("Daliy Delivery PDF Create success", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
