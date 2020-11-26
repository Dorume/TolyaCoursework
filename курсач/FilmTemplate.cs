using System;
using System.Windows.Forms;
using курсач.Films.Film;

namespace курсач
{
    public partial class FilmTemplate : Form
    {
        private FilmC _Film = new FilmC();

        public FilmC Film 
        { 
            get => _Film;
            set
            {
                _Film = value;
                RefreshLabels();
            } 
        }


        public FilmTemplate()
        {
            InitializeComponent();
        }

        private void RefreshLabels()
        {
            LabelName.Text = _Film.Name;
            LabelCountry.Text = _Film.Country;
            LabelDescription.Text = _Film.Description;
            LabelDuration.Text = _Film.Duration.ToString() + " хв.";
            LabelPremier.Text = _Film.ReleaseData.ToString();
            LabelProducer.Text = _Film.Producer;
            LabelRaiting.Text = _Film.Rating;
            LabelTranslation.Text = _Film.Translation;
            LabelType.Text = _Film.TypeF.ToString();
            IsNewLabel.Visible = _Film.IsNew;
            PosterPictureBox.Image = _Film.Poster;
        }

        private void TrailerButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_Film.TrailerURL);
        }

        private void FilmTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
