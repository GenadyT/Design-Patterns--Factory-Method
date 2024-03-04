using FactoryMethod.BL;
using FactoryMethod.Factories;

namespace FactoryMethod
{
    public partial class frmAlbumByMood : Form
    {
        private Mood[] moods;
        private Genre[] genres;
        private Album[] albums;

        private GenreFactory genreFactory;
        private AlbumFactory albumFactory;

        public frmAlbumByMood()
        {
            InitializeComponent();
        }

        private void btnGetAlbumData_Click(object sender, EventArgs e)
        {
            int moodId = Convert.ToInt32(cmbMoods.SelectedValue);
            Mood mood = moods.Where(m => m.ID == moodId).ToArray()[0];
            Genre genre = genreFactory.GetMoodGenre(mood);
            Album album = albumFactory.GetGenreAlbum(genre);

            ((TextBox)pnlAlbumData.Controls["tbxBandName"]).Text = album.BandName;
            ((TextBox)pnlAlbumData.Controls["tbxAlbumName"]).Text = album.Name;


            TextBox tblAlbumTracks = ((TextBox)pnlAlbumData.Controls["tblAlbumTracks"]);
            tblAlbumTracks.Text = String.Empty;
            for (int i = 0; i < album.TrackList.Length; i++)
            {
                tblAlbumTracks.AppendText(album.TrackList[i]);
                tblAlbumTracks.AppendText(Environment.NewLine);
            }
            
        }

        protected override void OnLoad(EventArgs e)
        {
            this.moods = BL.BL.GetMoods();
            this.genres = BL.BL.GetGenres();
            this.albums = BL.BL.GetAlbums();

            this.genreFactory = new GenreFactory(this.genres);
            this.albumFactory = new AlbumFactory(this.albums);

            cmbMoods.DataSource = moods;
            cmbMoods.ValueMember = "ID";
            cmbMoods.DisplayMember = "Name";
        }

        private void tblAlbumTracks_TextChanged(object sender, EventArgs e)
        {

        }
    }
}