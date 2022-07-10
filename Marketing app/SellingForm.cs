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

namespace Marketing_app
{
    public partial class SellingForm : Form
    {
        public SellingForm(string id)
        {
            InitializeComponent();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from categorytable";
            cmd.Connection = connection.connect2server();
            MySqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                categorybox.Items.Add(dr.GetString("CategoryName"));
            }
            refresh();
            calculatebillID();
            getsellername(id);
        }

        void getsellername(string id)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select SellerName from sellerstable where SellerID='" + id + "'";
            cmd.Connection = connection.connect2server();
            MySqlDataReader reader= cmd.ExecuteReader();
            reader.Read();
            sellername_label.Text = reader.GetString(0);
        }
        void calculatebillID()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM sellslist ORDER BY BillID DESC LIMIT 1";
                cmd.Connection = connection.connect2server();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int billnum = Convert.ToInt32(reader.GetString("BillID"))+1;
                billid_txtbox.Text = Convert.ToString(billnum);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void refresh()
        {
            try
            {
                if (categorybox.SelectedIndex < 0)
                {
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = "select ProductName, ProductPrice from producttable where ProductQuantity!=0";
                    command.Connection = connection.connect2server();
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    seller_display.DataSource = dt;
                }
                else if(categorybox.SelectedIndex >= 0)
                {
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = "select ProductName, ProductPrice from producttable where ProductCategory='"+categorybox.SelectedItem.ToString()+"' and ProductQuantity!=0";
                    command.Connection = connection.connect2server();
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    seller_display.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void seller_display_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            prodname_txtbox.Text = seller_display.SelectedRows[0].Cells[0].Value.ToString();
            prodprice_txtbox.Text = seller_display.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void close_bttn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categorybox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh_bttn_Click(object sender, EventArgs e)
        {
            categorybox.SelectedIndex = -1;
            categorybox.Text = "Select Category";
            refresh();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            date.Text=DateTime.Today.Day.ToString()+"/"+DateTime.Today.Month.ToString()+"/"+DateTime.Today.Year.ToString();
        }

        int grandTotal = 0, n = 0;

        private void add2_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (billid_txtbox.Text != "" && total_amount_label.Text != "")
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "insert into sellslist values('" + billid_txtbox.Text + "','" + sellername_label.Text + "','" + date.Text + "','" +Convert.ToInt32( total_amount_label.Text) + "')";
                    cmd.Connection = connection.connect2server();
                    cmd.ExecuteNonQuery();
                    try
                    {
                        MySqlCommand cmdd = new MySqlCommand();
                        cmdd.CommandText = "select * from sellslist where BillID='" + billid_txtbox.Text + "'";
                        cmdd.Connection = connection.connect2server();
                        DataTable dt1 = new DataTable();
                        dt1.Load(cmdd.ExecuteReader());
                        sellsListdisplay.DataSource = dt1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    calculatebillID();
                    for (int i = 0; i < orderdisplay.RowCount; i++)
                    {
                        cmd.CommandText = "select ProductQuantity from producttable where ProductName='" + orderdisplay.Rows[i].Cells[1].Value.ToString() + "'";
                        cmd.Connection = connection.connect2server();
                        MySqlDataReader readr = cmd.ExecuteReader();
                        readr.Read();
                        int qntity = Convert.ToInt32(readr.GetString(0));
                        qntity = qntity - Convert.ToInt32(orderdisplay.Rows[i].Cells[3].Value.ToString());
                        cmd.CommandText = "update producttable set ProductQuantity='" + qntity + "' where ProductName='" + orderdisplay.Rows[i].Cells[1].Value.ToString() + "'";
                        cmd.Connection = connection.connect2server();
                        cmd.ExecuteNonQuery();
                     }
                    prodprice_txtbox.Clear();
                    prodquantity_txtbox.Clear();
                    prodname_txtbox.Clear();
                    refresh();
                }
                else
                {
                    MessageBox.Show("Enter the valid data", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int flag = 0;
        private void print_bttn_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }



        }

        private void sellsListdisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int j = 380;
            e.Graphics.DrawString("YOUR SUPERMARKET", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red,new Point(230));
            e.Graphics.DrawString("Bill ID:", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(50, 100));
            e.Graphics.DrawString(sellsListdisplay.Rows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(300, 100));
            e.Graphics.DrawString("Seller Name:", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(50, 150));
            e.Graphics.DrawString(sellsListdisplay.Rows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(300, 150));
            e.Graphics.DrawString("Bill Date:", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(50, 200));
            e.Graphics.DrawString(sellsListdisplay.Rows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(300, 200));
            e.Graphics.DrawString("S.N.", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(50,330));
            e.Graphics.DrawString("Product Name", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(150, 330));
            e.Graphics.DrawString("Rate", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(500, 330));
            e.Graphics.DrawString("Qnty", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(600, 330));
            e.Graphics.DrawString("Price", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(700, 330));
            for (int i=0;i<orderdisplay.RowCount;i++)
            {
                e.Graphics.DrawString(orderdisplay.Rows[i].Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(50, j));
                e.Graphics.DrawString(orderdisplay.Rows[i].Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(150, j));
                e.Graphics.DrawString(orderdisplay.Rows[i].Cells[2].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(500, j));
                e.Graphics.DrawString(orderdisplay.Rows[i].Cells[3].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(600, j));
                e.Graphics.DrawString(orderdisplay.Rows[i].Cells[4].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, new Point(700, j));
                j += 50;
            }
            e.Graphics.DrawString("Total Amount", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(400, j));
            e.Graphics.DrawString("Rs"+sellsListdisplay.Rows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(650, j));
        }

        private void logout_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void add_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodname_txtbox.Text != "" && prodprice_txtbox.Text != "" && prodquantity_txtbox.Text != "")
                {
                    int total = Convert.ToInt32(prodprice_txtbox.Text) * Convert.ToInt32(prodquantity_txtbox.Text);
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(orderdisplay);
                    row.Cells[0].Value = n+1;
                    n = n + 1;
                    row.Cells[1].Value = prodname_txtbox.Text;
                    row.Cells[2].Value = prodprice_txtbox.Text;
                    row.Cells[3].Value = prodquantity_txtbox.Text;
                    row.Cells[4].Value = Convert.ToInt32(prodprice_txtbox.Text) * Convert.ToInt32(prodquantity_txtbox.Text);
                    orderdisplay.Rows.Add(row);
                    grandTotal = grandTotal + total;
                    total_amount_label.Text = grandTotal.ToString();
                    prodname_txtbox.Clear();
                    prodquantity_txtbox.Clear();
                    prodprice_txtbox.Clear();
                }
                else
                {
                    MessageBox.Show("Enter the valid data", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
