namespace Loja_de_Jogos
{
    partial class frmCompra
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
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJogo = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtJogo = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblRemover = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotVendas = new System.Windows.Forms.Label();
            this.lblTotValor = new System.Windows.Forms.Label();
            this.lblTotUsers = new System.Windows.Forms.Label();
            this.lblTotJogos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQtdeJogos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRelatorio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(884, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "Movimentações";
            // 
            // dgvCompra
            // 
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(18, 76);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.Size = new System.Drawing.Size(319, 479);
            this.dgvCompra.TabIndex = 17;
            this.dgvCompra.DoubleClick += new System.EventHandler(this.dgvCompra_DoubleClick);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(360, 87);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(75, 22);
            this.lblUser.TabIndex = 18;
            this.lblUser.Text = "Usuário";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "comprou";
            // 
            // lblJogo
            // 
            this.lblJogo.AutoSize = true;
            this.lblJogo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogo.Location = new System.Drawing.Point(714, 87);
            this.lblJogo.Name = "lblJogo";
            this.lblJogo.Size = new System.Drawing.Size(56, 22);
            this.lblJogo.TabIndex = 20;
            this.lblJogo.Text = "Jogo";
            this.lblJogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(364, 127);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(183, 31);
            this.txtUser.TabIndex = 21;
            // 
            // txtJogo
            // 
            this.txtJogo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJogo.Location = new System.Drawing.Point(717, 127);
            this.txtJogo.Name = "txtJogo";
            this.txtJogo.Size = new System.Drawing.Size(183, 31);
            this.txtJogo.TabIndex = 22;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(369, 178);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(147, 19);
            this.lblData.TabIndex = 23;
            this.lblData.Text = "Data da Compra";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(369, 217);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(142, 19);
            this.lblHora.TabIndex = 24;
            this.lblHora.Text = "Hora da Compra";
            // 
            // lblRemover
            // 
            this.lblRemover.AutoSize = true;
            this.lblRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemover.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemover.Location = new System.Drawing.Point(360, 521);
            this.lblRemover.Name = "lblRemover";
            this.lblRemover.Size = new System.Drawing.Size(93, 22);
            this.lblRemover.TabIndex = 25;
            this.lblRemover.Text = "Remover";
            this.lblRemover.Click += new System.EventHandler(this.lblRemover_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(728, 178);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(73, 19);
            this.lblValor.TabIndex = 26;
            this.lblValor.Text = "Valor R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Total de Jogos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Total de Usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Valor total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total Vendas";
            // 
            // lblTotVendas
            // 
            this.lblTotVendas.AutoSize = true;
            this.lblTotVendas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotVendas.Location = new System.Drawing.Point(576, 399);
            this.lblTotVendas.Name = "lblTotVendas";
            this.lblTotVendas.Size = new System.Drawing.Size(16, 18);
            this.lblTotVendas.TabIndex = 34;
            this.lblTotVendas.Text = "0";
            // 
            // lblTotValor
            // 
            this.lblTotValor.AutoSize = true;
            this.lblTotValor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotValor.Location = new System.Drawing.Point(576, 432);
            this.lblTotValor.Name = "lblTotValor";
            this.lblTotValor.Size = new System.Drawing.Size(16, 18);
            this.lblTotValor.TabIndex = 33;
            this.lblTotValor.Text = "0";
            // 
            // lblTotUsers
            // 
            this.lblTotUsers.AutoSize = true;
            this.lblTotUsers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotUsers.Location = new System.Drawing.Point(576, 366);
            this.lblTotUsers.Name = "lblTotUsers";
            this.lblTotUsers.Size = new System.Drawing.Size(16, 18);
            this.lblTotUsers.TabIndex = 32;
            this.lblTotUsers.Text = "0";
            // 
            // lblTotJogos
            // 
            this.lblTotJogos.AutoSize = true;
            this.lblTotJogos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotJogos.Location = new System.Drawing.Point(576, 333);
            this.lblTotJogos.Name = "lblTotJogos";
            this.lblTotJogos.Size = new System.Drawing.Size(16, 18);
            this.lblTotJogos.TabIndex = 31;
            this.lblTotJogos.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(599, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Qtde. Jogos Comprados";
            // 
            // lblQtdeJogos
            // 
            this.lblQtdeJogos.AutoSize = true;
            this.lblQtdeJogos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeJogos.Location = new System.Drawing.Point(823, 217);
            this.lblQtdeJogos.Name = "lblQtdeJogos";
            this.lblQtdeJogos.Size = new System.Drawing.Size(18, 19);
            this.lblQtdeJogos.TabIndex = 36;
            this.lblQtdeJogos.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(364, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Dados Gerais";
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRelatorio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorio.Location = new System.Drawing.Point(855, 521);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(93, 22);
            this.lblRelatorio.TabIndex = 38;
            this.lblRelatorio.Text = "Relatório";
            this.lblRelatorio.Click += new System.EventHandler(this.lblRelatorio_Click);
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 567);
            this.Controls.Add(this.lblRelatorio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblQtdeJogos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotVendas);
            this.Controls.Add(this.lblTotValor);
            this.Controls.Add(this.lblTotUsers);
            this.Controls.Add(this.lblTotJogos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblRemover);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtJogo);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblJogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manter Compras";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJogo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtJogo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblRemover;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotVendas;
        private System.Windows.Forms.Label lblTotValor;
        private System.Windows.Forms.Label lblTotUsers;
        private System.Windows.Forms.Label lblTotJogos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQtdeJogos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRelatorio;
    }
}