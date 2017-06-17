namespace Loja_de_Jogos
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblJogos = new System.Windows.Forms.Label();
            this.lblGeneros = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabelas";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuarios.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.Black;
            this.lblUsuarios.Location = new System.Drawing.Point(74, 131);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(109, 30);
            this.lblUsuarios.TabIndex = 1;
            this.lblUsuarios.Text = "Usuários";
            this.lblUsuarios.Click += new System.EventHandler(this.lblUsuarios_Click);
            // 
            // lblJogos
            // 
            this.lblJogos.AutoSize = true;
            this.lblJogos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblJogos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogos.ForeColor = System.Drawing.Color.Black;
            this.lblJogos.Location = new System.Drawing.Point(77, 208);
            this.lblJogos.Name = "lblJogos";
            this.lblJogos.Size = new System.Drawing.Size(83, 30);
            this.lblJogos.TabIndex = 2;
            this.lblJogos.Text = "Jogos";
            this.lblJogos.Click += new System.EventHandler(this.lblJogos_Click);
            // 
            // lblGeneros
            // 
            this.lblGeneros.AutoSize = true;
            this.lblGeneros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGeneros.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneros.ForeColor = System.Drawing.Color.Black;
            this.lblGeneros.Location = new System.Drawing.Point(80, 285);
            this.lblGeneros.Name = "lblGeneros";
            this.lblGeneros.Size = new System.Drawing.Size(114, 30);
            this.lblGeneros.TabIndex = 3;
            this.lblGeneros.Text = "Gêneros";
            this.lblGeneros.Click += new System.EventHandler(this.lblGeneros_Click);
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCompras.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.ForeColor = System.Drawing.Color.Black;
            this.lblCompras.Location = new System.Drawing.Point(77, 362);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(122, 30);
            this.lblCompras.TabIndex = 4;
            this.lblCompras.Text = "Compras";
            this.lblCompras.Click += new System.EventHandler(this.lblCompras_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(866, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 29;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.lblGeneros);
            this.Controls.Add(this.lblJogos);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblJogos;
        private System.Windows.Forms.Label lblGeneros;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Button button1;
    }
}