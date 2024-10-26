using OOP_2.Music.Collection;

namespace OOP_2.Misc.Search
{
    // интерфейс для стратегий поиска
    public interface ISearchStrategy
    {
        List<string> Search(List<ICollection> catalog, string query);
    }
}
