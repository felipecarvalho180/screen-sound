// Band

Band queen = new Band("Queen");

Album album = new Album("A night at the opera");

Music music1 = new Music(queen, "Love of my life")
{
    Duration = 213,
    Available = true,
};

Music music2 = new Music(queen, "Bohemian Rhapsody")
{
    Duration = 354,
    Available = false,
};

album.AddMusic(music1);
album.AddMusic(music2);
queen.AddAlbum(album);

music1.ShowDetails();
music2.ShowDetails();
album.ShowMusics();
queen.ShowBand();