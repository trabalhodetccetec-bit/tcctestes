using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace tcctestes
{
    class salvarjson
    {
        public static void SalvarNoJson(List<dados> lista)
        {
            string pasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DadosJogos", "dados.json");


            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(pasta, json);
        }
        public static List<dados> CarregarDoArquivo()
        {
            string pasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DadosJogos", "dados.json");

            if (!File.Exists(pasta))
            {
                return new List<dados>();
            }


            string json = File.ReadAllText(pasta);
            return JsonSerializer.Deserialize<List<dados>>(json);
        }
    }
}
