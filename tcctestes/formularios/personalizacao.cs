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
    public partial class personalizacao : Form
    {
        public personalizacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Modo Claro")
            {
                button1.Text = "Modo Escuro";
                Acessibilidade.Acessibilidade.Tema(this, false);
                button1.Text = "Modo Escuro";
<<<<<<< HEAD
=======

>>>>>>> e0a3ecdab8eda482f2178c2c1681353aeaa9b841
            }
            else if (button1.Text == "Modo Escuro")
            {
                button1.Text = "Modo Claro";
                Acessibilidade.Acessibilidade.Tema(this, true);
                button1.Text = "Modo Claro";
<<<<<<< HEAD
            }
        }

        private void personalizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel1.Visible = true;
        }

        private void acessibilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = true;
        }
=======

            }
        }
>>>>>>> e0a3ecdab8eda482f2178c2c1681353aeaa9b841
    }
}
