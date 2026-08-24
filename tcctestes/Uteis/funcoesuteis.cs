using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace tcctestes.Uteis
{
    public class funcoesuteis
    {
        public void MudarCorLabels(Control controle, Color cor)
        {
            foreach (Control c in controle.Controls)
            {
                if (c is Label)
                {
                    c.ForeColor = cor;
                }

                if (c.HasChildren)
                {
                    MudarCorLabels(c, cor);
                }
            }
        }
    }
}
