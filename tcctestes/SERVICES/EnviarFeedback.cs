using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using System.Net.Http;

namespace tcctestes.SERVICES
{
    class EnviarFeedback
    {
        public bool postado = false;
        public bool naopostado = false;
        public async void Enviar(string nome, string escala, string recomendacao, string recurso, string dificuldade, string comentario)
        {
            string webhook = "https://discord.com/api/webhooks/1515073725676916848/b7VwzoJEwPTFhhJp6VBbbu-DZKNsVaBBfpuJ0wUvAyMRTjRMa_gjgYsvZaZ9gamvRSuc";
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
                        MessageBox.Show("FeedBack enviado com sucesso!");
                        postado = true;
                    }
                    else
                    {
                        MessageBox.Show("Conectado com o destinatario, mas sem sucesso ao enviar seu Feedback!");
                        naopostado = true;
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Não foi possível se comunicar com o destinatario :(" + ex.Message);
            }
        }
    }
}
