using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace tcctestes.formularios
{
    public partial class Gráfico : Form
    {
        public Gráfico()
        {
            InitializeComponent();
        }

        private void Gráfico_Load(object sender, EventArgs e)
        {
            ajudaToolStripMenuItem.Visible = false;
            sobreToolStripMenuItem.Visible = true;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            selecao.SelectedIndex = 0;
        }

        private void selecao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            chart1.Series[0].Points.Clear();
            chart1.Palette = ChartColorPalette.None;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart1.BorderlineWidth = 0;
            chart1.Titles[0].Text = selecao.SelectedItem.ToString();
            carregarGrafico();

        }
        private void carregarGrafico()
        {
            try
            {
                Color[] cores =
                {
                    Color.FromArgb(33,150,243),   // azul
                    Color.FromArgb(76,175,80),    // verde
                    Color.FromArgb(255,193,7),    // amarelo
                    Color.FromArgb(244,67,54),    // vermelho
                    Color.FromArgb(156,39,176),   // roxo
                    Color.FromArgb(0,188,212),    // ciano
                    Color.FromArgb(255,87,34),    // laranja
                    Color.FromArgb(121,85,72)     // marrom
                };
                Panel[] paineis =
                {
                    panel2, panel3, panel4, panel5,
                    panel6, panel7, panel8, panel9
                };
                BancodeDados.SQL sql = new BancodeDados.SQL();
                if (selecao.SelectedIndex == 0 || selecao.SelectedIndex == 1 || selecao.SelectedIndex == 4)
                {
                    chart1.Series[0].ChartType = SeriesChartType.Pie;
                }
                else if (selecao.SelectedIndex == 3)
                {
                    chart1.Series[0].ChartType = SeriesChartType.Column;
                }
                else
                {
                    chart1.Series[0].ChartType = SeriesChartType.Bar;
                }
                if (selecao.SelectedIndex == 0)
                {
                    var jogos = sql.Grafico(selecao.SelectedIndex);

                    chart1.Series[0].Points.Clear();

                    Label[] labels =
                    {
                        label1, label2, label3, label4,
                        label5, label6, label7, label8
                    };

                    // limpa tudo primeiro
                    foreach (var lbl in labels)
                    {
                        lbl.Text = "";
                        lbl.Visible = false;
                    }

                    int i = 0;

                    foreach (var jogo in jogos)
                    {
                        chart1.Series[0].Points.AddXY(
                            jogo.nome,
                            jogo.quantidade
                        );

                        if (i < labels.Length)
                        {
                            labels[i].Text = $"{jogo.nome}: {jogo.quantidade}";
                            labels[i].Visible = true;
                            i++;
                        }
                    }
                    for (i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        Color cor = cores[i % cores.Length];

                        chart1.Series[0].Points[i].Color = cor;

                        if (i < paineis.Length)
                        {
                            paineis[i].BackColor = cor;
                        }
                    }
                }
                else if (selecao.SelectedIndex == 1)
                {
                    var jogos = sql.Grafico(selecao.SelectedIndex);

                    chart1.Series[0].Points.Clear();

                    Label[] labels =
                    {
                        label1, label2, label3, label4,
                        label5, label6, label7, label8
                    };

                    // limpa tudo primeiro
                    foreach (var lbl in labels)
                    {
                        lbl.Text = "";
                        lbl.Visible = false;
                    }

                    int i = 0;

                    foreach (var jogo in jogos)
                    {
                        chart1.Series[0].Points.AddXY(
                            jogo.nome,
                            jogo.quantidade
                        );

                        if (i < labels.Length)
                        {
                            labels[i].Text = $"{jogo.nome}: {jogo.quantidade}";
                            labels[i].Visible = true;
                            i++;
                        }
                    }

                    for (i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        Color cor = cores[i % cores.Length];

                        chart1.Series[0].Points[i].Color = cor;

                        if (i < paineis.Length)
                        {
                            paineis[i].BackColor = cor;
                        }
                    }
                }
                else if (selecao.SelectedIndex == 2)
                {
                    var jogos = sql.Grafico(selecao.SelectedIndex);

                    chart1.Series[0].Points.Clear();

                    Label[] labels =
                    {
                        label1, label2, label3, label4,
                        label5, label6, label7, label8
                    };

                    // limpa tudo primeiro
                    foreach (var lbl in labels)
                    {
                        lbl.Text = "";
                        lbl.Visible = false;
                    }

                    int i = 0;

                    foreach (var jogo in jogos)
                    {
                        chart1.Series[0].Points.AddXY(
                            jogo.nome,
                            jogo.quantidade
                        );

                        if (i < labels.Length)
                        {
                            labels[i].Text = $"{jogo.nome}: {jogo.quantidade}";
                            labels[i].Visible = true;
                            i++;
                        }
                    }

                    for (i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        Color cor = cores[i % cores.Length];

                        chart1.Series[0].Points[i].Color = cor;

                        if (i < paineis.Length)
                        {
                            paineis[i].BackColor = cor;
                        }
                    }
                }
                else if (selecao.SelectedIndex == 3)
                {
                    var jogos = sql.Grafico(selecao.SelectedIndex);

                    chart1.Series[0].Points.Clear();

                    Label[] labels =
                    {
                        label1, label2, label3, label4,
                        label5, label6, label7, label8
                    };

                    // limpa tudo primeiro
                    foreach (var lbl in labels)
                    {
                        lbl.Text = "";
                        lbl.Visible = false;
                    }

                    int i = 0;

                    foreach (var jogo in jogos)
                    {
                        chart1.Series[0].Points.AddXY(
                            jogo.nome,
                            jogo.quantidade
                        );

                        if (i < labels.Length)
                        {
                            labels[i].Text = $"{jogo.nome}: Jogou {jogo.quantidade} vezes";
                            labels[i].Visible = true;
                            i++;
                        }
                    }

                    for (i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        Color cor = cores[i % cores.Length];

                        chart1.Series[0].Points[i].Color = cor;

                        if (i < paineis.Length)
                        {
                            paineis[i].BackColor = cor;
                        }
                    }
                }
                else
                {
                    var jogos = sql.Grafico(selecao.SelectedIndex);

                    chart1.Series[0].Points.Clear();

                    Label[] labels =
                    {
                        label1, label2, label3, label4,
                        label5, label6, label7, label8
                    };

                    // limpa tudo primeiro
                    foreach (var lbl in labels)
                    {
                        lbl.Text = "";
                        lbl.Visible = false;
                    }

                    int i = 0;

                    foreach (var jogo in jogos)
                    {
                        chart1.Series[0].Points.AddXY(
                            jogo.nome,
                            jogo.quantidade
                        );

                        if (i < labels.Length)
                        {
                            labels[i].Text = $"{jogo.nome}: {jogo.quantidade}";
                            labels[i].Visible = true;
                            i++;
                        }
                    }

                    for (i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        Color cor = cores[i % cores.Length];

                        chart1.Series[0].Points[i].Color = cor;

                        if (i < paineis.Length)
                        {
                            paineis[i].BackColor = cor;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro a seleção do gráfico: " + ex.Message);
            }
        }
    }
}
