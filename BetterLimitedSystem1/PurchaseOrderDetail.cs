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
    public partial class PurchaseOrderDetail : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataTable dt;
        public PurchaseOrderDetail()
        {
            InitializeComponent();
            con.Connect();
        }

        private void PurchaseOrderDetail_Load(object sender, EventArgs e)
        {
            double total = 0;
            ProductView.ReadOnly = true;
            try
            {
                con.cn.Open();
                command = new MySqlCommand("select * from purchaseorder where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txtSupplierID.Text = dr["SupplierID"].ToString();
                    txtStatus.Text = dr["Status"].ToString();
                    dr.Close();
                    command = new MySqlCommand("select SupplierName from supplier where SupplierID = '" + txtSupplierID.Text + "'", con.cn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        txtSupplierName.Text = dr[0].ToString();
                        dr.Close();
                    }
                }
                con.cn.Close();


                con.cn.Open();
                command = new MySqlCommand("select sum(Total_Price) from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    if (dr[0].ToString() == "")
                    {
                        total = 0;
                    }
                    else
                    {
                        total = double.Parse(dr[0].ToString());
                    }
                    dr.Close();
                }
                txtTotal.Text = total.ToString();
                updateProductView("select Item_ID,Quantity,Price from purchaseitem where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'");
                con.cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        public void updateProductView(string SqlStr)
        {
            dt = new DataTable();
            da = new MySqlDataAdapter(SqlStr, con.cn);
            dt.Clear();
            da.Fill(dt);
            ProductView.DataSource = dt;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("update purchaseorder set Status = 'Approval' where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();

                DialogResult print = MessageBox.Show("Do you want to generate a Purchase Order Notes?", "Purchase Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (print == DialogResult.Yes)
                {
                    String purchaseorderid = txtPurchaseOrderID.Text;


                    string fileName = $"{Directory.GetCurrentDirectory()}\\..\\..\\..\\Purchase Order Notes\\{purchaseorderid}.pdf";

                    Document pdod = new Document(PageSize.A4, 50f, 50f, 40f, 40f);

                    PdfWriter.GetInstance(pdod, new FileStream(fileName, FileMode.Create));
                    pdod.Open();

                    Paragraph pd3 = new Paragraph("Purchase Order Notes");
                    pd3.Alignment = 1;
                    pdod.Add(pd3);

                    command = new MySqlCommand("select * from purchaseorder where PurchaseOrder_ID = '" + purchaseorderid + "'", con.cn);
                    con.cn.Open();
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        DateTime Purchase = DateTime.Now;
                        string PurchaseDate = Purchase.ToString("yyyy-MM-dd");
                        string[] PurchaseOrderID = { "Purchase Order ID:", purchaseorderid };
                        string[] supplierid = { "Supplier ID:", dr["SupplierID"].ToString() };
                        string[] purchaseDateArray = {"Purchase Date:", PurchaseDate };

                        Chunk glue1 = new Chunk(new VerticalPositionMark());
                        Paragraph pd = new Paragraph(PurchaseOrderID[0] + " " + PurchaseOrderID[1]);
                        pd.Add(new Chunk(glue1));
                        pd.Add(purchaseDateArray[0] + " " + purchaseDateArray[1]);
                        pd.SpacingAfter = 20;
                        pdod.Add(pd);

                        pdod.Add(new Paragraph(""));
                        pd = new Paragraph(supplierid[0] + " " + supplierid[1]);
                        pd.Alignment = 1;
                        pd.SpacingAfter = 20;
                        pdod.Add(pd);
                        dr.Close();
                    }
                    DateTime date = DateTime.Now;
                    string currentdate = date.ToString("yyyy-MM-dd");

                    PdfPTable pTable = new PdfPTable(ProductView.Columns.Count);

                    for (int i = 0; i < ProductView.Columns.Count; i++)
                    {
                        pTable.AddCell(new Phrase(ProductView.Columns[i].HeaderText));
                    }
                    pTable.HeaderRows = 1;
                    for (int i = 0; i < ProductView.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < ProductView.Columns.Count; j++)
                        {
                            if (ProductView[j, i].Value != null)
                                pTable.AddCell(new Phrase(ProductView[j, i].Value.ToString()));
                        }
                    }

                    pTable.SpacingAfter = 30;
                    pTable.SpacingBefore = 30;
                    pdod.Add(pTable);


                    Chunk glue = new Chunk(new VerticalPositionMark());
                    Paragraph p = new Paragraph("Purchase Order Notes Print Date: "); ;
                    p.Add(new Chunk(glue));
                    p.Add("Sign: __________");
                    p.SpacingBefore = 30;
                    pdod.Add(p);

                    Chunk glue2 = new Chunk(new VerticalPositionMark());
                    Paragraph p2 = new Paragraph(currentdate.ToString());
                    pdod.Add(p2);
                    con.cn.Close();
                    pdod.Close();

                    MessageBox.Show("PDF Create success", "", MessageBoxButtons.OK);
                    PurchaseOrderList POL = new PurchaseOrderList();
                    this.Hide();
                    POL.Show();
                }
                else
                {
                    PurchaseOrderList POL = new PurchaseOrderList();
                    this.Hide();
                    POL.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("update purchaseorder set Status = 'Not Approval' where PurchaseOrder_ID = '" + txtPurchaseOrderID.Text + "'", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();

                PurchaseOrderList POL = new PurchaseOrderList();
                this.Hide();
                POL.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
