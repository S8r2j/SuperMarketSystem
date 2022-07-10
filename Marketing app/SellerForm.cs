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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
            refresh();
        }

        void refresh()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from sellerstable";
            command.Connection = connection.connect2server();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            seller_display.DataSource = dt;
        }

        private void categoryadd_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "insert into sellerstable values('" +id_txtbox.Text + "','" + name_txtbox.Text + "','" +Convert.ToInt32( age_txtbox.Text) + "','" +phone_txtbox.Text + "','" + password_txtbox.Text + "')";
                cmd.Connection = connection.connect2server();
                cmd.ExecuteNonQuery();
                id_txtbox.Clear();
                name_txtbox.Clear();
                age_txtbox.Clear();
                phone_txtbox.Clear();
                password_txtbox.Clear();
                refresh();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.Show();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ProductForm form= new ProductForm();
            form.Show();
            this.Close();
        }

        private void close_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seller_display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_txtbox.Text = seller_display.SelectedRows[0].Cells[0].Value.ToString();
            name_txtbox.Text = seller_display.SelectedRows[0].Cells[1].Value.ToString();
            age_txtbox.Text = seller_display.SelectedRows[0].Cells[2].Value.ToString();
            phone_txtbox.Text = seller_display.SelectedRows[0].Cells[3].Value.ToString();
            password_txtbox.Text = seller_display.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void categorydelete_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_txtbox.Text != "" && name_txtbox.Text != "" && age_txtbox.Text != "" && phone_txtbox.Text != "" && password_txtbox.Text != "")
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "Delete from sellerstable where SellerID='" + id_txtbox.Text + "'";
                    cmd.Connection = connection.connect2server();
                    cmd.ExecuteNonQuery();
                    id_txtbox.Clear();
                    name_txtbox.Clear();
                    age_txtbox.Clear();
                    phone_txtbox.Clear();
                    password_txtbox.Clear();
                    refresh();
                }
                else
                {
                    MessageBox.Show("Select from the list to delete","Delete Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void categoryedit_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_txtbox.Text != "" && name_txtbox.Text != "" && age_txtbox.Text != "" && phone_txtbox.Text != "" && password_txtbox.Text != "")
                {
                    MySqlCommand cmd= new MySqlCommand();
                    cmd.CommandText = "update sellerstable set SellerName='" + name_txtbox.Text + "',SellerAge='" +Convert.ToInt32( age_txtbox.Text) + "',SellerPhone='" + phone_txtbox.Text + "',SellerPassword='" + password_txtbox.Text + "' where SellerID='" + id_txtbox.Text + "'";
                    cmd.Connection = connection.connect2server();
                    cmd.ExecuteNonQuery();
                    id_txtbox.Clear();
                    name_txtbox.Clear();
                    age_txtbox.Clear();
                    phone_txtbox.Clear();
                    password_txtbox.Clear();
                    refresh();
                }
                else
                {
                    MessageBox.Show("Select from the list to edit", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logout_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
