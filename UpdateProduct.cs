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
    public partial class frmUpdateProduct : Form
    {
        frmPrincipal frmprincipal;

        public frmUpdateProduct(frmPrincipal f)
        {
            // Creating new DataTable for using with database command
            DataTable dt = new DataTable();

            InitializeComponent();
            frmprincipal = f;

            txtbox_productName.Text = frmprincipal.lstbox_products.SelectedItem.ToString();
            string selected = frmprincipal.lstbox_products.SelectedItem.ToString();
            string sql = "SELECT * FROM tb_products WHERE PRODUCT_NAME='" + selected + "'";
            dt = database.DataBaseCommand(sql);
            txtbox_productPrice.Text = dt.Rows[0].ItemArray[2].ToString();
            nudProductAmount.Value = decimal.Parse(dt.Rows[0].ItemArray[3].ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtbox_productName.Text == "")
            {
                MessageBox.Show("Nome do produto inválido");
                return;
            }
            else if (txtbox_productPrice.Text == "")
            {
                MessageBox.Show("Preço do produto inválido");
                return;
            }
            string productName = frmprincipal.lstbox_products.SelectedItem.ToString();
            string newProductName = txtbox_productName.Text;
            string newProductPrice = txtbox_productPrice.Text;
            string newProductAmount = nudProductAmount.Value.ToString();
            
            Products.UpdateProduct(productName, newProductName, newProductPrice, newProductAmount);

            MessageBox.Show("Produto atualizado com sucesso!");

            txtbox_productName.Clear();
            txtbox_productPrice.Clear();
            nudProductAmount.Value = 0;
            
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbox_productPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
            }
        }
    }
}
