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
        }

        private void dgvCompra_DoubleClick(object sender, EventArgs e)
        {
            
            lblDataHora.Text = dgvCompra.SelectedRows[0].Cells["horaCompra"].Value.ToString();

            Camadas.BLL.Usuario bllUser = new Camadas.BLL.Usuario();
            lblUser.Text = dgvCompra.SelectedRows[0].Cells["idUser"].Value.ToString();
            txtUser.Text = bllUser.BuscaNome(Convert.ToInt32(lblUser.Text));

            Camadas.BLL.Jogo bllJogo = new Camadas.BLL.Jogo();
            lblJogo.Text = dgvCompra.SelectedRows[0].Cells["idJogo"].Value.ToString();
            txtJogo.Text = bllJogo.BuscaNome(Convert.ToInt32(lblJogo.Text));
        }
    }
}
