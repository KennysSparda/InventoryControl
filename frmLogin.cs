using InventoryControl.Properties;
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
    public partial class frmLogin : Form
    {
        // Creating new DataTable for using with database command
        DataTable dt = new DataTable();
        
        frmPrincipal frmprincipal;

        public frmLogin(frmPrincipal f)
        {
            InitializeComponent();
            frmprincipal = f;
        }

        public void login()
        {
            txtboxUsername.Focus();
            // Reading username and password from txtbox's
            string username = txtboxUsername.Text;
            string password = txtboxPassword.Text;

            // Checking if username field is empty
            if (username == "")
            { MessageBox.Show("Usuário está vazio!"); txtboxUsername.Focus(); return; }

            // Checking if password field is empty
            else if (password == "") { MessageBox.Show("Senha está vazia"); txtboxPassword.Focus(); return; }

            // Calling database to search for user and password correspondence
            string sql = "SELECT * FROM tb_users WHERE USER_NAME='" + username + "' AND USER_PASSWORD='" + password + "'";
            dt = database.DataBaseCommand(sql);
            if (dt.Rows.Count == 1)
            {
                // Change all the properties to log on
                frmprincipal.pnlStatus_lblAcessoNum.Text = dt.Rows[0].ItemArray[3].ToString();
                frmprincipal.pnlStatus_lblUserName.Text = dt.Rows[0].ItemArray[1].ToString();
                frmprincipal.pnlStatus_pbLed.Image = Properties.Resources.led_green;
                Global.level = int.Parse(dt.Rows[0].ItemArray[3].ToString());
                Global.logged = true;
                frmprincipal.top_menu_logoff.Visible = true;
                frmprincipal.top_menu_logon.Visible = false;
                if (Global.level > 0)
                {
                    frmprincipal.top_inventory.Visible = true;
                }
                if (Global.level > 1)
                {
                    frmprincipal.top_products.Visible = true;
                    
                }
                if (Global.level > 2)
                {
                    frmprincipal.top_users.Visible = true;
                    frmprincipal.top_maintenance.Visible = true;
                }
                this.Close();
            }
            else
            {
                // Show the ERROR message
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Call function login
            login();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close
            this.Close();
        }

        private void txtboxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Shortcut for function login when press Enter key
            if(e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
