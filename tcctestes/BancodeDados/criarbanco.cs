using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace tcctestes.BancodeDados
{
    class criarbanco
    {
        public static void InicializarBanco()
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
                        cate TEXT NOT NULL,
                        aval TEXT NOT NULL,
                        Caminhoimg TEXT NOT NULL,
                        zerei TEXT NOT NULL,
                        joguei TEXT NOT NULL,
                        Desc TEXT NOT NULL,
                        freq TEXT,
                        sync TEXT NOT NULL
                    );";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
