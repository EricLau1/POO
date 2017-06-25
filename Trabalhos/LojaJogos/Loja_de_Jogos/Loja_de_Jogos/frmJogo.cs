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
    public partial class frmJogo : Form
    {
        public frmJogo()
        {
            InitializeComponent();
        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Jogo jogo = new Camadas.BLL.Jogo();
            dgvJogos.DataSource = jogo.Select();

            Camadas.DAL.Genero genero = new Camadas.DAL.Genero();
            cmbGenero.DisplayMember = "genero";
            cmbGenero.ValueMember = "id";
            cmbGenero.DataSource = genero.Select();
            txtGenero.Enabled = false;
            txtGenero.Text = cmbGenero.SelectedValue.ToString();
        }

        private void Limpar()
        {
            lblId.Text = "0";
            txtNome.Text = "";
            txtDev.Text = "";
            txtDist.Text = "";
            txtValor.Text = "";
            txtDesc.Text = "";
        }

        private Camadas.MODEL.Jogo getJogo()
        {
            Camadas.MODEL.Jogo jogo = new Camadas.MODEL.Jogo();

            jogo.id = Convert.ToInt32(lblId.Text);
            jogo.idGenero = Convert.ToInt32(txtGenero.Text);
            jogo.nome = txtNome.Text;
            jogo.desenvolvedora = txtDev.Text;
            jogo.distribuidora = txtDist.Text;
            jogo.valor = Convert.ToSingle(txtValor.Text);
            jogo.descricao = txtDesc.Text;

            return jogo;
        }

        private bool verifica()
        {
            string[] campos = new string[6];
            campos[0] = txtGenero.Text;
            campos[1] = txtNome.Text;
            campos[2] = txtDev.Text;
            campos[3] = txtDist.Text;
            campos[4] = txtValor.Text;
            campos[5] = txtDesc.Text;
            for(int i = 0; i < 6; i++)
            {
                if(campos[i] == string.Empty)
                {
                    string msg = "Preencha todos os campos!";
                    MessageBox.Show(msg, "Jogos", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbGenero_Leave(object sender, EventArgs e)
        {
            txtGenero.Text = cmbGenero.SelectedValue.ToString();
        }

        private void lblInserir_Click(object sender, EventArgs e)
        {
            Limpar();
            txtNome.Focus();
        }

        private void lblGravar_Click(object sender, EventArgs e)
        {
            if (verifica())
            {
                Camadas.MODEL.Jogo jogo = new Camadas.MODEL.Jogo();
                jogo.idGenero = Convert.ToInt32(txtGenero.Text);
                jogo.nome = txtNome.Text;
                jogo.desenvolvedora = txtDev.Text;
                jogo.distribuidora = txtDist.Text;
                jogo.valor = Convert.ToSingle(txtValor.Text);
                jogo.descricao = txtDesc.Text;

                Camadas.BLL.Jogo bllJogo = new Camadas.BLL.Jogo();
                bllJogo.Insert(jogo);
                dgvJogos.DataSource = bllJogo.Select();
                Limpar();
            }
        }

        private void btnAddChave_Click(object sender, EventArgs e)
        {
            frmChaves jChave = new frmChaves();
            jChave.Show();
        }

        private void lblEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "0")
            {
                Camadas.BLL.Jogo bllJogo = new Camadas.BLL.Jogo();
                bllJogo.Update(getJogo());
                dgvJogos.DataSource = "";
                dgvJogos.DataSource = bllJogo.Select();
                Limpar();
            }
            else
            {
                string msg = "selecione um jogo na tabela";
                MessageBox.Show(msg, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvJogos_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvJogos.SelectedRows[0].Cells["id"].Value.ToString();
            txtGenero.Text = dgvJogos.SelectedRows[0].Cells["idGenero"].Value.ToString();
            cmbGenero.SelectedValue = Convert.ToInt32(txtGenero.Text);
            txtNome.Text = dgvJogos.SelectedRows[0].Cells["nome"].Value.ToString();
            txtDev.Text = dgvJogos.SelectedRows[0].Cells["desenvolvedora"].Value.ToString();
            txtDist.Text = dgvJogos.SelectedRows[0].Cells["distribuidora"].Value.ToString();
            txtValor.Text = dgvJogos.SelectedRows[0].Cells["valor"].Value.ToString();
            txtDesc.Text = dgvJogos.SelectedRows[0].Cells["descricao"].Value.ToString();
        }

        private void lblRemover_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "0")
            {
                Camadas.BLL.Compra compra = new Camadas.BLL.Compra();
                Camadas.BLL.ChaveProduto cp = new Camadas.BLL.ChaveProduto();

                if (compra.DetectedGame(Convert.ToInt32(lblId.Text)) && cp.DetectedGame(Convert.ToInt32(lblId.Text)))
                {
                    Camadas.BLL.Jogo bllJogo = new Camadas.BLL.Jogo();
                    bllJogo.Delete(getJogo());
                    dgvJogos.DataSource = bllJogo.Select();
                    Limpar();
                }
                else
                {
                    if (!compra.DetectedGame(Convert.ToInt32(lblId.Text)))
                    {
                        string msg = "Este Jogo está no histórico de compras!";
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string msg = "Este Jogo possui uma Chave de Produto!";
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                string msg = "selecione um jogo na tabela";
                MessageBox.Show(msg, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string frase = txtNome.Text;
            if(frase.Length > 33)
            {
                txtDev.Focus();
            }
        }

        private void txtDev_TextChanged(object sender, EventArgs e)
        {
            string frase = txtDev.Text;
            if (frase.Length > 33)
            {
                txtDist.Focus();
            }
        }

        private void txtDist_TextChanged(object sender, EventArgs e)
        {
            string frase = txtDist.Text;
            if (frase.Length > 33)
            {
                txtValor.Focus();
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            string frase = txtValor.Text;
            if (frase.Length > 6)
            {
                txtDesc.Focus();
            }
        }
    }
}
