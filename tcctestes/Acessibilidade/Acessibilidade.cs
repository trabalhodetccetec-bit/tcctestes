using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace tcctestes.Acessibilidade
{
    static class Acessibilidade
    {
        static bool claroescuro;
        public static void Tema(Control form, bool modo)
        {
            switch (modo)
            {
                case (false):
                    //tema claro
                    foreach (Control c in form.Controls) {
                        form.BackColor = Color.WhiteSmoke;
                        form.ForeColor = Color.Black;
                    }
                    claroescuro = false;
                    break;
                case (true):
                    //tema escuro
                    foreach (Control c in form.Controls)
                    {
                        form.BackColor = Color.Black;
                        form.ForeColor = Color.WhiteSmoke;
                    }
                    
                    claroescuro = true;
                    break;
            }
        }
        public static void AplicarContraste(Control form, bool contraste)
        {
            if (contraste)
            {
                if (claroescuro)
                {

                }
                else
                {

                }
            }
            else if (!contraste)
            {
                if (claroescuro)
                {

                }
                else
                {

                }
            }
        }
    }

}

