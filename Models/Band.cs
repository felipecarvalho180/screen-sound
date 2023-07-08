namespace ScreenSound.Models;

internal class Band : IRating
{
    private List<Album> albums = new();
    private List<Rating> ratings = new();
    public string Name { get; }
    public List<Album> Albums => albums;
    public double Average
    {
        get {
            if(ratings.Count == 0) return 0;
            else return ratings.Average(a => a.Value);
        }
    }


    public Band(string name)
    {
        Name = name;
    }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AddRating(Rating rating)
    {
        ratings.Add(rating);
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