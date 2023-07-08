namespace ScreenSound.Models;

internal class Music
{
    public string Name { get; }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string Description => $"A música {Name} percente a banda {Artist}";

    public Music(Band band, string name)
    {
        Artist = band;
        Name = name;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artista: {Artist.Name}");
        Console.WriteLine($"Duração: {Duration}");

        if (Available) {
            Console.WriteLine("Disponível");
        } else {
            Console.WriteLine("Adiquira o plano Plus+");
        }
    }
};