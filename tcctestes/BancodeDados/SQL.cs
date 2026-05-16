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
                    if (!string.IsNullOrWhiteSpace(formularios.informacoes.txtprocurar) &&
                        formularios.informacoes.txtprocurar != "Buscar...")
                    {
                        sql += " AND Nome LIKE @nome";
                        cmd.Parameters.AddWithValue("@nome", "%" + formularios.informacoes.txtprocurar + "%");
                    }

                    // raiobuttons
                    // radiobuttons
                    if (formularios.informacoes.filtrojogado)
                    {
                        sql += " AND joguei = 'Já joguei'";
                    }
                    else if (!formularios.informacoes.filtrojogado)
                    {
                        sql += " AND joguei = 'Não joguei'";
                    }

                    // checkbuttons
                    if (formularios.informacoes.filtrozerado && !formularios.informacoes.filtronaozerado)
                    {
                        sql += " AND zerei = 'Já zerei'";
                    }
                    else if (!formularios.informacoes.filtrozerado && formularios.informacoes.filtronaozerado)
                    {
                        sql += " AND zerei = 'Não zerei'";
                    }

                    // categorias
                    if (formularios.informacoes.posicaocombobox2 != -1)
                    {
                        sql += " AND cate = @categoria";
                        cmd.Parameters.AddWithValue("@categoria", formularios.informacoes.combobox2);
                    }

                    // avaliações
                    if (formularios.informacoes.posicaocombobox1 != -1)
                    {
                        sql += " AND aval = @aval";
                        cmd.Parameters.AddWithValue("@aval", formularios.informacoes.combobox1);
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
       
    }
}
