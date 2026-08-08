using Supabase;
using System.Threading.Tasks;
using System.Configuration;

public static class supabase
{
    public static Client Instance { get; private set; }

    public static async Task InitializeAsync()
    {
        string url = ConfigurationManager.AppSettings["SupabaseUrl"];
        string key = ConfigurationManager.AppSettings["SupabaseKey"];
        var options = new SupabaseOptions
        {
            AutoRefreshToken = true,
            //pra salvar o token de autenticação localmente
            SessionHandler = new LogadorAutomatico()
        };

        Instance = new Client(url, key, options);
        await Instance.InitializeAsync();
    }
}
