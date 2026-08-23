using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace tcctestes.formularios
{
    public partial class paginaInicial : Form
    {
        static bool jamostrou = false;
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

            this.BackgroundImageLayout = ImageLayout.Stretch;
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            SERVICES.VerificarInternet verify = new SERVICES.VerificarInternet();
            bool conectado = verify.Pingar();
            if (conectado)
            {
                Feedback.Enabled = true;
                reportarErrosToolStripMenuItem.Enabled = true;
            }
            else if (!conectado)
            {
                Feedback.Enabled = false;
                reportarErrosToolStripMenuItem.Enabled = false;
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
            recarregar();
        }

        private void recarregar()
        {
            try
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
                if (pictureBox3.Image == null)
                {
                    panel3.Visible = false;
                }
                else
                {
                    panel3.Visible = true;
                }
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
                if (this.BackgroundImage == null)
                {
                    comunicacao.getplanodefundo();

                    if (!string.IsNullOrEmpty(plano.planodefundo))
                    {
                        this.BackgroundImage = Image.FromFile(plano.planodefundo);
                        this.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (jamostrou == false && pictureBox1.Image == null && pictureBox2.Image == null && pictureBox3.Image == null)
            {
                timer2.Stop();
                MessageBox.Show("Você ainda não abriu nenhum jogo");
                timer2.Start();
                jamostrou = true;
            }
        }

        private void trocarPlanoDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MODELS.Paginanicial pag = new MODELS.Paginanicial();
            SERVICES.cominicacao cominicacao = new SERVICES.cominicacao();
            using (OpenFileDialog dialogo = new OpenFileDialog())
            {
                dialogo.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                dialogo.Title = "Selecionar imagem";

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    // Carrega uma cópia da imagem para a PictureBox
                    using (Image imagemOriginal = Image.FromFile(dialogo.FileName))
                    {
                        this.BackgroundImage = new Bitmap(imagemOriginal);
                        if (this.BackgroundImage != null)
                        {
                            pag.planodefundo = cominicacao.salvarimagem(this.BackgroundImage, "background.jpg", this.BackgroundImage.RawFormat);
                        }
                        else
                        {
                            pag.planodefundo = null;
                        }
                        cominicacao.setplanodefundo(pag);
                    }
                }
            }
        }

        private void removerPlanoDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = null;
                MODELS.Paginanicial pag = new MODELS.Paginanicial();
                SERVICES.cominicacao cominicacao = new SERVICES.cominicacao();
                pag.planodefundo = null;
                cominicacao.setplanodefundo(pag);


            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao remover plano de fundo");
            }
        }
    }
}
