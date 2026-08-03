using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcctestes.MODELS;

namespace tcctestes.SERVICES
{
    internal class cominicacao
    {
        public void adicionar(MODELS.Dados dados)
        {
            try
            {
                BancodeDados.SQL sql = new BancodeDados.SQL();
                sql.Adicionar(dados);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar dados: " + ex.Message);
            }
        }
        public MODELS.Dados mostrar(int id, MODELS.Dados dados)
        {
            try
            {

                BancodeDados.SQL sql = new BancodeDados.SQL();
                sql.Mostrar(id);
                return dados;
            }
            catch
            {
                return null;
            }
        }
        public List<MODELS.Paginanicial> recentes()
        {
            try
            {
                BancodeDados.SQL sql = new BancodeDados.SQL();
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
                BancodeDados.SQL sql = new BancodeDados.SQL();
                sql.AbrirRecente(id);
            }
            catch
            {
                throw new Exception("Erro");
            }

        }
        public List<MODELS.Grafico> grafico() {
            return null;
        }


    }
}
