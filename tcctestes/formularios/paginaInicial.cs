using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SQLite;
using System.IO;
using System.Windows.Media.Animation;
using System.Xml;
using Microsoft.SqlServer.Server;
using System.Net.Mail;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;

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
            Label[] labels = { label1, label2, label3, label4, label5, label6 };
            for (int i = 0; i < labels.Length; i++) 
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

        private void estatísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gráfico form = new Gráfico();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)

       {
            

        }

        private void trocarBackgroudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox4.BackgroundImage = Image.FromFile(opf.FileName);
                    
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
