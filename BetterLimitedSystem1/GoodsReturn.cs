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
    public partial class GoodsReturn : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataTable dt;
        public GoodsReturn()
        {
            InitializeComponent();
            con.Connect();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtOther_Enter(object sender, EventArgs e)
        {
            if (txtDetails.Text == "Faulty or other details") 
            {
                txtDetails.Text = "";
                txtDetails.ForeColor = Color.Black;
            }
        }

        private void txtOther_Leave(object sender, EventArgs e)
        {
            if (txtDetails.Text == "") 
            {
                txtDetails.Text = "Faulty or other details";
                txtDetails.ForeColor = Color.Gray;
            }
        }

        private void GoodsReturn_Load(object sender, EventArgs e)
        {
            BindData1();
            rbDead.Checked = true;
            rbOpenYes.Checked = true;
        }

        public void BindData1()
        {
            con.cn.Open();
            string strCmd = "select * from product";
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

        public void BindData2()
        {
            con.cn.Open();
            string strCmd = "select * from salesorder where Customer_Email = '" + txtEmail.Text + "'";
            command = new MySqlCommand(strCmd, con.cn);
            dr = command.ExecuteReader();
            if (dr.Read())
            {
                DateTime orderdate = DateTime.Parse(dr["Order_Date"].ToString());
                dtpOrderDate.Text = orderdate.ToString("yyyy-MM-dd");
                dr.Close();
                da = new MySqlDataAdapter(strCmd, con.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                command.ExecuteNonQuery();
                con.cn.Close();

                cbOrderID.DisplayMember = "Order_ID";
                cbOrderID.ValueMember = "Order_ID";
                cbOrderID.DataSource = ds.Tables[0];

                cbOrderID.Enabled = true;
                dtpOrderDate.Enabled = false;
            }
            else 
            {
                dr.Close();
                cbOrderID.Text = "";
                cbOrderID.DataSource = null;
                MessageBox.Show("This customer no relative order record");
                con.cn.Close();
                dtpOrderDate.Enabled = true;
            }


        }

        private void cbItemID_SelectedValueChanged(object sender, EventArgs e)
        {
            try 
            {
                con.cn.Open();
                command = new MySqlCommand("select Item_Name from product where Item_ID = '" + cbItemID.SelectedValue + "'", con.cn);
                dr = command.ExecuteReader();
                if (dr.Read()) 
                {
                    string itemname = dr[0].ToString();
                    dr.Close();
                    txtItemName.Text = itemname;
                    
                }
                con.cn.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            this.Hide();
            i.Show();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (this.txtEmail.Text.Contains('@') && this.txtEmail.Text.Contains('.')){
                try
                {
                    con.cn.Open();
                    command = new MySqlCommand("select * from customer where Customer_Email = '" + txtEmail.Text + "'", con.cn);
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        string customername = dr["Customer_Name"].ToString();
                        string customerphone = dr["Phone_Number"].ToString();
                        dr.Close();
                        txtCustomerName.Text = customername;
                        txtPhone.Text = customerphone;
                        con.cn.Close();
                        txtCustomerName.ReadOnly = true;
                        txtPhone.ReadOnly = true;
                        
                        BindData2();
                    }
                    else 
                    {
                        dr.Close();
                        MessageBox.Show("Dont have this customer information");
                        txtCustomerName.Text = "";
                        txtPhone.Text = "";
                        cbOrderID.Text = "";
                        txtCustomerName.ReadOnly = true;
                        txtPhone.ReadOnly = true;
                        dtpOrderDate.Enabled = false;
                    }
                    con.cn.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Please input valid email address");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtCustomerName.Text != string.Empty && txtPhone.Text != string.Empty
                && cbOrderID.Text != string.Empty && txtItemName.Text != string.Empty && cbItemID.Text != string.Empty
                && numQty.Value != 0)
            {
                DialogResult result = MessageBox.Show("Do you want to create a new defect item?","Defect Item", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string defectid;
                    string newdefectid;
                    string reason;
                    char open;
                    command = new MySqlCommand("SELECT DefectID FROM defectitem WHERE DefectID=(SELECT max(DefectID) FROM defectitem)", con.cn);
                    con.cn.Open();
                    dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        defectid = dr[0].ToString();
                        newdefectid = "DE" + String.Format("{00:0000}", Convert.ToInt32(defectid.TrimStart("DE".ToCharArray())) + 1);
                        dr.Close();
                    }
                    else
                    {
                        newdefectid = "DE" + String.Format("{00:0000}", 1);
                        dr.Close();
                    }
                    con.cn.Close();
                    DateTime CurrentDate = DateTime.Now;
                    string current = CurrentDate.ToString("yyyy-MM-dd");
                    con.cn.Open();
                    command = new MySqlCommand("insert into defectitem values(@defectid,@orderid,@itemid,@customeremail,@quantity," +
                        "@defectdate,@reason,@opened,@detail)", con.cn);
                    command.Parameters.AddWithValue("defectid", newdefectid);
                    command.Parameters.AddWithValue("orderid", cbOrderID.SelectedValue);
                    command.Parameters.AddWithValue("itemid", cbItemID.SelectedValue);
                    command.Parameters.AddWithValue("customeremail", txtEmail.Text);
                    command.Parameters.AddWithValue("quantity", numQty.Text);
                    command.Parameters.AddWithValue("defectdate", current);
                    if (rbDead.Checked == true)
                    {
                        reason = "Dead On Arrival";
                    }
                    else if (rbFaulty.Checked == true)
                    {
                        reason = "Faulty";
                    }
                    else if (rbReceivedWrongItem.Checked == true)
                    {
                        reason = "Received Wrong Item";
                    }
                    else if (rbOther.Checked == true)
                    {
                        reason = "Other";
                    }
                    else
                    {
                        reason = "";
                    }
                    command.Parameters.AddWithValue("reason", reason);
                    if (rbOpenYes.Checked == true)
                    {
                        open = 'Y';
                    }
                    else
                    {
                        open = 'N';
                    }
                    command.Parameters.AddWithValue("opened", open);
                    command.Parameters.AddWithValue("detail", txtDetails.Text);
                    command.ExecuteNonQuery();
                    con.cn.Close();

                    con.cn.Open();
                    command = new MySqlCommand("update product set Avalibility = 0 where Item_ID = '" + cbItemID.SelectedValue + "'",con.cn);
                    command.ExecuteNonQuery();
                    con.cn.Close();



                    DialogResult print = MessageBox.Show("Do you want to generate a defect item pdf?", "Defect Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (print == DialogResult.Yes)
                    {
                        String defectID = newdefectid;


                        string fileName = $"{Directory.GetCurrentDirectory()}\\..\\..\\..\\Defec Item Notes\\{defectID}.pdf";

                        Document pdod = new Document(PageSize.A4, 50f, 50f, 40f, 40f);

                        PdfWriter.GetInstance(pdod, new FileStream(fileName, FileMode.Create));
                        pdod.Open();

                        Paragraph pd3 = new Paragraph("Defect Item Notes");
                        pd3.Alignment = 1;
                        pdod.Add(pd3);

                        command = new MySqlCommand("select * from defectitem where DefectID = '" + defectID + "'", con.cn);
                        con.cn.Open();
                        dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            DateTime defectDate = DateTime.Parse(dr["DefectDate"].ToString());
                            string[] DefectID = { "Defect ID:", defectID };
                            string[] itemid = { "Product ID:", dr["Item_ID"].ToString() };
                            string[] itemname = { "Product Name :", txtItemName.Text };
                            string[] customeremail = { "Customer Email:", dr["Customer_Email"].ToString() };
                            string[] quantity = { "Quantity: ", numQty.Text };
                            string[] username = { "Customer Name:", txtCustomerName.Text };
                            string[] defectdate = { " Defect Date : ", defectDate.ToString("yyyy-MM-dd") };
                            string[] Reason = { "Reason :", dr["Reason"].ToString() };
                            string[] Opened = { "Product Open?", dr["Opened"].ToString() };
                            string[] Details = { "Detail: ", dr["Detail"].ToString() };
                            string[] phone = { "Phone : ", txtPhone.Text };

                            Chunk glue1 = new Chunk(new VerticalPositionMark());
                            Paragraph pd = new Paragraph(DefectID[0] + " " + DefectID[1]);
                            pd.Add(new Chunk(glue1));
                            pd.Add(defectdate[0] + " " + defectdate[1]);
                            pd.SpacingAfter = 20;
                            pdod.Add(pd);

                            pdod.Add(new Paragraph(""));
                            pd = new Paragraph(username[0] + " " + username[1]);
                            pd.Alignment = 1;
                            pd.SpacingAfter = 20;
                            pdod.Add(pd);
                            pd = new Paragraph(customeremail[0] + " " + customeremail[1]);
                            pd.Alignment = 1;
                            pd.SpacingAfter = 20;
                            pdod.Add(pd);
                            pd = new Paragraph(phone[0] + " " + phone[1]);
                            pd.Alignment = 1;
                            pd.SpacingAfter = 20;
                            pdod.Add(pd);
                            pd = new Paragraph(itemid[0] + " " + itemid[1]);
                            pd.Alignment = 1;
                            pd.SpacingAfter = 20;
                            pdod.Add(pd);
                            pd = new Paragraph(itemname[0] + " " + itemname[1]);
                            pd.Alignment = 1;
                            pd.SpacingAfter = 20;
                            pdod.Add(pd);
                            pd = new Paragraph(quantity[0] + " " + quantity[1]);
                            pd.Alignment = 1;
                            pd.SpacingAfter = 20;
                            pdod.Add(pd);
                            pd = new Paragraph(Reason[0] + " " + Reason[1]);
                            pd.Alignment = 1;
                            pd.SpacingAfter = 20;
                            pdod.Add(pd);
                            pd = new Paragraph(Opened[0] + " " + Opened[1]);
                            pd.Alignment = 1;
                            pd.SpacingAfter = 20;
                            pdod.Add(pd);
                            pd = new Paragraph(Details[0] + " " + Details[1]);
                            pd.Alignment = 1;
                            pd.SpacingAfter = 20;
                            pdod.Add(pd);
                            dr.Close();
                        }
                        DateTime date = new DateTime();
                        date = System.DateTime.Now;

                        Chunk glue = new Chunk(new VerticalPositionMark());
                        Paragraph p = new Paragraph("Defect Notes Print Date: "); ;
                        p.Add(new Chunk(glue));
                        p.Add("Sign: __________");
                        p.SpacingBefore = 30;
                        p.SpacingAfter = 30;
                        pdod.Add(p);

                        Chunk glue2 = new Chunk(new VerticalPositionMark());
                        Paragraph p2 = new Paragraph(date.ToString());
                        p2.Add(new Chunk(glue2));
                        p2.Add("Customer Sign: __________");

                        pdod.Add(p2);
                        con.cn.Close();
                        pdod.Close();
                        MessageBox.Show("PDF Create success", "", MessageBoxButtons.OK);
                        Inventory i = new Inventory();
                        this.Hide();
                        i.Show();
                    }
                    else 
                    {
                        Inventory i = new Inventory();
                        this.Hide();
                        i.Show();
                    }
                }
                else 
                {
                    MessageBox.Show("Please confirm your information");
                }
            }
            else 
            {
                MessageBox.Show("Please fill in all field with * to finish the goods return notes");
            }
        }

        private void gpProduct_Enter(object sender, EventArgs e)
        {

        }
    }
}
