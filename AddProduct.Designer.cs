namespace InventoryControl
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtbox_productName = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtbox_productPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudProductAmount = new System.Windows.Forms.NumericUpDown();
            this.lblProductAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(1, 16);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(114, 16);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Nome do Produto";
            // 
            // txtbox_productName
            // 
            this.txtbox_productName.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_productName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_productName.ForeColor = System.Drawing.Color.White;
            this.txtbox_productName.Location = new System.Drawing.Point(120, 13);
            this.txtbox_productName.Name = "txtbox_productName";
            this.txtbox_productName.Size = new System.Drawing.Size(180, 22);
            this.txtbox_productName.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(120, 66);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(87, 22);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Aplicar";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.White;
            this.lblProductPrice.Location = new System.Drawing.Point(1, 41);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(113, 16);
            this.lblProductPrice.TabIndex = 0;
            this.lblProductPrice.Text = "Preço do Produto";
            // 
            // txtbox_productPrice
            // 
            this.txtbox_productPrice.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_productPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_productPrice.ForeColor = System.Drawing.Color.White;
            this.txtbox_productPrice.Location = new System.Drawing.Point(120, 38);
            this.txtbox_productPrice.Name = "txtbox_productPrice";
            this.txtbox_productPrice.Size = new System.Drawing.Size(180, 22);
            this.txtbox_productPrice.TabIndex = 1;
            this.txtbox_productPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_productPrice_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(213, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 22);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudProductAmount
            // 
            this.nudProductAmount.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudProductAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProductAmount.ForeColor = System.Drawing.Color.White;
            this.nudProductAmount.Location = new System.Drawing.Point(66, 67);
            this.nudProductAmount.Name = "nudProductAmount";
            this.nudProductAmount.Size = new System.Drawing.Size(48, 18);
            this.nudProductAmount.TabIndex = 4;
            // 
            // lblProductAmount
            // 
            this.lblProductAmount.AutoSize = true;
            this.lblProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductAmount.ForeColor = System.Drawing.Color.White;
            this.lblProductAmount.Location = new System.Drawing.Point(12, 67);
            this.lblProductAmount.Name = "lblProductAmount";
            this.lblProductAmount.Size = new System.Drawing.Size(36, 16);
            this.lblProductAmount.TabIndex = 0;
            this.lblProductAmount.Text = "Qntd";
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(312, 99);
            this.Controls.Add(this.nudProductAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtbox_productPrice);
            this.Controls.Add(this.txtbox_productName);
            this.Controls.Add(this.lblProductAmount);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.nudProductAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtbox_productName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtbox_productPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudProductAmount;
        private System.Windows.Forms.Label lblProductAmount;
    }
}