using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace tcctestes
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formularios.paginaInicial());
            InicializarBanco();
        }
        private static void InicializarBanco()
        {
            string pasta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "DadosJogos"
            );
            if (!Directory.Exists(pasta)) { Directory.CreateDirectory(pasta); }

            string caminhoDb = Path.Combine(pasta, "prim.db");

            if (!File.Exists(caminhoDb))
            {
                SQLiteConnection.CreateFile(caminhoDb);
            }

            using (var conn = new SQLiteConnection($"Data Source={caminhoDb}"))
            {
                conn.Open();

                string sql = @"
                    CREATE TABLE IF NOT EXISTS Jogos 
                    (
                        IDJogo INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL,
                        Caminho TEXT NOT NULL,
                        cate TEXT,
                        aval TEXT,
                        Caminhoimg TEXT,
                        zerei TEXT,
                        joguei TEXT,
                        Desc TEXT,
                        freq TEXT
                    );";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
    public class dados
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string pathexe { get; set; }
        public string Categoria { get; set; }
        public string zerou { get; set; }
        public string jogou { get; set; }
        public string pathimage { get; set; }
        public string aval { get; set; }
        public DateTime frec { get; set; }
    }

}
