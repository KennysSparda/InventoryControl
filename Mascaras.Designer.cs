namespace Mascaras
{
    partial class frm_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.painel_produtos = new System.Windows.Forms.Panel();
            this.txtbox_produtos_valor = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_produtos = new System.Windows.Forms.Label();
            this.lstbox_produtos_nome = new System.Windows.Forms.ListBox();
            this.painel_estoque = new System.Windows.Forms.Panel();
            this.txtbox_estoque_produtos_qntd = new System.Windows.Forms.TextBox();
            this.lbl_estoque_qntd = new System.Windows.Forms.Label();
            this.painel_toolbox_produtos = new System.Windows.Forms.Panel();
            this.txtbox_add_produto_valor = new System.Windows.Forms.TextBox();
            this.txtbox_add_produto_nome = new System.Windows.Forms.TextBox();
            this.lbl_add_produto_valor = new System.Windows.Forms.Label();
            this.btn_add_produto = new System.Windows.Forms.Button();
            this.btn_att_produto = new System.Windows.Forms.Button();
            this.btn_rem_produto = new System.Windows.Forms.Button();
            this.lbl_add_produto_name = new System.Windows.Forms.Label();
            this.nud_estoque_qntd = new System.Windows.Forms.NumericUpDown();
            this.btn_estoque_aplicar = new System.Windows.Forms.Button();
            this.painel_toolbox_estoque = new System.Windows.Forms.Panel();
            this.painel_produtos.SuspendLayout();
            this.painel_estoque.SuspendLayout();
            this.painel_toolbox_produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_estoque_qntd)).BeginInit();
            this.painel_toolbox_estoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_produtos
            // 
            this.painel_produtos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.painel_produtos.Controls.Add(this.txtbox_produtos_valor);
            this.painel_produtos.Controls.Add(this.lbl_valor);
            this.painel_produtos.Controls.Add(this.lbl_produtos);
            this.painel_produtos.Controls.Add(this.lstbox_produtos_nome);
            this.painel_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painel_produtos.Location = new System.Drawing.Point(12, 12);
            this.painel_produtos.Name = "painel_produtos";
            this.painel_produtos.Size = new System.Drawing.Size(485, 347);
            this.painel_produtos.TabIndex = 4;
            // 
            // txtbox_produtos_valor
            // 
            this.txtbox_produtos_valor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbox_produtos_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_produtos_valor.Location = new System.Drawing.Point(313, 52);
            this.txtbox_produtos_valor.Multiline = true;
            this.txtbox_produtos_valor.Name = "txtbox_produtos_valor";
            this.txtbox_produtos_valor.ReadOnly = true;
            this.txtbox_produtos_valor.Size = new System.Drawing.Size(153, 282);
            this.txtbox_produtos_valor.TabIndex = 2;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(363, 24);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(46, 20);
            this.lbl_valor.TabIndex = 0;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_produtos
            // 
            this.lbl_produtos.AutoSize = true;
            this.lbl_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtos.Location = new System.Drawing.Point(121, 24);
            this.lbl_produtos.Name = "lbl_produtos";
            this.lbl_produtos.Size = new System.Drawing.Size(73, 20);
            this.lbl_produtos.TabIndex = 0;
            this.lbl_produtos.Text = "Produtos";
            // 
            // lstbox_produtos_nome
            // 
            this.lstbox_produtos_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbox_produtos_nome.FormattingEnabled = true;
            this.lstbox_produtos_nome.ItemHeight = 20;
            this.lstbox_produtos_nome.Location = new System.Drawing.Point(22, 50);
            this.lstbox_produtos_nome.Name = "lstbox_produtos_nome";
            this.lstbox_produtos_nome.Size = new System.Drawing.Size(270, 284);
            this.lstbox_produtos_nome.TabIndex = 1;
            // 
            // painel_estoque
            // 
            this.painel_estoque.BackColor = System.Drawing.SystemColors.ControlLight;
            this.painel_estoque.Controls.Add(this.txtbox_estoque_produtos_qntd);
            this.painel_estoque.Controls.Add(this.lbl_estoque_qntd);
            this.painel_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painel_estoque.Location = new System.Drawing.Point(503, 12);
            this.painel_estoque.Name = "painel_estoque";
            this.painel_estoque.Size = new System.Drawing.Size(134, 347);
            this.painel_estoque.TabIndex = 5;
            // 
            // txtbox_estoque_produtos_qntd
            // 
            this.txtbox_estoque_produtos_qntd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_estoque_produtos_qntd.Location = new System.Drawing.Point(23, 52);
            this.txtbox_estoque_produtos_qntd.Multiline = true;
            this.txtbox_estoque_produtos_qntd.Name = "txtbox_estoque_produtos_qntd";
            this.txtbox_estoque_produtos_qntd.ReadOnly = true;
            this.txtbox_estoque_produtos_qntd.Size = new System.Drawing.Size(88, 282);
            this.txtbox_estoque_produtos_qntd.TabIndex = 3;
            this.txtbox_estoque_produtos_qntd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_estoque_qntd
            // 
            this.lbl_estoque_qntd.AutoSize = true;
            this.lbl_estoque_qntd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estoque_qntd.Location = new System.Drawing.Point(19, 23);
            this.lbl_estoque_qntd.Name = "lbl_estoque_qntd";
            this.lbl_estoque_qntd.Size = new System.Drawing.Size(92, 20);
            this.lbl_estoque_qntd.TabIndex = 1;
            this.lbl_estoque_qntd.Text = "Quantidade";
            // 
            // painel_toolbox_produtos
            // 
            this.painel_toolbox_produtos.Controls.Add(this.txtbox_add_produto_valor);
            this.painel_toolbox_produtos.Controls.Add(this.txtbox_add_produto_nome);
            this.painel_toolbox_produtos.Controls.Add(this.lbl_add_produto_valor);
            this.painel_toolbox_produtos.Controls.Add(this.btn_add_produto);
            this.painel_toolbox_produtos.Controls.Add(this.btn_att_produto);
            this.painel_toolbox_produtos.Controls.Add(this.btn_rem_produto);
            this.painel_toolbox_produtos.Controls.Add(this.lbl_add_produto_name);
            this.painel_toolbox_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painel_toolbox_produtos.Location = new System.Drawing.Point(12, 365);
            this.painel_toolbox_produtos.Name = "painel_toolbox_produtos";
            this.painel_toolbox_produtos.Size = new System.Drawing.Size(485, 139);
            this.painel_toolbox_produtos.TabIndex = 6;
            // 
            // txtbox_add_produto_valor
            // 
            this.txtbox_add_produto_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_add_produto_valor.Location = new System.Drawing.Point(11, 91);
            this.txtbox_add_produto_valor.Name = "txtbox_add_produto_valor";
            this.txtbox_add_produto_valor.Size = new System.Drawing.Size(262, 26);
            this.txtbox_add_produto_valor.TabIndex = 1;
            // 
            // txtbox_add_produto_nome
            // 
            this.txtbox_add_produto_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_add_produto_nome.Location = new System.Drawing.Point(11, 39);
            this.txtbox_add_produto_nome.Name = "txtbox_add_produto_nome";
            this.txtbox_add_produto_nome.Size = new System.Drawing.Size(262, 26);
            this.txtbox_add_produto_nome.TabIndex = 0;
            // 
            // lbl_add_produto_valor
            // 
            this.lbl_add_produto_valor.AutoSize = true;
            this.lbl_add_produto_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_produto_valor.Location = new System.Drawing.Point(7, 68);
            this.lbl_add_produto_valor.Name = "lbl_add_produto_valor";
            this.lbl_add_produto_valor.Size = new System.Drawing.Size(165, 20);
            this.lbl_add_produto_valor.TabIndex = 1;
            this.lbl_add_produto_valor.Text = "Valor do novo produto";
            // 
            // btn_add_produto
            // 
            this.btn_add_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_produto.Location = new System.Drawing.Point(313, 16);
            this.btn_add_produto.Name = "btn_add_produto";
            this.btn_add_produto.Size = new System.Drawing.Size(153, 36);
            this.btn_add_produto.TabIndex = 2;
            this.btn_add_produto.Text = "Adicionar Produto";
            this.btn_add_produto.UseVisualStyleBackColor = true;
            this.btn_add_produto.Click += new System.EventHandler(this.btn_add_produto_Click);
            // 
            // btn_att_produto
            // 
            this.btn_att_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_att_produto.Location = new System.Drawing.Point(313, 52);
            this.btn_att_produto.Name = "btn_att_produto";
            this.btn_att_produto.Size = new System.Drawing.Size(153, 36);
            this.btn_att_produto.TabIndex = 3;
            this.btn_att_produto.Text = "Atualizar Produto";
            this.btn_att_produto.UseVisualStyleBackColor = true;
            this.btn_att_produto.Click += new System.EventHandler(this.btn_att_produto_Click);
            // 
            // btn_rem_produto
            // 
            this.btn_rem_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rem_produto.Location = new System.Drawing.Point(313, 86);
            this.btn_rem_produto.Name = "btn_rem_produto";
            this.btn_rem_produto.Size = new System.Drawing.Size(153, 36);
            this.btn_rem_produto.TabIndex = 3;
            this.btn_rem_produto.Text = "Remover Produto";
            this.btn_rem_produto.UseVisualStyleBackColor = true;
            this.btn_rem_produto.Click += new System.EventHandler(this.btn_rem_produto_Click);
            // 
            // lbl_add_produto_name
            // 
            this.lbl_add_produto_name.AutoSize = true;
            this.lbl_add_produto_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_produto_name.Location = new System.Drawing.Point(7, 16);
            this.lbl_add_produto_name.Name = "lbl_add_produto_name";
            this.lbl_add_produto_name.Size = new System.Drawing.Size(170, 20);
            this.lbl_add_produto_name.TabIndex = 1;
            this.lbl_add_produto_name.Text = "Nome do novo produto";
            // 
            // nud_estoque_qntd
            // 
            this.nud_estoque_qntd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_estoque_qntd.Location = new System.Drawing.Point(23, 16);
            this.nud_estoque_qntd.Name = "nud_estoque_qntd";
            this.nud_estoque_qntd.Size = new System.Drawing.Size(88, 26);
            this.nud_estoque_qntd.TabIndex = 3;
            // 
            // btn_estoque_aplicar
            // 
            this.btn_estoque_aplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estoque_aplicar.Location = new System.Drawing.Point(23, 86);
            this.btn_estoque_aplicar.Name = "btn_estoque_aplicar";
            this.btn_estoque_aplicar.Size = new System.Drawing.Size(88, 36);
            this.btn_estoque_aplicar.TabIndex = 4;
            this.btn_estoque_aplicar.Text = "Aplicar";
            this.btn_estoque_aplicar.UseVisualStyleBackColor = true;
            this.btn_estoque_aplicar.Click += new System.EventHandler(this.btn_estoque_aplicar_Click);
            // 
            // painel_toolbox_estoque
            // 
            this.painel_toolbox_estoque.Controls.Add(this.btn_estoque_aplicar);
            this.painel_toolbox_estoque.Controls.Add(this.nud_estoque_qntd);
            this.painel_toolbox_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painel_toolbox_estoque.Location = new System.Drawing.Point(503, 365);
            this.painel_toolbox_estoque.Name = "painel_toolbox_estoque";
            this.painel_toolbox_estoque.Size = new System.Drawing.Size(134, 139);
            this.painel_toolbox_estoque.TabIndex = 6;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(644, 510);
            this.Controls.Add(this.painel_toolbox_estoque);
            this.Controls.Add(this.painel_produtos);
            this.Controls.Add(this.painel_estoque);
            this.Controls.Add(this.painel_toolbox_produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lekyw Mask";
            this.painel_produtos.ResumeLayout(false);
            this.painel_produtos.PerformLayout();
            this.painel_estoque.ResumeLayout(false);
            this.painel_estoque.PerformLayout();
            this.painel_toolbox_produtos.ResumeLayout(false);
            this.painel_toolbox_produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_estoque_qntd)).EndInit();
            this.painel_toolbox_estoque.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel painel_produtos;
        private System.Windows.Forms.Panel painel_estoque;
        private System.Windows.Forms.Panel painel_toolbox_produtos;
        private System.Windows.Forms.Panel painel_toolbox_estoque;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_produtos;
        private System.Windows.Forms.Label lbl_add_produto_valor;
        private System.Windows.Forms.Label lbl_add_produto_name;
        private System.Windows.Forms.Label lbl_estoque_qntd;
        private System.Windows.Forms.Button btn_add_produto;
        private System.Windows.Forms.Button btn_att_produto;
        private System.Windows.Forms.Button btn_rem_produto;
        private System.Windows.Forms.Button btn_estoque_aplicar;
        private System.Windows.Forms.ListBox lstbox_produtos_nome;
        private System.Windows.Forms.TextBox txtbox_add_produto_valor;
        private System.Windows.Forms.TextBox txtbox_add_produto_nome;
        private System.Windows.Forms.TextBox txtbox_produtos_valor;
        private System.Windows.Forms.TextBox txtbox_estoque_produtos_qntd;
        private System.Windows.Forms.NumericUpDown nud_estoque_qntd;
    }
}

