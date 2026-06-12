using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Diagnostics;
using System.Data.SQLite;

namespace tcctestes.BancodeDados
{
    class SQL : bancoConexao
    {
        public DataTable CarregarDados()
        {
            using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
            {
                conn.Open();
                string sql = "SELECT IDJogo, Nome, cate, joguei, zerei, aval, sync FROM Jogos";
                using (var dt = new SQLiteDataAdapter(sql, conn))
                {
                    DataTable tabela = new DataTable();
                    dt.Fill(tabela);
                    return tabela;
                }
            }
        }
        public DataTable Filtro(MODELS.Filtro info)
        {
            try
            {

                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    conn.Open();

                    string sql = @"SELECT IDJogo, Nome, cate, joguei, zerei, aval FROM Jogos WHERE 1=1";

                    SQLiteCommand cmd = new SQLiteCommand(conn);

                    // via escrever
                    if (!string.IsNullOrWhiteSpace(info.txtprocurar) &&
                        info.txtprocurar != "Buscar...")
                    {
                        sql += " AND Nome LIKE @nome";
                        cmd.Parameters.AddWithValue("@nome", "%" + info.txtprocurar + "%");
                    }

                    // raiobuttons
                    // radiobuttons
                    if (info.filtrojogado)
                    {
                        sql += " AND joguei = 'Já joguei'";
                    }
                    if (info.filtronaojogado)
                    {
                        sql += " AND joguei = 'Não joguei'";
                    }

                    // checkbuttons
                    if (info.filtrozerado)
                    {
                        sql += " AND zerei = 'Já zerei'";
                    }
                    if (info.filtronaozerado)
                    {
                        sql += " AND zerei = 'Não zerei'";
                    }

                    // categorias
                    if (info.posicaocombobox2 != -1)
                    {
                        sql += " AND cate = @categoria";
                        cmd.Parameters.AddWithValue("@categoria", info.combobox2);
                    }

                    // avaliações
                    if (info.posicaocombobox1 != -1)
                    {
                        sql += " AND aval = @aval";
                        cmd.Parameters.AddWithValue("@aval", info.combobox1);
                    }

                    cmd.CommandText = sql;

                    using (var dt = new SQLiteDataAdapter(cmd))
                    {
                        DataTable tabela = new DataTable();
                        dt.Fill(tabela);
                        return tabela;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar: " + ex.Message);
                return null;
            }
        }
        public void Salvar(MODELS.Dados dados)
        {
            try
            {
                string img = dados.pathimage;

                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    string sql = @"SELECT Caminhoimg FROM Jogos WHERE IDJogo = @id";

                    conn.Open();

                    if (string.IsNullOrEmpty(img))
                    {
                        using (var comando = new SQLiteCommand(sql, conn))
                        {
                            comando.Parameters.AddWithValue("@id", dados.idselecionado);

                            using (var reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    img = reader["Caminhoimg"].ToString();
                                }
                            }
                        }
                    }

                    dados.pathimage = img;

                    sql = @"UPDATE Jogos 
                    SET 
                    Nome = @nome,
                    Caminho = @exe,
                    cate = @cat,
                    aval = @aval,
                    Caminhoimg = @img,
                    zerei = @zer,
                    joguei = @jog,
                    Desc = @Des
                    WHERE IDJogo = @id";

                    using (var comando = new SQLiteCommand(sql, conn))
                    {
                        comando.Parameters.AddWithValue("@nome", dados.Nome);
                        comando.Parameters.AddWithValue("@exe", dados.pathexe);
                        comando.Parameters.AddWithValue("@cat", dados.Categoria);
                        comando.Parameters.AddWithValue("@aval", dados.aval);
                        comando.Parameters.AddWithValue("@img", dados.pathimage);
                        comando.Parameters.AddWithValue("@zer", dados.zerou);
                        comando.Parameters.AddWithValue("@jog", dados.jogou);
                        comando.Parameters.AddWithValue("@Des", dados.Descricao);
                        comando.Parameters.AddWithValue("@id", dados.idselecionado);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Excluir(int id)
        {
            try
            {
                MODELS.Dados dados = new MODELS.Dados();
                using (var conn = new SQLiteConnection($"Data Source={BancodeDados.bancoConexao.caminhosql}"))
                {
                    string sql = @"DELETE FROM Jogos WHERE IDJOgo = @id";
                    conn.Open();
                    using (var comando = new SQLiteCommand(sql, conn))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Abrir(int id)
        {
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    conn.Open();

                    string sqlUpdate = @"
                    UPDATE Jogos 
                    SET freq = @data,
                    vezesjogado = vezesjogado + 1
                    WHERE IDJogo = @id";

                    using (var update = new SQLiteCommand(sqlUpdate, conn))
                    {
                        update.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        update.Parameters.AddWithValue("@id", id);
                        update.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public MODELS.Dados Mostrar(int id)
        {
            using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
            {
                conn.Open();

                string sql = @"
                        SELECT Nome, Caminho, cate, aval,
                        Caminhoimg, zerei, joguei, Desc, vezesjogado
                        FROM Jogos
                        WHERE IDJogo = @id";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new MODELS.Dados
                            {
                                Nome = reader["Nome"].ToString(),
                                pathexe = reader["Caminho"].ToString(),
                                Categoria = reader["cate"].ToString(),
                                aval = reader["aval"].ToString(),
                                pathimage = reader["Caminhoimg"].ToString(),
                                zerou = reader["zerei"].ToString(),
                                jogou = reader["joguei"].ToString(),
                                Descricao = reader["Desc"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
        public void Adicionar(MODELS.Dados dados)
        {
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    conn.Open();

                    string sql = @"";
                    sql = "INSERT INTO Jogos (Nome, Caminho, cate, aval, Caminhoimg, zerei, joguei, Desc, sync) VALUES (@nome, @exe, @cat, @aval, @img, @zer, @jog, @Des, @Sync)";
                    using (var comando = new SQLiteCommand(sql, conn))
                    {
                        comando.Parameters.AddWithValue("@nome", dados.Nome);
                        comando.Parameters.AddWithValue("@exe", dados.pathexe);
                        comando.Parameters.AddWithValue("@cat", dados.Categoria);
                        comando.Parameters.AddWithValue("@aval", dados.aval);
                        comando.Parameters.AddWithValue("@img", dados.pathimage);
                        comando.Parameters.AddWithValue("@zer", dados.zerou);
                        comando.Parameters.AddWithValue("@jog", dados.jogou);
                        comando.Parameters.AddWithValue("@Des", dados.Descricao);
                        comando.Parameters.AddWithValue("@Sync", "NAOSINCRONIZADO");

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Jogo salvo com sucesso!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("O jogo não foi salvo! Erro: " + ex.Message);
            }
        }
        public List<MODELS.Paginanicial> Recentes()
        {
            List<MODELS.Paginanicial> lista = new List<MODELS.Paginanicial>();

            try
            {
                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    string sql = @"
                        SELECT Caminhoimg, IDJogo, Nome, cate
                        FROM Jogos
                        ORDER BY freq DESC
                        LIMIT 3";

                    conn.Open();

                    using (var comando = new SQLiteCommand(sql, conn))
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new MODELS.Paginanicial
                            {
                                Id = Convert.ToInt32(reader["IDJogo"]),
                                Nome = reader["Nome"].ToString(),
                                Categoria = reader["cate"].ToString(),
                                CaminhoImagem = reader["Caminhoimg"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return lista;
        }
        public void AbrirRecente(int id)
        {
            using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
            {
                conn.Open();

                string sql = @"SELECT Caminho FROM Jogos WHERE IDJogo = @id";

                string caminhoExe = "";

                using (var comando = new SQLiteCommand(sql, conn))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                        caminhoExe = resultado.ToString();
                }

                if (string.IsNullOrWhiteSpace(caminhoExe) || !File.Exists(caminhoExe))
                {
                    MessageBox.Show("Executável não encontrado.");
                    return;
                }

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = caminhoExe,
                    UseShellExecute = true,
                    WorkingDirectory = Path.GetDirectoryName(caminhoExe)
                };

                Process.Start(psi);
                string sqlUpdate = @"
                    UPDATE Jogos 
                    SET freq = @data,
                    vezesjogado = vezesjogado + 1
                    WHERE IDJogo = @id";

                using (var update = new SQLiteCommand(sqlUpdate, conn))
                {
                    update.Parameters.AddWithValue(
                        "@data",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    );
                    update.Parameters.AddWithValue("@id", id);

                    update.ExecuteNonQuery();
                }
            }
        }
        public List<MODELS.Grafico> Grafico(int tipodechart)
        {
            List<MODELS.Grafico> lista = new List<MODELS.Grafico>();
            try
            {
                if (tipodechart == 0)
                {
                    using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                    {
                        string sql = @"
                            SELECT zerei, COUNT(*) AS quantidade
                            FROM Jogos
                            GROUP BY zerei";

                        conn.Open();

                        using (var comando = new SQLiteCommand(sql, conn))
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new MODELS.Grafico
                                {
                                    nome = reader["zerei"].ToString(),
                                    quantidade = Convert.ToInt32(reader["quantidade"])
                                });
                            }
                        }
                    }
                }
                else if (tipodechart == 1)
                {
                    using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                    {
                        string sql = @"
                            SELECT joguei, COUNT(*) AS quantidade
                            FROM Jogos
                            GROUP BY joguei";

                        conn.Open();

                        using (var comando = new SQLiteCommand(sql, conn))
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new MODELS.Grafico
                                {
                                    nome = reader["joguei"].ToString(),
                                    quantidade = Convert.ToInt32(reader["quantidade"])
                                });
                            }
                        }
                    }
                }
                else if (tipodechart == 2)
                {
                    using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                    {
                        string sql = @"
                            SELECT cate, COUNT(*) AS quantidade
                            FROM Jogos
                            GROUP BY cate
                        ";

                        conn.Open();

                        using (var comando = new SQLiteCommand(sql, conn))
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new MODELS.Grafico
                                {
                                    nome = reader["cate"].ToString(),
                                    quantidade = Convert.ToInt32(reader["quantidade"])
                                });
                            }
                        }
                    }
                }
                else if (tipodechart == 3)
                {

                    using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                    {
                        string sql = @"
                        SELECT Nome, vezesjogado
                        FROM Jogos
                        ORDER BY vezesjogado DESC
                        LIMIT 5";

                        conn.Open();

                        using (var comando = new SQLiteCommand(sql, conn))
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new MODELS.Grafico
                                {
                                    nome = reader["Nome"].ToString(),
                                    quantidade = Convert.ToInt32(reader["vezesjogado"])
                                });
                            }
                        }
                    }
                }
                else if (tipodechart == 4)
                {
                    using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                    {
                        string sql = @"
                            SELECT aval, COUNT(*) AS quantidade
                            FROM Jogos
                            GROUP BY aval
                        ";

                        conn.Open();

                        using (var comando = new SQLiteCommand(sql, conn))
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new MODELS.Grafico
                                {
                                    nome = reader["aval"].ToString(),
                                    quantidade = Convert.ToInt32(reader["quantidade"])
                                });
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na comunicação com o banco: " + ex.Message);
            }

            return lista;
        }
        public MODELS.Paginanicial GETplanodefundo()
        {
            MODELS.Paginanicial plano = new MODELS.Paginanicial();

            using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
            {
                conn.Open();

                string sql = "SELECT planodefundo FROM Form";

                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        plano.planodefundo = reader["planodefundo"].ToString();
                    }
                }
            }

            return plano;
        }
        public void SETplanodefundo(MODELS.Paginanicial pag)
        {
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
                {
                    conn.Open();
                    string sql = @"";
                    if (pag.planodefundo == null)
                    {
                        sql = @"INSERT INTO Form (planodefundo) VALUES (@plano);";
                    }
                    else
                    {
                        sql = @"UPDATE Form SET planodefundo = @plano";
                    }

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@plano", pag.planodefundo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

