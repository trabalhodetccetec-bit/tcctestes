using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcctestes.formularios
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.BackgroundImage = Image.FromFile(opf.FileName);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SERVICES.Cadastro cadastro = new SERVICES.Cadastro();
            MODELS.usuario usuario = new MODELS.usuario();
            usuario.email = Email.Text;
            usuario.nome = nome.Text;
            usuario.senha = senha.Text;
            cadastro.cadastro(usuario);
            usuario.camainhoimagem = pictureBox1.ImageLocation;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nome.Text)) { }
            if (nome.Text == "nome de usuario") { nome.Text = ""; nome.ForeColor = Color.Black; }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nome.Text))
            {
                nome.Text = "nome de usuario";
                nome.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(senha.Text))
            {
                senha.Text = "senha";
                senha.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(senha.Text)) { }
            if (senha.Text == "senha") { senha.Text = ""; senha.ForeColor = Color.Black; }

        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nome.Text))
            {
                Email.Text = "Exemplo@email.com";
                Email.ForeColor = Color.Gray;
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Email.Text)) { }
            if (Email.Text == "Exemplo@email.com") { Email.Text = ""; Email.ForeColor = Color.Black; }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if (MODELS.persistente.saiusemlogar)
            {
                this.Hide();
            }
        }
    }
}
