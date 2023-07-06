class Album
{
    private List<Music> musics = new List<Music>();

    public string Name { get; }

    public int Duration => musics.Sum(m => m.Duration);

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
}