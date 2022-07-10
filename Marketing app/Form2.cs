using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marketing_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            app_progress.Value = startpoint;
            if(app_progress.Value==100)
            {
                app_progress.Value = 0;
                timer1.Stop();
                Form1 form = new Form1();
                this.Hide();
                form.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
