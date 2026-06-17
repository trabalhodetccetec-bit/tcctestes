using System;
using System.Threading;
using System.Windows.Forms;

namespace tcctestes.formularios
{
    public partial class FeedBack : Form
    {
        public FeedBack()
        {
            InitializeComponent();
        }

        private async void enviarFeedback_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Não feche essa janela enquanto sua avaliação não estiver enviada") == DialogResult.OK)
            {
                enviarFeedback.Enabled = false;
                progressBar1.Visible = true;
                for (int i = 0; i <= 3; i++)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(1000);
                }
                try
                {
                    SERVICES.EnviarFeedback enviar = new SERVICES.EnviarFeedback();
                    bool sucesso = await enviar.Enviar(txtNome.Text, txtExperiencia.Value.ToString(), comboBox1.Text, recursos.Text, dificuldades.Text, comentario.Text);
                    
                    if (sucesso)
                    {                        
                        this.Close();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    progressBar1.Visible = false;
                    enviarFeedback.Enabled = true;
                }
            }

        }

        private void txtExperiencia_Scroll(object sender, EventArgs e)
        {
            label4.Text = txtExperiencia.Value.ToString();
        }

        private void FeedBack_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
