using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new pagina());

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
