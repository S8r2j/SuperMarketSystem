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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            refresh();
        }
        void refresh()
        {
            try
            {
                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.CommandText = "select * from categorytable";
                cmd1.Connection = connection.connect2server();
                MySqlDataReader reader = cmd1.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    for (int i = 0; i < productcategory.Items.Count; i++)
                    {
                        if (productcategory.GetItemText(productcategory.Items[i]) == reader.GetString("CategoryName"))
                        {
                            count += 1;
                        }
                    }
                    if (count == 0)
                    {
                        productcategory.Items.Add(reader.GetString("CategoryName"));
                        comboBox1.Items.Add(reader.GetString("CategoryName"));

                    }
                }

                if (comboBox1.SelectedIndex == -1)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from producttable";
                    cmd.Connection = connection.connect2server();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    Product_display.DataSource = dt;
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from producttable where ProductCategory='"+comboBox1.GetItemText(comboBox1.SelectedItem)+"'";
                    cmd.Connection = connection.connect2server();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    Product_display.DataSource = dt;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void close_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productrefresh_bttn_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            if(comboBox1.SelectedIndex==-1)
            {
                comboBox1.Text = "Select Category";
            }
            refresh();
        }

        private void productadd_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productid_txtbox.Text != "" && productname_txtbox.Text != "" && productprice_txtbox.Text != "" && productquantity_txtbox.Text != "" && productcategory.SelectedIndex >= 0)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "insert into producttable values('" + productid_txtbox.Text + "','" + productname_txtbox.Text + "','" + productprice_txtbox.Text + "','" + productquantity_txtbox.Text + "','" + productcategory.GetItemText(productcategory.SelectedItem) + "')";
                    cmd.Connection = connection.connect2server();
                    cmd.ExecuteNonQuery();
                    productid_txtbox.Text = "";
                    productname_txtbox.Text = "";
                    productprice_txtbox.Text = "";
                    productquantity_txtbox.Text = "";
                    productcategory.SelectedIndex = 0;
                    refresh();
                }
                else
                {
                    MessageBox.Show("Enter a valid data");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productdelete_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productid_txtbox.Text != "" && productname_txtbox.Text != "" && productprice_txtbox.Text != "" && productquantity_txtbox.Text != "" && productcategory.SelectedIndex >= 0)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "delete from producttable where ProductID='" + productid_txtbox.Text + "'";
                    cmd.Connection = connection.connect2server();
                    cmd.ExecuteNonQuery();
                    productid_txtbox.Text = ""; 
                    productname_txtbox.Text = "";
                    productprice_txtbox.Text = "";
                    productquantity_txtbox.Text = "";
                    productcategory.SelectedIndex = 0;
                    refresh();
                }
                else
                {
                    MessageBox.Show("Select from the list to delete", "Delete Record", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Product_display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productid_txtbox.Text = Product_display.SelectedRows[0].Cells[0].Value.ToString();
            productname_txtbox.Text = Product_display.SelectedRows[0].Cells[1].Value.ToString();
            productprice_txtbox.Text = Product_display.SelectedRows[0].Cells[2].Value.ToString();
            productquantity_txtbox.Text = Product_display.SelectedRows[0].Cells[3].Value.ToString();
            productcategory.SelectedItem = Product_display.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void productedit_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productid_txtbox.Text != "" && productname_txtbox.Text != "" && productprice_txtbox.Text != "" && productquantity_txtbox.Text != "" && productcategory.SelectedIndex >= 0)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "update producttable set ProductName='" + productname_txtbox.Text + "',ProductPrice='" + productprice_txtbox.Text + "',ProductCategory='" + productcategory.GetItemText(productcategory.SelectedItem) + "',ProductQuantity='" + productquantity_txtbox.Text + "' where ProductID='" + productid_txtbox.Text + "'";
                    cmd.Connection = connection.connect2server();
                    cmd.ExecuteNonQuery();
                    productid_txtbox.Text = "";
                    productname_txtbox.Text = "";
                    productprice_txtbox.Text = "";
                    productquantity_txtbox.Text = "";
                    productcategory.SelectedIndex = 0;
                    refresh();
                }
                else
                {
                    MessageBox.Show("Select the data from the list to update","Edit Data",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from producttable";
                    cmd.Connection = connection.connect2server();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    Product_display.DataSource = dt;
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from producttable where ProductCategory='" + comboBox1.GetItemText(comboBox1.SelectedItem) + "'";
                    cmd.Connection = connection.connect2server();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    Product_display.DataSource = dt;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            CategoryForm form = new CategoryForm();
            form.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SellerForm form = new SellerForm();
            form.Show();
            this.Hide();
        }

        private void logout_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
