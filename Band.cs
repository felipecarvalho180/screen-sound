class Band
{
    private List<Album> albums = new List<Album>();
    public string Name { get; }

    public Band(string name)
    {
        Name = name;
    }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowBand()
    {
        Console.WriteLine($"Essa é a banda {Name}\n");

        foreach (var album in albums)
        {
            Console.WriteLine($"Álbum {album.Name} ({album.Duration}s)\n");
        }
    }
}