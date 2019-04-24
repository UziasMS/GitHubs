namespace WindowsForms_BancoTuiuiu
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.pnlPrincipalTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNomeDoBanco = new System.Windows.Forms.Label();
            this.pnlPrincipalMsg = new System.Windows.Forms.Panel();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.pnlPrincipalTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPrincipalMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(17, 356);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 70);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btnSaque
            // 
            this.btnSaque.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.Location = new System.Drawing.Point(151, 356);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(108, 70);
            this.btnSaque.TabIndex = 1;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            // 
            // btnDeposito
            // 
            this.btnDeposito.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Location = new System.Drawing.Point(278, 356);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(146, 70);
            this.btnDeposito.TabIndex = 2;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            // 
            // pnlPrincipalTitulo
            // 
            this.pnlPrincipalTitulo.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlPrincipalTitulo.Controls.Add(this.pictureBox1);
            this.pnlPrincipalTitulo.Controls.Add(this.lblNomeDoBanco);
            this.pnlPrincipalTitulo.Location = new System.Drawing.Point(1, 0);
            this.pnlPrincipalTitulo.Name = "pnlPrincipalTitulo";
            this.pnlPrincipalTitulo.Size = new System.Drawing.Size(434, 96);
            this.pnlPrincipalTitulo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblNomeDoBanco
            // 
            this.lblNomeDoBanco.AutoSize = true;
            this.lblNomeDoBanco.BackColor = System.Drawing.Color.DarkOrange;
            this.lblNomeDoBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoBanco.ForeColor = System.Drawing.Color.Crimson;
            this.lblNomeDoBanco.Location = new System.Drawing.Point(113, 26);
            this.lblNomeDoBanco.Name = "lblNomeDoBanco";
            this.lblNomeDoBanco.Size = new System.Drawing.Size(317, 58);
            this.lblNomeDoBanco.TabIndex = 0;
            this.lblNomeDoBanco.Text = "Banco Tuiuiu";
            // 
            // pnlPrincipalMsg
            // 
            this.pnlPrincipalMsg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlPrincipalMsg.Controls.Add(this.lbl_msg);
            this.pnlPrincipalMsg.Location = new System.Drawing.Point(1, 294);
            this.pnlPrincipalMsg.Name = "pnlPrincipalMsg";
            this.pnlPrincipalMsg.Size = new System.Drawing.Size(434, 56);
            this.pnlPrincipalMsg.TabIndex = 4;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.White;
            this.lbl_msg.Location = new System.Drawing.Point(187, 12);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(59, 29);
            this.lbl_msg.TabIndex = 0;
            this.lbl_msg.Text = "Msg";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 137);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(71, 26);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(12, 188);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(68, 26);
            this.lblConta.TabIndex = 6;
            this.lblConta.Text = "Conta:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(12, 236);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(65, 26);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "Saldo:";
            this.lblSaldo.Click += new System.EventHandler(this.lbl_saldo_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNome.Location = new System.Drawing.Point(89, 137);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(313, 31);
            this.txtNome.TabIndex = 8;
            // 
            // txtConta
            // 
            this.txtConta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtConta.Location = new System.Drawing.Point(89, 188);
            this.txtConta.Multiline = true;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(313, 31);
            this.txtConta.TabIndex = 9;
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSaldo.Location = new System.Drawing.Point(89, 236);
            this.txtSaldo.Multiline = true;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(313, 34);
            this.txtSaldo.TabIndex = 10;
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrincipal.Location = new System.Drawing.Point(15, 102);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(264, 29);
            this.gbPrincipal.TabIndex = 11;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Informações do cliente";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(436, 428);
            this.Controls.Add(this.gbPrincipal);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlPrincipalMsg);
            this.Controls.Add(this.pnlPrincipalTitulo);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.btnSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.pnlPrincipalTitulo.ResumeLayout(false);
            this.pnlPrincipalTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPrincipalMsg.ResumeLayout(false);
            this.pnlPrincipalMsg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Panel pnlPrincipalTitulo;
        private System.Windows.Forms.Panel pnlPrincipalMsg;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomeDoBanco;
        private System.Windows.Forms.Label lbl_msg;
    }
}

