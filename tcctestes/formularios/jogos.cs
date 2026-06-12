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
using System.Data.SQLite;

namespace tcctestes.formularios
{
    public partial class jogos : Form
    {
        string cam;
        public jogos()
        {
            InitializeComponent();
        }

        

        private void adicionarJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.adicionarjog adjog = new formularios.adicionarjog();
            adjog.Show();
        }

        private void jogos_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnsalvar.Enabled = false;
            try
            {
                BancodeDados.SQL sql = new BancodeDados.SQL();
                dataGridView1.DataSource = sql.CarregarDados();
                dataGridView1.Columns["IDJogo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                painel.Enabled = true;

                BancodeDados.SQL sql = new BancodeDados.SQL();

                int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDJogo"].Value);

                MODELS.Dados dados = sql.Mostrar(idSelecionado);
                nome.Text = dados.Nome;
                descricao.Text = dados.Descricao;
                pictureBox1.Image = Image.FromFile(dados.pathimage);
                path.Text = dados.pathexe;
                if (dados.jogou == "Já joguei")
                {
                    jajoguei.Checked = true;
                    painelop2.Enabled = true;
                }
                else
                {
                    naojoguei.Checked = true;
                    painelop2.Enabled = false;
                }
                if (dados.zerou == "Já zerei")
                {
                    jaze.Checked = true;
                    naoze.Checked = false;
                }
                else
                {
                    naoze.Checked = true;
                    jaze.Checked = false;
                }
                aval.Text = dados.aval;
                cat.Text = dados.Categoria;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao carregar os dados: "+ex.Message);
            }
        }

        private void btnalt_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog opf = new OpenFileDialog())
                {
                    opf.Filter = "Executaveis|*.exe;*.lnk;*.*";

                    opf.ShowDialog();
                    string nome = Path.GetFileNameWithoutExtension(opf.FileName);
                    path.Text = opf.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK);
            }
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {
            btnsalvar.Enabled = true;
        }

        private void path_TextChanged(object sender, EventArgs e)
        {
            btnsalvar.Enabled = true;
        }

        private void descricao_TextChanged(object sender, EventArgs e)
        {
            btnsalvar.Enabled = true;
        }

        private void aval_TextChanged(object sender, EventArgs e)
        {
            btnsalvar.Enabled = true;
        }

        private void cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnsalvar.Enabled = true;
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                MODELS.Dados dados = new MODELS.Dados();
                int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDJogo"].Value);

                dados.idselecionado = idSelecionado;
                dados.Nome = nome.Text;
                dados.Descricao = descricao.Text;
                dados.pathexe = path.Text;
                dados.Categoria = cat.SelectedItem.ToString();
                dados.aval = aval.SelectedItem.ToString();
                dados.pathimage = cam;
                dados.sync = "ALTERADO";

                if (jajoguei.Checked) { dados.jogou = jajoguei.Text; }
                else { dados.jogou = naojoguei.Text; }
                if (jaze.Checked) { dados.zerou = jaze.Text; }
                else { dados.zerou = naoze.Text; }

                BancodeDados.SQL sql = new BancodeDados.SQL();
                sql.Salvar(dados);
                dataGridView1.DataSource = sql.CarregarDados();
                dataGridView1.Columns["IDJogo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnsalvar.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MODELS.Dados dados = new MODELS.Dados();
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(opf.FileName);
                    dados.pathimage = opf.FileName;
                }
            }
            btnsalvar.Enabled = true;
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            try
            {
                BancodeDados.SQL sql = new BancodeDados.SQL();
                sql.Abrir(Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDJogo"].Value));
                Process.Start(path.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnexc_Click(object sender, EventArgs e)
        {

            BancodeDados.SQL sql = new BancodeDados.SQL();
            if (MessageBox.Show("Deseja realmente excluir este jogo?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }
            else
            {
                sql.Excluir(Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDJogo"].Value));
            }
            dataGridView1.DataSource = sql.CarregarDados();
            dataGridView1.Columns["IDJogo"].Visible = false;
        }

        private void txtfiltros_Click(object sender, EventArgs e)
        {
            //botão pra abrir a tela de filtro
            txtfiltros.Enabled = false;
            panel4.Visible = true;
            panel1.Visible = true;
            fltjog.Checked = false;
        }

        private void filtrar_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel1.Visible = false;
            txtfiltros.Enabled = true;
            MODELS.Filtro info = new MODELS.Filtro();
            info.txtprocurar = txtproc.Text;
            info.filtrojogado = fltjog.Checked;
            info.filtronaojogado = fltnaojog.Checked;
            info.filtrozerado = fltzercheck.Checked;
            info.filtronaozerado = fltnaozercheck.Checked;
            info.posicaocombobox1 = comboBox1.SelectedIndex;
            info.combobox1 = comboBox1.Text;
            info.posicaocombobox2 = comboBox2.SelectedIndex;
            info.combobox2 = comboBox2.Text;
            try
            {
                BancodeDados.SQL sql = new BancodeDados.SQL();
                dataGridView1.DataSource = sql.Filtro(info);
                dataGridView1.Columns["IDJogo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar: " + ex.Message);
            }
        }

        private void fltjog_CheckedChanged(object sender, EventArgs e)
        {
            if (fltjog.Checked)
            {
                panel3.Enabled = true;
                fltnaozercheck.Checked = false;
            }
        }

        private void fltnaojog_CheckedChanged(object sender, EventArgs e)
        {
            if (fltnaojog.Checked)
            {
                panel3.Enabled = false;
                fltnaozercheck.Checked = true;
            }
        }

        private void txtproc_TextChanged(object sender, EventArgs e)
        {
            filtrar_Click(sender, e);
        }

        private void txtproc_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void txtproc_Click(object sender, EventArgs e)
        {
            if (txtproc.Text == "Buscar...")
            {
                txtproc.Text = "";
                txtproc.ForeColor = Color.Black;
            }
            else { }

        }

        private void txtproc_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtproc.Text))
            {
                txtproc.ForeColor = Color.Gray;
                txtproc.Text = "Buscar...";
            }
        }

        private void lmpfiltro_Click(object sender, EventArgs e)
        {
            txtproc.Text = "Buscar...";
            fltjog.Checked = false;
            fltnaojog.Checked = false;
            fltzercheck.Checked = false;
            fltnaozercheck.Checked = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            filtrar_Click(sender, e);
        }

        private void jajoguei_CheckedChanged(object sender, EventArgs e)
        {
            if (jajoguei.Checked)
            {
                painelop2.Enabled = true;
            }
            else
            {
                painelop2.Enabled = false;
                naoze.Checked = true;
            }
        }
    }
}
