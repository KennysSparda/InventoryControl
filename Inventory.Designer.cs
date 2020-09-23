namespace InventoryControl
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.lbl_product_amount = new System.Windows.Forms.Label();
            this.nud_product_amount = new System.Windows.Forms.NumericUpDown();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_product_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_product_amount
            // 
            this.lbl_product_amount.AutoSize = true;
            this.lbl_product_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_amount.Location = new System.Drawing.Point(12, 23);
            this.lbl_product_amount.Name = "lbl_product_amount";
            this.lbl_product_amount.Size = new System.Drawing.Size(181, 20);
            this.lbl_product_amount.TabIndex = 0;
            this.lbl_product_amount.Text = "Quantidade de produtos";
            // 
            // nud_product_amount
            // 
            this.nud_product_amount.BackColor = System.Drawing.Color.RoyalBlue;
            this.nud_product_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nud_product_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_product_amount.ForeColor = System.Drawing.Color.White;
            this.nud_product_amount.Location = new System.Drawing.Point(16, 50);
            this.nud_product_amount.Name = "nud_product_amount";
            this.nud_product_amount.Size = new System.Drawing.Size(177, 25);
            this.nud_product_amount.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(209, 23);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Aplicar";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(209, 52);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(312, 99);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.nud_product_amount);
            this.Controls.Add(this.lbl_product_amount);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.nud_product_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_product_amount;
        private System.Windows.Forms.NumericUpDown nud_product_amount;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}