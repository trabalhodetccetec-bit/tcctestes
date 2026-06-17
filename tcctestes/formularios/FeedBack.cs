using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace tcctestes.formularios
{
    public partial class FeedBack : Form
    {
        public FeedBack()
        {
            InitializeComponent();
        }

        private void enviarFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                SERVICES.EnviarFeedback enviar = new SERVICES.EnviarFeedback();
                enviar.Enviar(txtNome.Text, txtExperiencia.Value.ToString(), comboBox1.Text, recursos.Text, dificuldades.Text, comentario.Text);
                while (!enviar.postado || !enviar.naopostado)
                {

                }
                if (enviar.postado || enviar.naopostado)
                {
                    this.Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
