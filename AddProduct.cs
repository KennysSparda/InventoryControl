using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryControl
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string product_name = txtbox_productName.Text;
            string product_price = txtbox_productPrice.Text;
            string product_amount = nudProductAmount.Value.ToString();

            Products.AddNewProduct(product_name, product_price, product_amount);
            MessageBox.Show("Produto adicionado com sucesso");
            txtbox_productName.Text = "";
            txtbox_productPrice.Text = "";
            this.Close();
        }

        private void txtbox_productPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnApply.PerformClick();
            }
        }
    }
}
