using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace tcctestes.BancodeDados
{
    public class Backup : bancoConexao
    {
        public void backup(string caminhodownload)
        {
            // Validação de segurança caso o caminho venha vazio
            if (string.IsNullOrEmpty(caminhodownload)) return;

            try
            {
                string caminhoBancoSqlite = caminhosql;

                string nomeDoZip = "Backup_Jogos_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".zip";
                string caminhoZipFinal = Path.Combine(caminhodownload, nomeDoZip);

                //conteúdo do .txt
                string conteudoTxt = $"Não esqueça que o Organizador de Jogos deve estar encerrado para que sua recuperação possa ocorrer.{Environment.NewLine}ATENÇÃO!!! {Environment.NewLine}Ao rodar backup.bat ele vai substituir o banco de dados atual usado pelo seu app, {Environment.NewLine}não rode ele se não tiver certeza se essa versão estiver desatualizada.";

                string conteudoBat = string.Join(Environment.NewLine, new[] {
                    "@echo off",
                    "title Recuperacao - Organizador de Jogos",
                    "echo Comecando Processo de recuperacao...",
                    "echo.",
                    @"if not exist ""%APPDATA%\OrganizadorDeJogos\SAVE\DadosJogos"" mkdir ""%APPDATA%\OrganizadorDeJogos\SAVE\DadosJogos""",
                    "echo Copiando novo banco de dados para o seu lugar...",
                    @"xcopy ""%~dp0prim.db"" ""%APPDATA%\OrganizadorDeJogos\SAVE\DadosJogos\"" /y /q",
                    @"xcopy ""%~dp0Imagens"" ""%APPDATA%\OrganizadorDeJogos\SAVE\Imagens"" /E /I /Y /Q",
                    "echo.",
                    "echo Banco de dados atualizado com sucesso!",
                    "pause"
                });

                //criando o arquivo zip
                using (ZipArchive zip = ZipFile.Open(caminhoZipFinal, ZipArchiveMode.Create))
                {
                    //criando o .txt com seu conteudo
                    ZipArchiveEntry entradaTxt = zip.CreateEntry("LEIA_ANTES.txt");
                    using (Stream streamTxt = entradaTxt.Open())
                    using (StreamWriter writer = new StreamWriter(streamTxt, Encoding.UTF8))
                    {
                        writer.Write(conteudoTxt);
                    }

                    //criando o .bat com seu conteúdo
                    ZipArchiveEntry entradaBat = zip.CreateEntry("backup.bat");
                    using (Stream streamBat = entradaBat.Open())
                    using (StreamWriter writer = new StreamWriter(streamBat, new UTF8Encoding(false)))
                    {
                        writer.Write(conteudoBat);
                    }

                    //copiando o banco para o zip
                    if (File.Exists(caminhoBancoSqlite))
                    {
                        zip.CreateEntryFromFile(caminhoBancoSqlite, "prim.db");
                    }
                    else
                    {
                        throw new FileNotFoundException("O banco de dados original (prim.db) não foi localizado em: " + caminhoBancoSqlite);
                    }
                    if (Directory.Exists(caminhoimagem))
                    {
                        foreach (string arquivo in Directory.GetFiles(caminhoimagem))
                        {
                            zip.CreateEntryFromFile(
                                arquivo,
                                Path.Combine("Imagens", Path.GetFileName(arquivo))
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel realizar essa açao" + Environment.NewLine + ex.Message);
            }
        }
    }
}
