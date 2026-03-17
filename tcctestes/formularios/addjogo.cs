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
    public partial class addjogo : Form
    {
        public addjogo()
        {
            InitializeComponent();
            
        }

        private void addjogo_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(opf.FileName);
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
            if(textBox1.Text == "nome") { textBox1.Text = ""; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) {
                textBox1.Text = "nome";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
