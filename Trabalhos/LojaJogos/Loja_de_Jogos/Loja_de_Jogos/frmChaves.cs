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
    public partial class frmChaves : Form
    {
        public frmChaves()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool Verifica()
        {
            string[] campos = new string[2];
            campos[0] = txtChave.Text;
            campos[1] = txtStatus.Text;
            for(int i = 0; i < 2; i++)
            {
                if(campos[i] == string.Empty)
                {
                    string msg = "Preencha todos os campos";
                    MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }

        private void Limpar()
        {
            lblCodigo.Text = "0";
            txtChave.Text = "";
            txtStatus.Text = "";
        }

        private void frmChaves_Load(object sender, EventArgs e)
        {
            Camadas.BLL.ChaveProduto cp = new Camadas.BLL.ChaveProduto();

            dgvChaves.DataSource = cp.Select();

            Camadas.BLL.Jogo jogo = new Camadas.BLL.Jogo();
            cmbJogos.DisplayMember = "nome";
            cmbJogos.ValueMember = "id";
            cmbJogos.DataSource = jogo.Select();
            lblid.Enabled = false;
            lblid.Text = cmbJogos.SelectedValue.ToString();
        }

        private void cmbJogos_Leave(object sender, EventArgs e)
        {
            lblid.Text = cmbJogos.SelectedValue.ToString();
        }

        private void lblInserir_Click(object sender, EventArgs e)
        {
            Limpar();
            txtChave.Focus();
        }

        private void dgvChaves_DoubleClick(object sender, EventArgs e)
        {
            lblCodigo.Text = dgvChaves.SelectedRows[0].Cells["codigo"].Value.ToString();
            lblid.Text = dgvChaves.SelectedRows[0].Cells["idJogo"].Value.ToString();
            cmbJogos.SelectedValue = Convert.ToInt32(lblid.Text);
            txtChave.Text = dgvChaves.SelectedRows[0].Cells["chave"].Value.ToString();
            txtStatus.Text = dgvChaves.SelectedRows[0].Cells["status"].Value.ToString();
        }

        private void lblGravar_Click(object sender, EventArgs e)
        {
            if (Verifica())
            {
                Camadas.MODEL.ChaveProduto cp = new Camadas.MODEL.ChaveProduto();
                cp.idJogo = Convert.ToInt32(lblid.Text);
                cp.chave = txtChave.Text;
                cp.status = Convert.ToChar(txtStatus.Text);
                Camadas.BLL.ChaveProduto bllCp = new Camadas.BLL.ChaveProduto();
                bllCp.Insert(cp);
                dgvChaves.DataSource = bllCp.Select();            }
        }

        private void lblEditar_Click(object sender, EventArgs e)
        {
            if(lblCodigo.Text != "0")
            {
                Camadas.MODEL.ChaveProduto cp = new Camadas.MODEL.ChaveProduto();
                cp.codigo = Convert.ToInt32(lblCodigo.Text);
                cp.idJogo = Convert.ToInt32(lblid.Text);
                cp.chave = txtChave.Text;
                cp.status = Convert.ToChar(txtStatus.Text);
                Camadas.BLL.ChaveProduto bllCp = new Camadas.BLL.ChaveProduto();
                bllCp.Update(cp);
                dgvChaves.DataSource = bllCp.Select();
                Limpar();
            }else
            {
                string msg = "Selecione um item da tabela";
                MessageBox.Show(msg,"Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void lblRemover_Click(object sender, EventArgs e)
        {
            if (lblCodigo.Text != "0")
            {
                Camadas.MODEL.ChaveProduto cp = new Camadas.MODEL.ChaveProduto();
                cp.codigo = Convert.ToInt32(lblCodigo.Text);
                cp.idJogo = Convert.ToInt32(lblid.Text);
                cp.chave = txtChave.Text;
                cp.status = Convert.ToChar(txtStatus.Text);
                Camadas.BLL.ChaveProduto bllCp = new Camadas.BLL.ChaveProduto();
                bllCp.Delete(cp);
                dgvChaves.DataSource = bllCp.Select();
                Limpar();
            }
            else
            {
                string msg = "Selecione um item da tabela";
                MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
