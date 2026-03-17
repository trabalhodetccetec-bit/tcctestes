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
    public partial class addjogo : Form
    {
        string cam = "";
        public addjogo()
        {
            InitializeComponent();

        }

        private void addjogo_Load(object sender, EventArgs e)
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
            try {
                using (OpenFileDialog opf = new OpenFileDialog())
                {
                    opf.Filter = "Executaveis|*.exe;*.lnk;*.*";

                    opf.ShowDialog();
                    string nome = System.IO.Path.GetFileNameWithoutExtension(opf.FileName);
                    if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "nome") {
                        textBox1.Text = nome;
                    }
                    textBox3.Text = opf.FileName;

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) { }
            if (textBox1.Text == "Nome") { textBox1.Text = ""; textBox1.ForeColor = Color.Black; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) {
                textBox1.Text = "Nome";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text)) { }
            if (textBox2.Text == "Descrição") { textBox2.Text = ""; textBox2.ForeColor = Color.Black; }

        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Descrição";
                textBox2.ForeColor = Color.Gray;
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
            List<dados> listjog = new List<dados>();
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados", "dados.json");

            if (File.Exists(caminho))
            {
                string json = File.ReadAllText(caminho);

                if (!string.IsNullOrWhiteSpace(json))
                {
                    listjog = JsonSerializer.Deserialize<List<dados>>(json);
                }
            }

            listjog.Add(dad);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string novoJson = JsonSerializer.Serialize(listjog, options);
            Directory.CreateDirectory(Path.GetDirectoryName(caminho));
            File.WriteAllText(caminho, novoJson);
            MessageBox.Show("Jogo salvo com sucesso!");
        }
    }
    public class dados {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string pathexe { get; set; }
        public string Categoria { get; set; }
        public string zerou { get; set; }
        public string jogou { get; set; }
        public string pathimage { get; set; }
        public string aval { get; set; }

    }
}
