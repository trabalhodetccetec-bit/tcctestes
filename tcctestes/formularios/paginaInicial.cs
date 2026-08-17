using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


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
            if (pictureBox1.Image != null)
            {
                pictureBox1.BorderStyle = BorderStyle.None;
            }
            if (pictureBox2.Image != null)
            {
                pictureBox2.BorderStyle = BorderStyle.None;
            }
            if (pictureBox3.Image != null)
            {
                pictureBox3.BorderStyle = BorderStyle.None;
            }
            

            if (pictureBox1.Image == null)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
            if (pictureBox2.Image == null)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
            if (pictureBox2.Image == null)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
            }


            sobreToolStripMenuItem.Visible = false;

            this.BackColor = Color.FromArgb(245, 245, 245);

            Label[] labels = { label1, label2, label3, label4, label5, label6 };

            label7.BackColor = Color.Transparent;
           

            pictureBox1.Click += AbrirJogoRecente;
            pictureBox2.Click += AbrirJogoRecente;
            pictureBox3.Click += AbrirJogoRecente;

            ConectarInicio();
        }
        private void AbrirJogoRecente(object sender, EventArgs e)
        {
            try
            {
                SERVICES.cominicacao comunicacao = new SERVICES.cominicacao();
                PictureBox pb = (PictureBox)sender;

                if (pb.Tag == null)
                {
                    MessageBox.Show("Este jogo não possui ID associado.");
                    return;
                }

                int idJogo = Convert.ToInt32(pb.Tag);
                comunicacao.abrirrecente(idJogo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir jogo: " + ex.Message);
            }
            ConectarInicio();
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

        private void ConectarInicio()
        {
            try
            {
                SERVICES.cominicacao comunicacao = new SERVICES.cominicacao();
                MODELS.Paginanicial plano = comunicacao.getplanodefundo();
                var jogos = comunicacao.recentes();

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

                comunicacao.getplanodefundo();

                if (!string.IsNullOrEmpty(plano.planodefundo))
                {
                    this.BackgroundImage = Image.FromFile(plano.planodefundo);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
               // if (pictureBox3.Image == null && pictureBox2.Image == null && pictureBox1.Image == null) MessageBox.Show("Você ainda não jogou nenhum jogo!");
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

        private void trocarBackgroudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MODELS.Paginanicial pag = new MODELS.Paginanicial();
            SERVICES.cominicacao cominicacao = new SERVICES.cominicacao();
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    this.BackgroundImage = Image.FromFile(opf.FileName);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    pag.planodefundo = opf.FileName;
                    cominicacao.setplanodefundo(pag);
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            SERVICES.VerificarInternet verify = new SERVICES.VerificarInternet();
            bool conectado = verify.Pingar();
            if (conectado)
            {
                Feedback.Enabled = true;
                reportarErrosToolStripMenuItem.Enabled = true;
                login.Enabled = true;
            }
            else if (!conectado)
            {
                Feedback.Enabled = false;
                reportarErrosToolStripMenuItem.Enabled = false;
                login.Enabled = false;
            }
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            FeedBack feedBack = new FeedBack();
            feedBack.Show();
        }

        private void reportarErrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report reportar = new Report();
            reportar.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caminho = Path.Combine(
                Application.StartupPath,
                "Paginas",
                "adicionarjogos.html");

            Process.Start(new ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true
            });
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.BorderStyle = BorderStyle.None;
            }
            if (pictureBox2.Image != null)
            {
                pictureBox2.BorderStyle = BorderStyle.None;
            }
            if (pictureBox3.Image != null)
            {
                pictureBox3.BorderStyle = BorderStyle.None;
            }


            if (pictureBox1.Image == null)
            {
                panel1.Visible = false;
            }
            else { 
                panel1.Visible = true;
            }
            if (pictureBox2.Image == null)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
            if (pictureBox3.Image == null)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
            }
            recarregar();
        }

        private void recarregar()
        {
            try
            {
                SERVICES.cominicacao comunicacao = new SERVICES.cominicacao();
                var jogos = comunicacao.recentes();

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
