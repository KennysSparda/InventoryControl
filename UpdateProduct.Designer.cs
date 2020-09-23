namespace InventoryControl
{
    partial class frmUpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateProduct));
            this.nudProductAmount = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtbox_productPrice = new System.Windows.Forms.TextBox();
            this.txtbox_productName = new System.Windows.Forms.TextBox();
            this.lblProductAmount = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // nudProductAmount
            // 
            this.nudProductAmount.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudProductAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProductAmount.ForeColor = System.Drawing.Color.White;
            this.nudProductAmount.Location = new System.Drawing.Point(72, 66);
            this.nudProductAmount.Name = "nudProductAmount";
            this.nudProductAmount.Size = new System.Drawing.Size(48, 18);
            this.nudProductAmount.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(219, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 22);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(126, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 22);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtbox_productPrice
            // 
            this.txtbox_productPrice.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_productPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_productPrice.ForeColor = System.Drawing.Color.White;
            this.txtbox_productPrice.Location = new System.Drawing.Point(126, 37);
            this.txtbox_productPrice.Name = "txtbox_productPrice";
            this.txtbox_productPrice.Size = new System.Drawing.Size(180, 22);
            this.txtbox_productPrice.TabIndex = 9;
            this.txtbox_productPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_productPrice_KeyDown);
            // 
            // txtbox_productName
            // 
            this.txtbox_productName.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_productName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_productName.ForeColor = System.Drawing.Color.White;
            this.txtbox_productName.Location = new System.Drawing.Point(126, 12);
            this.txtbox_productName.Name = "txtbox_productName";
            this.txtbox_productName.Size = new System.Drawing.Size(180, 22);
            this.txtbox_productName.TabIndex = 5;
            // 
            // lblProductAmount
            // 
            this.lblProductAmount.AutoSize = true;
            this.lblProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductAmount.ForeColor = System.Drawing.Color.White;
            this.lblProductAmount.Location = new System.Drawing.Point(18, 66);
            this.lblProductAmount.Name = "lblProductAmount";
            this.lblProductAmount.Size = new System.Drawing.Size(36, 16);
            this.lblProductAmount.TabIndex = 6;
            this.lblProductAmount.Text = "Qntd";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.White;
            this.lblProductPrice.Location = new System.Drawing.Point(7, 40);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(113, 16);
            this.lblProductPrice.TabIndex = 7;
            this.lblProductPrice.Text = "Preço do Produto";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(7, 15);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(114, 16);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Text = "Nome do Produto";
            // 
            // frmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(312, 99);
            this.Controls.Add(this.nudProductAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtbox_productPrice);
            this.Controls.Add(this.txtbox_productName);
            this.Controls.Add(this.lblProductAmount);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.nudProductAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblProductAmount;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        public System.Windows.Forms.NumericUpDown nudProductAmount;
        public System.Windows.Forms.TextBox txtbox_productPrice;
        public System.Windows.Forms.TextBox txtbox_productName;
    }
}