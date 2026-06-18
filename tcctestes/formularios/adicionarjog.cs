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
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Nome")
            {
                MessageBox.Show("O campo nome não pode ser\"Nome\" e nem ser vazio");
                return;
            }
            else
            {
                try
                {

                    MODELS.Dados dad = new MODELS.Dados();
                    BancodeDados.SQL sql = new BancodeDados.SQL();
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
                    sql.Adicionar(dad);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox2.SelectedIndex = 1;
                    comboBox1.SelectedIndex = 0;
                    cam = "";
                    pictureBox1.Image = Image.FromFile("..\\imgs\\addimage.png");
                    jajog.Checked = false;
                    naojog.Checked = false;
                    jaze.Checked = false;
                    naoze.Checked = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro na comunicação com o banco. Erro: " + ex.Message);
                }
            }

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

        private void naojog_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            naoze.Checked = true;
        }

        private void jajog_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            naoze.Checked = false;
        }

        private void adicionarjog_Load_1(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 1;
            comboBox1.SelectedIndex = 1;
        }
    }
}
