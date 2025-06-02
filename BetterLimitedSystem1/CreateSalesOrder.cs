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
using System.Collections;
using System.Runtime.Serialization;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.xtra;
using iTextSharp.text.pdf.draw;

namespace BetterLimitedSystem1
{
    

    public partial class CreateSalesOrder : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataTable dt;
        SalesOrder so = new SalesOrder();
        Product p;
        public CreateSalesOrder()
        {
            InitializeComponent();
            con.Connect();
        }

        private void CreateSalesOrder_Load(object sender, EventArgs e)
        {
            try
            {
                BindData1();
                DateTime CurrentDate = DateTime.Now;
                dtpDeliveryDate.MinDate = CurrentDate.AddDays(1);
                ProductView.ReadOnly = true;
                txtHandler.Text = LoginUser.StaffID;
                command = new MySqlCommand("SELECT Order_ID FROM salesorder WHERE Order_ID=(SELECT max(Order_ID) FROM salesorder)", con.cn);
                con.cn.Open();
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    string orderid = dr[0].ToString();
                    string neworderid = "OD" + String.Format("{00:000000}", Convert.ToInt32(orderid.TrimStart("OD".ToCharArray())) + 1);
                    txtOrderID.Text = neworderid;
                    dr.Close();
                }
                else
                {
                    txtOrderID.Text = "OD" + String.Format("{00:000000}", 1);
                    dr.Close();
                }
                con.cn.Close();
                con.cn.Open();
                command = new MySqlCommand("delete from cart",con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                command = new MySqlCommand("delete from cart where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                command.ExecuteNonQuery();
                con.cn.Close();
                this.Hide();
                so.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbDelivery.Checked == true || cbInstallation.Checked == true)
            {
                if (txtAddress.Text != string.Empty && dtpDeliveryDate.Text != string.Empty)
                {
                    if (txtCustomerName.Text != string.Empty && txtCustomerEmail.Text != string.Empty)
                    {
                        if (this.txtCustomerEmail.Text.Contains('@') && this.txtCustomerEmail.Text.Contains('.'))
                        {
                            if (txtCustomerMobile.Text.Length >= 8)
                            {
                                try
                                {
                                    string payment = "";
                                    con.cn.Open();
                                    command = new MySqlCommand("insert into ordereditems(Order_ID,Item_ID, Order_Qty, Price,Availability) select Order_ID,Item_ID,Qty,Price,Availability from cart where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                                    command.ExecuteNonQuery();

                                    command = new MySqlCommand("select * from customer where Customer_Email = '" + txtCustomerEmail.Text + "'", con.cn);
                                    dr = command.ExecuteReader();
                                    if (!dr.Read())
                                    {
                                        dr.Close();
                                        command = new MySqlCommand("insert into customer values(@customerEmail,@customername,@phonenumber,@address)", con.cn);
                                        command.Parameters.AddWithValue("customerEmail", txtCustomerEmail.Text);
                                        command.Parameters.AddWithValue("customername", txtCustomerName.Text);
                                        command.Parameters.AddWithValue("phonenumber", txtCustomerMobile.Text);
                                        command.Parameters.AddWithValue("address", txtAddress.Text);
                                        command.ExecuteNonQuery();
                                    }
                                    dr.Close();
                                    command = new MySqlCommand("insert into salesorder values(@orderid,@customerEmail,@handler,@orderdate,@remark,@paidprice,@totalprice,@payment,@discount,@status)", con.cn);
                                    command.Parameters.AddWithValue("orderid", txtOrderID.Text);
                                    command.Parameters.AddWithValue("customerEmail", txtCustomerEmail.Text);
                                    command.Parameters.AddWithValue("handler", txtHandler.Text);
                                    command.Parameters.AddWithValue("orderdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                    command.Parameters.AddWithValue("remark", txtRemarks.Text);
                                    command.Parameters.AddWithValue("paidprice", txtPaidPrice.Text);
                                    command.Parameters.AddWithValue("totalprice", txtTotal.Text);
                                    if (rbCash.Checked == true)
                                    {
                                        payment = "Cash";
                                    }
                                    else if (rbCreditCard.Checked == true)
                                    {
                                        payment = "Credit Card";
                                    }
                                    else if (rbFPS.Checked == true)
                                    {
                                        payment = "FPS";
                                    }
                                    else if (rbOctopus.Checked == true)
                                    {
                                        payment = "Octopus";
                                    }
                                    command.Parameters.AddWithValue("payment", payment);
                                    if (cbDeposit.Checked == true)
                                    {
                                        command.Parameters.AddWithValue("status", "Deposit");
                                    }
                                    else
                                    {
                                        command.Parameters.AddWithValue("status", "Completed");
                                    }
                                    command.Parameters.AddWithValue("discount", txtDiscount.Text);
                                    command.ExecuteNonQuery();


                                    con.cn.Close();

                                    con.cn.Open();
                                    for (int rows = 0; rows < ProductView.Rows.Count - 1; rows++)
                                    {
                                        string itemid = ProductView.Rows[rows].Cells[0].Value.ToString();
                                        command = new MySqlCommand("select ps.StockQuantity, c.Qty from productstock as ps left join cart as c on ps.Item_ID = c.Item_ID where c.Item_ID = '" + itemid + "'", con.cn);
                                        dr = command.ExecuteReader();
                                        if (dr.Read())
                                        {
                                            int stockqty;
                                            int qty;
                                            int newqty;
                                            stockqty = Convert.ToInt32(dr["StockQuantity"].ToString());
                                            qty = Convert.ToInt32(dr["Qty"].ToString());
                                            dr.Close();
                                            newqty = stockqty - qty;
                                            if (newqty <= 0)
                                            {
                                                command = new MySqlCommand("select Reservation from productstock where Item_ID = '" + itemid + "'", con.cn);
                                                dr = command.ExecuteReader();
                                                if (dr.Read())
                                                {
                                                    int reser = Convert.ToInt32(dr["Reservation"].ToString());
                                                    dr.Close();
                                                    int newser = newqty * -1;
                                                    reser += newser;
                                                    command = new MySqlCommand("update productstock set StockQuantity = '0',Reservation = '" + reser + "' where Item_ID = '" + itemid + "'", con.cn);
                                                    command.ExecuteNonQuery();

                                                }
                                            }
                                            else
                                            {
                                                command = new MySqlCommand("update productstock set StockQuantity = '" + newqty + "' where Item_ID = '" + itemid + "'", con.cn);
                                                command.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                    con.cn.Close();


                                    if (cbDelivery.Checked == true)
                                    {
                                        string newdeliid;
                                        command = new MySqlCommand("SELECT Deli_ID FROM delivery WHERE Deli_ID=(SELECT max(Deli_ID) FROM delivery)", con.cn);
                                        con.cn.Open();
                                        dr = command.ExecuteReader();
                                        if (dr.Read())
                                        {
                                            string deliid = dr[0].ToString();
                                            newdeliid = "DL" + String.Format("{00:00000}", Convert.ToInt32(deliid.TrimStart("DL".ToCharArray())) + 1);
                                            dr.Close();
                                        }
                                        else
                                        {
                                            newdeliid = "DL" + String.Format("{00:00000}", 1);
                                            dr.Close();
                                        }
                                        con.cn.Close();
                                        con.cn.Open();
                                        command = new MySqlCommand("insert into delivery values(@deli_id,@orderid,@address,@deliverydate,@deliverytime,@status,@workman)", con.cn);
                                        command.Parameters.AddWithValue("deli_id", newdeliid);
                                        command.Parameters.AddWithValue("orderid", txtOrderID.Text);
                                        command.Parameters.AddWithValue("address", txtAddress.Text);
                                        command.Parameters.AddWithValue("deliverydate", dtpDeliveryDate.Text);
                                        command.Parameters.AddWithValue("deliverytime", "");
                                        command.Parameters.AddWithValue("status", "Awaiting");
                                        command.Parameters.AddWithValue("workman", "");
                                        command.ExecuteNonQuery();
                                        con.cn.Close();
                                    }

                                    if (cbInstallation.Checked == true)
                                    {
                                        string newinstallid;
                                        command = new MySqlCommand("SELECT Install_ID FROM installation WHERE Install_ID=(SELECT max(Install_ID) FROM installation)", con.cn);
                                        con.cn.Open();
                                        dr = command.ExecuteReader();
                                        if (dr.Read())
                                        {
                                            string installid = dr[0].ToString();
                                            newinstallid = "IS" + String.Format("{00:00000}", Convert.ToInt32(installid.TrimStart("IS".ToCharArray())) + 1);
                                            dr.Close();
                                        }
                                        else
                                        {
                                            newinstallid = "IS" + String.Format("{00:00000}", 1);
                                            dr.Close();
                                        }
                                        con.cn.Close();
                                        con.cn.Open();
                                        command = new MySqlCommand("insert into installation values(@install_id,@orderid,@address,@installationdate,@installationtime,@status,@workman)", con.cn);
                                        command.Parameters.AddWithValue("install_id", newinstallid);
                                        command.Parameters.AddWithValue("orderid", txtOrderID.Text);
                                        command.Parameters.AddWithValue("address", txtAddress.Text);
                                        command.Parameters.AddWithValue("installationdate", dtpDeliveryDate.Text);
                                        command.Parameters.AddWithValue("installationtime", "");
                                        command.Parameters.AddWithValue("status", "Awaiting");
                                        command.Parameters.AddWithValue("workman", "");
                                        command.ExecuteNonQuery();
                                        con.cn.Close();
                                    }
                                    con.cn.Open();
                                    for (int rows = 0; rows < ProductView.Rows.Count - 1; rows++)
                                    {
                                        string itemid = ProductView.Rows[rows].Cells[0].Value.ToString();
                                        command = new MySqlCommand("select StockQuantity from productstock where Item_ID = '" + itemid + "'", con.cn);
                                        dr = command.ExecuteReader();
                                        if (dr.Read())
                                        {
                                            int stockqty = Convert.ToInt32(dr[0].ToString());
                                            dr.Close();
                                            if (stockqty <= 0)
                                            {
                                                command = new MySqlCommand("update product set Avalibility = '0' where Item_ID = '" + itemid + "'", con.cn);
                                                command.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                    con.cn.Close();

                                    MessageBox.Show("Order created . Your Order ID is " + txtOrderID.Text, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    con.cn.Open();
                                    command = new MySqlCommand("delete from cart where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                                    command.ExecuteNonQuery();
                                    con.cn.Close();

                                    if (cbPrint.Checked == true)
                                    {
                                        DialogResult result = MessageBox.Show("Do you want to export the PDF?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                        if (result == DialogResult.Yes)
                                        {
                                            String OrderID = txtOrderID.Text;


                                            string fileName = $"{Directory.GetCurrentDirectory()}\\..\\..\\{OrderID}.pdf";

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
                                                string[] username = { "User Name:", dr["Customer_Name"].ToString() };
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
                                            pdod.Add(new Paragraph(" "));
                                            pdod.Add(new Paragraph(" "));
                                            pdod.Add(new Paragraph(" "));
                                            pdod.Add(new Paragraph(" "));
                                            pdod.Add(pTable);

                                            Chunk glue2 = new Chunk(new VerticalPositionMark());
                                            Paragraph p2 = new Paragraph("");
                                            p2.Add(new Chunk(glue2));
                                            p2.Add("Total_Price = $" + txtTotal.Text);
                                            pdod.Add(p2);

                                            Chunk glue3 = new Chunk(new VerticalPositionMark());
                                            Paragraph p3 = new Paragraph("");
                                            p3.Add(new Chunk(glue3));
                                            p3.Add("Discount = " + txtDiscount.Text);
                                            pdod.Add(p3);

                                            DateTime date = new DateTime();
                                            date = System.DateTime.Now;

                                            Chunk glue = new Chunk(new VerticalPositionMark());
                                            Paragraph p = new Paragraph("Invoice Print Date: " + date.ToString()); ;
                                            p.Add(new Chunk(glue));
                                            p.Add("Sign: __________");
                                            pdod.Add(p);
                                            con.cn.Close();
                                            pdod.Close();
                                            MessageBox.Show("PDF Create success", "", MessageBoxButtons.OK);
                                        }
                                    }


                                    this.Hide();
                                    so.ShowDialog();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    con.cn.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter valid phone number at least 8 digit", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                con.cn.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.cn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter customer name and mobile number");
                        con.cn.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("Please input your delivery address and date");
                }
            }
            else
            {
                if (txtCustomerName.Text != string.Empty && txtCustomerEmail.Text != string.Empty)
                {
                    if (this.txtCustomerEmail.Text.Contains('@') && this.txtCustomerEmail.Text.Contains('.'))
                    {
                        if (txtCustomerMobile.Text.Length >= 8)
                        {
                            try
                            {
                                string payment = "";
                                con.cn.Open();
                                command = new MySqlCommand("insert into ordereditems(Order_ID,Item_ID, Order_Qty, Price,Availability) select Order_ID,Item_ID,Qty,Price,Availability from cart where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                                command.ExecuteNonQuery();

                                command = new MySqlCommand("select * from customer where Customer_Email = '" + txtCustomerEmail.Text + "'", con.cn);
                                dr = command.ExecuteReader();
                                if (!dr.Read())
                                {
                                    dr.Close();
                                    command = new MySqlCommand("insert into customer values(@customerEmail,@customername,@phonenumber,@address)", con.cn);
                                    command.Parameters.AddWithValue("customerEmail", txtCustomerEmail.Text);
                                    command.Parameters.AddWithValue("customername", txtCustomerName.Text);
                                    command.Parameters.AddWithValue("phonenumber", txtCustomerMobile.Text);
                                    command.Parameters.AddWithValue("address", txtAddress.Text);
                                    command.ExecuteNonQuery();
                                }
                                dr.Close();
                                command = new MySqlCommand("insert into salesorder values(@orderid,@customerEmail,@handler,@orderdate,@remark,@paidprice,@totalprice,@payment,@discount,@status)", con.cn);
                                command.Parameters.AddWithValue("orderid", txtOrderID.Text);
                                command.Parameters.AddWithValue("customerEmail", txtCustomerEmail.Text);
                                command.Parameters.AddWithValue("handler", txtHandler.Text);
                                command.Parameters.AddWithValue("orderdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                command.Parameters.AddWithValue("remark", txtRemarks.Text);
                                command.Parameters.AddWithValue("paidprice", txtPaidPrice.Text);
                                command.Parameters.AddWithValue("totalprice", txtTotal.Text);
                                if (rbCash.Checked == true)
                                {
                                    payment = "Cash";
                                }
                                else if (rbCreditCard.Checked == true)
                                {
                                    payment = "Credit Card";
                                }
                                else if (rbFPS.Checked == true)
                                {
                                    payment = "FPS";
                                }
                                else if (rbOctopus.Checked == true)
                                {
                                    payment = "Octopus";
                                }
                                command.Parameters.AddWithValue("payment", payment);
                                if (cbDeposit.Checked == true)
                                {
                                    command.Parameters.AddWithValue("status", "Deposit");
                                }
                                else
                                {
                                    command.Parameters.AddWithValue("status", "Completed");
                                }
                                command.Parameters.AddWithValue("discount", txtDiscount.Text);
                                command.ExecuteNonQuery();


                                con.cn.Close();

                                con.cn.Open();
                                for (int rows = 0; rows < ProductView.Rows.Count - 1; rows++)
                                {
                                    string itemid = ProductView.Rows[rows].Cells[0].Value.ToString();
                                    command = new MySqlCommand("select ps.StockQuantity, c.Qty from productstock as ps left join cart as c on ps.Item_ID = c.Item_ID where c.Item_ID = '" + itemid + "'", con.cn);
                                    dr = command.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        int stockqty;
                                        int qty;
                                        int newqty;
                                        stockqty = Convert.ToInt32(dr["StockQuantity"].ToString());
                                        qty = Convert.ToInt32(dr["Qty"].ToString());
                                        dr.Close();
                                        newqty = stockqty - qty;
                                        if (newqty <= 0)
                                        {
                                            command = new MySqlCommand("select Reservation from productstock where Item_ID = '" + itemid + "'", con.cn);
                                            dr = command.ExecuteReader();
                                            if (dr.Read())
                                            {
                                                int reser = Convert.ToInt32(dr["Reservation"].ToString());
                                                dr.Close();
                                                int newser = newqty * -1;
                                                reser += newser;
                                                command = new MySqlCommand("update productstock set StockQuantity = '0',Reservation = '" + reser + "' where Item_ID = '" + itemid + "'", con.cn);
                                                command.ExecuteNonQuery();

                                            }
                                        }
                                        else
                                        {
                                            command = new MySqlCommand("update productstock set StockQuantity = '" + newqty + "' where Item_ID = '" + itemid + "'", con.cn);
                                            command.ExecuteNonQuery();
                                        }
                                    }
                                }
                                con.cn.Close();


                                if (cbDelivery.Checked == true)
                                {
                                    string newdeliid;
                                    command = new MySqlCommand("SELECT Deli_ID FROM delivery WHERE Deli_ID=(SELECT max(Deli_ID) FROM delivery)", con.cn);
                                    con.cn.Open();
                                    dr = command.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        string deliid = dr[0].ToString();
                                        newdeliid = "DL" + String.Format("{00:00000}", Convert.ToInt32(deliid.TrimStart("DL".ToCharArray())) + 1);
                                        dr.Close();
                                    }
                                    else
                                    {
                                        newdeliid = "DL" + String.Format("{00:00000}", 1);
                                        dr.Close();
                                    }
                                    con.cn.Close();
                                    con.cn.Open();
                                    command = new MySqlCommand("insert into delivery values(@deli_id,@orderid,@address,@deliverydate,@deliverytime,@status,@workman)", con.cn);
                                    command.Parameters.AddWithValue("deli_id", newdeliid);
                                    command.Parameters.AddWithValue("orderid", txtOrderID.Text);
                                    command.Parameters.AddWithValue("address", txtAddress.Text);
                                    command.Parameters.AddWithValue("deliverydate", dtpDeliveryDate.Text);
                                    command.Parameters.AddWithValue("deliverytime", "");
                                    command.Parameters.AddWithValue("status", "Awaiting");
                                    command.Parameters.AddWithValue("workman", "");
                                    command.ExecuteNonQuery();
                                    con.cn.Close();
                                }

                                if (cbInstallation.Checked == true)
                                {
                                    string newinstallid;
                                    command = new MySqlCommand("SELECT Install_ID FROM installation WHERE Install_ID=(SELECT max(Install_ID) FROM installation)", con.cn);
                                    con.cn.Open();
                                    dr = command.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        string installid = dr[0].ToString();
                                        newinstallid = "IS" + String.Format("{00:00000}", Convert.ToInt32(installid.TrimStart("IS".ToCharArray())) + 1);
                                        dr.Close();
                                    }
                                    else
                                    {
                                        newinstallid = "IS" + String.Format("{00:00000}", 1);
                                        dr.Close();
                                    }
                                    con.cn.Close();
                                    con.cn.Open();
                                    command = new MySqlCommand("insert into installation values(@install_id,@orderid,@address,@installationdate,@installationtime,@status,@workman)", con.cn);
                                    command.Parameters.AddWithValue("install_id", newinstallid);
                                    command.Parameters.AddWithValue("orderid", txtOrderID.Text);
                                    command.Parameters.AddWithValue("address", txtAddress.Text);
                                    command.Parameters.AddWithValue("installationdate", dtpDeliveryDate.Text);
                                    command.Parameters.AddWithValue("installationtime", "");
                                    command.Parameters.AddWithValue("status", "Awaiting");
                                    command.Parameters.AddWithValue("workman", "");
                                    command.ExecuteNonQuery();
                                    con.cn.Close();
                                }
                                con.cn.Open();
                                for (int rows = 0; rows < ProductView.Rows.Count - 1; rows++)
                                {
                                    string itemid = ProductView.Rows[rows].Cells[0].Value.ToString();
                                    command = new MySqlCommand("select StockQuantity from productstock where Item_ID = '" + itemid + "'", con.cn);
                                    dr = command.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        int stockqty = Convert.ToInt32(dr[0].ToString());
                                        dr.Close();
                                        if (stockqty <= 0)
                                        {
                                            command = new MySqlCommand("update product set Avalibility = '0' where Item_ID = '" + itemid + "'", con.cn);
                                            command.ExecuteNonQuery();
                                        }
                                    }
                                }
                                con.cn.Close();

                                MessageBox.Show("Order created . Your Order ID is " + txtOrderID.Text, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con.cn.Open();
                                command = new MySqlCommand("delete from cart where Order_ID = '" + txtOrderID.Text + "'", con.cn);
                                command.ExecuteNonQuery();
                                con.cn.Close();

                                if (cbPrint.Checked == true)
                                {
                                    DialogResult result = MessageBox.Show("Do you want to export the PDF?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                    if (result == DialogResult.Yes)
                                    {
                                        String OrderID = txtOrderID.Text;


                                        string fileName = $"{Directory.GetCurrentDirectory()}\\..\\..\\{OrderID}.pdf";

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
                                            string[] username = { "User Name:", dr["Customer_Name"].ToString() };
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
                                        pdod.Add(new Paragraph(" "));
                                        pdod.Add(new Paragraph(" "));
                                        pdod.Add(new Paragraph(" "));
                                        pdod.Add(new Paragraph(" "));
                                        pdod.Add(pTable);

                                        Chunk glue2 = new Chunk(new VerticalPositionMark());
                                        Paragraph p2 = new Paragraph("");
                                        p2.Add(new Chunk(glue2));
                                        p2.Add("Total_Price = $" + txtTotal.Text);
                                        pdod.Add(p2);

                                        Chunk glue3 = new Chunk(new VerticalPositionMark());
                                        Paragraph p3 = new Paragraph("");
                                        p3.Add(new Chunk(glue3));
                                        p3.Add("Discount = " + txtDiscount.Text);
                                        pdod.Add(p3);

                                        DateTime date = new DateTime();
                                        date = System.DateTime.Now;

                                        Chunk glue = new Chunk(new VerticalPositionMark());
                                        Paragraph p = new Paragraph("Invoice Print Date: " + date.ToString()); ;
                                        p.Add(new Chunk(glue));
                                        p.Add("Sign: __________");
                                        pdod.Add(p);
                                        con.cn.Close();
                                        pdod.Close();
                                        MessageBox.Show("PDF Create success", "", MessageBoxButtons.OK);
                                    }
                                }


                                this.Hide();
                                so.ShowDialog();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                con.cn.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid phone number at least 8 digit", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.cn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.cn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter customer name and mobile number");
                    con.cn.Close();
                }
            }
        }

        private void ProductView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                bool hvitem = false;
                bool deposit = false;
                string itemid;
                int qty;
                int stockqty;
                int newqty;
                
                p = new Product();
                if (cbItemID.Text != string.Empty)
                {
                    con.cn.Open();
                    command = new MySqlCommand("select Item_ID from product where Item_ID='" + cbItemID.Text + "'", con.cn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        command = new MySqlCommand("select Item_ID from cart where Item_ID = '" + cbItemID.Text + "'", con.cn);
                        dr = command.ExecuteReader();
                        if (dr.Read()) 
                        {
                            hvitem = true;
                        }
                        else
                        {
                            hvitem = false;
                        }
                        dr.Close();
                        con.cn.Close();
                        if (numQty.Value != 0)
                        {
                            if (hvitem == false)
                            {
                                con.cn.Open();
                                command = new MySqlCommand("select * from product where Item_ID='" + cbItemID.Text + "'", con.cn);
                                dr = command.ExecuteReader();
                                if (dr.Read())
                                {
                                    p.setItem_ID(dr["Item_ID"].ToString());
                                    p.setprice((Double)(dr["Price"]));
                                    dr.Close();

                                    command = new MySqlCommand("Insert into cart values(@orderid,@cartid,@itemid,@orderqty,@price,@avability )", con.cn);
                                    command.Parameters.AddWithValue("orderid", txtOrderID.Text);
                                    command.Parameters.AddWithValue("cartid", 1);
                                    command.Parameters.AddWithValue("itemid", p.Item_ID);
                                    command.Parameters.AddWithValue("orderqty", (int)(numQty.Value));
                                    double Price = p.price * (double)(numQty.Value);
                                    command.Parameters.AddWithValue("price", Price);
                                    command.Parameters.AddWithValue("avability", 'Y');
                                    command.ExecuteNonQuery();

                                    
                                    itemid = cbItemID.Text;
                                    qty = (int)(numQty.Value);
                                    command = new MySqlCommand("select ps.StockQuantity,p.Price from productstock as ps left join product as p on ps.Item_ID = p.Item_ID where p.Item_ID = '" + itemid + "'", con.cn);
                                    dr = command.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        stockqty = Convert.ToInt32(dr["StockQuantity"].ToString());
                                        Price = Double.Parse(dr["Price"].ToString());
                                        dr.Close();
                                        newqty = stockqty - qty;

                                        if (newqty <= 0 && Price > 5000)
                                        {
                                            MessageBox.Show("Not enough product to provide and product price over 5000, order will be deposit with customer", "Not enough product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            deposit = true;
                                        }
                                        else if (newqty <= 0 && Price < 5000)
                                        {
                                            MessageBox.Show("Not enough product to provide but product price is under 5000", "Not enough product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            deposit = true;
                                        }
                                        else if (newqty > 0)
                                        {
                                            deposit = false;
                                        }
                                    }
                                    con.cn.Close();

                                    if (deposit == false)
                                    {
                                        cbDeposit.Checked = false;
                                        command = new MySqlCommand("update cart set Avability = 'Y' where Item_ID = '" + cbItemID.Text + "'", con.cn);
                                        dt = new DataTable();
                                        command = new MySqlCommand("select SUM(Price) from cart", con.cn);
                                        con.cn.Open();
                                        dr = command.ExecuteReader();
                                        if (dr.Read())
                                        {
                                            total = Double.Parse(dr[0].ToString());
                                            dr.Close();
                                        }
                                        con.cn.Close();
                                        txtTotal.Text = total.ToString();
                                        if (total >= 10000)
                                        {
                                            txtDiscount.Text = "10";
                                            txtPaidPrice.Text = (total * 0.9).ToString();
                                        }
                                        else 
                                        {
                                            txtDiscount.Text = "0";
                                            txtPaidPrice.Text = total.ToString();
                                        }
                                        numQty.Value = 0;
                                    }
                                    else
                                    {
                                        cbDeposit.Visible = true;
                                        txtDeposit.Visible = true;
                                        cbDeposit.Checked = true;
                                        dt = new DataTable();
                                        command = new MySqlCommand("select Price from cart where Item_ID = '" + cbItemID.Text + "'", con.cn);
                                        con.cn.Open();
                                        dr = command.ExecuteReader();
                                        if (dr.Read()) {
                                            Price = Double.Parse(dr[0].ToString());
                                            dr.Close();
                                        }
                                        command = new MySqlCommand("update cart set Price = " + Price + ", Availability = 'N' where Item_ID = '" + cbItemID.Text + "'",con.cn);
                                        command.ExecuteNonQuery();

                                        command = new MySqlCommand("select SUM(Price) from cart", con.cn);
                                        dr = command.ExecuteReader();
                                        if (dr.Read())
                                        {
                                            total = Double.Parse(dr[0].ToString());
                                            dr.Close();
                                        }
                                        con.cn.Close();
                                        txtTotal.Text = total.ToString();
                                        if (total >= 10000)
                                        {
                                            txtDiscount.Text = "10";
                                            txtPaidPrice.Text = (total*0.9).ToString();
                                            txtDeposit.Text = (total / 2).ToString();
                                        }
                                        numQty.Value = 0;
                                    }

                                    con.cn.Open();
                                    command = new MySqlCommand("select p.Item_ID as Item_ID, p.Item_Name as Item_Name, c.Qty as Qty, c.Price as Price, c.Availability as Availability from product as p right join cart as c on p.Item_ID = c.Item_ID and c.Order_ID = '" + txtOrderID.Text + "'", con.cn);
                                    dr = command.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        dr.Close();
                                        dt = new DataTable();
                                        da = new MySqlDataAdapter(command);
                                        da.Fill(dt);
                                        ProductView.DataSource = dt;
                                    }
                                    con.cn.Close();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Your list already have this item, please edit by click the item in cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                con.cn.Close();
                                cbItemID.Text = "";
                                numQty.Value = 0;
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid qty of product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.cn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Item ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.cn.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("Please enter the Item ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void txtOrderBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool deposit = false;
                if (ProductView.SelectedRows.Count > 0)
                {
                    double total = 0;
                    int selectedIndex = ProductView.SelectedRows[0].Index;

                    string ItemID = ProductView[0, selectedIndex].Value.ToString();
                    con.cn.Open();
                    command = new MySqlCommand("delete from cart where Item_ID = '" + ItemID + "'", con.cn);
                    command.ExecuteNonQuery();
                    con.cn.Close();

                    command = new MySqlCommand("select sum(Price) from cart", con.cn);
                    con.cn.Open();
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
                    else
                    {
                        dr.Close();
                    }

                    command = new MySqlCommand("select Availability from cart", con.cn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        if (dr[0].ToString() == "")
                        {
                            deposit = false;
                        }
                        else
                        {
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                if (Char.Parse(dr[i].ToString()) == 'Y')
                                {
                                    deposit = true;
                                }
                            }
                        }
                    }
                    else 
                    {
                        deposit = false;
                    }
                    dr.Close();

                    txtTotal.Text = total.ToString();

                    if (total >= 10000)
                    {
                        txtDiscount.Text = "10";
                        txtPaidPrice.Text = (total * 0.9).ToString();
                        if (deposit)
                        {
                            txtDeposit.Text = (total / 2).ToString();
                        }
                        else
                        {
                            txtDeposit.Text = "0";
                        }

                    }
                    else
                    {
                        txtDiscount.Text = "0";
                        txtPaidPrice.Text = total.ToString();
                        txtDeposit.Text = "0";
                    }
                    con.cn.Close();


                    con.cn.Open();
                    command = new MySqlCommand("select p.Item_ID as Item_ID, p.Item_Name as Item_Name, c.Qty as Qty, c.Price as Price, c.Availability as Availability from product as p right join cart as c on p.Item_ID = c.Item_ID and c.Order_ID = '" + txtOrderID.Text + "'", con.cn);
                    dt = new DataTable();
                    da = new MySqlDataAdapter(command);
                    da.Fill(dt);
                    ProductView.DataSource = dt;
                    con.cn.Close();
                }
                else 
                {
                    MessageBox.Show("Please select the product to delete.","Error"
                        ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deleting Failed:" + ex.Message.ToString(), "Delete",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.cn.Close();
            }
        }

        private void txtCustomerEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerEmail.Text != string.Empty)
                {
                    con.cn.Open();
                    command = new MySqlCommand("select * from customer where Customer_Email = '" + txtCustomerEmail.Text + "'", con.cn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        txtCustomerName.Text = dr["Customer_Name"].ToString();
                        txtCustomerMobile.Text = dr["Phone_Number"].ToString();
                        txtAddress.Text = dr["Address"].ToString();
                        dr.Close();
                        con.cn.Close();

                    }
                    else 
                    {
                        MessageBox.Show(txtCustomerName.Text + " never buy product from our company", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.cn.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("Please enter customer email first","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            double total;
            bool deposit = false;
            try
            {
                con.cn.Open();
                command = new MySqlCommand("select p.Item_ID as Item_ID, p.Item_Name as Item_Name, c.Qty as Qty, c.Price as Price, c.Availability as Availability from product as p right join cart as c on p.Item_ID = c.Item_ID and c.Order_ID = '" + txtOrderID.Text + "'", con.cn);
                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                da.Fill(dt);
                ProductView.DataSource = dt;
                con.cn.Close();

                command = new MySqlCommand("select sum(Price) from cart", con.cn);
                con.cn.Open();
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
                else 
                {
                    total = 0;
                    dr.Close();
                }

                command = new MySqlCommand("select Availability from cart", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    if (dr[0].ToString() == "")
                    {
                        deposit = false;
                    }
                    else
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            if (Char.Parse(dr[i].ToString()) == 'N')
                            {
                                deposit = true;
                            }
                        }
                    }
                }
                else
                {
                    deposit = false;
                }
                dr.Close();
                
                txtTotal.Text = total.ToString();

                if (deposit == false)
                {
                    cbDeposit.Checked = false;
                    cbDeposit.Visible = false;
                    txtDeposit.Visible = false;

                    if (total >= 10000)
                    {
                        txtDiscount.Text = "10";
                        txtPaidPrice.Text = (total * 0.9).ToString();
                    }
                    else
                    {
                        txtDiscount.Text = "0";
                        txtPaidPrice.Text = total.ToString();
                        txtDeposit.Text = "0";
                    }
                }
                else
                {
                    cbDeposit.Visible = true;
                    txtDeposit.Visible = true;
                    cbDeposit.Checked = true;
                    
                    command = new MySqlCommand("select SUM(Price) from cart", con.cn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        total = Double.Parse(dr[0].ToString());
                        dr.Close();
                    }
                    con.cn.Close();
                    txtTotal.Text = total.ToString();
                    if (total >= 10000)
                    {
                        txtDiscount.Text = "10";
                        txtPaidPrice.Text = (total * 0.9).ToString();
                        txtDeposit.Text = (total / 2).ToString();
                    }
                    else
                    {
                        txtDiscount.Text = "0";
                        txtPaidPrice.Text = total.ToString();
                        txtDeposit.Text = (total / 2).ToString();
                    }
                }
                con.cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.cn.Close();
            }
        }

        private void ProductView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrdereditemDetail OI = new OrdereditemDetail();
            OI.txtItemID.Text = this.ProductView.CurrentRow.Cells[0].Value.ToString();
            OI.txtItemName.Text = this.ProductView.CurrentRow.Cells[1].Value.ToString();
            OI.txtQty.Text = this.ProductView.CurrentRow.Cells[2].Value.ToString();
            OI.txtPrice.Text = this.ProductView.CurrentRow.Cells[3].Value.ToString();
            OI.ShowDialog();
        }

        private void cbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDelivery.Checked == true)
            {
                lbAddress.Visible = true;
                txtAddress.Visible = true;
                lbDelivery.Visible = true;
                dtpDeliveryDate.Visible = true;
            }
            else 
            {
                lbAddress.Visible = false;
                txtAddress.Visible = false;
                lbDelivery.Visible = false;
                dtpDeliveryDate.Visible = false;
            }

        }

        private void dtpDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            con.cn.Open();
            command = new MySqlCommand("select count(Delivery_Date) from delivery where Delivery_Date = '" + dtpDeliveryDate.Text + "'", con.cn);
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                int count = Convert.ToInt32(dr[0].ToString());
                if (count > 15)
                {
                    MessageBox.Show("This day is full delivery booking");
                    dr.Close();
                }
            }
            con.cn.Close();
        }

        public void BindData1()
        {
            con.cn.Open();
            string strCmd = "select Item_ID from product where Avalibility = '1' order by Item_ID";
            command = new MySqlCommand(strCmd, con.cn);
            da = new MySqlDataAdapter(strCmd, con.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            command.ExecuteNonQuery();
            con.cn.Close();

            cbItemID.DisplayMember = "Item_ID";
            cbItemID.ValueMember = "Item_ID";
            cbItemID.DataSource = ds.Tables[0];

            cbItemID.Enabled = true;

        }

        private void cbItemID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRemarks_Enter(object sender, EventArgs e)
        {
            if (txtRemarks.Text == "Remarks...")
            {
                txtRemarks.Text = "";
                txtRemarks.ForeColor = Color.Black;
            }
        }

        private void txtRemarks_Leave(object sender, EventArgs e)
        {
            if (txtRemarks.Text == "")
            {
                txtRemarks.Text = "Remarks...";
                txtRemarks.ForeColor = Color.Gray;
            }
        }

        private void txtCustomerMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch) && ch != 8 && ch != 46 && ch != '-')
            {
                e.Handled = true;
            }
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
