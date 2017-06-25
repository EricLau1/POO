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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {
            frmUsers jUsuario = new frmUsers();
            jUsuario.Show();
        }

        private void lblJogos_Click(object sender, EventArgs e)
        {
            frmJogo jJogo = new frmJogo();
            jJogo.Show();
        }

        private void lblGeneros_Click(object sender, EventArgs e)
        {
            frmGenero jGenero = new frmGenero();
            jGenero.Show();
        }

        private void lblCompras_Click(object sender, EventArgs e)
        {
            frmLoja  jLoja = new frmLoja();
            jLoja.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
