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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string role;

        private void login_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (role == "ADMIN" && username_txtbox.Text!="" && password_txtbox.Text!="")
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select AdminID from martadmin where AdminID='" + username_txtbox.Text + "' and AdminPassword= '" + password_txtbox.Text + "'";
                    cmd.Connection = connection.connect2server();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        ProductForm form = new ProductForm();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Enter a correct id and password", "Info Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(role == "SELLER" && username_txtbox.Text != "" && password_txtbox.Text != "")
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = "select SellerID from sellerstable where SellerID='" + username_txtbox.Text + "' and SellerPassword='" + password_txtbox.Text + "'";
                        cmd.Connection = connection.connect2server();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            string id = reader.GetString(0);
                            this.Hide();
                            SellingForm form = new SellingForm(id);
                            form.Show();
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Select a role with Username and Password not being empty ", "Info Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void role_selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            role=role_selection.SelectedItem.ToString();
        }
    }
}
