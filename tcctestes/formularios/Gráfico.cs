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
            label1.Text = chart1.Series[0].LegendText;
            label2.Text = chart1.Series[0].LegendText;
        }

        private void selecao_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarGrafico();

        }
        private void carregarGrafico()
        {
            try
            {
                BancodeDados.SQL sql = new BancodeDados.SQL();
                if (selecao.SelectedIndex == 0 || selecao.SelectedIndex == 1 || selecao.SelectedIndex == 4)
                {
                    var jogos = sql.Grafico(selecao.SelectedIndex);
                    chart1.Series[0].ChartType = SeriesChartType.Pie;

                    chart1.Series[0].Points.Clear();

                    foreach (var jogo in jogos)
                    {
                        chart1.Series[0].Points.AddXY(
                            jogo.nome,
                            jogo.quantidade
                        );
                    }
                }
                else if (selecao.SelectedIndex == 3)
                {
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    MessageBox.Show("Line");
                }
                else
                {
                    chart1.Series[0].ChartType = SeriesChartType.Bar;

                    MessageBox.Show("Bar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no selecionamento do gráfico: " + ex.Message);
            }
        }
    }
}
