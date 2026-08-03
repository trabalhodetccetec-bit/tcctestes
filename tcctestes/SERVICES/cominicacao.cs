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
using tcctestes.MODELS;
using tcctestes.BancodeDados;

namespace tcctestes.SERVICES
{
    internal class cominicacao
    {
        public void adicionar(Dados dados)
        {
            try
            {
                SQL sql = new SQL();
                sql.Adicionar(dados);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar dados: " + ex.Message);
            }
        }
        public Dados Mostrar(int id)
        {
            try
            {
                SQL sql = new SQL();
                return sql.Mostrar(id);
            }
            catch
            {
                return null;
            }
        }
        public List<Paginanicial> recentes()
        {
            try
            {
                SQL sql = new SQL();
                return sql.Recentes();
            }
            catch
            {
                return null;
            }
        }
        public void abrirrecente(int id)
        {
            try
            {
                SQL sql = new SQL();
                sql.AbrirRecente(id);
            }
            catch
            {
                throw new Exception("Erro");
            }

        }
        public List<Grafico> grafico(int tipo)
        {
            SQL sql = new SQL();
            return sql.Grafico(tipo);
        }
        public DataTable carregardados()
        {

            try
            {
                SQL sql = new SQL();
                return sql.CarregarDados();
            }
            catch
            {
                return null;
            }
        }
        public DataTable filtro(Filtro filtro)
        {
            try
            {
                SQL sql = new SQL();
                return sql.Filtro(filtro);
            }
            catch
            {
                return null;
            }
        }
        public void salvar(Dados dados)
        {
            try
            {
                SQL sql = new SQL();
                sql.Salvar(dados);
            }
            catch
            {
                throw new Exception("Erro ao salvar dados");
            }
        }
        public void excluir(int id)
        {
            try
            {
                SQL sql = new SQL();
                sql.Excluir(id);
            }
            catch
            {
                throw new Exception("Erro ao excluir dados");
            }
        }
        public void abrir(int id)
        {
            try
            {
                SQL sql = new SQL();
                sql.Abrir(id);
            }
            catch
            {
                throw new Exception("Erro ao abrir dados");
            }
        }
        public void setplanodefundo(Paginanicial plano)
        {
            try
            {
                SQL sql = new SQL();
                sql.SETplanodefundo(plano);
            }
            catch
            {
                throw new Exception("Erro ao definir plano de fundo");
            }
        }
        public Paginanicial getplanodefundo()
        {
            try
            {
                SQL sql = new SQL();
                return sql.GETplanodefundo();
            }
            catch
            {
                throw new Exception("Erro ao obter plano de fundo");
            }
        }
    }
}
