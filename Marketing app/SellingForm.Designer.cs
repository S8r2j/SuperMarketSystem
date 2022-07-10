namespace Marketing_app
{
    partial class SellingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.close_bttn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.sellername_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.print_bttn = new Guna.UI2.WinForms.Guna2Button();
            this.total_amount_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderdisplay = new Guna.UI2.WinForms.Guna2DataGridView();
            this.serialnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.Label();
            this.sellsListdisplay = new Guna.UI2.WinForms.Guna2DataGridView();
            this.refresh_bttn = new Guna.UI2.WinForms.Guna2Button();
            this.categorybox = new System.Windows.Forms.ComboBox();
            this.prodquantity_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.seller_display = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.add2_bttn = new Guna.UI2.WinForms.Guna2Button();
            this.delete_bttn = new Guna.UI2.WinForms.Guna2Button();
            this.add_bttn = new Guna.UI2.WinForms.Guna2Button();
            this.prodprice_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.prodname_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.billid_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.logout_bttn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsListdisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seller_display)).BeginInit();
            this.SuspendLayout();
            // 
            // close_bttn
            // 
            this.close_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.close_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.close_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.close_bttn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.close_bttn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_bttn.ForeColor = System.Drawing.Color.Coral;
            this.close_bttn.Location = new System.Drawing.Point(1097, 1);
            this.close_bttn.Name = "close_bttn";
            this.close_bttn.Size = new System.Drawing.Size(32, 27);
            this.close_bttn.TabIndex = 24;
            this.close_bttn.Text = "X";
            this.close_bttn.Click += new System.EventHandler(this.close_bttn_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.guna2Panel1.Controls.Add(this.sellername_label);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.print_bttn);
            this.guna2Panel1.Controls.Add(this.total_amount_label);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.orderdisplay);
            this.guna2Panel1.Controls.Add(this.date);
            this.guna2Panel1.Controls.Add(this.sellsListdisplay);
            this.guna2Panel1.Controls.Add(this.refresh_bttn);
            this.guna2Panel1.Controls.Add(this.categorybox);
            this.guna2Panel1.Controls.Add(this.prodquantity_txtbox);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.seller_display);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.add2_bttn);
            this.guna2Panel1.Controls.Add(this.delete_bttn);
            this.guna2Panel1.Controls.Add(this.add_bttn);
            this.guna2Panel1.Controls.Add(this.prodprice_txtbox);
            this.guna2Panel1.Controls.Add(this.quantity_label);
            this.guna2Panel1.Controls.Add(this.prodname_txtbox);
            this.guna2Panel1.Controls.Add(this.name_label);
            this.guna2Panel1.Controls.Add(this.billid_txtbox);
            this.guna2Panel1.Controls.Add(this.id_label);
            this.guna2Panel1.Location = new System.Drawing.Point(159, 34);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(970, 649);
            this.guna2Panel1.TabIndex = 23;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // sellername_label
            // 
            this.sellername_label.AutoSize = true;
            this.sellername_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.sellername_label.ForeColor = System.Drawing.Color.White;
            this.sellername_label.Location = new System.Drawing.Point(3, 8);
            this.sellername_label.Name = "sellername_label";
            this.sellername_label.Size = new System.Drawing.Size(214, 31);
            this.sellername_label.TabIndex = 27;
            this.sellername_label.Text = "SELLER NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(618, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "SELLS LIST";
            // 
            // print_bttn
            // 
            this.print_bttn.AutoRoundedCorners = true;
            this.print_bttn.BackColor = System.Drawing.Color.Transparent;
            this.print_bttn.BorderColor = System.Drawing.Color.DarkOrange;
            this.print_bttn.BorderRadius = 17;
            this.print_bttn.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.print_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.print_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.print_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.print_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.print_bttn.FillColor = System.Drawing.Color.White;
            this.print_bttn.FocusedColor = System.Drawing.Color.White;
            this.print_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_bttn.ForeColor = System.Drawing.Color.Coral;
            this.print_bttn.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.print_bttn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.print_bttn.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.print_bttn.Location = new System.Drawing.Point(681, 599);
            this.print_bttn.Name = "print_bttn";
            this.print_bttn.Size = new System.Drawing.Size(91, 36);
            this.print_bttn.TabIndex = 25;
            this.print_bttn.Text = "PRINT";
            this.print_bttn.UseTransparentBackground = true;
            this.print_bttn.Click += new System.EventHandler(this.print_bttn_Click);
            // 
            // total_amount_label
            // 
            this.total_amount_label.AutoSize = true;
            this.total_amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.total_amount_label.ForeColor = System.Drawing.Color.White;
            this.total_amount_label.Location = new System.Drawing.Point(858, 262);
            this.total_amount_label.Name = "total_amount_label";
            this.total_amount_label.Size = new System.Drawing.Size(50, 31);
            this.total_amount_label.TabIndex = 24;
            this.total_amount_label.Text = "Rs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(695, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Amount Rs";
            // 
            // orderdisplay
            // 
            this.orderdisplay.AllowUserToAddRows = false;
            this.orderdisplay.AllowUserToDeleteRows = false;
            this.orderdisplay.AllowUserToResizeColumns = false;
            this.orderdisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.orderdisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderdisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderdisplay.BackgroundColor = System.Drawing.Color.White;
            this.orderdisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderdisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderdisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderdisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderdisplay.ColumnHeadersHeight = 40;
            this.orderdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.orderdisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialnum,
            this.prodname,
            this.prodprice,
            this.prodquantity,
            this.prodtotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderdisplay.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderdisplay.EnableHeadersVisualStyles = false;
            this.orderdisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderdisplay.Location = new System.Drawing.Point(451, 45);
            this.orderdisplay.Name = "orderdisplay";
            this.orderdisplay.ReadOnly = true;
            this.orderdisplay.RowHeadersVisible = false;
            this.orderdisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderdisplay.ShowEditingIcon = false;
            this.orderdisplay.Size = new System.Drawing.Size(507, 214);
            this.orderdisplay.TabIndex = 22;
            this.orderdisplay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.orderdisplay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderdisplay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderdisplay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderdisplay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderdisplay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.orderdisplay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderdisplay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderdisplay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderdisplay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdisplay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderdisplay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.orderdisplay.ThemeStyle.HeaderStyle.Height = 40;
            this.orderdisplay.ThemeStyle.ReadOnly = true;
            this.orderdisplay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.orderdisplay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderdisplay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.orderdisplay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderdisplay.ThemeStyle.RowsStyle.Height = 22;
            this.orderdisplay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderdisplay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // serialnum
            // 
            this.serialnum.HeaderText = "S.N.";
            this.serialnum.Name = "serialnum";
            this.serialnum.ReadOnly = true;
            // 
            // prodname
            // 
            this.prodname.HeaderText = "Product Name";
            this.prodname.Name = "prodname";
            this.prodname.ReadOnly = true;
            // 
            // prodprice
            // 
            this.prodprice.HeaderText = "Price";
            this.prodprice.Name = "prodprice";
            this.prodprice.ReadOnly = true;
            // 
            // prodquantity
            // 
            this.prodquantity.HeaderText = "Quantity";
            this.prodquantity.Name = "prodquantity";
            this.prodquantity.ReadOnly = true;
            // 
            // prodtotal
            // 
            this.prodtotal.HeaderText = "Total";
            this.prodtotal.Name = "prodtotal";
            this.prodtotal.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(817, 8);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(91, 31);
            this.date.TabIndex = 21;
            this.date.Text = "DATE";
            // 
            // sellsListdisplay
            // 
            this.sellsListdisplay.AllowUserToAddRows = false;
            this.sellsListdisplay.AllowUserToDeleteRows = false;
            this.sellsListdisplay.AllowUserToResizeColumns = false;
            this.sellsListdisplay.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.sellsListdisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sellsListdisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellsListdisplay.BackgroundColor = System.Drawing.Color.White;
            this.sellsListdisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellsListdisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellsListdisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellsListdisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.sellsListdisplay.ColumnHeadersHeight = 40;
            this.sellsListdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sellsListdisplay.DefaultCellStyle = dataGridViewCellStyle6;
            this.sellsListdisplay.EnableHeadersVisualStyles = false;
            this.sellsListdisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellsListdisplay.Location = new System.Drawing.Point(451, 342);
            this.sellsListdisplay.Name = "sellsListdisplay";
            this.sellsListdisplay.ReadOnly = true;
            this.sellsListdisplay.RowHeadersVisible = false;
            this.sellsListdisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellsListdisplay.ShowEditingIcon = false;
            this.sellsListdisplay.Size = new System.Drawing.Size(507, 250);
            this.sellsListdisplay.TabIndex = 20;
            this.sellsListdisplay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.sellsListdisplay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.sellsListdisplay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.sellsListdisplay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.sellsListdisplay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.sellsListdisplay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.sellsListdisplay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellsListdisplay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sellsListdisplay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sellsListdisplay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellsListdisplay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.sellsListdisplay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sellsListdisplay.ThemeStyle.HeaderStyle.Height = 40;
            this.sellsListdisplay.ThemeStyle.ReadOnly = true;
            this.sellsListdisplay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.sellsListdisplay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellsListdisplay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sellsListdisplay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sellsListdisplay.ThemeStyle.RowsStyle.Height = 22;
            this.sellsListdisplay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellsListdisplay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sellsListdisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellsListdisplay_CellContentClick);
            // 
            // refresh_bttn
            // 
            this.refresh_bttn.BackColor = System.Drawing.Color.Transparent;
            this.refresh_bttn.BorderColor = System.Drawing.Color.DarkOrange;
            this.refresh_bttn.BorderRadius = 10;
            this.refresh_bttn.BorderThickness = 1;
            this.refresh_bttn.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.refresh_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refresh_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refresh_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refresh_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refresh_bttn.FillColor = System.Drawing.Color.White;
            this.refresh_bttn.FocusedColor = System.Drawing.Color.White;
            this.refresh_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_bttn.ForeColor = System.Drawing.Color.Coral;
            this.refresh_bttn.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.refresh_bttn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.refresh_bttn.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.refresh_bttn.Location = new System.Drawing.Point(337, 299);
            this.refresh_bttn.Name = "refresh_bttn";
            this.refresh_bttn.Size = new System.Drawing.Size(92, 37);
            this.refresh_bttn.TabIndex = 19;
            this.refresh_bttn.Text = "REFRESH";
            this.refresh_bttn.UseTransparentBackground = true;
            this.refresh_bttn.Click += new System.EventHandler(this.refresh_bttn_Click);
            // 
            // categorybox
            // 
            this.categorybox.BackColor = System.Drawing.Color.White;
            this.categorybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorybox.ForeColor = System.Drawing.Color.Coral;
            this.categorybox.FormattingEnabled = true;
            this.categorybox.Location = new System.Drawing.Point(8, 299);
            this.categorybox.Name = "categorybox";
            this.categorybox.Size = new System.Drawing.Size(323, 33);
            this.categorybox.TabIndex = 18;
            this.categorybox.Text = "Select Catagory";
            this.categorybox.SelectedIndexChanged += new System.EventHandler(this.categorybox_SelectedIndexChanged);
            // 
            // prodquantity_txtbox
            // 
            this.prodquantity_txtbox.AutoRoundedCorners = true;
            this.prodquantity_txtbox.BackColor = System.Drawing.Color.DarkOrange;
            this.prodquantity_txtbox.BorderColor = System.Drawing.Color.DarkOrange;
            this.prodquantity_txtbox.BorderRadius = 16;
            this.prodquantity_txtbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.prodquantity_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodquantity_txtbox.DefaultText = "";
            this.prodquantity_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodquantity_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodquantity_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodquantity_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodquantity_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodquantity_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.prodquantity_txtbox.ForeColor = System.Drawing.Color.Coral;
            this.prodquantity_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodquantity_txtbox.Location = new System.Drawing.Point(196, 186);
            this.prodquantity_txtbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prodquantity_txtbox.Name = "prodquantity_txtbox";
            this.prodquantity_txtbox.PasswordChar = '\0';
            this.prodquantity_txtbox.PlaceholderText = "";
            this.prodquantity_txtbox.SelectedText = "";
            this.prodquantity_txtbox.Size = new System.Drawing.Size(221, 34);
            this.prodquantity_txtbox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "QUANTITY";
            // 
            // seller_display
            // 
            this.seller_display.AllowUserToAddRows = false;
            this.seller_display.AllowUserToDeleteRows = false;
            this.seller_display.AllowUserToResizeColumns = false;
            this.seller_display.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.seller_display.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.seller_display.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seller_display.BackgroundColor = System.Drawing.Color.White;
            this.seller_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seller_display.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.seller_display.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.seller_display.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.seller_display.ColumnHeadersHeight = 40;
            this.seller_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.seller_display.DefaultCellStyle = dataGridViewCellStyle9;
            this.seller_display.EnableHeadersVisualStyles = false;
            this.seller_display.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.seller_display.Location = new System.Drawing.Point(3, 342);
            this.seller_display.Name = "seller_display";
            this.seller_display.ReadOnly = true;
            this.seller_display.RowHeadersVisible = false;
            this.seller_display.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seller_display.ShowEditingIcon = false;
            this.seller_display.Size = new System.Drawing.Size(437, 304);
            this.seller_display.TabIndex = 15;
            this.seller_display.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.seller_display.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.seller_display.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.seller_display.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.seller_display.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.seller_display.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.seller_display.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.seller_display.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.seller_display.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.seller_display.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seller_display.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.seller_display.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.seller_display.ThemeStyle.HeaderStyle.Height = 40;
            this.seller_display.ThemeStyle.ReadOnly = true;
            this.seller_display.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.seller_display.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.seller_display.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.seller_display.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.seller_display.ThemeStyle.RowsStyle.Height = 22;
            this.seller_display.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.seller_display.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.seller_display.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seller_display_CellContentClick_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Enabled = false;
            this.guna2Button1.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2Button1.FocusedColor = System.Drawing.Color.DarkOrange;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2Button1.Location = new System.Drawing.Point(337, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(331, 36);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "SELLING";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // add2_bttn
            // 
            this.add2_bttn.AutoRoundedCorners = true;
            this.add2_bttn.BackColor = System.Drawing.Color.Transparent;
            this.add2_bttn.BorderColor = System.Drawing.Color.DarkOrange;
            this.add2_bttn.BorderRadius = 17;
            this.add2_bttn.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.add2_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add2_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add2_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add2_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add2_bttn.FillColor = System.Drawing.Color.White;
            this.add2_bttn.FocusedColor = System.Drawing.Color.White;
            this.add2_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add2_bttn.ForeColor = System.Drawing.Color.Coral;
            this.add2_bttn.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.add2_bttn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.add2_bttn.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.add2_bttn.Location = new System.Drawing.Point(599, 599);
            this.add2_bttn.Name = "add2_bttn";
            this.add2_bttn.Size = new System.Drawing.Size(76, 36);
            this.add2_bttn.TabIndex = 12;
            this.add2_bttn.Text = "ORDER";
            this.add2_bttn.UseTransparentBackground = true;
            this.add2_bttn.Click += new System.EventHandler(this.add2_bttn_Click);
            // 
            // delete_bttn
            // 
            this.delete_bttn.AutoRoundedCorners = true;
            this.delete_bttn.BackColor = System.Drawing.Color.Transparent;
            this.delete_bttn.BorderColor = System.Drawing.Color.DarkOrange;
            this.delete_bttn.BorderRadius = 17;
            this.delete_bttn.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.delete_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_bttn.FillColor = System.Drawing.Color.White;
            this.delete_bttn.FocusedColor = System.Drawing.Color.White;
            this.delete_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_bttn.ForeColor = System.Drawing.Color.Coral;
            this.delete_bttn.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.delete_bttn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.delete_bttn.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.delete_bttn.Location = new System.Drawing.Point(778, 599);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(89, 36);
            this.delete_bttn.TabIndex = 11;
            this.delete_bttn.Text = "DELETE";
            this.delete_bttn.UseTransparentBackground = true;
            // 
            // add_bttn
            // 
            this.add_bttn.AutoRoundedCorners = true;
            this.add_bttn.BackColor = System.Drawing.Color.Transparent;
            this.add_bttn.BorderColor = System.Drawing.Color.DarkOrange;
            this.add_bttn.BorderRadius = 17;
            this.add_bttn.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.add_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_bttn.FillColor = System.Drawing.Color.White;
            this.add_bttn.FocusedColor = System.Drawing.Color.White;
            this.add_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_bttn.ForeColor = System.Drawing.Color.Coral;
            this.add_bttn.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.add_bttn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.add_bttn.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.add_bttn.Location = new System.Drawing.Point(226, 229);
            this.add_bttn.Name = "add_bttn";
            this.add_bttn.Size = new System.Drawing.Size(126, 36);
            this.add_bttn.TabIndex = 10;
            this.add_bttn.Text = " ADD PRODUCT";
            this.add_bttn.UseTransparentBackground = true;
            this.add_bttn.Click += new System.EventHandler(this.add_bttn_Click);
            // 
            // prodprice_txtbox
            // 
            this.prodprice_txtbox.AutoRoundedCorners = true;
            this.prodprice_txtbox.BackColor = System.Drawing.Color.DarkOrange;
            this.prodprice_txtbox.BorderColor = System.Drawing.Color.DarkOrange;
            this.prodprice_txtbox.BorderRadius = 16;
            this.prodprice_txtbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.prodprice_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodprice_txtbox.DefaultText = "";
            this.prodprice_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodprice_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodprice_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodprice_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodprice_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodprice_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.prodprice_txtbox.ForeColor = System.Drawing.Color.Coral;
            this.prodprice_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodprice_txtbox.Location = new System.Drawing.Point(196, 139);
            this.prodprice_txtbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prodprice_txtbox.Name = "prodprice_txtbox";
            this.prodprice_txtbox.PasswordChar = '\0';
            this.prodprice_txtbox.PlaceholderText = "";
            this.prodprice_txtbox.SelectedText = "";
            this.prodprice_txtbox.Size = new System.Drawing.Size(221, 34);
            this.prodprice_txtbox.TabIndex = 5;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.ForeColor = System.Drawing.Color.White;
            this.quantity_label.Location = new System.Drawing.Point(4, 145);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(80, 25);
            this.quantity_label.TabIndex = 4;
            this.quantity_label.Text = "PRICE";
            // 
            // prodname_txtbox
            // 
            this.prodname_txtbox.AutoRoundedCorners = true;
            this.prodname_txtbox.BackColor = System.Drawing.Color.DarkOrange;
            this.prodname_txtbox.BorderColor = System.Drawing.Color.DarkOrange;
            this.prodname_txtbox.BorderRadius = 16;
            this.prodname_txtbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.prodname_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodname_txtbox.DefaultText = "";
            this.prodname_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prodname_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prodname_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodname_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prodname_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodname_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.prodname_txtbox.ForeColor = System.Drawing.Color.Coral;
            this.prodname_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodname_txtbox.Location = new System.Drawing.Point(196, 92);
            this.prodname_txtbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prodname_txtbox.Name = "prodname_txtbox";
            this.prodname_txtbox.PasswordChar = '\0';
            this.prodname_txtbox.PlaceholderText = "";
            this.prodname_txtbox.SelectedText = "";
            this.prodname_txtbox.Size = new System.Drawing.Size(221, 34);
            this.prodname_txtbox.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(4, 98);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(194, 25);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "PRODUCT NAME";
            // 
            // billid_txtbox
            // 
            this.billid_txtbox.AutoRoundedCorners = true;
            this.billid_txtbox.BackColor = System.Drawing.Color.DarkOrange;
            this.billid_txtbox.BorderColor = System.Drawing.Color.DarkOrange;
            this.billid_txtbox.BorderRadius = 16;
            this.billid_txtbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.billid_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.billid_txtbox.DefaultText = "";
            this.billid_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.billid_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.billid_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.billid_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.billid_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billid_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.billid_txtbox.ForeColor = System.Drawing.Color.Coral;
            this.billid_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.billid_txtbox.Location = new System.Drawing.Point(196, 45);
            this.billid_txtbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.billid_txtbox.Name = "billid_txtbox";
            this.billid_txtbox.PasswordChar = '\0';
            this.billid_txtbox.PlaceholderText = "";
            this.billid_txtbox.SelectedText = "";
            this.billid_txtbox.Size = new System.Drawing.Size(221, 34);
            this.billid_txtbox.TabIndex = 1;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(4, 51);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(88, 25);
            this.id_label.TabIndex = 0;
            this.id_label.Text = "BILL ID";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // logout_bttn
            // 
            this.logout_bttn.AutoRoundedCorners = true;
            this.logout_bttn.BackColor = System.Drawing.Color.Transparent;
            this.logout_bttn.BorderColor = System.Drawing.Color.White;
            this.logout_bttn.BorderRadius = 17;
            this.logout_bttn.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.logout_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logout_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logout_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logout_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logout_bttn.FillColor = System.Drawing.Color.White;
            this.logout_bttn.FocusedColor = System.Drawing.Color.White;
            this.logout_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_bttn.ForeColor = System.Drawing.Color.Coral;
            this.logout_bttn.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.logout_bttn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.logout_bttn.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.logout_bttn.Location = new System.Drawing.Point(38, 633);
            this.logout_bttn.Name = "logout_bttn";
            this.logout_bttn.Size = new System.Drawing.Size(89, 36);
            this.logout_bttn.TabIndex = 25;
            this.logout_bttn.Text = "LOG OUT";
            this.logout_bttn.UseTransparentBackground = true;
            this.logout_bttn.Click += new System.EventHandler(this.logout_bttn_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 681);
            this.Controls.Add(this.logout_bttn);
            this.Controls.Add(this.close_bttn);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsListdisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seller_display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button close_bttn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox prodquantity_txtbox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView seller_display;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button add2_bttn;
        private Guna.UI2.WinForms.Guna2Button delete_bttn;
        private Guna.UI2.WinForms.Guna2Button add_bttn;
        private Guna.UI2.WinForms.Guna2TextBox prodprice_txtbox;
        private System.Windows.Forms.Label quantity_label;
        private Guna.UI2.WinForms.Guna2TextBox prodname_txtbox;
        private System.Windows.Forms.Label name_label;
        private Guna.UI2.WinForms.Guna2TextBox billid_txtbox;
        private System.Windows.Forms.Label id_label;
        private Guna.UI2.WinForms.Guna2Button refresh_bttn;
        private System.Windows.Forms.ComboBox categorybox;
        private System.Windows.Forms.Label date;
        private Guna.UI2.WinForms.Guna2DataGridView sellsListdisplay;
        private Guna.UI2.WinForms.Guna2Button print_bttn;
        private System.Windows.Forms.Label total_amount_label;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView orderdisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sellername_label;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2Button logout_bttn;
    }
}