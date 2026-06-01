using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcctestes.formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.BackgroundImage = Image.FromFile(opf.FileName);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) { }
            if (textBox1.Text == "nome de usuario") { textBox1.Text = ""; textBox1.ForeColor = Color.Black; }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "nome de usuario";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "senha";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text)) { }
            if (textBox2.Text == "senha") { textBox2.Text = ""; textBox2.ForeColor = Color.Black; }

        }
    }
}
