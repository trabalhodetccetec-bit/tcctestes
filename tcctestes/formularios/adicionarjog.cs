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
using System.Data.SQLite;


namespace tcctestes.formularios
{
    public partial class adicionarjog : Form
    {
        string cam = "";
        public adicionarjog()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.pictureBox1, "dê preferencia a imagens altas e não largas");
        }
        private void adicionarjog_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 0;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog opf = new OpenFileDialog())
                {
                    opf.Filter = "Executaveis|*.exe;*.lnk;*.*";

                    opf.ShowDialog();
                    string nome = System.IO.Path.GetFileNameWithoutExtension(opf.FileName);
                    if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "nome")
                    {
                        textBox1.Text = nome;
                    }
                    textBox3.Text = opf.FileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK);
            }
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            dados dad = new dados();
            dad.Nome = textBox1.Text;
            dad.Descricao = textBox2.Text;
            dad.pathexe = textBox3.Text;
            dad.Categoria = comboBox2.SelectedItem.ToString();
            dad.aval = comboBox1.SelectedItem.ToString();
            dad.pathimage = cam;
            if (jajog.Checked) { dad.jogou = jajog.Text; }
            else { dad.jogou = naojog.Text; }
            if (jaze.Checked) { dad.zerou = jaze.Text; }
            else { dad.zerou = naoze.Text; }
            string caminhosql = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DadosJogos", "prim.db");
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    conn.Open();

                    string sql = @"";
                    sql = "INSERT INTO Jogos (Nome, Caminho, cate, aval, Caminhoimg, zerei, joguei, Desc) VALUES (@nome, @exe, @cat, @aval, @img, @zer, @jog, @Des)";
                    using (var comando = new SQLiteCommand(sql, conn))
                    {
                        comando.Parameters.AddWithValue("@nome", $@"{dad.Nome}");
                        comando.Parameters.AddWithValue("@exe", $@"{dad.pathexe}");
                        comando.Parameters.AddWithValue("@cat", $@"{dad.Categoria}");
                        comando.Parameters.AddWithValue("@aval", $@"{dad.aval}");
                        comando.Parameters.AddWithValue("@img", $@"{dad.pathimage}");
                        comando.Parameters.AddWithValue("@zer", $@"{dad.zerou}");
                        comando.Parameters.AddWithValue("@jog", $@"{dad.jogou}");
                        comando.Parameters.AddWithValue("@Des", $@"{dad.Descricao}");
                        comando.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }





            MessageBox.Show("Jogo salvo com sucesso!");
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) { }
            if (textBox1.Text == "Nome") { textBox1.Text = ""; textBox1.ForeColor = Color.Black; }

        }



        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Nome";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text)) { }
            if (textBox2.Text == "Descrição") { textBox2.Text = ""; textBox2.ForeColor = Color.Black; }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Descrição";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
