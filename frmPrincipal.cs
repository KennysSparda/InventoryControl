using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryControl
{
    public partial class frmPrincipal : Form
    {
        // Creating new DataTable for using with database command
        DataTable dt = new DataTable();

        public void ReloadComponents()
        {
            lstbox_products.Items.Clear();
            lblPriceList.Text = "";
            lblAmountList.Text = "";

            string sql = "SELECT * FROM tb_products";
            dt = database.DataBaseCommand(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lstbox_products.Items.Add(dt.Rows[i].Field<string>("PRODUCT_NAME"));

                lblPriceList.Text += "R$: " + dt.Rows[i].Field<decimal>("PRODUCT_PRICE") + "\r\n";
                lblAmountList.Text += dt.Rows[i].Field<Int64>("PRODUCT_AMOUNT").ToString() + "\r\n";
            }
        }

        public frmPrincipal()
        {
            InitializeComponent();
            frmLogin f_login = new frmLogin(this);
            f_login.ShowDialog();
            ReloadComponents();
        }

        private void top_menu_logon_Click(object sender, EventArgs e)
        {
            // Call the main form
            frmLogin f_login = new frmLogin(this);
            f_login.ShowDialog();
        }

        private void top_menu_logoff_Click(object sender, EventArgs e)
        {
            // Seting all the values to default
            Global.logged = false;
            Global.level = 0;
            pnlStatus_lblAcessoNum.Text = Global.level.ToString();
            pnlStatus_lblUserName.Text = "- - -";
            pnlStatus_pbLed.Image = Properties.Resources.led_red;
            top_menu_logon.Visible = true;
            top_menu_logoff.Visible = false;
            top_maintenance.Visible = false;
            top_inventory.Visible = false;
            top_products.Visible = false;
            top_users.Visible = false;
        }

        private void top_products_addProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct addproduct = new frmAddProduct();
            addproduct.ShowDialog();
            ReloadComponents();
        }

        private void top_products_updateProduct_Click(object sender, EventArgs e)
        {
            if (lstbox_products.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item para modifica-lo");
                return;
            }
            frmUpdateProduct updateProduct = new frmUpdateProduct(this);
            updateProduct.ShowDialog();
            ReloadComponents();
        }

        private void top_products_removeProduct_Click(object sender, EventArgs e)
        {
            if (lstbox_products.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item para modifica-lo");
                return;
            }

            string selected = lstbox_products.SelectedItem.ToString();
            if (MessageBox.Show("Deseja excluir este produto ? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Products.RemoveProduct(selected);
            }

            ReloadComponents();
        }

        private void top_inventory_Click(object sender, EventArgs e)
        {
            if (lstbox_products.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item para modifica-lo");
                return;
            }

            frmInventory inventory = new frmInventory(this);
            inventory.ShowDialog();

            ReloadComponents();
        }

        private void top_users_newUser_Click(object sender, EventArgs e)
        {
            frmSignUp signup = new frmSignUp();
            signup.ShowDialog();
        }
    }
}
