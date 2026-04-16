using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SQLite;
using System.IO;

namespace tcctestes.formularios
{
    public partial class paginaInicial : Form
    {
        string cam, camab;
        public paginaInicial()
        {
            InitializeComponent();
        }

        private void paginaInicial_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(245, 245, 245);
            pictureBox1.Click += AbrirJogoRecente;
            pictureBox2.Click += AbrirJogoRecente;
            pictureBox3.Click += AbrirJogoRecente;
            Conectar();
        }
        private void AbrirJogoRecente(object sender, EventArgs e)
        {
            try
            {
                PictureBox pb = (PictureBox)sender;

                if (pb.Tag == null)
                {
                    MessageBox.Show("Este jogo não possui ID associado.");
                    return;
                }

                int idJogo = Convert.ToInt32(pb.Tag);

                string caminhosql = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "DadosJogos",
                    "prim.db"
                );

                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    conn.Open();

                    string sql = @"SELECT Caminho FROM Jogos WHERE IDJogo = @id";

                    string caminhoExe = "";

                    using (var comando = new SQLiteCommand(sql, conn))
                    {
                        comando.Parameters.AddWithValue("@id", idJogo);

                        object resultado = comando.ExecuteScalar();

                        if (resultado != null)
                            caminhoExe = resultado.ToString();
                    }

                    if (string.IsNullOrWhiteSpace(caminhoExe) || !File.Exists(caminhoExe))
                    {
                        MessageBox.Show("Executável não encontrado.");
                        return;
                    }

                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = caminhoExe,
                        UseShellExecute = true,
                        WorkingDirectory = Path.GetDirectoryName(caminhoExe)
                    };

                    Process.Start(psi);
                    string sqlUpdate = @"
                UPDATE Jogos
                SET freq = @data
                WHERE IDJogo = @id";

                    using (var update = new SQLiteCommand(sqlUpdate, conn))
                    {
                        update.Parameters.AddWithValue(
                            "@data",
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        );

                        update.Parameters.AddWithValue("@id", idJogo);

                        update.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir jogo: " + ex.Message);
            }
            Conectar();
        }

        private static void nomeecategoria()
        {
            string caminhosql = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DadosJogos", "prim.db");
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    string sql = @"";
                    conn.Open();
                    using (var comando = new SQLiteCommand(sql, conn))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // cam = (reader["Caminhoimg"].ToString());
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
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.adicionarjog adjog = new formularios.adicionarjog();
            adjog.Show();
        }

        private void verTodosOsJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.jogos all = new formularios.jogos();
            this.Hide();
            all.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dhstats.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.WhiteSmoke;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            // não usar, fica estranho
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightGray;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.WhiteSmoke;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightGray;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightGray;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightGray;
        }

        private void Conectar()
        {

            string caminhosql = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "DadosJogos",
            "prim.db"
         );

            try
            {
                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    string sql = @"
                SELECT Caminhoimg, IDJogo, Nome, cate
                FROM Jogos
                ORDER BY freq DESC
                LIMIT 3;";

                    conn.Open();

                    using (var comando = new SQLiteCommand(sql, conn))
                    using (var reader = comando.ExecuteReader())
                    {
                        Label[] titulos = { label1, label2, label3 };
                        Label[] categorias = { label4, label5, label6 };
                        PictureBox[] imagens = { pictureBox1, pictureBox2, pictureBox3 };


                        int i = 0;

                        while (reader.Read() && i < 3)
                        {
                            string caminhoImagem = reader["Caminhoimg"].ToString();

                            imagens[i].Tag = reader["IDJogo"];
                            titulos[i].Tag = reader["IDJogo"];
                            categorias[i].Tag = reader["IDJogo"];

                            if (File.Exists(caminhoImagem))
                            {
                                imagens[i].Image = Image.FromFile(caminhoImagem);
                            }

                            titulos[i].Text = reader["Nome"].ToString();
                            categorias[i].Text = reader["cate"].ToString();

                            i++;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
