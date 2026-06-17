using System;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using System.Windows.Forms;

namespace tcctestes.SERVICES
{
    class EnviarReport
    {
        public async Task<bool> Enviar(string nome, string onde, string explicacao)
        {
            string webhook = "https://discord.com/api/webhooks/1515472160343199896/UdyX0vyHiGoI93hg2GtLR9KzaYL-PeHdB31qu33iIL-gxdmIrBrNXZi0Rj50y2Dm9ZE8";
            string msg = $"{Environment.NewLine}**NOVO REPORT**{Environment.NewLine}" +
                $"**Nome**: {nome} {Environment.NewLine}" +
                $"**Nível de experiência**: {onde}{Environment.NewLine}" +
                $"**Recomendaria pra alguém**: {explicacao}{Environment.NewLine}";
            try
            {
                var msgn = new { content = msg };
                string mensagem = JsonSerializer.Serialize(msgn);

                using (HttpClient httpsclient = new HttpClient())
                {
                    var conteudo = new StringContent(mensagem, Encoding.UTF8, "application/json");
                    HttpResponseMessage resposta = await httpsclient.PostAsync(webhook, conteudo);


                    if (resposta.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Reporte enviado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Conectado com o destinatario, mas sem sucesso ao enviar sua avaliação!");
                    }
                    return true;
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Não foi possível se comunicar com o destinatario :(" + ex.Message);
                return false;
            }
        }
    }
}
