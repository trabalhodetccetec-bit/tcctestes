using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SQLite;
using System.IO;

namespace tcctestes.formularios
{
    public partial class paginaInicial : Form
    {
        public paginaInicial()
        {

            InitializeComponent();
        }

        private void paginaInicial_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(245, 245, 245);
            pictureBox1.Click += AbrirJogoRecente;
            pictureBox2.Click += AbrirJogoRecente;
            pictureBox3.Click += AbrirJogoRecente;
            Conectar();
        }
        private void AbrirJogoRecente(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.SQL sql = new BancodeDados.SQL();
                PictureBox pb = (PictureBox)sender;

                if (pb.Tag == null)
                {
                    MessageBox.Show("Este jogo não possui ID associado.");
                    return;
                }

                int idJogo = Convert.ToInt32(pb.Tag);
                sql.AbrirRecente(idJogo);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir jogo: " + ex.Message);
            }
            Conectar();
        }

        
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.adicionarjog adjog = new formularios.adicionarjog();
            adjog.Show();
        }

        private void verTodosOsJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.jogos all = new formularios.jogos();
            this.Hide();
            all.Show();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightGray;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.WhiteSmoke;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightGray;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightGray;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formularios.login all = new formularios.login();
            this.Hide();
            all.Show();
        }

        private void Conectar()
        {
            try
            {
                BancodeDados.SQL sql = new BancodeDados.SQL();

                var jogos = sql.Recentes();

                Label[] titulos = { label1, label2, label3 };
                Label[] categorias = { label4, label5, label6 };
                PictureBox[] imagens = { pictureBox1, pictureBox2, pictureBox3 };

                for (int i = 0; i < jogos.Count; i++)
                {
                    titulos[i].Text = jogos[i].Nome;
                    categorias[i].Text = jogos[i].Categoria;

                    titulos[i].Tag = jogos[i].Id;
                    categorias[i].Tag = jogos[i].Id;
                    imagens[i].Tag = jogos[i].Id;

                    if (File.Exists(jogos[i].CaminhoImagem))
                    {
                        imagens[i].Image = Image.FromFile(jogos[i].CaminhoImagem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
