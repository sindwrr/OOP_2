using OOP_2.Misc;
using OOP_2.Music;
using OOP_2.Music.Collection;
using System.Data;

namespace OOP_2
{
    public partial class CompilationCreationForm : Form
    {
        private Compilation? _currentCompilation;
        private List<Album> _albums;

        // форма для создания сборника
        public CompilationCreationForm()
        {
            InitializeComponent();

            _albums = JsonManager.Instance.LoadAlbums();
            cbAlbums.Enabled = false;
            cbSongs.Enabled = false;
            btnAddSong.Enabled = false;
            btnSaveCompilation.Enabled = false;
        }
        
        // если юзер выбрал альбом, то в правом комбо боксе
        // появляется список его треков
        private void cbAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAlbums.SelectedIndex >= 0)
            {
                var selectedAlbum = _albums[cbAlbums.SelectedIndex];
                cbSongs.DataSource = selectedAlbum.Tracks.Select(t => t.Title).ToList();
                cbSongs.Enabled = true;
                cbSongs.SelectedIndex = -1;
            }
        }

        // после ввода названия сборника активирует
        // поля для выбора песен
        private void btnCreateCompilation_Click(object sender, EventArgs e)
        {
            List<Compilation> compilations = JsonManager.Instance.LoadCompilations();
            foreach (var comp in compilations)
            {
                if (comp.Title == txtCompilationTitle.Text)
                {
                    MessageBox.Show("Сборник с таким названием уже существует в каталоге.");
                    return;
                }
            }

            if (txtCompilationTitle.Text == "")
            {
                MessageBox.Show("Введите название сборника.");
                return;
            }

            _currentCompilation = new Compilation
            {
                Title = txtCompilationTitle.Text,
                Tracks = new List<Track>()
            };

            MessageBox.Show("Сборник создан! Теперь можно добавлять песни.");

            cbAlbums.DataSource = _albums.Select(a => a.Title + " - " + a.Artist.Name).ToList();
            cbAlbums.SelectedIndex = -1;
            cbSongs.Enabled = false;

            txtCompilationTitle.Enabled = false;
            cbAlbums.Enabled = true;
            cbSongs.Enabled = true;
            cbSongs.DataSource = null;
            btnAddSong.Enabled = true;
            btnSaveCompilation.Enabled = true;
        }

        // добавляет песню в сборник
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            foreach (var track in _currentCompilation.Tracks)
            {
                if (track.Title == cbSongs.Items[cbSongs.SelectedIndex])
                {
                    MessageBox.Show("Песня уже есть в сборнике.");
                    return;
                }
            }

            if (cbAlbums.SelectedIndex >= 0 && cbSongs.SelectedIndex >= 0)
            {
                var selectedAlbum = _albums[cbAlbums.SelectedIndex];
                var selectedTrack = selectedAlbum.Tracks[cbSongs.SelectedIndex];

                _currentCompilation.Tracks.Add(selectedTrack);
                MessageBox.Show("Песня успешно добавлена в сборник!");
            }
            else if (cbAlbums.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите альбом.");
            }
            else
            {
                MessageBox.Show("Выберите песню.");
            }
        }

        // сохраняет сборник в JSON
        private void btnSaveCompilation_Click(object sender, EventArgs e)
        {
            JsonManager.Instance.SaveCompilationToJson(_currentCompilation);
            MessageBox.Show("Сборник успешно сохранен!");
            Close();
        }
    }
}
