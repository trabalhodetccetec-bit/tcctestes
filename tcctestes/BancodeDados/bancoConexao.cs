using System;
using System.IO;

namespace tcctestes.BancodeDados
{
    public class bancoConexao
    {
        public static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string pasta = Path.Combine(appDataPath, "OrganizadorDeJogos", "SAVE", "DadosJogos");
        public static string caminhosql = Path.Combine(pasta, "prim.db");
        public static string caminhoimagem = Path.Combine(appDataPath, "OrganizadorDeJogos", "SAVE", "Imagens");
    }
}
