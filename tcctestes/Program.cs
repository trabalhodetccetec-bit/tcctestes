using System;
using System.Net;
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
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BancodeDados.criarbanco.InicializarBanco();
            Application.Run(new formularios.paginaInicial());    
            
        }
       

    }

}
