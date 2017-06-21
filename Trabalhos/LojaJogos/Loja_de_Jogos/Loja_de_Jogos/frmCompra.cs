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
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private Camadas.BLL.Compra bllCompra()
        {
            Camadas.BLL.Compra compra = new Camadas.BLL.Compra();
            return compra;
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            dgvCompra.DataSource = bllCompra().Select();
            txtJogo.Enabled = false;
            txtUser.Enabled = false;
        }

        private void dgvCompra_DoubleClick(object sender, EventArgs e)
        {
            
            Camadas.BLL.Usuario bllUser = new Camadas.BLL.Usuario();
            lblUser.Text = dgvCompra.SelectedRows[0].Cells["idUser"].Value.ToString();
            txtUser.Text = bllUser.BuscaNome(Convert.ToInt32(lblUser.Text));
            DateTime dataHora = Convert.ToDateTime(dgvCompra.SelectedRows[0].Cells["horaCompra"].Value);
            lblData.Text = dataHora.ToShortDateString();

            Camadas.BLL.Jogo bllJogo = new Camadas.BLL.Jogo();
            lblJogo.Text = dgvCompra.SelectedRows[0].Cells["idJogo"].Value.ToString();
            txtJogo.Text = bllJogo.BuscaNome(Convert.ToInt32(lblJogo.Text));
            lblHora.Text = dataHora.ToShortTimeString();
        }

        private void lblRemover_Click(object sender, EventArgs e)
        {
            if(lblUser.Text != "Usuário")
            {
                string msg = txtUser.Text + " comprou o jogo " + txtJogo.Text + ", Será Removido da tabela! (Confirma?)";
                DialogResult opcao;
                opcao = MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(opcao == DialogResult.Yes)
                {
                    Camadas.BLL.Compra bllCompra = new Camadas.BLL.Compra();
                    Camadas.MODEL.Compra compra = new Camadas.MODEL.Compra();
                    compra.idUser = Convert.ToInt32(lblUser.Text);
                    compra.idJogo = Convert.ToInt32(lblJogo.Text);
                    bllCompra.Delete(compra);
                    dgvCompra.DataSource = bllCompra.Select();
                }
            }
        }
    }
}
