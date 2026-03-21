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
using System.Diagnostics;

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
        {
            pagina form = new pagina();
            form.Show();
            this.Close();
        }

        private void adicionarJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.adicionarjog adjog = new formularios.adicionarjog();
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
                    dataGridView1.Columns["Descricao"].Visible = false;
                    dataGridView1.Columns["frec"].Visible = false;
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
            



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    dados dad = new dados();
                    var listaNoGrid = (List<dados>)dataGridView1.DataSource;
                    var jogoSelecionado = listaNoGrid[e.RowIndex];
                    jogoSelecionado.frec = DateTime.Now;
                    salvarjson.SalvarNoJson(listaNoGrid);
                    string caminhoParaAbrir = dataGridView1.Rows[e.RowIndex].Cells["pathexe"].Value.ToString();
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = caminhoParaAbrir,
                        UseShellExecute = true,
                        CreateNoWindow = false,
                        WorkingDirectory = Path.GetDirectoryName(caminhoParaAbrir)
                    };

                    Process.Start(psi);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void jogos_FormClosing(object sender, FormClosingEventArgs e)
        {
            pagina sla = new pagina();
            sla.Show();
        }
    }

}

