using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcctestes.MODELS
{
    class Filtro
    {
        public string txtprocurar { get; set; }
        public bool filtrojogado { get; set; }
        public bool filtronaojogado { get; set; }
        public bool filtrozerado { get; set; }
        public bool filtronaozerado { get; set; }
        public bool fltfavorito { get; set; }
        public bool fltnaofavorito { get; set; }
        public int posicaocombobox1 { get; set; }
        public int posicaocombobox2 { get; set; }
        public int posicaocombobox3 { get; set; }
        public string combobox1 { get; set; }
        public string combobox2 { get; set; }
        public string combobox3 { get; set; }
        public string camab { get; set; }
        public int ordem { get; set; }
    }
}
