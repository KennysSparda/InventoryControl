namespace InventoryControl
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtbox_confirm_password = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nud_level = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lbllevel1 = new System.Windows.Forms.Label();
            this.lbllevel2 = new System.Windows.Forms.Label();
            this.lbllevel3 = new System.Windows.Forms.Label();
            this.lblLevels = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(98, 216);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Nome de usuário";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbox_confirm_password
            // 
            this.txtbox_confirm_password.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_confirm_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_confirm_password.ForeColor = System.Drawing.Color.White;
            this.txtbox_confirm_password.Location = new System.Drawing.Point(368, 235);
            this.txtbox_confirm_password.Name = "txtbox_confirm_password";
            this.txtbox_confirm_password.Size = new System.Drawing.Size(100, 22);
            this.txtbox_confirm_password.TabIndex = 2;
            this.txtbox_confirm_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_confirm_password.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(289, 216);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(47, 16);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Senha";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbox_password
            // 
            this.txtbox_password.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_password.ForeColor = System.Drawing.Color.White;
            this.txtbox_password.Location = new System.Drawing.Point(262, 235);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(100, 22);
            this.txtbox_password.TabIndex = 1;
            this.txtbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_password.UseSystemPasswordChar = true;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(204, 322);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Aplicar";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(285, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nud_level
            // 
            this.nud_level.BackColor = System.Drawing.Color.DodgerBlue;
            this.nud_level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nud_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_level.ForeColor = System.Drawing.Color.White;
            this.nud_level.Location = new System.Drawing.Point(474, 235);
            this.nud_level.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_level.Name = "nud_level";
            this.nud_level.Size = new System.Drawing.Size(41, 22);
            this.nud_level.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryControl.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(82, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtbox_username
            // 
            this.txtbox_username.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_username.ForeColor = System.Drawing.Color.White;
            this.txtbox_username.Location = new System.Drawing.Point(50, 235);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(206, 22);
            this.txtbox_username.TabIndex = 0;
            this.txtbox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(365, 216);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(107, 16);
            this.lblConfirmPassword.TabIndex = 0;
            this.lblConfirmPassword.Text = "Confirmar Senha";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(475, 216);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(39, 16);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Nível";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbllevel1
            // 
            this.lbllevel1.AutoSize = true;
            this.lbllevel1.BackColor = System.Drawing.Color.Transparent;
            this.lbllevel1.ForeColor = System.Drawing.Color.White;
            this.lbllevel1.Location = new System.Drawing.Point(471, 296);
            this.lbllevel1.Name = "lbllevel1";
            this.lbllevel1.Size = new System.Drawing.Size(67, 16);
            this.lbllevel1.TabIndex = 0;
            this.lbllevel1.Text = "1 - Básico";
            this.lbllevel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbllevel2
            // 
            this.lbllevel2.AutoSize = true;
            this.lbllevel2.BackColor = System.Drawing.Color.Transparent;
            this.lbllevel2.ForeColor = System.Drawing.Color.White;
            this.lbllevel2.Location = new System.Drawing.Point(471, 312);
            this.lbllevel2.Name = "lbllevel2";
            this.lbllevel2.Size = new System.Drawing.Size(73, 16);
            this.lbllevel2.TabIndex = 0;
            this.lbllevel2.Text = "2 - Gerente";
            this.lbllevel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbllevel3
            // 
            this.lbllevel3.AutoSize = true;
            this.lbllevel3.BackColor = System.Drawing.Color.Transparent;
            this.lbllevel3.ForeColor = System.Drawing.Color.White;
            this.lbllevel3.Location = new System.Drawing.Point(471, 328);
            this.lbllevel3.Name = "lbllevel3";
            this.lbllevel3.Size = new System.Drawing.Size(66, 16);
            this.lbllevel3.TabIndex = 0;
            this.lbllevel3.Text = "3 - Master";
            this.lbllevel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLevels
            // 
            this.lblLevels.AutoSize = true;
            this.lblLevels.BackColor = System.Drawing.Color.Transparent;
            this.lblLevels.ForeColor = System.Drawing.Color.White;
            this.lblLevels.Location = new System.Drawing.Point(423, 296);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Size = new System.Drawing.Size(49, 16);
            this.lblLevels.TabIndex = 0;
            this.lblLevels.Text = "Níveis:";
            this.lblLevels.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(564, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nud_level);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.txtbox_confirm_password);
            this.Controls.Add(this.lbllevel3);
            this.Controls.Add(this.lbllevel2);
            this.Controls.Add(this.lbllevel1);
            this.Controls.Add(this.lblLevels);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro novo usuário";
            ((System.ComponentModel.ISupportInitialize)(this.nud_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtbox_confirm_password;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nud_level;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lbllevel1;
        private System.Windows.Forms.Label lbllevel2;
        private System.Windows.Forms.Label lbllevel3;
        private System.Windows.Forms.Label lblLevels;
    }
}