using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mascaras
{
    public partial class frm_principal : Form
    {
        DataTable dt = new DataTable();

        public frm_principal()
        {
            InitializeComponent();

            string sql = "SELECT * FROM tb_produtos";
            dt = Banco.Consulta(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lstbox_produtos_nome.Items.Add(dt.Rows[i].Field<string>("T_NOMEPRODUTO"));

                txtbox_produtos_valor.Text += "R$: " + dt.Rows[i].Field<decimal>("D_VALORPRODUTO") + "\r\n";
                txtbox_estoque_produtos_qntd.Text += dt.Rows[i].Field<Int64>("N_QUANTIDADEPRODUTO").ToString() + "\r\n";
            }
        }
        private void btn_add_produto_Click(object sender, EventArgs e)
        {
            if (txtbox_add_produto_nome.Text == "" || txtbox_add_produto_valor.Text == "")
            {
                MessageBox.Show("Nome do produto e ou valor inválido");
                txtbox_add_produto_nome.Focus();
                return;
            }

            string add_produto_nome = txtbox_add_produto_nome.Text;
            string add_produto_valor = txtbox_add_produto_valor.Text;

            dt = Banco.Consulta("SELECT * FROM tb_produtos WHERE T_NOMEPRODUTO='"+add_produto_nome+"'");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Nome inserido já está sendo utilizado");
                txtbox_add_produto_nome.Focus();
                return;
            }

            txtbox_add_produto_valor.Clear();
            txtbox_add_produto_nome.Clear();

            lstbox_produtos_nome.Items.Clear();

            txtbox_produtos_valor.Clear();
            txtbox_estoque_produtos_qntd.Clear();

            Banco.Consulta("INSERT INTO tb_produtos(T_NOMEPRODUTO, D_VALORPRODUTO, N_QUANTIDADEPRODUTO) VALUES('" + add_produto_nome + "', '" + add_produto_valor + "', 0);");

            dt = Banco.Consulta("SELECT * FROM tb_produtos");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lstbox_produtos_nome.Items.Add(dt.Rows[i].Field<string>("T_NOMEPRODUTO"));

                txtbox_produtos_valor.Text += "R$: " + dt.Rows[i].Field<decimal>("D_VALORPRODUTO") + "\r\n";
                txtbox_estoque_produtos_qntd.Text += dt.Rows[i].Field<Int64>("N_QUANTIDADEPRODUTO").ToString() + "\r\n";
            }
        }

        private void btn_att_produto_Click(object sender, EventArgs e)
        {
            if (lstbox_produtos_nome.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum produto foi selecionado.");
                return;
            }
            else if (txtbox_add_produto_nome.Text == "" || txtbox_add_produto_valor.Text == "")
            {
                MessageBox.Show("Nome do produto e ou valor inválido");
                txtbox_add_produto_nome.Focus();
                return;
            }
            string att_produto = lstbox_produtos_nome.SelectedItem.ToString();

            string att_produto_new_name = txtbox_add_produto_nome.Text;
            string att_produto_new_valor = txtbox_add_produto_valor.Text;

            Banco.Consulta("UPDATE tb_produtos SET T_NOMEPRODUTO='" + att_produto_new_name + "', D_VALORPRODUTO='" + att_produto_new_valor + "' WHERE T_NOMEPRODUTO='" + att_produto + "'; ");

            txtbox_add_produto_nome.Clear();
            txtbox_add_produto_valor.Clear();
            
            lstbox_produtos_nome.Items.Clear();

            txtbox_produtos_valor.Clear();
            txtbox_estoque_produtos_qntd.Clear();

            dt = Banco.Consulta("SELECT * FROM tb_produtos");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lstbox_produtos_nome.Items.Add(dt.Rows[i].Field<string>("T_NOMEPRODUTO"));

                txtbox_produtos_valor.Text += "R$: " + dt.Rows[i].Field<decimal>("D_VALORPRODUTO") + "\r\n";
                txtbox_estoque_produtos_qntd.Text += dt.Rows[i].Field<Int64>("N_QUANTIDADEPRODUTO").ToString() + "\r\n";
            }
        }

        private void btn_rem_produto_Click(object sender, EventArgs e)
        {
            if (lstbox_produtos_nome.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum produto foi selecionado.");
                return;
            }
            string rem_produto = lstbox_produtos_nome.SelectedItem.ToString();
            dt = Banco.Consulta("DELETE FROM tb_produtos WHERE T_NOMEPRODUTO='" + rem_produto + "';");

            lstbox_produtos_nome.Items.Clear();

            txtbox_produtos_valor.Clear();
            txtbox_estoque_produtos_qntd.Clear();

            dt = Banco.Consulta("SELECT * FROM tb_produtos");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lstbox_produtos_nome.Items.Add(dt.Rows[i].Field<string>("T_NOMEPRODUTO"));

                txtbox_produtos_valor.Text += "R$: " + dt.Rows[i].Field<decimal>("D_VALORPRODUTO") + "\r\n";
                txtbox_estoque_produtos_qntd.Text += dt.Rows[i].Field<Int64>("N_QUANTIDADEPRODUTO").ToString() + "\r\n";
            }
        }

        private void btn_estoque_aplicar_Click(object sender, EventArgs e)
        {
            string estoque_nome = lstbox_produtos_nome.SelectedItem.ToString();
            int estoque_qntd = int.Parse(nud_estoque_qntd.Value.ToString());

            Banco.Consulta("UPDATE tb_produtos SET N_QUANTIDADEPRODUTO='"+estoque_qntd+"' WHERE T_NOMEPRODUTO='"+estoque_nome+"';");

            lstbox_produtos_nome.Items.Clear();

            txtbox_produtos_valor.Clear();
            txtbox_estoque_produtos_qntd.Clear();

            dt = Banco.Consulta("SELECT * FROM tb_produtos");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lstbox_produtos_nome.Items.Add(dt.Rows[i].Field<string>("T_NOMEPRODUTO"));

                txtbox_produtos_valor.Text += "R$: " + dt.Rows[i].Field<decimal>("D_VALORPRODUTO") + "\r\n";
                txtbox_estoque_produtos_qntd.Text += dt.Rows[i].Field<Int64>("N_QUANTIDADEPRODUTO").ToString() + "\r\n";
            }
        }
    }
}
