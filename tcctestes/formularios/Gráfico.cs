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
    public partial class Gráfico : Form
    {
        public Gráfico()
        {
            InitializeComponent();
        }

        private void Gráfico_Load(object sender, EventArgs e)
        {
            label1.Text = chart1.Series[0].LegendText;
        }
    }
}
