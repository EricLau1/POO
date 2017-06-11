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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Jogo jogo = new Camadas.DAL.Jogo();
            dgvGrid.DataSource = jogo.Select();

            Camadas.DAL.Genero genero = new Camadas.DAL.Genero();
            dgvGenero.DataSource = genero.Select();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string txt = txtGenero.Text;
            Camadas.MODEL.Genero gene = new Camadas.MODEL.Genero();
  
            if (txt != "")
            {
                gene.genero = txt;
                Camadas.DAL.Genero genero = new Camadas.DAL.Genero();
                genero.Insert(gene);
                dgvGenero.DataSource = genero.Select();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int num =Convert.ToInt32(txtGenero.Text);
            Camadas.MODEL.Genero gene = new Camadas.MODEL.Genero();
            gene.id = num;
            Camadas.DAL.Genero genero = new Camadas.DAL.Genero();
            genero.Delete(gene);
            dgvGenero.DataSource = genero.Select();
        }

        private void dgvGenero_DoubleClick(object sender, EventArgs e)
        {
            if(dgvGenero.SelectedRows.Count > 0)
            {
                lblId.Text = dgvGenero.SelectedRows[0].Cells["id"].Value.ToString();
                txtGenero.Text = dgvGenero.SelectedRows[0].Cells["genero"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dgvGenero.SelectedRows.Count > 0)
            {
                Camadas.MODEL.Genero genero = new Camadas.MODEL.Genero();
                genero.id = Convert.ToInt32(lblId.Text);
                genero.genero = txtGenero.Text;
                Camadas.DAL.Genero dalgen = new Camadas.DAL.Genero();
                dalgen.Update(genero);
                dgvGenero.DataSource = "";
                dgvGenero.DataSource = dalgen.Select();
            }
            else
            {
                MessageBox.Show("Lalala","Bloco else", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
