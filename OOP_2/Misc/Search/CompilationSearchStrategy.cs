using OOP_2.Music.Collection;

namespace OOP_2.Misc.Search
{
    // поиск названий сборников
    public class CompilationSearchStrategy : ISearchStrategy
    {
        public List<string> Search(List<ICollection> catalog, string query)
        {
            return catalog
                .OfType<Compilation>()
                .Where(compilation => compilation.Title.Contains(query, StringComparison.OrdinalIgnoreCase))
                .Select(compilation => compilation.Title)
                .ToList();
        }
    }
}
