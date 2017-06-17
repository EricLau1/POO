using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_de_Jogos
{
    public partial class frmGenero : Form
    {
        public frmGenero()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            lblId.Text = "ID";
            txtGenero.Text = "";
        }

        private bool verifica()
        {
            if(txtGenero.Text != string.Empty)
            {
                return true;
            }
            string msg = "Digite um genero";
            MessageBox.Show(msg, "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private Camadas.MODEL.Genero ModelGenero()
        {
            Camadas.MODEL.Genero genero = new Camadas.MODEL.Genero();
            genero.id = Convert.ToInt32(lblId.Text);
            genero.genero = txtGenero.Text;
            return genero;
        }

        private void frmGenero_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Genero bllGenero = new Camadas.BLL.Genero();
            dgvGenero.DataSource = bllGenero.Select();
        }

        private void dgvGenero_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvGenero.SelectedRows[0].Cells["id"].Value.ToString();
            txtGenero.Text = dgvGenero.SelectedRows[0].Cells["genero"].Value.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblGravar_Click(object sender, EventArgs e)
        {
            if(verifica())
            {
                Camadas.MODEL.Genero genero = new Camadas.MODEL.Genero();
                genero.genero = txtGenero.Text;

                Camadas.BLL.Genero bllGenero = new Camadas.BLL.Genero();
                bllGenero.Insert(genero);
                dgvGenero.DataSource = bllGenero.Select();
            }
        }

        private void lblInserir_Click(object sender, EventArgs e)
        {
            Limpar();
            txtGenero.Focus();
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void lblEditar_Click(object sender, EventArgs e)
        {
            if(lblId.Text != "ID")
            {
                Camadas.BLL.Genero bllGenero = new Camadas.BLL.Genero();
                bllGenero.Update(ModelGenero());
                dgvGenero.DataSource = bllGenero.Select();
            }else
            {
                string msg = "Selecione um genero na tabela";
                MessageBox.Show(msg, "Validando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    } // fim class
}
