using System;
using System.Threading;
using System.Windows.Forms;

namespace tcctestes.formularios
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Não feche essa janela enquanto seu reporte não estiver enviado") == DialogResult.OK)
            {
                button1.Enabled = false;
                progressBar1.Visible = true;
                for (int i = 0; i <= 3; i++)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(1000);
                }
                try
                {
                    SERVICES.EnviarReport enviar = new SERVICES.EnviarReport();
                    bool sucesso = await enviar.Enviar(nome.Text, comboBox1.Text, textBox1.Text);

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
                    button1.Enabled = true;
                }
            }
        }
    }
}
