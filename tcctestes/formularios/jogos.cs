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

        bool a = false;
        string cam, camab;
        public jogos()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paginaInicial form = new paginaInicial();
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnsalvar.Enabled = false;
            try
            {
                CarregarDados();
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
                painel.Enabled = true;

                string caminhosql = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DadosJogos", "prim.db");

                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    conn.Open();

                    string sql = @"SELECT Nome, Caminho, cate, aval, Caminhoimg, zerei, joguei, Desc FROM Jogos WHERE IDJogo = @id";

                    using (var cmdsql = new SQLiteCommand(sql, conn))
                    {
                        int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDJogo"].Value);
                        cmdsql.Parameters.AddWithValue("@id", idSelecionado);

                        using (var reader = cmdsql.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cam = reader["Caminhoimg"].ToString();

                                if (pictureBox1.Image != null)

                                {

                                    pictureBox1.Image.Dispose();

                                    pictureBox1.Image = null;

                                }


                                pictureBox1.Image = Image.FromFile(cam);
                                pictureBox1.Refresh();
                                nome.Text = reader["Nome"].ToString();
                                path.Text = reader["Caminho"].ToString();
                                descricao.Text = reader["Desc"].ToString();
                                aval.Text = reader["aval"].ToString();
                                cat.Text = reader["cate"].ToString();

                                string joguei = reader["joguei"].ToString();
                                string zerei = reader["zerei"].ToString();

                                jajog.Checked = joguei == "Já joguei";
                                naojog.Checked = !jajog.Checked;

                                jaze.Checked = zerei == "Já zerei";
                                naoze.Checked = !jaze.Checked;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jogos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (jajog.Checked) { painelop2.Enabled = true; }
            else { painelop2.Enabled = false; naoze.Checked = true; }
            btnsalvar.Enabled = true;
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
            if (jajog.Checked) { painelop2.Enabled = true; }
            else { painelop2.Enabled = false; }
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
            //codigo de UPDATE TABLE

            string caminhosql = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DadosJogos", "prim.db");
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDJogo"].Value);
                    string sql = @"";
                    sql = @"SELECT Caminhoimg FROM Jogos WHERE IDJogo = @id";
                    conn.Open();
                    dados dad = new dados();
                    dad.Nome = nome.Text;
                    dad.Descricao = descricao.Text;
                    dad.pathexe = path.Text;
                    dad.Categoria = cat.SelectedItem.ToString();
                    dad.aval = aval.SelectedItem.ToString();
                    if (string.IsNullOrEmpty(cam))
                    {
                        using (var comando = new SQLiteCommand(sql, conn))
                        {
                            comando.Parameters.AddWithValue("@id", idSelecionado);
                            using (var reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    cam = (reader["Caminhoimg"].ToString());
                                }
                            }
                        }
                    }
                    dad.pathimage = cam;
                    if (jajog.Checked) { dad.jogou = jajog.Text; }
                    else { dad.jogou = naojog.Text; }
                    if (jaze.Checked) { dad.zerou = jaze.Text; }
                    else { dad.zerou = naoze.Text; }
                    sql = @" 
                        UPDATE Jogos 
                        SET 
                        Nome = @nome, Caminho = @exe, cate = @cat, 
                        aval = @aval, Caminhoimg = @img, zerei = @zer, 
                        joguei = @jog, Desc = @Des 
                        WHERE IDJogo = @id";
                    using (var comando = new SQLiteCommand(sql, conn))
                    {
                        comando.Parameters.AddWithValue("@nome", dad.Nome);
                        comando.Parameters.AddWithValue("@exe", dad.pathexe);
                        comando.Parameters.AddWithValue("@cat", dad.Categoria);
                        comando.Parameters.AddWithValue("@aval", dad.aval);
                        comando.Parameters.AddWithValue("@img", dad.pathimage);
                        comando.Parameters.AddWithValue("@zer", dad.zerou);
                        comando.Parameters.AddWithValue("@jog", dad.jogou);
                        comando.Parameters.AddWithValue("@Des", dad.Descricao);

                        comando.Parameters.AddWithValue("@id", idSelecionado);

                        comando.ExecuteNonQuery();
                    }
                }
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnsalvar.Enabled = false;
            a = true; //pra usar o exe updeitado
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(opf.FileName);
                    cam = opf.FileName;
                }
            }
            btnsalvar.Enabled = true;
        }

        private void painel_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            string caminhosql = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DadosJogos", "prim.db");
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    string sql = @"SELECT Caminho FROM Jogos WHERE IDJogo = @id";
                    int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDJogo"].Value);
                    conn.Open();
                    using (var comando = new SQLiteCommand(sql, conn))
                    {
                        comando.Parameters.AddWithValue("@id", idSelecionado);
                        using (var reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                camab = (reader["Caminho"].ToString());
                            }
                        }
                    }
                    Process.Start(camab);
                    string sqlUpdate = @"UPDATE Jogos SET freq = @data WHERE IDJogo = @id";
                    using (var Update = new SQLiteCommand(sqlUpdate, conn))
                    {
                        Update.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        Update.Parameters.AddWithValue("@id", idSelecionado);
                        Update.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexc_Click(object sender, EventArgs e)
        {
            string caminhosql = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DadosJogos", "prim.db");
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDJogo"].Value);
                    string sql = @"DELETE FROM Jogos WHERE IDJOgo = @id";
                    conn.Open();
                    if (MessageBox.Show( "Deseja realmente excluir este jogo?",  "Confirmar exclusão",  MessageBoxButtons.YesNo,  MessageBoxIcon.Warning) != DialogResult.Yes)
                    {
                        return;
                    }
                    using (var comando = new SQLiteCommand(sql, conn))
                    {
                        comando.Parameters.AddWithValue("@id", idSelecionado);
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CarregarDados();
        }

        private void txtfiltros_Click(object sender, EventArgs e)
        {
            txtfiltros.Enabled = false;
            panel1.Visible = true;
            fltjog.Checked = true;
        }

        private void filtrar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtfiltros.Enabled = true;
            string caminhosql = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "DadosJogos",
            "prim.db"
            );

            try
            {
                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    conn.Open();

                    string sql = @"SELECT IDJogo, Nome, cate, joguei, zerei, aval FROM Jogos WHERE 1=1";

                    SQLiteCommand cmd = new SQLiteCommand(conn);

                    // via escrever
                    if (!string.IsNullOrWhiteSpace(txtproc.Text) &&
                        txtproc.Text != "Buscar...")
                    {
                        sql += " AND Nome LIKE @nome";
                        cmd.Parameters.AddWithValue("@nome", "%" + txtproc.Text + "%");
                    }

                    // raiobuttons
                    if (fltjog.Checked)
                    {
                        sql += " AND joguei = 'Já joguei'";
                    }
                    else if (fltnaojog.Checked)
                    {
                        sql += " AND joguei = 'Não joguei'";
                    }

                    // checkbuttons
                    if (fltzercheck.Checked && !fltnaozercheck.Checked)
                    {
                        sql += " AND zerei = 'Já zerei'";
                    }
                    else if (!fltzercheck.Checked && fltnaozercheck.Checked)
                    {
                        sql += " AND zerei = 'Não zerei'";
                    }

                    // categorias
                    if (comboBox2.SelectedIndex != -1)
                    {
                        sql += " AND cate = @categoria";
                        cmd.Parameters.AddWithValue("@categoria", comboBox2.Text);
                    }

                    // avaliações
                    if (comboBox1.SelectedIndex != -1)
                    {
                        sql += " AND aval = @aval";
                        cmd.Parameters.AddWithValue("@aval", comboBox1.Text);
                    }

                    cmd.CommandText = sql;
                    a = true;
                    using (var dt = new SQLiteDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        dt.Fill(tabela);
                        dataGridView1.DataSource = tabela;
                    }
                }
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
            if (fltnaojog.Checked) {
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
            if (string.IsNullOrWhiteSpace(txtproc.Text)) { txtproc.ForeColor = Color.Gray; txtproc.Text = "Buscar..."; }
           

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

            CarregarDados();
        }

        private void CarregarDados()
        {
            string caminhosql = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DadosJogos", "prim.db");
            using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
            {
                conn.Open();
                string sql = "SELECT IDJogo, Nome, cate, joguei, zerei, aval FROM Jogos";
                using (var dt = new SQLiteDataAdapter(sql, conn))
                {
                    DataTable tabela = new DataTable();
                    dt.Fill(tabela);
                    dataGridView1.DataSource = tabela;
                    dataGridView1.Columns["IDJogo"].Visible = false;
                }
            }
        }
    }

}

/*
string caminhosql = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DadosJogos", "prim.db");
try
{
    using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
    {
        int idSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDJogo"].Value);
        string sql = @"";
        conn.Open();
using (var comando = new SQLiteCommand(sql, conn))
                        {
                            comando.Parameters.AddWithValue("@id", idSelecionado);
                            using (var reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    cam = (reader["Caminhoimg"].ToString());
                                }
                            }
                        }
    }
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
*/
