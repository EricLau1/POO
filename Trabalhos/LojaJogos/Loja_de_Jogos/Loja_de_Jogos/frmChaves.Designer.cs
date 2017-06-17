namespace Loja_de_Jogos
{
    partial class frmChaves
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
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblRemover = new System.Windows.Forms.Label();
            this.lblEditar = new System.Windows.Forms.Label();
            this.lblGravar = new System.Windows.Forms.Label();
            this.lblInserir = new System.Windows.Forms.Label();
            this.dgvChaves = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.cmbJogos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaves)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(884, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "Chaves de Produto";
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCancelar.Location = new System.Drawing.Point(26, 348);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(107, 24);
            this.lblCancelar.TabIndex = 28;
            this.lblCancelar.Text = "&Cancelar";
            this.lblCancelar.Click += new System.EventHandler(this.lblCancelar_Click);
            // 
            // lblRemover
            // 
            this.lblRemover.AutoSize = true;
            this.lblRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemover.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemover.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRemover.Location = new System.Drawing.Point(26, 289);
            this.lblRemover.Name = "lblRemover";
            this.lblRemover.Size = new System.Drawing.Size(105, 24);
            this.lblRemover.TabIndex = 27;
            this.lblRemover.Text = "&Remover";
            this.lblRemover.Click += new System.EventHandler(this.lblRemover_Click);
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblEditar.Location = new System.Drawing.Point(26, 230);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(65, 24);
            this.lblEditar.TabIndex = 26;
            this.lblEditar.Text = "&Editar";
            this.lblEditar.Click += new System.EventHandler(this.lblEditar_Click);
            // 
            // lblGravar
            // 
            this.lblGravar.AutoSize = true;
            this.lblGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGravar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGravar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblGravar.Location = new System.Drawing.Point(26, 171);
            this.lblGravar.Name = "lblGravar";
            this.lblGravar.Size = new System.Drawing.Size(81, 24);
            this.lblGravar.TabIndex = 25;
            this.lblGravar.Text = "&Gravar";
            this.lblGravar.Click += new System.EventHandler(this.lblGravar_Click);
            // 
            // lblInserir
            // 
            this.lblInserir.AutoSize = true;
            this.lblInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInserir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInserir.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblInserir.Location = new System.Drawing.Point(26, 112);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(65, 24);
            this.lblInserir.TabIndex = 24;
            this.lblInserir.Text = "&Inserir";
            this.lblInserir.Click += new System.EventHandler(this.lblInserir_Click);
            // 
            // dgvChaves
            // 
            this.dgvChaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChaves.Location = new System.Drawing.Point(185, 112);
            this.dgvChaves.Name = "dgvChaves";
            this.dgvChaves.Size = new System.Drawing.Size(600, 150);
            this.dgvChaves.TabIndex = 29;
            this.dgvChaves.DoubleClick += new System.EventHandler(this.dgvChaves_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Jogo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Chave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Status";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(363, 300);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(21, 22);
            this.lblCodigo.TabIndex = 34;
            this.lblCodigo.Text = "0";
            // 
            // txtChave
            // 
            this.txtChave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChave.Location = new System.Drawing.Point(366, 383);
            this.txtChave.MaxLength = 10;
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(335, 31);
            this.txtChave.TabIndex = 36;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(366, 429);
            this.txtStatus.MaxLength = 1;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(50, 31);
            this.txtStatus.TabIndex = 37;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(363, 348);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(29, 22);
            this.lblid.TabIndex = 38;
            this.lblid.Text = "ID";
            // 
            // cmbJogos
            // 
            this.cmbJogos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJogos.FormattingEnabled = true;
            this.cmbJogos.Location = new System.Drawing.Point(413, 342);
            this.cmbJogos.Name = "cmbJogos";
            this.cmbJogos.Size = new System.Drawing.Size(288, 30);
            this.cmbJogos.TabIndex = 39;
            this.cmbJogos.Leave += new System.EventHandler(this.cmbJogos_Leave);
            // 
            // frmChaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 567);
            this.Controls.Add(this.cmbJogos);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChaves);
            this.Controls.Add(this.lblCancelar);
            this.Controls.Add(this.lblRemover);
            this.Controls.Add(this.lblEditar);
            this.Controls.Add(this.lblGravar);
            this.Controls.Add(this.lblInserir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manter Chave Produto";
            this.Load += new System.EventHandler(this.frmChaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Label lblRemover;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.Label lblGravar;
        private System.Windows.Forms.Label lblInserir;
        private System.Windows.Forms.DataGridView dgvChaves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ComboBox cmbJogos;
    }
}

