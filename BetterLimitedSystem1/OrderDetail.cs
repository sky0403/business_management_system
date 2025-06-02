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

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.xtra;
using iTextSharp.text.pdf.draw;

namespace BetterLimitedSystem1
{
    public partial class Order_Detail : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        DataTable dt;
        MySqlDataAdapter da;
        SalesOrder so = new SalesOrder();
        public Order_Detail()
        {
            InitializeComponent();
            con.Connect();
        }

        private void Order_Detail_Load(object sender, EventArgs e)
        {
            try
            {
                cbDeposit.Enabled = false;
                command = new MySqlCommand("SELECT * FROM salesorder WHERE Order_ID = '" + txtOrderID.Text + "'", con.cn);
                con.cn.Open();
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    string staffid = dr["StaffID"].ToString();
                    txtHandler.Text = staffid;
                    string customeremail = dr["Customer_Email"].ToString();
                    txtCustomerEmail.Text = customeremail;
                    string remarks = dr["Remarks"].ToString();
                    txtRemarks.Text = remarks;
                    double total = Double.Parse(dr["Total_Price"].ToString());
                    txtTotal.Text = total.ToString();
                    txtPaidPrice.Text = dr["Paid_Price"].ToString();
                    txtOrderDate.Text = dr["Order_Date"].ToString();
                    txtDiscount.Text = dr["Discount"].ToString();
                    txtStatus.Text = dr["Status"].ToString();
                    txtPayment.Text = dr["Payment"].ToString();
                    if (dr["Status"].ToString() == "Deposit")
                    {
                        cbFullPaid.Checked = false;
                        cbDeposit.Checked = true;
                        cbDeposit.Visible = true;
                        txtDeposit.Visible = true;
                        txtDeposit.Text = (total / 2).ToString();
                    }
                    else 
                    {
                        cbFullPaid.Checked = true;
                        cbDeposit.Checked = false;
                        cbDeposit.Visible = false;
                        txtDeposit.Visible = false;
                        txtDeposit.Text = "";
                    }
                    dr.Close();
                    
                }
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("select * from delivery where Order_ID = '" + txtOrderID.Text + "'",con.cn);
                dr = command.ExecuteReader();
                if (dr.Read()) 
                {
                    DateTime delivery = DateTime.Parse(dr["Delivery_Date"].ToString());
                    txtDeliveryDate.Text = delivery.ToString("yyyy-MM-dd");
                    dr.Close();
                }
                con.cn.Close();

                command = new MySqlCommand("SELECT * FROM customer WHERE Customer_Email = '" + txtCustomerEmail.Text + "'", con.cn);
                con.cn.Open();
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txtCustomerName.Text = dr["Customer_Name"].ToString();
                    txtCustomerMobile.Text = dr["Phone_Number"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    dr.Close();
                    con.cn.Close();
                }

                dt = new DataTable();
                da = new MySqlDataAdapter("select oi.Item_ID, p.Item_Name , oi.Order_Qty as Qty, p.Price as Unit_Price, oi.Price as Total_Price from ordereditems as oi left join product as p on oi.Item_ID = p.Item_ID where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                da.Fill(dt);
                ProductView.DataSource = dt;

                con.cn.Open();
                command = new MySqlCommand("select * from delivery where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    txtDeliveryDate.Visible = true;
                    lb_address.Visible = true;
                    lb_date.Visible = true;
                    txtAddress.Visible = true;
                }
                else
                {
                    dr.Close();
                    txtDeliveryDate.Visible =false;
                    lb_address.Visible = false;
                    lb_date.Visible = false;
                    txtAddress.Visible = false;
                }


                con.cn.Close();

               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            so.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text != string.Empty && txtCustomerMobile.Text != string.Empty && txtCustomerEmail.Text != string.Empty)
            {
                try
                {
                    DialogResult result;
                    result = MessageBox.Show(this, "Are you sure you want to update this record?", "Update Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (cbFullPaid.Checked == true)
                        {
                            con.cn.Open();
                            command = new MySqlCommand("update salesorder set Remarks = @remarks, Status = @status where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                            command.Parameters.AddWithValue("remarks", txtRemarks.Text);
                            command.Parameters.AddWithValue("status", "Completed");
                            command.ExecuteNonQuery();
                            command = new MySqlCommand("update customer set Address = @address,Phone_Number = @phone, Customer_Name = @customername where Customer_Email = '" + txtCustomerEmail.Text + "'", con.cn);
                            command.Parameters.AddWithValue("address", txtAddress.Text);
                            command.Parameters.AddWithValue("phone", txtCustomerMobile.Text);
                            command.Parameters.AddWithValue("customername", txtCustomerName.Text);
                            command.ExecuteNonQuery();
                            con.cn.Close();
                        }
                        else
                        {
                            con.cn.Open();
                            command = new MySqlCommand("update salesorder set Status = @status,Remarks = @remarks where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                            command.Parameters.AddWithValue("status", "Deposit");
                            command.Parameters.AddWithValue("remarks", txtRemarks.Text);
                            command.ExecuteNonQuery();
                            command = new MySqlCommand("update customer set Address = @address,Phone_Number = @phone, Customer_Name = @customername where Customer_Email = '" + txtCustomerEmail.Text + "'", con.cn);
                            command.Parameters.AddWithValue("phone", txtCustomerMobile.Text);
                            command.Parameters.AddWithValue("address", txtAddress.Text);
                            command.Parameters.AddWithValue("customername", txtCustomerName.Text);
                            command.ExecuteNonQuery();
                            con.cn.Close();
                        }
                        con.cn.Open();
                        command = new MySqlCommand("update delivery set Address = @address where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                        command.Parameters.AddWithValue("address", txtAddress.Text);
                        command.ExecuteNonQuery();
                        command = new MySqlCommand("update installation set Address = @address where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                        command.Parameters.AddWithValue("address", txtAddress.Text);
                        command.ExecuteNonQuery();
                        con.cn.Close();
                        this.Hide();
                        so.ShowDialog();
                    }
                    else
                    {
                        con.cn.Close();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Please fill all customer information","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show(this, "Are you sure you want to cancel this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    con.cn.Open();
                    command = new MySqlCommand("delete from ordereditems where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                    command.ExecuteNonQuery();
                    command = new MySqlCommand("delete from delivery where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                    command.ExecuteNonQuery();
                    command = new MySqlCommand("delete from installation where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                    command.ExecuteNonQuery();
                    command = new MySqlCommand("delete from salesorder where Order_ID = '" + txtOrderID.Text + "'", con.cn );
                    command.ExecuteNonQuery();
                    con.cn.Close();
                    this.Hide();
                    so.ShowDialog();

                }
                else
                {
                    con.cn.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deleting Failed:" + ex.Message.ToString(), "Delete",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.cn.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to export the PDF?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes) 
                {
                    String OrderID = txtOrderID.Text;


                    string fileName = $"{Directory.GetCurrentDirectory()}\\..\\..\\..\\Invoice\\{OrderID}.pdf";

                    Document pdod = new Document(PageSize.A4, 50f, 50f, 40f, 40f);

                    PdfWriter.GetInstance(pdod, new FileStream(fileName, FileMode.Create));
                    pdod.Open();

                    command = new MySqlCommand("select so.Order_Date, c.Address, c.Customer_Name from salesorder as so left join customer as c on so.Customer_Email = c.Customer_Email where Order_ID = '" + OrderID + "'", con.cn);
                    con.cn.Open();
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        string[] oid = { "Order ID:", OrderID };
                        string[] orderDate = { "Order Date:", dr["Order_Date"].ToString() };
                        string[] username = { "Customer Name:", dr["Customer_Name"].ToString() };
                        string[] address = { "Address:", dr["Address"].ToString() };

                        Chunk glue1 = new Chunk(new VerticalPositionMark());
                        Paragraph pd = new Paragraph(oid[0] + " " + oid[1]);
                        pd.Add(new Chunk(glue1));
                        pd.Add(orderDate[0] + " " + orderDate[1]);
                        pdod.Add(pd);
                        pdod.Add(new Paragraph(username[0] + " " + username[1]));
                        pdod.Add(new Paragraph(address[0] + " " + address[1]));
                        dr.Close();
                    }

                    PdfPTable pTable = new PdfPTable(ProductView.Columns.Count);

                    for (int i = 0; i< ProductView.Columns.Count;i++) 
                    {
                        
                        pTable.AddCell(new Phrase(ProductView.Columns[i].HeaderText));
                    }
                    pTable.HeaderRows = 1;
                    for(int i = 0; i < ProductView.Rows.Count - 1; i++) {
                        for(int j = 0; j< ProductView.Columns.Count;j++) 
                        {
                            if(ProductView[j,i].Value != null)
                                pTable.AddCell(new Phrase(ProductView[j,i].Value.ToString()));
                        }
                    }
                    pdod.Add(new Paragraph(" "));
                    pdod.Add(new Paragraph(" "));
                    pdod.Add(new Paragraph(" "));
                    pdod.Add(new Paragraph(" "));
                    pTable.SpacingBefore = 30;
                    pTable.SpacingAfter = 60;
                    pdod.Add(pTable);

                    Chunk glue2 = new Chunk(new VerticalPositionMark());
                    Paragraph p2 = new Paragraph("");
                    p2.Add(new Chunk(glue2));
                    p2.Add("Total_Price = $" + txtTotal.Text);
                    pdod.Add(p2);

                    Chunk glue3 = new Chunk(new VerticalPositionMark());
                    Paragraph p3 = new Paragraph("");
                    p3.Add(new Chunk(glue3));
                    p3.Add("Discount = " + txtDiscount.Text + "%");
                    pdod.Add(p3);

                    Chunk glue4 = new Chunk(new VerticalPositionMark());
                    Paragraph p4 = new Paragraph("");
                    p3.Add(new Chunk(glue4));
                    p3.Add("Payment = " + txtPayment.Text);
                    pdod.Add(p4);

                    Chunk glue5 = new Chunk(new VerticalPositionMark());
                    Paragraph p5 = new Paragraph("");
                    p3.Add(new Chunk(glue5));
                    p3.Add("Status = " + txtStatus.Text);
                    pdod.Add(p5);

                    DateTime date = new DateTime();
                    date = System.DateTime.Now;

                    Chunk glue = new Chunk(new VerticalPositionMark());
                    Paragraph p = new Paragraph("Invoice Print Date: " + date.ToString()); ;
                    p.Add(new Chunk(glue));
                    p.Add("Sign: __________");
                    pdod.Add(p);
                    con.cn.Close();
                    pdod.Close();
                    MessageBox.Show("PDF Create success","", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
