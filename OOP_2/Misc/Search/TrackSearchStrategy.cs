using OOP_2.Music.Collection;

namespace OOP_2.Misc.Search
{
    // поиск названий треков
    public class TrackSearchStrategy : ISearchStrategy
    {
        public List<string> Search(List<ICollection> catalog, string query)
        {
            return catalog
            .OfType<Album>()
            .SelectMany(album => album.Tracks)
            .Where(track => track.Title.Contains(query, StringComparison.OrdinalIgnoreCase))
            .Select(track => track.Title) 
            .Distinct()
            .ToList();
        }
    }
}
