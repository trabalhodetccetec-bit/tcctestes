using System;
using System.Collections.Generic;
using Supabase;
using Postgrest.Attributes;
using Postgrest;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcctestes.BancodeDados
{
    class supabaseBanco
    {
        public async void Cadastro(MODELS.usuario usuario)
        {
            try
            {
                // 1. Cria o login real na nuvem do Supabase
                var session = await supabase.Instance.Auth.SignUp(
                    Supabase.Gotrue.Constants.SignUpType.Email,
                    usuario.email.Trim(),
                    usuario.senha
                );

                if (session?.User == null) throw new Exception("Falha ao gerar o login.");

                // 2. Alimenta a nossa classe de Modelo de forma limpa e organizada
                var novoUsuario = new Usuario
                {
                    Id = session.User.Id, // Vincula ao ID gerado pelo Auth
                    Nome = usuario.nome.Trim()
                };

                // Envia para a tabela usando o modelo fortemente tipado
                await supabase.Instance.From<Usuario>().Insert(novoUsuario);

                MessageBox.Show("Seu cadastro está quase pronto. Foi enviado um email de verificação de conta ao email fornecido, basta verificar seu email e seu cadastro estará pronto", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no cadastro: {ex.Message}", "Erro", MessageBoxButtons.OK);
            }
        }

        public async void Login(MODELS.usuario usuario)
        {
            try
            {
                var session = await supabase.Instance.Auth.SignIn(usuario.email.Trim(), usuario.senha);

                if (session?.User != null)
                {
                    string userId = session.User.Id;
                    string nomeDoUsuario = "Usuário";

                    //busca os dados
                    var query = await supabase.Instance.From<Usuario>().Filter("id", Supabase.Postgrest.Constants.Operator.Equals, userId).Get();

                    //pega o nome
                    if (query.Models.Count > 0)
                    {
                        nomeDoUsuario = query.Models[0].Nome;
                    }

                    MessageBox.Show("Login Efetuado",null,  MessageBoxButtons.OK);

                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Email not confirmed") || ex.Message.Contains("confirm"))
                {
                    MessageBox.Show("Você precisa confirmar seu e-mail antes de fazer login.",null, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("E-mail ou senha inválidos.", "Erro", MessageBoxButtons.OK);
                }
            }
        }
    }

    [Table("usuario")]
    public class Usuario : Supabase.Postgrest.Models.BaseModel
    {
        [PrimaryKey("id", false)]
        public string Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }
    }

}
