using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dhstats.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
