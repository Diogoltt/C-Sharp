using System.Text.Json;

namespace Aula28_Manipulacao2
{
    public class JsonToTxt
    {
        static async Task Main(string[] args)
        {
            // Url do arquivo json
            string url = "https://raw.githubusercontent.com/manami-project/anime-offline-database/master/anime-offline-database-minified.json";

            string nomeArquivo = "animes.txt";

            try
            {
                using (HttpClient cliente = new HttpClient())
                {
                    // Requisição get para obter o json
                    var response = await cliente.GetAsync(url);

                    var responseString = await response.Content.ReadAsStringAsync();

                    // Json to JArray
                    using (JsonDocument document = JsonDocument.Parse(responseString))
                    {
                        var animeList = document.RootElement.GetProperty("data");

                        SalvarEmTxt(animeList, nomeArquivo);
                    }

                    System.Console.WriteLine("Informações salvas com sucesso");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"Erro: {e.Message}");
            }
        }

        static void SalvarEmTxt(JsonElement animeList, string nomeArquivo)
        {
            try
            {
                using (var sw = new StreamWriter(nomeArquivo))
                {
                    foreach (var anime in animeList.EnumerateArray())
                    {
                        string title = anime.GetProperty("title").GetString() ?? "Sem Título";
                        string type = anime.GetProperty("type").GetString() ?? "Sem tipo";
                        /* int episodes = anime.TryGetProperty("episodes"). */
                        string status = anime.GetProperty("status").GetString() ?? "Sem status";
                        string season = "N/A";
                        int year = 0;

                        /* if (animeList.TryGetProperty("animeSeason", out JsonElement animeSeason))
                        {
                            season = animeSeason.GetProperty("season").GetString() ?? "N/A";
                        } */
                    }

                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"Erro: {e.Message}");
            }
        }

    }
}