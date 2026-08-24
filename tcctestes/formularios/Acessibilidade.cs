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
    public partial class Acessibilidade : Form
    {
        public Acessibilidade()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            MODELS.persistente.cordotexto = colorDialog1.Color;
            panel1.BackColor = MODELS.persistente.cordotexto;
            Uteis.funcoesuteis funcoesuteis = new Uteis.funcoesuteis();
            funcoesuteis.MudarCorLabels(this, MODELS.persistente.cordotexto);
        }

        private void Acessibilidade_Load(object sender, EventArgs e)
        {
            label1.ForeColor = MODELS.persistente.cordotexto;
        }
    }
}
