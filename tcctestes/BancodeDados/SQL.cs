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
                string sql = "SELECT IDJogo, Nome, cate, joguei, zerei, aval FROM Jogos";
                using (var dt = new SQLiteDataAdapter(sql, conn))
                {

                    DataTable tabela = new DataTable();
                    dt.Fill(tabela);

                    return tabela;
                }
            }
        }
        public DataTable Filtro() 
        {
            
            
            try
            {
                using (var conn = new SQLiteConnection($"Data Source={BancodeDados.bancoConexao.caminhosql}"))
                {
                    conn.Open();

                    string sql = @"SELECT IDJogo, Nome, cate, joguei, zerei, aval FROM Jogos WHERE 1=1";

                    SQLiteCommand cmd = new SQLiteCommand(conn);

                    // via escrever
                    if (!string.IsNullOrWhiteSpace(MODELS.informacoes.txtprocurar) &&
                        MODELS.informacoes.txtprocurar != "Buscar...")
                    {
                        sql += " AND Nome LIKE @nome";
                        cmd.Parameters.AddWithValue("@nome", "%" + MODELS.informacoes.txtprocurar + "%");
                    }

                    // raiobuttons
                    // radiobuttons
                    if (MODELS.informacoes.filtrojogado)
                    {
                        sql += " AND joguei = 'Já joguei'";
                    }
                    else if (!MODELS.informacoes.filtrojogado)
                    {
                        sql += " AND joguei = 'Não joguei'";
                    }

                    // checkbuttons
                    if (MODELS.informacoes.filtrozerado && !MODELS.informacoes.filtronaozerado)
                    {
                        sql += " AND zerei = 'Já zerei'";
                    }
                    else if (!MODELS.informacoes.filtrozerado && MODELS.informacoes.filtronaozerado)
                    {
                        sql += " AND zerei = 'Não zerei'";
                    }

                    // categorias
                    if (MODELS.informacoes.posicaocombobox2 != -1)
                    {
                        sql += " AND cate = @categoria";
                        cmd.Parameters.AddWithValue("@categoria", MODELS.informacoes.combobox2);
                    }

                    // avaliações
                    if (MODELS.informacoes.posicaocombobox1 != -1)
                    {
                        sql += " AND aval = @aval";
                        cmd.Parameters.AddWithValue("@aval", MODELS.informacoes.combobox1);
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
        public void Salvar() 
        {
            try
            {
                MODELS.Dados dados = new MODELS.Dados();
                string img = dados.cam;
                using (var conn = new SQLiteConnection($"Data Source={BancodeDados.bancoConexao.caminhosql}"))
                {
                    string sql = @"";
                    sql = @"SELECT Caminhoimg FROM Jogos WHERE IDJogo = @id";
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
                                    img = (reader["Caminhoimg"].ToString());
                                }
                            }
                        }
                    }
                    dados.pathimage = img;
                    sql = @" 
                        UPDATE Jogos 
                        SET 
                        Nome = @nome, Caminho = @exe, cate = @cat, 
                        aval = @aval, Caminhoimg = @img, zerei = @zer, 
                        joguei = @jog, Desc = @Des 
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
        public void Excluir() {
            try
            {
                MODELS.Dados dados = new MODELS.Dados();
                using (var conn = new SQLiteConnection($"Data Source={BancodeDados.bancoConexao.caminhosql}"))
                {
                    string sql = @"DELETE FROM Jogos WHERE IDJOgo = @id";
                    conn.Open();
                    using (var comando = new SQLiteCommand(sql, conn))
                    {
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
        public void Abrir() 
        {
            try
            {
                MODELS.Dados dados = new MODELS.Dados();
                using (var conn = new SQLiteConnection($"Data Source={BancodeDados.bancoConexao.caminhosql}"))
                {
                    string sql = @"SELECT Caminho FROM Jogos WHERE IDJogo = @id";
                    conn.Open();
                    using (var comando = new SQLiteCommand(sql, conn))
                    {
                        comando.Parameters.AddWithValue("@id", dados.idselecionado);
                        using (var reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MODELS.informacoes.camab = (reader["Caminho"].ToString());
                            }
                        }
                    }
                    string sqlUpdate = @"UPDATE Jogos SET freq = @data WHERE IDJogo = @id";
                    using (var Update = new SQLiteCommand(sqlUpdate, conn))
                    {
                        Update.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        Update.Parameters.AddWithValue("@id", dados.idselecionado);
                        Update.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public MODELS.Dados BuscarPorId(int id)
        {
            using (var conn = new SQLiteConnection($"Data Source={caminhosql}"))
            {
                conn.Open();

                string sql = @"SELECT Nome, Caminho, cate, aval,
                       Caminhoimg, zerei, joguei, Desc
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

    }
}
