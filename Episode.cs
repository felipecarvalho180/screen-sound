class Episode
{
    public Episode(int index, string title, int duration)
    {
        Index = index;
        Title = title;
        Duration = duration;
    }

    public int Index { get; }
    public string Title { get; }
    public int Duration { get; }
    private List<Guest> guests = new List<Guest>();
    public string Resume => $"({Index}) - '{Title}' com {string.Join(", ", guests.Select(g => g.Name))} - {Duration}m";

    public void AddGuest(Guest guest) {
        guests.Add(guest);
    }
}