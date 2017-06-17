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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        public bool verifica()
        {
            string[] campo = new string[4];
            campo[0] = txtNome.Text;
            campo[1] = txtUsername.Text;
            campo[2] = txtEmail.Text;
            campo[3] = txtSenha.Text;
            for(int i = 0; i < 4; i++)
            {
                if(campo[i] == string.Empty)
                {
                    string msg = "Preencha todos os campos!";
                    MessageBox.Show(msg, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        private Camadas.MODEL.Usuario UserModel()
        {
            Camadas.MODEL.Usuario usuario = new Camadas.MODEL.Usuario();
            usuario.id = Convert.ToInt32(lblId.Text);
            usuario.nome = txtNome.Text;
            usuario.username = txtUsername.Text;
            usuario.email = txtEmail.Text;
            usuario.senha = txtSenha.Text;
            return usuario;
        }

        private Camadas.DAL.Usuario UserDal()
        {
            Camadas.DAL.Usuario usuario = new Camadas.DAL.Usuario();
            return usuario;
        }

        public void Habilitar(bool status)
        {
            txtNome.Enabled = status;
            txtUsername.Enabled = status;
            txtEmail.Enabled = status;
            txtSenha.Enabled = status;
        }

        public void Limpar()
        {
            lblId.Text = "0";
            txtNome.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Usuario Usuarios = new Camadas.DAL.Usuario();
            dgvUsuarios.DataSource = Usuarios.Select();
            Habilitar(false);
            
        }

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            if(dgvUsuarios.SelectedRows.Count > 0)
            {
                Habilitar(true);
                lblId.Text = dgvUsuarios.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dgvUsuarios.SelectedRows[0].Cells["nome"].Value.ToString();
                txtUsername.Text = dgvUsuarios.SelectedRows[0].Cells["username"].Value.ToString();
                txtEmail.Text = dgvUsuarios.SelectedRows[0].Cells["email"].Value.ToString();
                txtSenha.Text = dgvUsuarios.SelectedRows[0].Cells["senha"].Value.ToString();
            }
        }
        
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
