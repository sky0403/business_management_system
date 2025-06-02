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
    public partial class DailyInstallationList : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlDataReader dr;
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt;
        public DailyInstallationList()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("select i.Install_ID as Installation_ID,i.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, i.Address,i.Installation_Time,i.Status,i.Installation_workman from installation as i left join salesorder as so on i.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where Installation_Date = '" + dtpDate.Text + "'", con.cn);
                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                dt.Clear();
                da.Fill(dt);
                InstallationView.DataSource = dt;
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DailyInstallationList_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                con.cn.Open();
                command = new MySqlCommand("select i.Install_ID as Installation_ID,i.Order_ID,c.Customer_Name,c.Phone_Number as Cuomster_Phone, i.Address,i.Installation_Time,i.Status,i.Installation_workman from installation as i left join salesorder as so on i.Order_ID = so.Order_ID left join customer as c on c.Customer_Email = so.Customer_Email where i.Status = 'P'", con.cn);
                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                dt.Clear();
                da.Fill(dt);
                InstallationView.DataSource = dt;
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DeliveryandInstallationManagement DI = new DeliveryandInstallationManagement();
            this.Hide();
            DI.Show();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to export the PDF?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    String InstallationName = dtpDate.Text + " Installation List";


                    string fileName = $"{Directory.GetCurrentDirectory()}\\..\\..\\..\\Daily Installation List\\{InstallationName}.pdf";

                    Document pdfDelivery = new Document(PageSize.A4_LANDSCAPE, 0f, 0f, 0f, 0f);

                    PdfWriter.GetInstance(pdfDelivery, new FileStream(fileName, FileMode.Create));
                    pdfDelivery.Open();

                    Paragraph pd = new Paragraph("Better Limited");
                    pd.Alignment = 1;
                    pdfDelivery.Add(pd);

                    Paragraph pd1 = new Paragraph(InstallationName);
                    pd1.Alignment = 1;
                    pdfDelivery.Add(pd1);

                    PdfPTable pTable = new PdfPTable(InstallationView.Columns.Count);


                    for (int i = 0; i < InstallationView.Columns.Count; i++)
                    {

                        pTable.AddCell(new Phrase(InstallationView.Columns[i].HeaderText));
                    }
                    pTable.HeaderRows = 1;
                    for (int i = 0; i < InstallationView.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < InstallationView.Columns.Count; j++)
                        {
                            if (InstallationView[j, i].Value != null)
                                pTable.AddCell(new Phrase(InstallationView[j, i].Value.ToString()));
                        }
                    }
                    pdfDelivery.Add(new Paragraph(" "));
                    pdfDelivery.Add(new Paragraph(" "));
                    pdfDelivery.Add(new Paragraph(" "));
                    pdfDelivery.Add(new Paragraph(" "));
                    pdfDelivery.Add(pTable);


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
