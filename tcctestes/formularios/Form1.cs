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
    public partial class Form1 : Form
    {
        formularios.addjogo adjog = new formularios.addjogo();
        formularios.excjogo exjog = new formularios.excjogo();
        formularios.jogos all = new formularios.jogos();
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            adjog.Show();
        }

        private void verTodosOsJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            all.Show();
        }

        private void removerJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
