using System.Text.Json;
using OOP_2.Music.Collection;

namespace OOP_2.Misc
{
    // класс для взаимодействия с JSON-файлом (синглтон)
    public class JsonManager
    {
        private const string FilePath = "music_catalog.json";

        private static JsonManager? _instance;

        private JsonManager() { }

        public static JsonManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new JsonManager();
                }
                return _instance;
            }
        }

        // вложенный класс для каталога - совокупности альбомов и сборников
        private class Catalog
        {
            public List<Album> Albums { get; set; } = new List<Album>();
            public List<Compilation> Compilations { get; set; } = new List<Compilation>();
        }

        // загружает весь каталог из JSON
        private Catalog LoadCatalog()
        {
            try
            {
                if (!File.Exists(FilePath) || new FileInfo(FilePath).Length == 0)
                {
                    return new Catalog { Albums = new List<Album>(), Compilations = new List<Compilation>() };
                }

                var jsonData = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<Catalog>(jsonData) ?? new Catalog();
            }
            catch (JsonException)
            {
                return new Catalog { Albums = new List<Album>(), Compilations = new List<Compilation>() };
            }
        }

        // загружает альбомы
        public List<Album> LoadAlbums()
        {
            var catalog = LoadCatalog();
            return catalog.Albums;
        }

        // загружает сборники
        public List<Compilation> LoadCompilations()
        {
            var catalog = LoadCatalog();
            return catalog.Compilations;
        }

        // сохраняет альбомы
        public void SaveAlbumToJson(Album album)
        {
            var catalog = LoadCatalog();
            catalog.Albums.Add(album);
            SaveCatalog(catalog);
        }

        // сохраняет сборники
        public void SaveCompilationToJson(Compilation compilation)
        {
            var catalog = LoadCatalog();
            catalog.Compilations.Add(compilation);
            SaveCatalog(catalog);
        }

        // сохраняет весь каталог
        private void SaveCatalog(Catalog catalog)
        {
            var jsonData = JsonSerializer.Serialize(catalog, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, jsonData);
        }
    }
}
