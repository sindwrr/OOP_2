using OOP_2.Music.Collection;

namespace OOP_2.Misc.Search
{
    // поиск названий альбомов
    public class AlbumSearchStrategy : ISearchStrategy
    {
        public List<string> Search(List<ICollection> catalog, string query)
        {
            return catalog
                .OfType<Album>()
                .Where(album => album.Title.Contains(query, StringComparison.OrdinalIgnoreCase))
                .Select(album => album.Title)
                .ToList();
        }
    }
}
