using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcctestes.SERVICES
{
    class Cadastro
    {
        public void cadastro(MODELS.usuario usuario)
        {
            try
            {
                BancodeDados.supabaseBanco supabase = new BancodeDados.supabaseBanco();
                supabase.Cadastro(usuario);
            }
            catch
            {
                throw new Exception("algo deu errado");
            }

        }
    }
}
