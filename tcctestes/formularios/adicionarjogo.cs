using System;
using System.Drawing;
using System.Windows.Forms;
using tcctestes.MODELS;


namespace tcctestes.formularios
{
    public partial class adicionarjogo : Form
    {
        public adicionarjogo()
        {
            InitializeComponent();
        }

        private void adicionarjog_Load(object sender, EventArgs e)
        {
            combobox1.SelectedIndex = 1;
            combobox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionarimagem();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            salvarjogo();
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
            combobox2.SelectedIndex = 1;
            combobox1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salvarcaminho();
        }

        private void adicionarjog_FormClosing(object sender, FormClosingEventArgs e)
        {
            persistente.aberto = false;
        }

        private void adicionarjog_Resize(object sender, EventArgs e)
        {
            responsividade();
        }
    }
}
