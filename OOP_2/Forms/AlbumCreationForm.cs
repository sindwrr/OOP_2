using OOP_2.Misc;
using OOP_2.Music;
using OOP_2.Music.Collection;

namespace OOP_2
{
    public partial class AlbumCreationForm : Form
    {
        private Album? _currentAlbum;

        // форма для добавления альбома
        public AlbumCreationForm()
        {
            InitializeComponent();
            Text = "Добавление альбома";
            cbAlbumGenre.DataSource = Enum.GetValues(typeof(Genre));
            txtSongTitle.Enabled = false;
            btnAddSong.Enabled = false;
            btnSaveAlbum.Enabled = false;
            cbAlbumGenre.SelectedIndex = -1;
        }

        // создает альбом с введенными данными
        // и активируем поля для ввода песен
        private void btnCreateAlbum_Click(object sender, EventArgs e)
        {
            List<Album> albums = JsonManager.Instance.LoadAlbums();
            foreach (var album in albums)
            {
                if (album.Title == txtAlbumTitle.Text &&
                    album.Artist.Name == txtArtistName.Text)
                {
                    MessageBox.Show("Альбом уже существует в каталоге.");
                    return;
                }
            }

            if (txtAlbumTitle.Text == "" ||
                txtArtistName.Text == "" ||
                cbAlbumGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Введите полную информацию об альбоме.");
                return;
            }

            _currentAlbum = new Album
            {
                Title = txtAlbumTitle.Text,
                Artist = new Artist(txtArtistName.Text),
                Genre = (Genre)cbAlbumGenre.SelectedItem,
                Tracks = new List<Track>()
            };

            MessageBox.Show("Альбом успешно создан! Теперь вы можете добавлять в него песни.");
            txtAlbumTitle.Enabled = false;
            txtArtistName.Enabled = false;
            cbAlbumGenre.Enabled = false;
            txtSongTitle.Enabled = true;
            btnAddSong.Enabled = true;
        }

        // вставляет песню в список треков альбома
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            foreach (var track in _currentAlbum.Tracks)
            {
                if (track.Title == txtSongTitle.Text)
                {
                    MessageBox.Show("Песня уже есть в альбоме.");
                    return;
                }
            }

            if (txtSongTitle.Text == "")
            {
                MessageBox.Show("Введите название песни.");
                return;
            }

            var newTrack = new Track
            {
                Title = txtSongTitle.Text,
                Artist = _currentAlbum.Artist
            };

            _currentAlbum.Tracks.Add(newTrack);
            MessageBox.Show("Песня успешно добавлена!");
            txtSongTitle.Clear();
            btnSaveAlbum.Enabled = true;
        }

        // сохраняет альбом в JSON
        private void btnSaveAlbum_Click(object sender, EventArgs e)
        {
            JsonManager.Instance.SaveAlbumToJson(_currentAlbum);
            MessageBox.Show("Альбом успешно сохранен!");
            Close();
        }
    }
}
