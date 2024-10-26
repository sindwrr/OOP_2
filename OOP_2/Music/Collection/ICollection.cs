namespace OOP_2.Music.Collection
{
    // интерфейс для коллекций песен (альбомов и сборников)
    public interface ICollection
    {
        string Title { get; set; }
        List<Track> Tracks { get; set; }
    }
}
