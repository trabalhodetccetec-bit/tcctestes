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
using System.IO;

namespace tcctestes.formularios
{
    public partial class jogos : Form
    {
        
       
        
        public jogos()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {   pagina form = new pagina();
            form.Show();
            this.Close();
        }

        private void adicionarJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {formularios.adicionarjog adjog = new formularios.adicionarjog();
            adjog.Show();
        }

        private void excluirJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void jogos_Load(object sender, EventArgs e)
        {
            try
            {

                string pasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DadosJogos", "dados.json");

                if (File.Exists(pasta))
                {
                    string json = File.ReadAllText(pasta);


                    List<dados> listaDeJogos = JsonSerializer.Deserialize<List<dados>>(json);

                    dataGridView1.DataSource = listaDeJogos;
                    dataGridView1.Columns["pathimage"].Visible = false;
                    dataGridView1.Columns["pathexe"].Visible = false;
                    if (!dataGridView1.Columns.Contains("btnJogar"))
                    {
                        DataGridViewButtonColumn botaoJogar = new DataGridViewButtonColumn();
                        botaoJogar.HeaderText = "";
                        botaoJogar.Text = "JOGAR";
                        botaoJogar.Name = "btnJogar";
                        botaoJogar.UseColumnTextForButtonValue = true; // Faz o texto "JOGAR" aparecer no botão

                        dataGridView1.Columns.Add(botaoJogar);
                    }
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string caminhoParaAbrir = dataGridView1.Rows[e.RowIndex].Cells["pathexe"].Value.ToString();

            System.Diagnostics.Process.Start(caminhoParaAbrir);
        }
    }
    
}
