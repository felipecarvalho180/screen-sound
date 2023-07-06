// Band

//Band queen = new Band("Queen");

//Album album = new Album("A night at the opera");

//Music music1 = new Music(queen, "Love of my life")
//{
//    Duration = 213,
//    Available = true,
//};

//Music music2 = new Music(queen, "Bohemian Rhapsody")
//{
//    Duration = 354,
//    Available = false,
//};

//album.AddMusic(music1);
//album.AddMusic(music2);
//queen.AddAlbum(album);

//music1.ShowDetails();
//music2.ShowDetails();
//album.ShowMusics();
//queen.ShowBand();

// Podcast

Podcast podcast = new Podcast("Podpah", "Igão");
Guest guest = new Guest("Elon Musk");
Guest guest2 = new Guest("Sarcani");
Episode episode1 = new Episode(1, "SpaceX", 190);

episode1.AddGuest(guest);
episode1.AddGuest(guest2);
podcast.AddEpisode(episode1);

Guest guest3 = new Guest("Neymar");
Guest guest4 = new Guest("Romario");
Episode episode2 = new Episode(2, "Futvolei", 300);

episode2.AddGuest(guest3);
episode2.AddGuest(guest4);
podcast.AddEpisode(episode2);

podcast.ShowPodcastInfo();