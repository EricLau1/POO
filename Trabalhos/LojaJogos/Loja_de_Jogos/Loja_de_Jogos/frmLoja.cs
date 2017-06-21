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
    public partial class frmLoja : Form
    {
        public frmLoja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLoja_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Usuario bllUser = new Camadas.BLL.Usuario();
            cmbUsers.DisplayMember = "nome";
            cmbUsers.ValueMember = "id";
            cmbUsers.DataSource = bllUser.Select();
            lblIdUser.Text = cmbUsers.SelectedValue.ToString();

            Camadas.BLL.Jogo bllJogo = new Camadas.BLL.Jogo();
            cmbJogos.DisplayMember = "nome";
            cmbJogos.ValueMember = "id";
            cmbJogos.DataSource = bllJogo.Select();
            lblIdJogo.Text = cmbJogos.SelectedValue.ToString();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdUser.Text = cmbUsers.SelectedValue.ToString();
        }

        private void cmbJogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdJogo.Text = cmbJogos.SelectedValue.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmCompra jCompra = new frmCompra();
            jCompra.Show();
        }

        private void lblComprar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Compra bllCompra = new Camadas.BLL.Compra();
            Camadas.MODEL.Compra compra = new Camadas.MODEL.Compra();

            compra.horaCompra = DateTime.Today;
            compra.idUser = Convert.ToInt32(lblIdUser.Text);
            compra.idJogo = Convert.ToInt32(lblIdJogo.Text);

            bllCompra.Insert(compra);

            string msg = "" + cmbUsers.Text;
            msg += " comprou " + cmbJogos.Text;
            MessageBox.Show(msg, "Loja", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
