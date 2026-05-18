using System;
using System.Windows.Forms;

namespace tcctestes.MODELS
{
    //pra jogos.cs e adicionarjogo.cs
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


    }
    //para o filtro no jogos.cs
    class Filtro
    {
        public string txtprocurar { get; set; }
        public bool filtrojogado { get; set; }
        public bool filtronaojogado { get; set; }
        public bool filtrozerado { get; set; }
        public bool filtronaozerado { get; set; }
        public int posicaocombobox1 { get; set; }
        public int posicaocombobox2 { get; set; }
        public string combobox1 { get; set; }
        public string combobox2 { get; set; }
        public string camab { get; set; }
    }

    //para a paginaInicial.cs
    class Paginanicial
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string CaminhoImagem { get; set; }
    }
}
