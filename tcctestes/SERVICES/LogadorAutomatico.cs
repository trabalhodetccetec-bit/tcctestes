using System;
using System.IO;
using Supabase.Gotrue;
using Supabase.Gotrue.Interfaces;
using Newtonsoft.Json;

public class LogadorAutomatico : IGotrueSessionPersistence<Session>
{
    private readonly string _cachePath;

    public LogadorAutomatico()
    {
        string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string appFolder = Path.Combine(appData, "OrganizadorDeJogos");

        if (!Directory.Exists(appFolder)) Directory.CreateDirectory(appFolder);

        _cachePath = Path.Combine(appFolder, "session.json");
    }

    //salva o token quando o usuário loga
    public void SaveSession(Session session)
    {
        string json = JsonConvert.SerializeObject(session);
        File.WriteAllText(_cachePath, json);
    }

    // Destrói o token quando o usuário clica em Logout
    public void DestroySession()
    {
        if (File.Exists(_cachePath)) File.Delete(_cachePath);
    }

    //carrega o token automaticamente ao abrir o app para o usuário já entrar logado
    public Session LoadSession()
    {
        if (!File.Exists(_cachePath)) return null;

        try
        {
            string json = File.ReadAllText(_cachePath);
            return JsonConvert.DeserializeObject<Session>(json);
        }
        catch
        {
            return null;
        }
    }
}
