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
    public partial class frmInventory : Form
    {
        // Creating new DataTable for using with database command
        DataTable dt = new DataTable();

        frmPrincipal frmprincipal;

        public frmInventory(frmPrincipal f)
        {
            InitializeComponent();
            frmprincipal = f;

            string selected = frmprincipal.lstbox_products.SelectedItem.ToString();
            string sql = "SELECT * FROM tb_products WHERE PRODUCT_NAME='"+selected+"'";
            dt = database.DataBaseCommand(sql);
            nud_product_amount.Value = decimal.Parse(dt.Rows[0].ItemArray[3].ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            
            
            string amount = nud_product_amount.Value.ToString();
            string selected = frmprincipal.lstbox_products.SelectedItem.ToString();
            string sql = "UPDATE tb_products SET PRODUCT_AMOUNT='" + amount + "' WHERE PRODUCT_NAME='" + selected + "'; ";
            database.DataBaseCommand(sql);
            MessageBox.Show("Feito!");
            
            
            this.Close();
        }
    }
}
