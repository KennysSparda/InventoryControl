namespace InventoryControl
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.top = new System.Windows.Forms.MenuStrip();
            this.top_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.top_menu_logon = new System.Windows.Forms.ToolStripMenuItem();
            this.top_menu_logoff = new System.Windows.Forms.ToolStripMenuItem();
            this.top_products = new System.Windows.Forms.ToolStripMenuItem();
            this.top_products_addProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.top_products_updateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.top_products_removeProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.top_inventory = new System.Windows.Forms.ToolStripMenuItem();
            this.top_maintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.top_maintenance_database = new System.Windows.Forms.ToolStripMenuItem();
            this.top_users = new System.Windows.Forms.ToolStripMenuItem();
            this.top_users_newUser = new System.Windows.Forms.ToolStripMenuItem();
            this.top_users_userManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.pnlStatus_lblUserName = new System.Windows.Forms.Label();
            this.pnlStatus_lblUser = new System.Windows.Forms.Label();
            this.pnlStatus_lblAcessoNum = new System.Windows.Forms.Label();
            this.pnlStatus_lblAcesso = new System.Windows.Forms.Label();
            this.pnlStatus_pbLed = new System.Windows.Forms.PictureBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lstbox_products = new System.Windows.Forms.ListBox();
            this.lblPriceList = new System.Windows.Forms.Label();
            this.lblAmountList = new System.Windows.Forms.Label();
            this.top.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlStatus_pbLed)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.top_menu,
            this.top_products,
            this.top_inventory,
            this.top_users,
            this.top_maintenance});
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(564, 24);
            this.top.TabIndex = 0;
            this.top.Text = "menuStrip1";
            // 
            // top_menu
            // 
            this.top_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.top_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.top_menu_logon,
            this.top_menu_logoff});
            this.top_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_menu.Name = "top_menu";
            this.top_menu.Size = new System.Drawing.Size(53, 20);
            this.top_menu.Text = "Menu";
            // 
            // top_menu_logon
            // 
            this.top_menu_logon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_menu_logon.Name = "top_menu_logon";
            this.top_menu_logon.Size = new System.Drawing.Size(111, 22);
            this.top_menu_logon.Text = "Entrar";
            this.top_menu_logon.Click += new System.EventHandler(this.top_menu_logon_Click);
            // 
            // top_menu_logoff
            // 
            this.top_menu_logoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_menu_logoff.Name = "top_menu_logoff";
            this.top_menu_logoff.Size = new System.Drawing.Size(111, 22);
            this.top_menu_logoff.Text = "Sair";
            this.top_menu_logoff.Visible = false;
            this.top_menu_logoff.Click += new System.EventHandler(this.top_menu_logoff_Click);
            // 
            // top_products
            // 
            this.top_products.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.top_products_addProduct,
            this.top_products_updateProduct,
            this.top_products_removeProduct});
            this.top_products.Name = "top_products";
            this.top_products.Size = new System.Drawing.Size(74, 20);
            this.top_products.Text = "Produtos";
            this.top_products.Visible = false;
            // 
            // top_products_addProduct
            // 
            this.top_products_addProduct.Name = "top_products_addProduct";
            this.top_products_addProduct.Size = new System.Drawing.Size(183, 22);
            this.top_products_addProduct.Text = "Adicionar Produto";
            this.top_products_addProduct.Click += new System.EventHandler(this.top_products_addProduct_Click);
            // 
            // top_products_updateProduct
            // 
            this.top_products_updateProduct.Name = "top_products_updateProduct";
            this.top_products_updateProduct.Size = new System.Drawing.Size(183, 22);
            this.top_products_updateProduct.Text = "Atualizar Produto";
            this.top_products_updateProduct.Click += new System.EventHandler(this.top_products_updateProduct_Click);
            // 
            // top_products_removeProduct
            // 
            this.top_products_removeProduct.Name = "top_products_removeProduct";
            this.top_products_removeProduct.Size = new System.Drawing.Size(183, 22);
            this.top_products_removeProduct.Text = "Remover Produto";
            this.top_products_removeProduct.Click += new System.EventHandler(this.top_products_removeProduct_Click);
            // 
            // top_inventory
            // 
            this.top_inventory.Name = "top_inventory";
            this.top_inventory.Size = new System.Drawing.Size(90, 20);
            this.top_inventory.Text = "Quantidade";
            this.top_inventory.Visible = false;
            this.top_inventory.Click += new System.EventHandler(this.top_inventory_Click);
            // 
            // top_maintenance
            // 
            this.top_maintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.top_maintenance_database});
            this.top_maintenance.Name = "top_maintenance";
            this.top_maintenance.Size = new System.Drawing.Size(94, 20);
            this.top_maintenance.Text = "Manutenção";
            this.top_maintenance.Visible = false;
            // 
            // top_maintenance_database
            // 
            this.top_maintenance_database.Name = "top_maintenance_database";
            this.top_maintenance_database.Size = new System.Drawing.Size(180, 22);
            this.top_maintenance_database.Text = "Banco de dados";
            // 
            // top_users
            // 
            this.top_users.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.top_users_newUser,
            this.top_users_userManagement});
            this.top_users.Name = "top_users";
            this.top_users.Size = new System.Drawing.Size(74, 20);
            this.top_users.Text = "Usuários";
            this.top_users.Visible = false;
            // 
            // top_users_newUser
            // 
            this.top_users_newUser.Name = "top_users_newUser";
            this.top_users_newUser.Size = new System.Drawing.Size(193, 22);
            this.top_users_newUser.Text = "Novo Usuário";
            this.top_users_newUser.Click += new System.EventHandler(this.top_users_newUser_Click);
            // 
            // top_users_userManagement
            // 
            this.top_users_userManagement.Name = "top_users_userManagement";
            this.top_users_userManagement.Size = new System.Drawing.Size(193, 22);
            this.top_users_userManagement.Text = "Gestão de usuários";
            this.top_users_userManagement.Visible = false;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlStatus.Controls.Add(this.pnlStatus_lblUserName);
            this.pnlStatus.Controls.Add(this.pnlStatus_lblUser);
            this.pnlStatus.Controls.Add(this.pnlStatus_lblAcessoNum);
            this.pnlStatus.Controls.Add(this.pnlStatus_lblAcesso);
            this.pnlStatus.Controls.Add(this.pnlStatus_pbLed);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStatus.Location = new System.Drawing.Point(0, 344);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(564, 26);
            this.pnlStatus.TabIndex = 1;
            // 
            // pnlStatus_lblUserName
            // 
            this.pnlStatus_lblUserName.AutoSize = true;
            this.pnlStatus_lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStatus_lblUserName.ForeColor = System.Drawing.Color.White;
            this.pnlStatus_lblUserName.Location = new System.Drawing.Point(173, 4);
            this.pnlStatus_lblUserName.Name = "pnlStatus_lblUserName";
            this.pnlStatus_lblUserName.Size = new System.Drawing.Size(26, 16);
            this.pnlStatus_lblUserName.TabIndex = 1;
            this.pnlStatus_lblUserName.Text = "- - -";
            // 
            // pnlStatus_lblUser
            // 
            this.pnlStatus_lblUser.AutoSize = true;
            this.pnlStatus_lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStatus_lblUser.ForeColor = System.Drawing.Color.White;
            this.pnlStatus_lblUser.Location = new System.Drawing.Point(112, 4);
            this.pnlStatus_lblUser.Name = "pnlStatus_lblUser";
            this.pnlStatus_lblUser.Size = new System.Drawing.Size(58, 16);
            this.pnlStatus_lblUser.TabIndex = 1;
            this.pnlStatus_lblUser.Text = "Usuário:";
            // 
            // pnlStatus_lblAcessoNum
            // 
            this.pnlStatus_lblAcessoNum.AutoSize = true;
            this.pnlStatus_lblAcessoNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStatus_lblAcessoNum.ForeColor = System.Drawing.Color.White;
            this.pnlStatus_lblAcessoNum.Location = new System.Drawing.Point(90, 4);
            this.pnlStatus_lblAcessoNum.Name = "pnlStatus_lblAcessoNum";
            this.pnlStatus_lblAcessoNum.Size = new System.Drawing.Size(15, 16);
            this.pnlStatus_lblAcessoNum.TabIndex = 1;
            this.pnlStatus_lblAcessoNum.Text = "0";
            // 
            // pnlStatus_lblAcesso
            // 
            this.pnlStatus_lblAcesso.AutoSize = true;
            this.pnlStatus_lblAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStatus_lblAcesso.ForeColor = System.Drawing.Color.White;
            this.pnlStatus_lblAcesso.Location = new System.Drawing.Point(30, 4);
            this.pnlStatus_lblAcesso.Name = "pnlStatus_lblAcesso";
            this.pnlStatus_lblAcesso.Size = new System.Drawing.Size(57, 16);
            this.pnlStatus_lblAcesso.TabIndex = 1;
            this.pnlStatus_lblAcesso.Text = "Acesso:";
            // 
            // pnlStatus_pbLed
            // 
            this.pnlStatus_pbLed.Image = global::InventoryControl.Properties.Resources.led_red;
            this.pnlStatus_pbLed.Location = new System.Drawing.Point(3, 2);
            this.pnlStatus_pbLed.Name = "pnlStatus_pbLed";
            this.pnlStatus_pbLed.Size = new System.Drawing.Size(20, 20);
            this.pnlStatus_pbLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlStatus_pbLed.TabIndex = 0;
            this.pnlStatus_pbLed.TabStop = false;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(139, 37);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(69, 18);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Produtos";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(377, 37);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 18);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Preço";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(469, 37);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(83, 18);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Quantidade";
            // 
            // lstbox_products
            // 
            this.lstbox_products.BackColor = System.Drawing.Color.DodgerBlue;
            this.lstbox_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstbox_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbox_products.ForeColor = System.Drawing.Color.White;
            this.lstbox_products.FormattingEnabled = true;
            this.lstbox_products.ItemHeight = 16;
            this.lstbox_products.Location = new System.Drawing.Point(12, 59);
            this.lstbox_products.Name = "lstbox_products";
            this.lstbox_products.Size = new System.Drawing.Size(322, 276);
            this.lstbox_products.TabIndex = 3;
            // 
            // lblPriceList
            // 
            this.lblPriceList.AutoSize = true;
            this.lblPriceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceList.Location = new System.Drawing.Point(375, 60);
            this.lblPriceList.Name = "lblPriceList";
            this.lblPriceList.Size = new System.Drawing.Size(52, 16);
            this.lblPriceList.TabIndex = 4;
            this.lblPriceList.Text = "R$ 0,00";
            this.lblPriceList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmountList
            // 
            this.lblAmountList.AutoSize = true;
            this.lblAmountList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountList.Location = new System.Drawing.Point(503, 60);
            this.lblAmountList.Name = "lblAmountList";
            this.lblAmountList.Size = new System.Drawing.Size(15, 16);
            this.lblAmountList.TabIndex = 2;
            this.lblAmountList.Text = "0";
            this.lblAmountList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(564, 370);
            this.Controls.Add(this.lblPriceList);
            this.Controls.Add(this.lstbox_products);
            this.Controls.Add(this.lblAmountList);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.top);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.top;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Control - v1.1";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlStatus_pbLed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip top;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label pnlStatus_lblUser;
        private System.Windows.Forms.Label pnlStatus_lblAcesso;
        public System.Windows.Forms.Label pnlStatus_lblUserName;
        public System.Windows.Forms.Label pnlStatus_lblAcessoNum;
        public System.Windows.Forms.PictureBox pnlStatus_pbLed;
        public System.Windows.Forms.ToolStripMenuItem top_menu;
        public System.Windows.Forms.ToolStripMenuItem top_menu_logoff;
        public System.Windows.Forms.ToolStripMenuItem top_menu_logon;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPriceList;
        private System.Windows.Forms.Label lblAmountList;
        private System.Windows.Forms.ToolStripMenuItem top_products_addProduct;
        private System.Windows.Forms.ToolStripMenuItem top_products_updateProduct;
        private System.Windows.Forms.ToolStripMenuItem top_products_removeProduct;
        public System.Windows.Forms.ToolStripMenuItem top_products;
        public System.Windows.Forms.ToolStripMenuItem top_inventory;
        public System.Windows.Forms.ListBox lstbox_products;
        private System.Windows.Forms.ToolStripMenuItem top_maintenance_database;
        private System.Windows.Forms.ToolStripMenuItem top_users_newUser;
        private System.Windows.Forms.ToolStripMenuItem top_users_userManagement;
        public System.Windows.Forms.ToolStripMenuItem top_maintenance;
        public System.Windows.Forms.ToolStripMenuItem top_users;
    }
}

