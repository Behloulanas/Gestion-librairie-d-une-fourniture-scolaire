namespace Retail
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_Help = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_sellers = new System.Windows.Forms.Button();
            this.btn_billing = new System.Windows.Forms.Button();
            this.btn_Orders = new System.Windows.Forms.Button();
            this.btn_Customers = new System.Windows.Forms.Button();
            this.btn_Products = new System.Windows.Forms.Button();
            this.btn_Categories = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_dashborad = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.uC_Billing1 = new Retail.UC_Billing();
            this.uC_dashboard1 = new Retail.UC_dashboard();
            this.uC_Sellers1 = new Retail.UC_Sellers();
            this.uC_categories1 = new Retail.UC_categories();
            this.uC_orders1 = new Retail.UC_orders();
            this.uC_products1 = new Retail.UC_products();
            this.uC_Customers1 = new Retail.UC_Customers();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Emsi Anas Store";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1309, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 663);
            this.panel5.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(271, 725);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 10);
            this.panel4.TabIndex = 15;
            // 
            // Logout
            // 
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(16, 650);
            this.Logout.Margin = new System.Windows.Forms.Padding(4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(251, 50);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "Exit";
            this.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(4, 84);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 50);
            this.SidePanel.TabIndex = 4;
            // 
            // btn_Help
            // 
            this.btn_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.ForeColor = System.Drawing.Color.White;
            this.btn_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.Location = new System.Drawing.Point(4, 689);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(48, 42);
            this.btn_Help.TabIndex = 4;
            this.btn_Help.Text = "?";
            this.btn_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btn_sellers);
            this.panel1.Controls.Add(this.btn_billing);
            this.panel1.Controls.Add(this.btn_Orders);
            this.panel1.Controls.Add(this.btn_Customers);
            this.panel1.Controls.Add(this.btn_Products);
            this.panel1.Controls.Add(this.btn_Categories);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.btn_dashborad);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btn_Help);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 735);
            this.panel1.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::Retail.Properties.Resources.icons8_enter_30px1;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(74, 651);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(49, 49);
            this.panel7.TabIndex = 22;
            // 
            // btn_sellers
            // 
            this.btn_sellers.FlatAppearance.BorderSize = 0;
            this.btn_sellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sellers.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sellers.ForeColor = System.Drawing.Color.White;
            this.btn_sellers.Image = ((System.Drawing.Image)(resources.GetObject("btn_sellers.Image")));
            this.btn_sellers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sellers.Location = new System.Drawing.Point(16, 556);
            this.btn_sellers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sellers.Name = "btn_sellers";
            this.btn_sellers.Size = new System.Drawing.Size(251, 50);
            this.btn_sellers.TabIndex = 21;
            this.btn_sellers.Text = "   Sellers";
            this.btn_sellers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sellers.UseVisualStyleBackColor = true;
            this.btn_sellers.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_billing
            // 
            this.btn_billing.FlatAppearance.BorderSize = 0;
            this.btn_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billing.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billing.ForeColor = System.Drawing.Color.White;
            this.btn_billing.Image = ((System.Drawing.Image)(resources.GetObject("btn_billing.Image")));
            this.btn_billing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_billing.Location = new System.Drawing.Point(12, 478);
            this.btn_billing.Margin = new System.Windows.Forms.Padding(4);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(251, 50);
            this.btn_billing.TabIndex = 20;
            this.btn_billing.Text = "   Billing";
            this.btn_billing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_billing.UseVisualStyleBackColor = true;
            this.btn_billing.Click += new System.EventHandler(this.btn_Sales_Invoice_Click);
            // 
            // btn_Orders
            // 
            this.btn_Orders.FlatAppearance.BorderSize = 0;
            this.btn_Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Orders.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Orders.ForeColor = System.Drawing.Color.White;
            this.btn_Orders.Image = ((System.Drawing.Image)(resources.GetObject("btn_Orders.Image")));
            this.btn_Orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Orders.Location = new System.Drawing.Point(16, 397);
            this.btn_Orders.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Orders.Name = "btn_Orders";
            this.btn_Orders.Size = new System.Drawing.Size(251, 50);
            this.btn_Orders.TabIndex = 19;
            this.btn_Orders.Text = "   Orders";
            this.btn_Orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Orders.UseVisualStyleBackColor = true;
            this.btn_Orders.Click += new System.EventHandler(this.btn_Orders_Click);
            // 
            // btn_Customers
            // 
            this.btn_Customers.FlatAppearance.BorderSize = 0;
            this.btn_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customers.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customers.ForeColor = System.Drawing.Color.White;
            this.btn_Customers.Image = ((System.Drawing.Image)(resources.GetObject("btn_Customers.Image")));
            this.btn_Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Customers.Location = new System.Drawing.Point(16, 314);
            this.btn_Customers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Customers.Name = "btn_Customers";
            this.btn_Customers.Size = new System.Drawing.Size(251, 50);
            this.btn_Customers.TabIndex = 18;
            this.btn_Customers.Text = "   Customers";
            this.btn_Customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Customers.UseVisualStyleBackColor = true;
            this.btn_Customers.Click += new System.EventHandler(this.btn_Customers_Click);
            // 
            // btn_Products
            // 
            this.btn_Products.FlatAppearance.BorderSize = 0;
            this.btn_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Products.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Products.ForeColor = System.Drawing.Color.White;
            this.btn_Products.Image = ((System.Drawing.Image)(resources.GetObject("btn_Products.Image")));
            this.btn_Products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Products.Location = new System.Drawing.Point(16, 235);
            this.btn_Products.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.Size = new System.Drawing.Size(251, 50);
            this.btn_Products.TabIndex = 17;
            this.btn_Products.Text = "   Livres";
            this.btn_Products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Products.UseVisualStyleBackColor = true;
            this.btn_Products.Click += new System.EventHandler(this.btn_Products_Click);
            // 
            // btn_Categories
            // 
            this.btn_Categories.FlatAppearance.BorderSize = 0;
            this.btn_Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Categories.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Categories.ForeColor = System.Drawing.Color.White;
            this.btn_Categories.Image = ((System.Drawing.Image)(resources.GetObject("btn_Categories.Image")));
            this.btn_Categories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Categories.Location = new System.Drawing.Point(16, 158);
            this.btn_Categories.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Categories.Name = "btn_Categories";
            this.btn_Categories.Size = new System.Drawing.Size(251, 50);
            this.btn_Categories.TabIndex = 16;
            this.btn_Categories.Text = "   Categories";
            this.btn_Categories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Categories.UseVisualStyleBackColor = true;
            this.btn_Categories.Click += new System.EventHandler(this.btn_Categories_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 66);
            this.panel3.TabIndex = 7;
            // 
            // btn_dashborad
            // 
            this.btn_dashborad.FlatAppearance.BorderSize = 0;
            this.btn_dashborad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashborad.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashborad.ForeColor = System.Drawing.Color.White;
            this.btn_dashborad.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashborad.Image")));
            this.btn_dashborad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashborad.Location = new System.Drawing.Point(16, 84);
            this.btn_dashborad.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dashborad.Name = "btn_dashborad";
            this.btn_dashborad.Size = new System.Drawing.Size(251, 50);
            this.btn_dashborad.TabIndex = 11;
            this.btn_dashborad.Text = "   Dashboard";
            this.btn_dashborad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dashborad.UseVisualStyleBackColor = true;
            this.btn_dashborad.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel6.Controls.Add(this.uC_Billing1);
            this.panel6.Controls.Add(this.uC_dashboard1);
            this.panel6.Controls.Add(this.uC_Sellers1);
            this.panel6.Controls.Add(this.uC_categories1);
            this.panel6.Controls.Add(this.uC_orders1);
            this.panel6.Controls.Add(this.uC_products1);
            this.panel6.Controls.Add(this.uC_Customers1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(271, 62);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1038, 663);
            this.panel6.TabIndex = 24;
            // 
            // uC_Billing1
            // 
            this.uC_Billing1.BackColor = System.Drawing.Color.White;
            this.uC_Billing1.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.uC_Billing1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Billing1.ForeColor = System.Drawing.Color.Black;
            this.uC_Billing1.Location = new System.Drawing.Point(0, 0);
            this.uC_Billing1.Name = "uC_Billing1";
            this.uC_Billing1.Size = new System.Drawing.Size(1038, 663);
            this.uC_Billing1.TabIndex = 18;
            this.uC_Billing1.Load += new System.EventHandler(this.uC_Billing1_Load);
            // 
            // uC_dashboard1
            // 
            this.uC_dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uC_dashboard1.Name = "uC_dashboard1";
            this.uC_dashboard1.Size = new System.Drawing.Size(1038, 663);
            this.uC_dashboard1.TabIndex = 23;
            // 
            // uC_Sellers1
            // 
            this.uC_Sellers1.BackColor = System.Drawing.Color.White;
            this.uC_Sellers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Sellers1.Location = new System.Drawing.Point(0, 0);
            this.uC_Sellers1.Name = "uC_Sellers1";
            this.uC_Sellers1.Size = new System.Drawing.Size(1038, 663);
            this.uC_Sellers1.TabIndex = 17;
            // 
            // uC_categories1
            // 
            this.uC_categories1.BackColor = System.Drawing.Color.White;
            this.uC_categories1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_categories1.Location = new System.Drawing.Point(0, 0);
            this.uC_categories1.Name = "uC_categories1";
            this.uC_categories1.Size = new System.Drawing.Size(1038, 663);
            this.uC_categories1.TabIndex = 22;
            // 
            // uC_orders1
            // 
            this.uC_orders1.BackColor = System.Drawing.Color.White;
            this.uC_orders1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_orders1.Location = new System.Drawing.Point(0, 0);
            this.uC_orders1.Name = "uC_orders1";
            this.uC_orders1.Size = new System.Drawing.Size(1038, 663);
            this.uC_orders1.TabIndex = 19;
            // 
            // uC_products1
            // 
            this.uC_products1.BackColor = System.Drawing.Color.White;
            this.uC_products1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_products1.ForeColor = System.Drawing.Color.Purple;
            this.uC_products1.Location = new System.Drawing.Point(0, 0);
            this.uC_products1.Name = "uC_products1";
            this.uC_products1.Size = new System.Drawing.Size(1038, 663);
            this.uC_products1.TabIndex = 21;
            // 
            // uC_Customers1
            // 
            this.uC_Customers1.BackColor = System.Drawing.Color.White;
            this.uC_Customers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Customers1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.uC_Customers1.Location = new System.Drawing.Point(0, 0);
            this.uC_Customers1.Name = "uC_Customers1";
            this.uC_Customers1.Size = new System.Drawing.Size(1038, 663);
            this.uC_Customers1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel2.BackgroundImage = global::Retail.Properties.Resources.logo_LE_couls_turquoise1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(271, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 62);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Retail.Properties.Resources.Simpleicons_Interface_power_symbol_1_svg;
            this.pictureBox2.Location = new System.Drawing.Point(981, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1319, 735);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_sellers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_billing;
        private System.Windows.Forms.Button btn_Orders;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Customers;
        private System.Windows.Forms.Button btn_Products;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button btn_dashborad;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Categories;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel6;
        private UC_Billing uC_Billing1;
        private UC_dashboard uC_dashboard1;
        private UC_Sellers uC_Sellers1;
        private UC_categories uC_categories1;
        private UC_orders uC_orders1;
        private UC_products uC_products1;
        private UC_Customers uC_Customers1;
        private System.Windows.Forms.Panel panel7;
    }
}