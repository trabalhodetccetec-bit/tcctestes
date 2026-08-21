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
        bool clicado = false;
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
            comboBox4.SelectedIndex = 0;
            dataGridView1.RowHeadersVisible = false;
            panel1.Visible = false;
            btnsalvar.Enabled = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                SERVICES.cominicacao cominicacao = new SERVICES.cominicacao();
                dataGridView1.DataSource = cominicacao.carregardados();
                dataGridView1.Columns["IDJogo"].Visible = false;
                dataGridView1.Columns["cate"].HeaderText = "Categoria";
                dataGridView1.Columns["sync"].HeaderText = "Sincronização";
                dataGridView1.Columns["aval"].HeaderText = "Avaliação";
                dataGridView1.Columns["joguei"].HeaderText = "Jogado";
                dataGridView1.Columns["zerei"].HeaderText = "Zerado";
                dataGridView1.Columns["favoritado"].HeaderText = "Favorito";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.ToString());
            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

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

                SERVICES.cominicacao cominicacao = new SERVICES.cominicacao();
                int id = dados.idselecionado;

                cominicacao.salvar(dados);

                dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

                dataGridView1.DataSource = cominicacao.carregardados();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["IDJogo"].Value) == id)
                    {
                        dataGridView1.CurrentCell = row.Cells["Nome"];
                        row.Selected = true;
                        break;
                    }
                }

                dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
                dataGridView1.Columns["IDJogo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            btnsalvar.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MODELS.Dados dad = new MODELS.Dados();
            SERVICES.cominicacao cominicacao = new SERVICES.cominicacao();
            using (OpenFileDialog dialogo = new OpenFileDialog())
            {
                dialogo.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                dialogo.Title = "Selecionar imagem";

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    //carrega uma cópia da imagem para a PictureBox, assim evita da imagem ficar bloqueada pra copia, exclusão, etc
                    using (Image imagemOriginal = Image.FromFile(dialogo.FileName))
                    {
                        cam = cominicacao.salvarimagem(pictureBox1.Image, nome.Text.Trim() + ".jpg", pictureBox1.Image.RawFormat);
                        pictureBox1.Image = new Bitmap(imagemOriginal);
                    }
                }
            }
            btnsalvar.Enabled = true;
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            try
            {
                SERVICES.cominicacao cominicacao = new SERVICES.cominicacao();
                cominicacao.abrir(Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDJogo"].Value));
                Process.Start(path.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnexc_Click(object sender, EventArgs e)
        {

            SERVICES.cominicacao cominicacao = new SERVICES.cominicacao();

            if (MessageBox.Show("Deseja realmente excluir este jogo?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }
            else
            {
                dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;

                cominicacao.excluir(Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDJogo"].Value));

                dataGridView1.DataSource = cominicacao.carregardados();
                dataGridView1.Columns["IDJogo"].Visible = false;

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[0].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells["Nome"];
                }

                dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1_SelectionChanged(null, EventArgs.Empty);
                }
                else
                {
                    pictureBox1.Image = null;
                    nome.Clear();
                    descricao.Clear();
                    path.Clear();
                    cat.SelectedIndex = -1;
                    aval.SelectedIndex = -1;
                    jajoguei.Checked = false;
                    naojoguei.Checked = false;
                    jaze.Checked = false;
                    naoze.Checked = false;
                }

            }
            dataGridView1.DataSource = cominicacao.carregardados();
            dataGridView1.Columns["IDJogo"].Visible = false;
            ajudaToolStripMenuItem.Visible = true;
            panel1.Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnsalvar.Enabled = false;
            try
            {
                dataGridView1.DataSource = cominicacao.carregardados();
                dataGridView1.Columns["IDJogo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        private void txtfiltros_Click(object sender, EventArgs e)
        {
            if (!clicado) { panel1.Visible = true; clicado = true; }
            else { panel1.Visible = false; clicado = false; }
        }

        private void filtrar_Click(object sender, EventArgs e)
        {
            clicado = false;
            panel1.Visible = false;
            txtfiltros.Enabled = true;
            MODELS.Filtro info = new MODELS.Filtro();
            info.txtprocurar = txtproc.Text;
            info.filtrojogado = fltjog.Checked;
            info.filtronaojogado = fltnaojog.Checked;
            info.filtrozerado = fltzercheck.Checked;
            info.filtronaozerado = fltnaozercheck.Checked;
            info.fltfavorito = fltfavorito.Checked;
            info.fltnaofavorito = fltnaofavorito.Checked;
            info.posicaocombobox1 = comboBox1.SelectedIndex;
            info.combobox1 = comboBox1.Text;
            info.posicaocombobox2 = comboBox2.SelectedIndex;
            info.combobox2 = comboBox2.Text;
            info.posicaocombobox3 = comboBox3.SelectedIndex;
            info.combobox3 = comboBox3.Text;
            info.ordem = comboBox4.SelectedIndex;
            try
            {
                SERVICES.cominicacao cominicacao = new SERVICES.cominicacao();

                dataGridView1.DataSource = cominicacao.filtro(info);
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
            fltfavorito.Checked = false;
            fltnaofavorito.Checked = false;
            fltjog.Checked = false;
            fltnaojog.Checked = false;
            fltzercheck.Checked = false;
            fltnaozercheck.Checked = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            clicado = false;
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

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caminho = Path.Combine(
                Application.StartupPath,
                "Paginas",
                "adicionarjogos.html");

            Process.Start(new ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true
            });
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                    return;

                if (dataGridView1.CurrentRow.Cells["IDJogo"].Value == null ||
                    dataGridView1.CurrentRow.Cells["IDJogo"].Value == DBNull.Value)
                    return;
                painel.Enabled = true;

                SERVICES.cominicacao com = new SERVICES.cominicacao();

                int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDJogo"].Value);
                MODELS.Dados dados = com.Mostrar(idSelecionado);

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
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dataGridView1.Columns["favoritado"].Index)
                return;

            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDJogo"].Value);

            bool favorito = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["favoritado"].Value);

            favorito = !favorito;

            dataGridView1.Rows[e.RowIndex].Cells["favoritado"].Value = favorito;

            SERVICES.cominicacao cominicacao = new SERVICES.cominicacao();
            cominicacao.atualizarfavorito(id, favorito);
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SERVICES.cominicacao cominicacao = new SERVICES.cominicacao();
                string caminho = null;

                using (var folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        caminho = folderDialog.SelectedPath;

                        try
                        {
                            cominicacao.backup(caminho);

                            MessageBox.Show($"Backup realizado com sucesso na pasta: {caminho}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            MessageBox.Show("Você não tem permissão para gravar nesta pasta. Por favor, escolha outro diretório (como Documentos ou Área de Trabalho).", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                filtrar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
