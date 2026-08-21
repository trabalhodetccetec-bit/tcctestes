using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace tcctestes.BancodeDados
{
    class SalvarImagem
    {
        public string Salvar(Image imagem, string nomeArquivo, ImageFormat formato)
        {
            try
            {
                if (imagem == null) return null;

                string pasta = bancoConexao.caminhoimagem;

                Directory.CreateDirectory(pasta);

                string caminhoCompleto = Path.Combine(pasta, nomeArquivo);

                //cria uma cópia da imagem original
                using (Bitmap copia = new Bitmap(imagem))
                {
                    //se o arquivo já existir, apaga antes de salvar
                    if (File.Exists(caminhoCompleto)) File.Delete(caminhoCompleto);

                    copia.Save(caminhoCompleto, formato);
                    return caminhoCompleto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

