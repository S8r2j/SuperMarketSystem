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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            refresh();
        }
        public void refresh()
        {
            connection.connect2server();
            MySqlCommand cmd1 = new MySqlCommand();
            cmd1.CommandText = "select * from categorytable";
            cmd1.Connection = connection.connect2server();
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd1.ExecuteReader());
            category_display.DataSource = dt;
        }

        private void categoryadd_bttn_Click(object sender, EventArgs e)
        {
            if (categorydescription_txtbox.Text != "" || categoryid_txtbox.Text != "" || categoryname_txtbox.Text != "")
            {
                connection.connect2server();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "insert into categorytable values('" + categoryid_txtbox.Text + "','" + categoryname_txtbox.Text + "','" + categorydescription_txtbox.Text + "')";
                cmd.Connection = connection.connect2server();
                cmd.ExecuteNonQuery();
                categoryname_txtbox.Clear();
                categoryid_txtbox.Clear();
                categorydescription_txtbox.Clear();
                refresh();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Text");
            }
        }

        private void close_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void category_display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryid_txtbox.Text = category_display.SelectedRows[0].Cells[0].Value.ToString();
            categoryname_txtbox.Text = category_display.SelectedRows[0].Cells[1].Value.ToString();
            categorydescription_txtbox.Text = category_display.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void categorydelete_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (categorydescription_txtbox.Text != "" || categoryid_txtbox.Text != "" || categoryname_txtbox.Text != "")
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "Delete from categorytable where CategoryID='" + categoryid_txtbox.Text + "'";
                    cmd.Connection = connection.connect2server();
                    cmd.ExecuteNonQuery();
                    categoryname_txtbox.Clear();
                    categoryid_txtbox.Clear();
                    categorydescription_txtbox.Clear();
                    refresh();
                }
                else
                {
                    MessageBox.Show("Select from the list to delete");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void categoryedit_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "update categorytable set CategoryName='" + categoryname_txtbox.Text + "', CategoryDescription='" + categorydescription_txtbox.Text + "' where CategoryID='" + categoryid_txtbox.Text + "'";
                cmd.Connection = connection.connect2server();
                cmd.ExecuteNonQuery();
                categoryname_txtbox.Clear();
                categoryid_txtbox.Clear();
                categorydescription_txtbox.Clear();
                refresh();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.Show();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SellerForm form = new SellerForm();
            form.Show();
            this.Close();
        }

        private void logout_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
