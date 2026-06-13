using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace tcctestes.SERVICES
{
    class EnviarFeedback
    {
        public static void Enviar(string nome)
        {
            string webhook = "https://discord.com/api/webhooks/1515073725676916848/b7VwzoJEwPTFhhJp6VBbbu-DZKNsVaBBfpuJ0wUvAyMRTjRMa_gjgYsvZaZ9gamvRSuc";
            string msg = $"Nome: {nome}";
            
        }
    }
}
