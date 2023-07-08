namespace ScreenSound.Models;

internal class Album : IRating
{
    private List<Music> musics = new List<Music>();
    private List<Rating> ratings = new();

    public string Name { get; }

    public int Duration => musics.Sum(m => m.Duration);

    public double Average
    {
        get
        {
            if (ratings.Count == 0) return 0;
            else return ratings.Average(a => a.Value);
        }
    }

    public Album(string name)
    {
        Name = name;
    }

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowMusics()
    {
        Console.WriteLine($"Músicas do álbum {Name}\n");

        foreach (var music in musics)
        {
            Console.WriteLine($"Música: {music.Name}");
        }

        Console.WriteLine($"\nPara ouvir este álbum você precisa de {Duration} segundos");
    }

    public void AddRating(Rating value)
    {
        ratings.Add(value);
    }
}