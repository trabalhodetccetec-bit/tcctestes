using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcctestes.MODELS
{
    class Dados
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
        public string sync { get; set; }
        public int idselecionado { get; set; }
        public string cam { get; set; }
    }
    public static class informacoes
    {
        public static string txtprocurar { get; set; }
        public static bool filtrojogado { get; set; }
        public static bool filtrozerado { get; set; }
        public static bool filtronaozerado { get; set; }
        public static int posicaocombobox1 { get; set; }
        public static int posicaocombobox2 { get; set; }
        public static string combobox1 { get; set; }
        public static string combobox2 { get; set; }
        public static string camab { get; set; }
    }
}
