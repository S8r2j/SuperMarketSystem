namespace Marketing_app
{
    partial class CategoryForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.category_display = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.categoryedit_bttn = new Guna.UI2.WinForms.Guna2Button();
            this.categorydelete_bttn = new Guna.UI2.WinForms.Guna2Button();
            this.categoryadd_bttn = new Guna.UI2.WinForms.Guna2Button();
            this.categorydescription_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.categoryname_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.categoryid_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.close_bttn = new Guna.UI2.WinForms.Guna2Button();
            this.logout_bttn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_display)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.guna2Panel1.Controls.Add(this.category_display);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.categoryedit_bttn);
            this.guna2Panel1.Controls.Add(this.categorydelete_bttn);
            this.guna2Panel1.Controls.Add(this.categoryadd_bttn);
            this.guna2Panel1.Controls.Add(this.categorydescription_txtbox);
            this.guna2Panel1.Controls.Add(this.quantity_label);
            this.guna2Panel1.Controls.Add(this.categoryname_txtbox);
            this.guna2Panel1.Controls.Add(this.name_label);
            this.guna2Panel1.Controls.Add(this.categoryid_txtbox);
            this.guna2Panel1.Controls.Add(this.id_label);
            this.guna2Panel1.Location = new System.Drawing.Point(159, 32);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(970, 591);
            this.guna2Panel1.TabIndex = 1;
            // 
            // category_display
            // 
            this.category_display.AllowUserToAddRows = false;
            this.category_display.AllowUserToDeleteRows = false;
            this.category_display.AllowUserToResizeColumns = false;
            this.category_display.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.category_display.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.category_display.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.category_display.BackgroundColor = System.Drawing.Color.White;
            this.category_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.category_display.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.category_display.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.category_display.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.category_display.ColumnHeadersHeight = 40;
            this.category_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.category_display.DefaultCellStyle = dataGridViewCellStyle3;
            this.category_display.EnableHeadersVisualStyles = false;
            this.category_display.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.category_display.Location = new System.Drawing.Point(430, 86);
            this.category_display.Name = "category_display";
            this.category_display.ReadOnly = true;
            this.category_display.RowHeadersVisible = false;
            this.category_display.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.category_display.ShowEditingIcon = false;
            this.category_display.Size = new System.Drawing.Size(531, 500);
            this.category_display.TabIndex = 15;
            this.category_display.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.category_display.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.category_display.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.category_display.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.category_display.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.category_display.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.category_display.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.category_display.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.category_display.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.category_display.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_display.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.category_display.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.category_display.ThemeStyle.HeaderStyle.Height = 40;
            this.category_display.ThemeStyle.ReadOnly = true;
            this.category_display.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.category_display.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.category_display.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.category_display.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.category_display.ThemeStyle.RowsStyle.Height = 22;
            this.category_display.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.category_display.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.category_display.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.category_display_CellContentClick);
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
            this.guna2Button1.Location = new System.Drawing.Point(300, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(331, 36);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "MANAGE CATAGORY";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // categoryedit_bttn
            // 
            this.categoryedit_bttn.AutoRoundedCorners = true;
            this.categoryedit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.categoryedit_bttn.BorderColor = System.Drawing.Color.DarkOrange;
            this.categoryedit_bttn.BorderRadius = 17;
            this.categoryedit_bttn.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.categoryedit_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryedit_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryedit_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryedit_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryedit_bttn.FillColor = System.Drawing.Color.White;
            this.categoryedit_bttn.FocusedColor = System.Drawing.Color.White;
            this.categoryedit_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryedit_bttn.ForeColor = System.Drawing.Color.Coral;
            this.categoryedit_bttn.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.categoryedit_bttn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.categoryedit_bttn.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.categoryedit_bttn.Location = new System.Drawing.Point(268, 241);
            this.categoryedit_bttn.Name = "categoryedit_bttn";
            this.categoryedit_bttn.Size = new System.Drawing.Size(64, 36);
            this.categoryedit_bttn.TabIndex = 12;
            this.categoryedit_bttn.Text = "EDIT";
            this.categoryedit_bttn.UseTransparentBackground = true;
            this.categoryedit_bttn.Click += new System.EventHandler(this.categoryedit_bttn_Click);
            // 
            // categorydelete_bttn
            // 
            this.categorydelete_bttn.AutoRoundedCorners = true;
            this.categorydelete_bttn.BackColor = System.Drawing.Color.Transparent;
            this.categorydelete_bttn.BorderColor = System.Drawing.Color.DarkOrange;
            this.categorydelete_bttn.BorderRadius = 17;
            this.categorydelete_bttn.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.categorydelete_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categorydelete_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categorydelete_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categorydelete_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categorydelete_bttn.FillColor = System.Drawing.Color.White;
            this.categorydelete_bttn.FocusedColor = System.Drawing.Color.White;
            this.categorydelete_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorydelete_bttn.ForeColor = System.Drawing.Color.Coral;
            this.categorydelete_bttn.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.categorydelete_bttn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.categorydelete_bttn.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.categorydelete_bttn.Location = new System.Drawing.Point(338, 241);
            this.categorydelete_bttn.Name = "categorydelete_bttn";
            this.categorydelete_bttn.Size = new System.Drawing.Size(89, 36);
            this.categorydelete_bttn.TabIndex = 11;
            this.categorydelete_bttn.Text = "DELETE";
            this.categorydelete_bttn.UseTransparentBackground = true;
            this.categorydelete_bttn.Click += new System.EventHandler(this.categorydelete_bttn_Click);
            // 
            // categoryadd_bttn
            // 
            this.categoryadd_bttn.AutoRoundedCorners = true;
            this.categoryadd_bttn.BackColor = System.Drawing.Color.Transparent;
            this.categoryadd_bttn.BorderColor = System.Drawing.Color.DarkOrange;
            this.categoryadd_bttn.BorderRadius = 17;
            this.categoryadd_bttn.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.categoryadd_bttn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryadd_bttn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryadd_bttn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryadd_bttn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryadd_bttn.FillColor = System.Drawing.Color.White;
            this.categoryadd_bttn.FocusedColor = System.Drawing.Color.White;
            this.categoryadd_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryadd_bttn.ForeColor = System.Drawing.Color.Coral;
            this.categoryadd_bttn.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.categoryadd_bttn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.categoryadd_bttn.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.categoryadd_bttn.Location = new System.Drawing.Point(171, 241);
            this.categoryadd_bttn.Name = "categoryadd_bttn";
            this.categoryadd_bttn.Size = new System.Drawing.Size(91, 36);
            this.categoryadd_bttn.TabIndex = 10;
            this.categoryadd_bttn.Text = "ADD";
            this.categoryadd_bttn.UseTransparentBackground = true;
            this.categoryadd_bttn.Click += new System.EventHandler(this.categoryadd_bttn_Click);
            // 
            // categorydescription_txtbox
            // 
            this.categorydescription_txtbox.AutoRoundedCorners = true;
            this.categorydescription_txtbox.BackColor = System.Drawing.Color.DarkOrange;
            this.categorydescription_txtbox.BorderColor = System.Drawing.Color.DarkOrange;
            this.categorydescription_txtbox.BorderRadius = 17;
            this.categorydescription_txtbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.categorydescription_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categorydescription_txtbox.DefaultText = "";
            this.categorydescription_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categorydescription_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categorydescription_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categorydescription_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categorydescription_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorydescription_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.categorydescription_txtbox.ForeColor = System.Drawing.Color.Coral;
            this.categorydescription_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorydescription_txtbox.Location = new System.Drawing.Point(167, 180);
            this.categorydescription_txtbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.categorydescription_txtbox.Name = "categorydescription_txtbox";
            this.categorydescription_txtbox.PasswordChar = '\0';
            this.categorydescription_txtbox.PlaceholderText = "";
            this.categorydescription_txtbox.SelectedText = "";
            this.categorydescription_txtbox.Size = new System.Drawing.Size(256, 36);
            this.categorydescription_txtbox.TabIndex = 5;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.ForeColor = System.Drawing.Color.White;
            this.quantity_label.Location = new System.Drawing.Point(3, 186);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(164, 25);
            this.quantity_label.TabIndex = 4;
            this.quantity_label.Text = "DESCRIPTION";
            // 
            // categoryname_txtbox
            // 
            this.categoryname_txtbox.AutoRoundedCorners = true;
            this.categoryname_txtbox.BackColor = System.Drawing.Color.DarkOrange;
            this.categoryname_txtbox.BorderColor = System.Drawing.Color.DarkOrange;
            this.categoryname_txtbox.BorderRadius = 17;
            this.categoryname_txtbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.categoryname_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryname_txtbox.DefaultText = "";
            this.categoryname_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categoryname_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categoryname_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryname_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryname_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryname_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.categoryname_txtbox.ForeColor = System.Drawing.Color.Coral;
            this.categoryname_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryname_txtbox.Location = new System.Drawing.Point(167, 133);
            this.categoryname_txtbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.categoryname_txtbox.Name = "categoryname_txtbox";
            this.categoryname_txtbox.PasswordChar = '\0';
            this.categoryname_txtbox.PlaceholderText = "";
            this.categoryname_txtbox.SelectedText = "";
            this.categoryname_txtbox.Size = new System.Drawing.Size(256, 36);
            this.categoryname_txtbox.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(12, 139);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(77, 25);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "NAME";
            // 
            // categoryid_txtbox
            // 
            this.categoryid_txtbox.AutoRoundedCorners = true;
            this.categoryid_txtbox.BackColor = System.Drawing.Color.DarkOrange;
            this.categoryid_txtbox.BorderColor = System.Drawing.Color.DarkOrange;
            this.categoryid_txtbox.BorderRadius = 17;
            this.categoryid_txtbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.categoryid_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryid_txtbox.DefaultText = "";
            this.categoryid_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categoryid_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categoryid_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryid_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryid_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryid_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.categoryid_txtbox.ForeColor = System.Drawing.Color.Coral;
            this.categoryid_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryid_txtbox.Location = new System.Drawing.Point(167, 86);
            this.categoryid_txtbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.categoryid_txtbox.Name = "categoryid_txtbox";
            this.categoryid_txtbox.PasswordChar = '\0';
            this.categoryid_txtbox.PlaceholderText = "";
            this.categoryid_txtbox.SelectedText = "";
            this.categoryid_txtbox.Size = new System.Drawing.Size(256, 36);
            this.categoryid_txtbox.TabIndex = 1;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(12, 92);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(34, 25);
            this.id_label.TabIndex = 0;
            this.id_label.Text = "ID";
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
            this.close_bttn.Location = new System.Drawing.Point(1097, -1);
            this.close_bttn.Name = "close_bttn";
            this.close_bttn.Size = new System.Drawing.Size(32, 27);
            this.close_bttn.TabIndex = 18;
            this.close_bttn.Text = "X";
            this.close_bttn.Click += new System.EventHandler(this.close_bttn_Click);
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
            this.logout_bttn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.logout_bttn.FocusedColor = System.Drawing.Color.White;
            this.logout_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_bttn.ForeColor = System.Drawing.Color.Coral;
            this.logout_bttn.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.logout_bttn.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.logout_bttn.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.logout_bttn.Location = new System.Drawing.Point(51, 575);
            this.logout_bttn.Name = "logout_bttn";
            this.logout_bttn.Size = new System.Drawing.Size(91, 36);
            this.logout_bttn.TabIndex = 20;
            this.logout_bttn.Text = "LOG OUT";
            this.logout_bttn.UseTransparentBackground = true;
            this.logout_bttn.Click += new System.EventHandler(this.logout_bttn_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.BorderRadius = 17;
            this.guna2Button3.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button3.FocusedColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Coral;
            this.guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2Button3.Location = new System.Drawing.Point(51, 118);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(91, 36);
            this.guna2Button3.TabIndex = 19;
            this.guna2Button3.Text = "SELLER";
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 17;
            this.guna2Button2.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button2.FocusedColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Coral;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2Button2.Location = new System.Drawing.Point(46, 165);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(101, 36);
            this.guna2Button2.TabIndex = 18;
            this.guna2Button2.Text = "PRODUCT";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1129, 623);
            this.Controls.Add(this.logout_bttn);
            this.Controls.Add(this.close_bttn);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView category_display;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button categoryedit_bttn;
        private Guna.UI2.WinForms.Guna2Button categorydelete_bttn;
        private Guna.UI2.WinForms.Guna2Button categoryadd_bttn;
        private Guna.UI2.WinForms.Guna2TextBox categorydescription_txtbox;
        private System.Windows.Forms.Label quantity_label;
        private Guna.UI2.WinForms.Guna2TextBox categoryname_txtbox;
        private System.Windows.Forms.Label name_label;
        private Guna.UI2.WinForms.Guna2TextBox categoryid_txtbox;
        private System.Windows.Forms.Label id_label;
        private Guna.UI2.WinForms.Guna2Button close_bttn;
        private Guna.UI2.WinForms.Guna2Button logout_bttn;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}