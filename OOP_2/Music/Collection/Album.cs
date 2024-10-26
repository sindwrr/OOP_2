namespace OOP_2.Music.Collection
{
    // класс для альбомов
    public class Album : ICollection
    {
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
        public List<Track> Tracks { get; set; }
    }
}
