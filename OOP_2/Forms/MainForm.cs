using OOP_2.Misc;
using OOP_2.Misc.Search;
using OOP_2.Music.Collection;

namespace OOP_2
{
    public partial class MainForm : Form
    {
        // главная форма (окно) приложения
        public MainForm()
        {
            InitializeComponent();
        }

        // вызывает форму для добавления альбома
        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            var albumCreationForm = new AlbumCreationForm();
            albumCreationForm.ShowDialog();
        }

        // вызывает форму для создания сборника
        private void btnAddCompilation_Click(object sender, EventArgs e)
        {
            var compilationCreationForm = new CompilationCreationForm();
            compilationCreationForm.ShowDialog();
        }

        // поиск в каталоге по категориям
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearchCategories.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию поиска.");
                return;
            }

            string query = txtSearch.Text.Trim();

            // загружаем альбомы и сборники из JSON и соединяем в один список
            List<Album> albums = JsonManager.Instance.LoadAlbums();
            List<Compilation> compilations = JsonManager.Instance.LoadCompilations();
            List<ICollection> catalog = albums.Cast<ICollection>()
                                              .Concat(compilations.Cast<ICollection>())
                                              .ToList();

            // выбираем стратегию поиска на основе категории
            ISearchStrategy searchStrategy;
            switch (cbSearchCategories.SelectedItem.ToString())
            {
                case "по песням":
                    searchStrategy = new TrackSearchStrategy();
                    break;
                case "по исполнителям":
                    searchStrategy = new ArtistSearchStrategy();
                    break;
                case "по альбомам":
                    searchStrategy = new AlbumSearchStrategy();
                    break;
                case "по сборникам":
                    searchStrategy = new CompilationSearchStrategy();
                    break;
                default:
                    MessageBox.Show("Ошибка выбора категории.");
                    return;
            }

            var results = searchStrategy.Search(catalog, query);

            txtResults.Clear();

            // выводим результаты в текстовое поле
            if (results.Count == 0)
            {
                txtResults.AppendText("Ничего не найдено :(\n");
            }
            else
            {
                foreach (var result in results)
                {
                    txtResults.AppendText(result + Environment.NewLine);
                }
            }
        }
    }
}
