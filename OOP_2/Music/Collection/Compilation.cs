namespace OOP_2.Music.Collection
{
    // класс для сборников
    public class Compilation : ICollection
    {
        public string Title { get; set; }
        public List<Track> Tracks { get; set; }
    }
}
