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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtbox_password.Text != txtbox_confirm_password.Text)
            {
                MessageBox.Show("Essas senhas não coincidem!");
                return;
            }

            user newuser = new user();
            newuser.user_name = txtbox_username.Text;
            newuser.user_password = txtbox_password.Text;
            newuser.user_level = Convert.ToInt32(Math.Round(nud_level.Value, 0));

            database.newUser(newuser);
            txtbox_username.Clear();
            txtbox_password.Clear();
            txtbox_confirm_password.Clear();
            nud_level.Value = 0;
            this.Close();
        }
    }
}
