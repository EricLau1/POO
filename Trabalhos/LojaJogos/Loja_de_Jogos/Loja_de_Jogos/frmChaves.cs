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
    }
}
