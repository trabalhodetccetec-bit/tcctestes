using System;
using System.Drawing;
using System.Windows.Forms;
using tcctestes.MODELS;

namespace tcctestes.formularios
{
    public partial class adicionarjogo
    {
        void salvarjogo()
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
                    SERVICES.cominicacao comunicacao = new SERVICES.cominicacao();
                    dad.Nome = textBox1.Text;
                    dad.Descricao = textBox2.Text;
                    dad.pathexe = textBox3.Text;
                    dad.Categoria = combobox2.SelectedItem.ToString();
                    dad.aval = combobox1.SelectedItem.ToString();
                    dad.pathimage = comunicacao.salvarimagem(pictureBox1.Image, textBox1.Text.Trim() + ".jpg", pictureBox1.Image.RawFormat);
                    if (jajog.Checked) { dad.jogou = jajog.Text; }
                    else { dad.jogou = naojog.Text; }
                    if (jaze.Checked) { dad.zerou = jaze.Text; }
                    else { dad.zerou = naoze.Text; }
                    comunicacao.adicionar(dad);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    combobox2.SelectedIndex = 1;
                    combobox1.SelectedIndex = 0;
                    pictureBox1.BackgroundImage = Properties.Resources.addimage;
                    pictureBox1.Image = Properties.Resources.quadro8;
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
        void adicionarimagem()
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
        void salvarcaminho()
        {
            using (OpenFileDialog dialogo = new OpenFileDialog())
            {
                dialogo.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                dialogo.Title = "Selecionar imagem";

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    //carrega uma cópia da imagem para a PictureBox, assim evita da imagem ficar bloqueada pra copia, exclusão, etc
                    using (Image imagemOriginal = Image.FromFile(dialogo.FileName))
                    {
                        pictureBox1.Image = new Bitmap(imagemOriginal);
                    }
                }
            }
        }
        void responsividade()
        {
            #region panel1
            int espacoDisponivelpanel1 = this.ClientSize.Width - panel1.Location.X - 5;

            panel1.Location = new Point(panel2.Right + 6, 6);
            panel1.Width = espacoDisponivelpanel1;
            #endregion

            #region combobox1
            int espacoDisponivelcombobox1 = Convert.ToInt32(panel1.Width * 0.4);

            combobox1.Width = espacoDisponivelcombobox1;
            #endregion

            #region combobox2
            int espacoDisponivelcombobox2 = Convert.ToInt32((this.panel1.Width * 0.6) - 6);

            combobox2.Location = new Point((combobox1.Right + 4), combobox2.Location.Y);
            combobox2.Width = espacoDisponivelcombobox2;
            #endregion
        }
    }
}
