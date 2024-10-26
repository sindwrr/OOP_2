using OOP_2.Music.Collection;

namespace OOP_2.Misc.Search
{
    // поиск имен исполнителей
    public class ArtistSearchStrategy : ISearchStrategy
    {
        public List<string> Search(List<ICollection> catalog, string query)
        {
            return catalog
                .OfType<Album>()
                .Select(album => album.Artist.Name)
                .Distinct()
                .Where(artistName => artistName.Contains(query, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
