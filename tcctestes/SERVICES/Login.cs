using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcctestes.SERVICES
{
    class Login
    {
        public void login(MODELS.usuario usuario)
        {
            try
            {
                BancodeDados.supabaseBanco supabase = new BancodeDados.supabaseBanco();
                supabase.Login(usuario);
            }
            catch
            {
                throw new Exception("algo deu errado");
            }

        }
    }
}
