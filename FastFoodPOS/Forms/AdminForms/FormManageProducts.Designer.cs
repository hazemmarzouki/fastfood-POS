namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormManageProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonsMenu = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonDesserts = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPackages = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSnacks = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonFoods = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonDrinks = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ButtonAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.TextSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonsMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(79, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Products :";
            // 
            // ButtonsMenu
            // 
            this.ButtonsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsMenu.ColumnCount = 5;
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsMenu.Controls.Add(this.ButtonDesserts, 0, 0);
            this.ButtonsMenu.Controls.Add(this.ButtonPackages, 0, 0);
            this.ButtonsMenu.Controls.Add(this.ButtonSnacks, 0, 0);
            this.ButtonsMenu.Controls.Add(this.ButtonFoods, 0, 0);
            this.ButtonsMenu.Controls.Add(this.ButtonDrinks, 0, 0);
            this.ButtonsMenu.Location = new System.Drawing.Point(36, 91);
            this.ButtonsMenu.Name = "ButtonsMenu";
            this.ButtonsMenu.RowCount = 1;
            this.ButtonsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsMenu.Size = new System.Drawing.Size(825, 50);
            this.ButtonsMenu.TabIndex = 6;
            // 
            // ButtonDesserts
            // 
            this.ButtonDesserts.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonDesserts.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.ButtonDesserts.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ButtonDesserts.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonDesserts.CheckedState.Parent = this.ButtonDesserts;
            this.ButtonDesserts.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ButtonDesserts.CustomImages.Parent = this.ButtonDesserts;
            this.ButtonDesserts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDesserts.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.ButtonDesserts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDesserts.ForeColor = System.Drawing.Color.White;
            this.ButtonDesserts.HoverState.Parent = this.ButtonDesserts;
            this.ButtonDesserts.Image = global::FastFoodPOS.Properties.Resources.melting_ice_cream_48px;
            this.ButtonDesserts.ImageOffset = new System.Drawing.Point(-2, 0);
            this.ButtonDesserts.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonDesserts.Location = new System.Drawing.Point(495, 0);
            this.ButtonDesserts.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDesserts.Name = "ButtonDesserts";
            this.ButtonDesserts.ShadowDecoration.Parent = this.ButtonDesserts;
            this.ButtonDesserts.Size = new System.Drawing.Size(165, 50);
            this.ButtonDesserts.TabIndex = 5;
            this.ButtonDesserts.Tag = "Dessert";
            this.ButtonDesserts.Text = "Desserts";
            this.ButtonDesserts.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // ButtonPackages
            // 
            this.ButtonPackages.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonPackages.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.ButtonPackages.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ButtonPackages.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonPackages.CheckedState.Parent = this.ButtonPackages;
            this.ButtonPackages.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ButtonPackages.CustomImages.Parent = this.ButtonPackages;
            this.ButtonPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPackages.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(89)))));
            this.ButtonPackages.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPackages.ForeColor = System.Drawing.Color.White;
            this.ButtonPackages.HoverState.Parent = this.ButtonPackages;
            this.ButtonPackages.Image = global::FastFoodPOS.Properties.Resources.Street_Food_48px;
            this.ButtonPackages.ImageOffset = new System.Drawing.Point(-2, 0);
            this.ButtonPackages.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonPackages.Location = new System.Drawing.Point(660, 0);
            this.ButtonPackages.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPackages.Name = "ButtonPackages";
            this.ButtonPackages.ShadowDecoration.Parent = this.ButtonPackages;
            this.ButtonPackages.Size = new System.Drawing.Size(165, 50);
            this.ButtonPackages.TabIndex = 4;
            this.ButtonPackages.Tag = "Package";
            this.ButtonPackages.Text = "Packages";
            this.ButtonPackages.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // ButtonSnacks
            // 
            this.ButtonSnacks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonSnacks.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.ButtonSnacks.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ButtonSnacks.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonSnacks.CheckedState.Parent = this.ButtonSnacks;
            this.ButtonSnacks.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ButtonSnacks.CustomImages.Parent = this.ButtonSnacks;
            this.ButtonSnacks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSnacks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(167)))), ((int)(((byte)(66)))));
            this.ButtonSnacks.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSnacks.ForeColor = System.Drawing.Color.White;
            this.ButtonSnacks.HoverState.Parent = this.ButtonSnacks;
            this.ButtonSnacks.Image = global::FastFoodPOS.Properties.Resources.sandwich_100px;
            this.ButtonSnacks.ImageOffset = new System.Drawing.Point(-2, 0);
            this.ButtonSnacks.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonSnacks.Location = new System.Drawing.Point(330, 0);
            this.ButtonSnacks.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSnacks.Name = "ButtonSnacks";
            this.ButtonSnacks.ShadowDecoration.Parent = this.ButtonSnacks;
            this.ButtonSnacks.Size = new System.Drawing.Size(165, 50);
            this.ButtonSnacks.TabIndex = 3;
            this.ButtonSnacks.Tag = "Snack";
            this.ButtonSnacks.Text = "Snacks";
            this.ButtonSnacks.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // ButtonFoods
            // 
            this.ButtonFoods.Animated = true;
            this.ButtonFoods.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonFoods.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.ButtonFoods.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ButtonFoods.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonFoods.CheckedState.Parent = this.ButtonFoods;
            this.ButtonFoods.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ButtonFoods.CustomImages.Parent = this.ButtonFoods;
            this.ButtonFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonFoods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(56)))), ((int)(((byte)(64)))));
            this.ButtonFoods.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFoods.ForeColor = System.Drawing.Color.White;
            this.ButtonFoods.HoverState.Parent = this.ButtonFoods;
            this.ButtonFoods.Image = global::FastFoodPOS.Properties.Resources.guacamole_100px;
            this.ButtonFoods.ImageOffset = new System.Drawing.Point(-2, 0);
            this.ButtonFoods.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonFoods.Location = new System.Drawing.Point(0, 0);
            this.ButtonFoods.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonFoods.Name = "ButtonFoods";
            this.ButtonFoods.ShadowDecoration.Parent = this.ButtonFoods;
            this.ButtonFoods.Size = new System.Drawing.Size(165, 50);
            this.ButtonFoods.TabIndex = 2;
            this.ButtonFoods.Tag = "Food";
            this.ButtonFoods.Text = "Foods";
            this.ButtonFoods.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // ButtonDrinks
            // 
            this.ButtonDrinks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButtonDrinks.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.ButtonDrinks.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ButtonDrinks.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ButtonDrinks.CheckedState.Parent = this.ButtonDrinks;
            this.ButtonDrinks.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ButtonDrinks.CustomImages.Parent = this.ButtonDrinks;
            this.ButtonDrinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDrinks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(75)))), ((int)(((byte)(64)))));
            this.ButtonDrinks.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDrinks.ForeColor = System.Drawing.Color.White;
            this.ButtonDrinks.HoverState.Parent = this.ButtonDrinks;
            this.ButtonDrinks.Image = global::FastFoodPOS.Properties.Resources.soda_48px;
            this.ButtonDrinks.ImageOffset = new System.Drawing.Point(-2, 0);
            this.ButtonDrinks.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonDrinks.Location = new System.Drawing.Point(165, 0);
            this.ButtonDrinks.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDrinks.Name = "ButtonDrinks";
            this.ButtonDrinks.ShadowDecoration.Parent = this.ButtonDrinks;
            this.ButtonDrinks.Size = new System.Drawing.Size(165, 50);
            this.ButtonDrinks.TabIndex = 1;
            this.ButtonDrinks.Tag = "Drink";
            this.ButtonDrinks.Text = "Drinks";
            this.ButtonDrinks.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(35, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 357);
            this.panel1.TabIndex = 7;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(735, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(802, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::FastFoodPOS.Properties.Resources.Food_Donor_48px;
            this.guna2PictureBox1.Location = new System.Drawing.Point(36, 35);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 36);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddProduct.CheckedState.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.CustomImages.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ButtonAddProduct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddProduct.ForeColor = System.Drawing.Color.White;
            this.ButtonAddProduct.HoverState.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.Image = global::FastFoodPOS.Properties.Resources.plus_math_48px;
            this.ButtonAddProduct.ImageOffset = new System.Drawing.Point(-2, 0);
            this.ButtonAddProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonAddProduct.Location = new System.Drawing.Point(696, 168);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.ShadowDecoration.Parent = this.ButtonAddProduct;
            this.ButtonAddProduct.Size = new System.Drawing.Size(164, 36);
            this.ButtonAddProduct.TabIndex = 9;
            this.ButtonAddProduct.Text = "Add Products";
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // TextSearch
            // 
            this.TextSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextSearch.DefaultText = "";
            this.TextSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextSearch.DisabledState.Parent = this.TextSearch;
            this.TextSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextSearch.FocusedState.Parent = this.TextSearch;
            this.TextSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextSearch.HoverState.Parent = this.TextSearch;
            this.TextSearch.IconLeft = global::FastFoodPOS.Properties.Resources.search_gray;
            this.TextSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.TextSearch.IconLeftSize = new System.Drawing.Size(18, 18);
            this.TextSearch.Location = new System.Drawing.Point(36, 168);
            this.TextSearch.Margin = new System.Windows.Forms.Padding(0);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.PasswordChar = '\0';
            this.TextSearch.PlaceholderText = "Search for menu ..";
            this.TextSearch.SelectedText = "";
            this.TextSearch.ShadowDecoration.Parent = this.TextSearch;
            this.TextSearch.Size = new System.Drawing.Size(316, 36);
            this.TextSearch.TabIndex = 8;
            this.TextSearch.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // FormManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonsMenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormManageProducts";
            this.Size = new System.Drawing.Size(904, 579);
            this.ButtonsMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel ButtonsMenu;
        private Guna.UI2.WinForms.Guna2Button ButtonDrinks;
        private Guna.UI2.WinForms.Guna2Button ButtonPackages;
        private Guna.UI2.WinForms.Guna2Button ButtonSnacks;
        private Guna.UI2.WinForms.Guna2Button ButtonFoods;
        private Guna.UI2.WinForms.Guna2Button ButtonDesserts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox TextSearch;
        private Guna.UI2.WinForms.Guna2Button ButtonAddProduct;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
