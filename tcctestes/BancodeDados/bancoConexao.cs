using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace tcctestes.BancodeDados
{
    public class bancoConexao
    {
        public static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string pasta = Path.Combine(appDataPath, "OrganizadorDeJogos", "SAVE", "DadosJogos");
        public static string caminhosql = Path.Combine(pasta, "prim.db");
    }
}
