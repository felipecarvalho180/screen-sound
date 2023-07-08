namespace ScreenSound.FirstChallenge;

class Podcast
{
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public string Name { get; }
    public string Host { get; }
    private List<Episode> episodes = new List<Episode>();

    public void AddEpisode(Episode episode) {
        episodes.Add(episode);
    }

    public void ShowPodcastInfo() {
        Console.WriteLine($"Bem vindo ao podcast {Name}");
        Console.WriteLine($"Apresentado por {Host}\n");
        Console.WriteLine("Temos os seguintes episódios disponíveis");

        foreach (var episode in episodes)
        {
            Console.WriteLine($"* {episode.Resume}");
        }
    }
}