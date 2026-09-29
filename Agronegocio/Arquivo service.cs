using System.Text.Json;

namespace AgroControl.Services;

public static class ArquivoService
{
    public static void Salvar<T>(T dados)
    {
        string json =
            JsonSerializer.Serialize(
                dados,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

        File.WriteAllText("dados.json", json);
    }

    public static T? Carregar<T>()
    {
        if (!File.Exists("dados.json"))
        {
            return default;
        }

        string json =
            File.ReadAllText("dados.json");

        return JsonSerializer.Deserialize<T>(json);
    }
}