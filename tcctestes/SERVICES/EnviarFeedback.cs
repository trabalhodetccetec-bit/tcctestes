using System;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using System.Net.Http;

namespace tcctestes.SERVICES
{
    class EnviarFeedback
    {
        public async Task<bool> Enviar(string nome, string escala, string recomendacao, string recurso, string dificuldade, string comentario)
        {
            string webhook = ConfigurationManager.AppSettings["webhookfeedback"];
            string msg = $"{Environment.NewLine}{Environment.NewLine}**NOVA AVALIAÇÃO**{Environment.NewLine}" +
                $"**Nome**: {nome} {Environment.NewLine}" +
                $"**Nível de experiência**: {escala}{Environment.NewLine}" +
                $"**Recomendaria pra alguém**: {recomendacao}{Environment.NewLine}" +
                $"**Recurso que deseja**: {recurso}{Environment.NewLine}" +
                $"**Dificuldades que teve**: {dificuldade}{Environment.NewLine}" +
                $"**Comentário sobre**: {comentario}{Environment.NewLine}";
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
                        MessageBox.Show("Avaliação enviada com sucesso!");
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
