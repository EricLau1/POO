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

        private Camadas.DAL.Compra compraDal()
        {
            Camadas.DAL.Compra compra = new Camadas.DAL.Compra();
            return compra;
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOJA_DE_JOGOSDataSet.Compra' table. You can move, or remove it, as needed.
            this.compraTableAdapter.Fill(this.lOJA_DE_JOGOSDataSet.Compra);

            dgvCompra.DataSource = compraDal().Select();
        }
    }
}
