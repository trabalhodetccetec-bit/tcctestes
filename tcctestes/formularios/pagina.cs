using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace tcctestes
{
    public partial class pagina : Form
    {
        
        public pagina()
        {
            InitializeComponent();
            
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

        private void removerJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.login exjog = new formularios.login();
            exjog.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<dados> lista = salvarjson.CarregarDoArquivo();

            var ordenados = lista.OrderByDescending(x => x.frec).ToList();

            if (ordenados.Count >= 1)
            {
                pictureBox1.ImageLocation = ordenados[0].pathimage;
                pictureBox1.Tag = ordenados[0].pathexe;
            }
            if (ordenados.Count >= 2)
            {
                pictureBox2.ImageLocation = ordenados[1].pathimage;
                pictureBox2.Tag = ordenados[1].pathexe;
            }
            if (ordenados.Count >= 3)
            {
                pictureBox3.ImageLocation = ordenados[2].pathimage;
                pictureBox3.Tag = ordenados[2].pathexe;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dhstats.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
