using OOP_2.Misc;
using OOP_2.Misc.Search;
using OOP_2.Music.Collection;

namespace OOP_2
{
    public partial class MainForm : Form
    {
        // ������� ����� (����) ����������
        public MainForm()
        {
            InitializeComponent();
        }

        // �������� ����� ��� ���������� �������
        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            var albumCreationForm = new AlbumCreationForm();
            albumCreationForm.ShowDialog();
        }

        // �������� ����� ��� �������� ��������
        private void btnAddCompilation_Click(object sender, EventArgs e)
        {
            var compilationCreationForm = new CompilationCreationForm();
            compilationCreationForm.ShowDialog();
        }

        // ����� � �������� �� ����������
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearchCategories.SelectedItem == null)
            {
                MessageBox.Show("�������� ��������� ������.");
                return;
            }

            string query = txtSearch.Text.Trim();

            // ��������� ������� � �������� �� JSON � ��������� � ���� ������
            List<Album> albums = JsonManager.Instance.LoadAlbums();
            List<Compilation> compilations = JsonManager.Instance.LoadCompilations();
            List<ICollection> catalog = albums.Cast<ICollection>()
                                              .Concat(compilations.Cast<ICollection>())
                                              .ToList();

            // �������� ��������� ������ �� ������ ���������
            ISearchStrategy searchStrategy;
            switch (cbSearchCategories.SelectedItem.ToString())
            {
                case "�� ������":
                    searchStrategy = new TrackSearchStrategy();
                    break;
                case "�� ������������":
                    searchStrategy = new ArtistSearchStrategy();
                    break;
                case "�� ��������":
                    searchStrategy = new AlbumSearchStrategy();
                    break;
                case "�� ���������":
                    searchStrategy = new CompilationSearchStrategy();
                    break;
                default:
                    MessageBox.Show("������ ������ ���������.");
                    return;
            }

            var results = searchStrategy.Search(catalog, query);

            txtResults.Clear();

            // ������� ���������� � ��������� ����
            if (results.Count == 0)
            {
                txtResults.AppendText("������ �� ������� :(\n");
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
