class Music
{
    public string name;
    public string artist;
    public int duration;
    public bool available;

    public void ShowDetails()
    {
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Artista: {artist}");
        Console.WriteLine($"Duração: {duration}");

        if (available) {
            Console.WriteLine("Disponível");
        } else {
            Console.WriteLine("Adiquira o plano Plus+");
        }
    }
};