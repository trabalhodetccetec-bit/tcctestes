using System;
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
            BancodeDados.criarbanco.InicializarBanco();
            Application.Run(new formularios.paginaInicial());    
            
        }
       

    }

}
